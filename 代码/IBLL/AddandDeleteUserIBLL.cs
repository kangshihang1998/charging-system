using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
namespace IBLL
{
    /// <summary>
    /// 添加删除用户业务层接口
    /// </summary>
  public  interface AddandDeleteUserIBLL
    {
        /// <summary>
        /// 显示用户信息
        /// </summary>
        /// <param name="UserLevel">用户级别</param>
        /// <param name="StrMsg">返回信息</param>
        /// <returns>以表形式返回登录信息</returns>
        DataTable SelectLogin(string userLevel,out string StrMsg);
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="UserID">用户DI</param>
        /// <param name="UserLevel">用户级别</param>
        /// <param name="UserPwd">用户密码</param>
        /// <param name="UserName">用户姓名</param>
        /// <param name="State">使用状态</param>
        /// <param name="PhonNumber">手机号</param>
        /// <param name="Sex">性别</param>
        /// <param name="Age">年龄</param>
        /// <param name="form">添加删除窗体</param>
        /// <returns>是否添加成功！</returns>
        string AddUserManInfo(string UserID,string UserLevel,string UserPwd,string UserName,string State,string PhonNumber,string Sex,string Age,Form form);
        /// <summary>
        /// 删除用户信息
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="form">添加删除窗体</param>
        /// <returns></returns>
        string DeleteUserManInfo(string UserID);

    }
}
