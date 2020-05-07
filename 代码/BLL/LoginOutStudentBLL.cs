using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enitity;
using Factory;
using IDAL;
using IBLL;
using System.Data;
using System.Reflection;
using System.Configuration;
using System.Windows.Forms;
namespace BLL
{
   
    /// <summary>
    /// 学生下机业务
    /// </summary>
    public  class LoginOutStudentBLL:LoginOutStudentIBLL
    {

        /// <summary>
        /// 实例化创建UI层窗体工厂
        /// </summary>
        FactoryUI CreatfactForm = new FactoryUI();
        /// <summary>
        /// 实例化工厂，用于创建D登录查询类。
        /// </summary>
        FactoryDAl fact = new FactoryDAl();
        /// <summary>
        /// 学生下机
        /// </summary>
        /// <param name="StuentCardno">学生卡号</param>
        /// <param name="TimeSolt">上机时长</param>
        /// <returns></returns>
        public void LoginOutStudent(string StuentCardno,string stuName)
        {
            #region 实例化退出工厂 
            //使用工厂实例化接口
            LoginOutStudentIDAL idal =(LoginOutStudentIDAL)fact.CreateUser("LoginOutStudentDAL");
            DataTable BasitInfoTable = idal.SelectBasit();//获取基础信息
            //获取正在上机的卡号信息
            StudentOnLine studentOnline = new StudentOnLine();//实例化正在上机实体
            studentOnline.StudentCardno = int.Parse(StuentCardno);//给卡号赋值
            DataTable OnlineTable = idal.SelectOnLineStudent(studentOnline);//获取正在上机的卡号信息
            #endregion
            #region 计算上机时长
            double LimTime = double.Parse(BasitInfoTable.Rows[0][2].ToString());   //给最小上机时间赋值
            //获取上机日期+时间
            string LoginData = DateTime.Parse(OnlineTable.Rows[0][3].ToString()).ToString("yyyy/MM/dd"); //获取上机日期  
            string LoginTime =DateTime.Parse( OnlineTable.Rows[0][4].ToString()).ToShortTimeString();//获取上机时间
            string LoginDateTime =LoginData +" "+ LoginTime;  //合并上机日期+时间 
            //获取下机日期+时间
            string LoginOutData = DateTime.Parse(DateTime.Now.Date.ToString()).ToString("yyyy/MM/dd"); //获取上机日期  
            string LoginOutTime = DateTime.Now.ToShortTimeString();//获取上机时间
            string LoginOutDateTime = LoginOutData + " " +LoginOutTime ;  //合并上机日期+时间
             //公式：下机日期和时间-上机日期和时间=上机时长
            TimeSpan TimeSolt =DateTime.Parse(LoginOutDateTime) - DateTime.Parse( LoginDateTime);
            #endregion
            #region 计算消费金额
            string stuentType = OnlineTable.Rows[0][1].ToString();//给卡号类型赋值
            double Cash = 0;//收费标准
            //给收费标准赋值
            if (stuentType == "固定用户")
            {
                Cash = double.Parse(BasitInfoTable.Rows[0][3].ToString());//给固定用户收费标准赋值
            }
            else if (stuentType == "临时用户")
            {
                Cash = double.Parse(BasitInfoTable.Rows[0][4].ToString());//给临时用户收费标准赋值
            }//end if
            //实例化策略模式，传入卡号类型和对应的收费标准。
            Cash.StuCashContext stuCashContext = new Cash.StuCashContext(stuentType,Cash);
            //传入：消费时长和最小上机时间，得到消费金额
            double Money = stuCashContext.GetResult(TimeSolt.ToString(),LimTime);
            #endregion
            //计算目前余额:公式:上机前余额-消费金额=当前余额
            double NowCsh = double.Parse(OnlineTable.Rows[0][2].ToString()) - Money;
            #region 更新学生上机记录
            //给上机记录实体赋值，和实例化
            #region 给上机记录实体赋值
            StudentLien StuLine = new StudentLien();
            StuLine.Computer = Computer.GetMachineName();//计算机名称
            StuLine.ConsumptionCash = Money;//消费金额
            StuLine.NowCash = NowCsh;//目前余额
            StuLine.OnDate = DateTime.Parse(OnlineTable.Rows[0][3].ToString());//上机日期
            StuLine.OnLineMin= TimeSolt.ToString();//在线时长
            StuLine.OnTime= OnlineTable.Rows[0][4].ToString();//上机时间
            StuLine.StudentCardno= int.Parse(OnlineTable.Rows[0][0].ToString());//卡号
            StuLine.StudentLevel= OnlineTable.Rows[0][1].ToString();//用户类型
            StuLine.StudentNam=stuName ;//用户姓名 问题：正在上机表设计不合理，无法得到用户姓名。
            StuLine.UpDate = DateTime.Now.Date;//下机日期
            StuLine.UpTime = DateTime.Now.ToShortTimeString();//下机时间
            #endregion
            //向上机记录插入信息
            idal.InsertLineStudent(StuLine);
            #endregion
            //更新卡号状态和目前余额
            RegistrationCardno stuCardno = new RegistrationCardno();
            stuCardno.StudentCardno = StuLine.StudentCardno;//给卡号赋值
            stuCardno.Studentbalance = NowCsh;
            stuCardno.State = "未激活";
            idal.UpdateRegiCardno(stuCardno);

            //删除在线学生信息
            idal.DeleteOnLineStudent(studentOnline);
            //实例化登录窗体
            Form CreatLoginForm = CreatfactForm.CreatFrom("LoginUser");//实例化学生窗体
            CreatLoginForm.Show();//显示登录窗体          
        }

    }
}
