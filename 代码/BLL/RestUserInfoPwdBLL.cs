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
/// 重置用户密码业务
/// </summary>
public    class RestUserInfoPwdBLL:RestUserInfoPwdIBLL
    {
        /// <summary>
        /// 实例化工厂，用于创建D登录查询类。
        /// </summary>
        FactoryDAl fact = new FactoryDAl();
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="OldPwd">旧密码</param>
        /// <param name="NewPwd">新密码</param>
        /// <param name="NewPwdOk">确认密码</param>
        /// <param name="form">窗体</param>
        /// <returns>是否修改成功！</returns>
        public string RestUserPwd(string UserID,string OldPwd,string NewPwd ,string NewPwdOk, Form form )
        {
            //用于返回信息
            string strMsger = "";
            //接受判空返回值，判断文本框是否为空。
            string isNull = IsNull.isNull(form);
            if (isNull=="")//没有返回值说明文本框不为空！
            {
                //判断新密码和确认密码是否一致
                if (NewPwd==NewPwdOk)
                {
                    //转化为实体
                    UserLevel userID = new UserLevel();
                    userID.UserID = int.Parse(UserID);
                    userID.UserPwd = OldPwd;
                    //利用反射，实例化D层登录查询类
                    RestUserInfoPwdIDAL idal = (RestUserInfoPwdIDAL)fact.CreateUser("RestUserInfoPwdDAL");
                    //获取登录表信息
                    DataTable UserPwdTable = idal.SelectUserInfPwd(userID);
                    //查询旧密码是否正确
                    if (UserPwdTable.Rows.Count != 0)//密码正确
                    {
                        //判断新密码是否和上次的一样
                        if (NewPwd==UserPwdTable.Rows[0][2].ToString())
                        {
                            strMsger = "不能和上次密码一致！";
                        }
                        else
                        {
                            //修改用户密码
                            userID.UserPwd = NewPwd;//给新密码赋值
                            idal.UpdateUserInfoPwd(userID);
                            strMsger = "恭喜，密码修改成！";
                        }
                    }
                    else
                    {
                        //密码错误
                        strMsger = "旧密码错误，请从新输入！";
                    }//end if
                }
                else
                {
                    strMsger = "新密码和确认密码不一致，请检查下！";
                }
                  
            }
            else
            {
                strMsger = isNull;//返回信息
            }//end if
            return strMsger;//返回信息
        }
    }
}
