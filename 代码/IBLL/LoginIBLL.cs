using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace IBLL
{
/// <summary>
/// 登录接口
/// </summary>
    public interface LoginIBLL
    {
        /// <summary>
        /// 登录方法
        /// </summary>
        /// <param name="userid">用户ID</param>
        /// <param name="pwd">密码</param>
        /// <param name="form">登录窗体</param>
        /// <returns>是否登录成功</returns>
        string loginFacade(string userid, string pwd, Form form);
    }
}
