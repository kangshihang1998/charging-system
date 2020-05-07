using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace IBLL
{
/// <summary>
/// 修改密码接口
/// </summary>
 public   interface RestUserInfoPwdIBLL
    {
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="OldPwd">旧密码</param>
        /// <param name="NewPwd">新密码</param>
        /// <param name="NewPwdOk">确认密码</param>
        /// <param name="form">窗体</param>
        /// <returns>是否修改成功！</returns>
        string RestUserPwd(string UserID, string OldPwd, string NewPwd, string NewPwdOk, Form form);
    }
}
