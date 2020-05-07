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
    /// 重置学生密码业务层
    /// </summary>
  public  class StudentPwdOpertionBLL:StudentPwdOpertionIBLL
    {
        /// <summary>
        /// 实例化工厂，用于创建D登录查询类。
        /// </summary>
        FactoryDAl fact = new FactoryDAl();
        /// <summary>
        /// 重置学生密码
        /// </summary>
        /// <param name="cardno">卡号</param>
        /// <param name="newpwd">新密码</param>
        /// <param name="newpwdok">确认密码</param>
        /// <param name="form">重置学生密码窗体</param>
        /// <returns></returns>
        public string StudentPwdOpertion(string cardno, string newpwd, string newpwdok, Form form)
        {
            //用于返回信息
            string StrMsg = "";
            //接受判空返回值，判断文本框是否为空。
            string isNull = IsNull.isNull(form);
            //接受是不是数字的判断返回值
            bool isNumber = IsNull.IsNumber(cardno);
            //判断文本框是否为空
            if (isNull=="")//没有返回值，说明不为空。
            {
                //判断卡号是否是数字
                if (isNumber==true)//返回true说明输入的是数字！
                {
                    //判断密码和确认密码是否一致
                    if (newpwd==newpwdok)
                    {
                        //调用重置学生密码的数据层接口和创建DAL层的功能实例化具体的DAL层类
                        StudentPwdOpertionIDAL studentpwdopertion = (StudentPwdOpertionIDAL)fact.CreateUser("StudentPwdOpertionDAL");
                        //实例化userlevel实体
                        UserLevel user = new UserLevel();
                        user.UserID = int.Parse(cardno);
                        user.Userlevel = "学生";
                        //调用修改密码的方法,获取用户信息！
                         DataTable userTable = studentpwdopertion.SelectUserLoginCardnoInfo(user);
                        //判断用户是否存在
                        if (userTable.Rows.Count!=0)//说明用户存在
                        {
                            user.UserPwd = newpwd;//更新密码
                            studentpwdopertion.UpdateLoginPWD(user);
                            StrMsg = "重置成功！";
                        }
                        else
                        {
                            //用户不存在
                            StrMsg = "用户不存在，请从新输入！";
                        }
                    }
                    else
                    {
                        StrMsg = "新密码和确认密码不一致，请重新输入！";
                    }


                }
                else
                {
                    StrMsg = "卡号请输入数字！";
                }
            }
            else
            {
                StrMsg = isNull;//返回错误信息
            }
            return StrMsg;//返回是否成功的信息！
        }
    }
}
