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
using System.Windows.Forms;
namespace BLL
{
/// <summary>
/// 登录业务
/// </summary>
  public  class LoginBLL:LoginIBLL
    {
        /// <summary>
        /// 实例化工厂，用于创建D登录查询类。
        /// </summary>
        FactoryDAl fact = new FactoryDAl();
        /// <summary>
        /// 实例化临时表，储存UserLevel用户的所有信息
        /// </summary>
        public static DataTable UserTable = new DataTable();
       
        /// <summary>
        /// 登录业务
        /// </summary>
        /// <param name="userid">用户id</param>
        /// <param name="pwd">密码</param>
        /// <returns>是否登录成功</returns>
        public string loginFacade(string userid, string pwd, Form form)
        {
            //用于返回信息
            string strMsger = "";
            //接受判空返回值，判断文本框是否为空。
            string isNull = IsNull.isNull(form);
            //接受是不是数字的判断返回值
            bool isNumber = IsNull.IsNumber(userid);
            //判断文本框是否为空
            if (isNull == "")//没有返回值说明文本框不为空！
            {
                //判断UserID是不是数字
                if (isNumber==true)//等于true，说明输入的是数字！
                {
                    #region 赋值与转化实体
                    //转换为实体
                    UserLevel user = new UserLevel();
                    user.UserID = Convert.ToInt32(userid);
                    user.UserPwd = pwd;
                    #endregion
                    #region 调用D层登录查询
                    //利用反射，实例化D层登录查询类
                    LoginIDAL idal = (LoginIDAL)fact.CreateUser("LoginDal");
                    //获取D层返回值
                    UserTable = idal.SelectUserLevel(user);
                    #endregion
                    #region 判断用户是否存在
                    //判断账号是否存在
                    if (UserTable.Rows.Count != 0)
                    {
                        //给级别赋值
                        user.Userlevel = UserTable.Rows[0][1].ToString().Trim();
                        #region 设置继续处理者
                        Level.LoginAdmin admin = new Level.LoginAdmin("管理员");
                        Level.LoginOpetion operation = new Level.LoginOpetion("操作员");
                        Level.LoginStudnet student = new Level.LoginStudnet("学生");
                        #endregion
                        #region 级别判断
                        //判断级别
                        if (user.Userlevel == "管理员")
                        {
                            //继续处理者，跳转到对应的职责链
                            admin.SetSupertior(operation);
                            admin.SetSupertior(student);
                            strMsger = admin.UserLogin(user, form);

                        }
                        else if (user.Userlevel == "操作员")
                        {
                            //继续处理者，跳转到对应的职责链
                            operation.SetSupertior(admin);
                            operation.SetSupertior(student);
                            strMsger = operation.UserLogin(user, form);

                        }
                        else if (user.Userlevel == "学生")
                        {
                            //继续处理者,跳转到对应的职责链
                            student.SetSupertior(admin);
                            student.SetSupertior(operation);
                            strMsger = student.UserLogin(user, form);

                        }
                        #endregion
                    }
                    else
                    {
                        strMsger = "账号不存在，或密码错误！";
                    }
                    //end if 
                    #endregion
                }
                else
                {
                    //输入值不是数字
                    strMsger ="登录账号请输入数字！";
                }

            }
            else
            {
                //文本框为空！
                strMsger = isNull;//把返回结果赋值给strMsger返回给U层
            }

            return strMsger;
        }
    }
}
