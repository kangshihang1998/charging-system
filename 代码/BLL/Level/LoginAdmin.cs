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
/// 管理员职责
/// </summary>
public  class LoginAdmin:userlevel
    {
        /// <summary>
        /// 实例化工厂，用于创建D登录查询类。
        /// </summary>
        FactoryDAl fact = new FactoryDAl();
        /// <summary>
        /// 实例化创建UI层窗体工厂
        /// </summary>
        FactoryUI CreatfactForm = new FactoryUI();
        /// <summary>
        /// 调用父类构造函数
        /// </summary>
        /// <param name="Level">给级别赋值</param>
        public LoginAdmin(string Level) : base(Level)
        {
        }

        /// <summary>
        /// 向值班表插入用户数据
        /// </summary>
        /// <param name="insertonwork">值班人员</param>
        /// <returns>整数</returns>
        private int InserUserOnWork(UserOnWork insertonwork)
        {
            //调用接口实例化，D层查询类
            LoginIDAL idal = (LoginIDAL)fact.CreateUser("LoginDal");
            //接收接口的返回值
            int Result = idal.InsertUser(insertonwork);
            return Result;
        }
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="userlevel">用户</param>
        /// <returns>是否登录成功！</returns>
        public override string UserLogin(UserLevel userlevel,Form form)
        {
            //返回信息
            string StrMesg = "";
            //调用接口实例化D层查询类
            LoginIDAL idal = (LoginIDAL)fact.CreateUser("LoginDal");
          //实例化管理者实体和赋值
          Managerial Manageria = new Managerial();
            Manageria.ManId = userlevel.UserID;//登录id赋值给管理者ID
            //接受管理者信息
            DataTable ManTable = idal.SelectState(Manageria);

            //判断账号是否使用
            if (ManTable.Rows[0][3].ToString().Trim()=="使用")
            {
                #region 判断管理者是否已经登录
                //实例化值班实体与赋值
                UserOnWork userOnWork = new UserOnWork();
                userOnWork.ManId = userlevel.UserID;//值班实体的管理者id赋值
                //接受接口的返回值,返回整个值班表的信息。
                DataTable OnWorkTable = idal.SelectOnUser(userOnWork);
                //判断管理者是否已经登录
                if (OnWorkTable.Rows.Count == 0)//没有登录
                {
                    form.Hide();//隐藏窗体
                    #region 向值班表插入信息
                    //给值班实体赋值
                    userOnWork.Level = userlevel.Userlevel;//管理者级别
                    userOnWork.Name = ManTable.Rows[0][1].ToString().Trim();//管理者姓名
                    userOnWork.Ondate = DateTime.Now.Date;//登录日期
                    userOnWork.OnTime = DateTime.Parse(DateTime.Now.ToShortTimeString());//登录时间
                    userOnWork.Computer = Computer.GetMachineName();//计算机名
                    //调用插入方法
                    InserUserOnWork(userOnWork);
                    #endregion
                    //给全局ID赋值
                    UserLevel.UserIdall = userlevel.UserID;
                    StrMesg = "登录成功！";
                    //显示管理员窗体
                    Form CreatForm = CreatfactForm.CreatFrom("AdminMain");//实例化管理员窗体
                    CreatForm.Show();//显示窗体
                }
                else
                {
                    StrMesg = "此账号已登录！";
                }
                #endregion
            }
            else
            {
                StrMesg = "此账号未使用,请激活使用！";
            }//end if

            return StrMesg;
            
        }
       
    }
}
