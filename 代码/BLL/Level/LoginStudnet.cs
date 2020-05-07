using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enitity;
using Factory;
using IDAL;
using System.Data;
using System.Windows.Forms;
using System.Reflection;
using System.Configuration;
namespace BLL.Level
{
/// <summary>
/// 学生职责
/// </summary>
  public  class LoginStudnet:userlevel
    {
        /// <summary>
        /// 实例化工厂，用于创建D登录查询类。
        /// </summary>
        FactoryDAl fact = new FactoryDAl();
        /// <summary>
        /// 实例化创建UI层窗体工厂
        /// </summary>
        FactoryUI CreatfactForm = new FactoryUI();
        public LoginStudnet(string Level) : base(Level)
        {
        }
        /// <summary>
        /// 向正在上机表插入学生信息
        /// </summary>
        /// <param name="studentOnLien"></param>
        /// <returns></returns>
        private int InserStudentOnlien(StudentOnLine studentOnLien)
        {
            //调用接口实例化，D层查询类
            LoginIDAL idal = (LoginIDAL)fact.CreateUser("LoginDal");
            //接收接口的返回值
            int Result =idal.InsertStudentOnLie(studentOnLien);
            return Result;
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="userlevel">用户</param>
        /// <returns>是否上机成功！</returns>
        public override string UserLogin(UserLevel userlevel,Form form)
        {
            #region 实例化与赋值
            string StrMsg="";//要返回的信息
            LoginIDAL idal = (LoginIDAL)fact.CreateUser("LoginDal"); //调用接口实例化，D层查询类
            RegistrationCardno RegisCardno = new RegistrationCardno(); //实例化实体
            RegisCardno.StudentCardno = userlevel.UserID;//给卡号赋值                                          
            #endregion
            DataTable StuCardnoTable = idal.SelectStuCardno(RegisCardno);//接受卡号信息
            RegisCardno.Studentbalance = double.Parse(StuCardnoTable.Rows[0][1].ToString());//给余额赋值
            DataTable BasitInfoTable = idal.SelectBasitInfo();//接受基础信息
            #region 判断卡号状态
            //判断卡号状态
            if (StuCardnoTable.Rows[0][4].ToString()=="已激活")
            {
                //判断余额是否充足
                if (RegisCardno.Studentbalance >=double.Parse(BasitInfoTable.Rows[0][0].ToString()))
                {
                    //实例化上机表实体与赋值
                    StudentOnLine stuOnLine = new StudentOnLine();
                    stuOnLine.StudentCardno = userlevel.UserID;//给卡号赋值
                    //获取上机表信息
                    DataTable OnWorkTable = idal.SelectOnStudent(stuOnLine);
                    //查询卡号是否已经登录
                    if (OnWorkTable.Rows.Count==0)//没有登录
                    {
                        form.Hide();//隐藏窗体
                      
                        #region 给上机实体赋值
                        stuOnLine.StudentLevel = StuCardnoTable.Rows[0][3].ToString();//卡号类型赋值
                        stuOnLine.OnDate = DateTime.Now.Date;//上机日期
                        stuOnLine.OnTime = DateTime.Now.ToShortTimeString();//上机时间
                        stuOnLine.NowCash =RegisCardno.Studentbalance;//当前余额
                        stuOnLine.Computer = Computer.GetMachineName();//电脑名称
                        #endregion
                        InserStudentOnlien(stuOnLine);//向上机表插入信息
                        UserLevel.UserIdall = userlevel.UserID; //给全局ID赋值
                        StrMsg = "上机成功!";
                        Form CreatForm = CreatfactForm.CreatFrom("StudentMain");//实例化学生窗体
                        CreatForm.Show();//显示窗体
                        
                    }
                    else
                    {
                        StrMsg = "此卡号已登录！";
                    }//end if
                   
                }
                else
                {
                    StrMsg = "余额不足，请充值";
                }//end if


            }
            else
            {
                StrMsg = "此卡号未激活，请激活使用！";
            }//end if
            #endregion
            return StrMsg;//返回登录信息    
        }
        
    }
}
