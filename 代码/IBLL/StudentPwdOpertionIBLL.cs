using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace IBLL
{
    /// <summary>
    /// 重置学生密码业务层接口
    /// </summary>
public    interface StudentPwdOpertionIBLL
    {
        /// <summary>
        /// 重置学生密码
        /// </summary>
        /// <param name="cardno">卡号</param>
        /// <param name="newpwd">新密码</param>
        /// <param name="newpwdok">确认密码</param>
        /// <param name="form">重置学生密码窗体</param>
        /// <returns></returns>
        string StudentPwdOpertion(string cardno,string newpwd,string newpwdok,Form form);

    }
}
