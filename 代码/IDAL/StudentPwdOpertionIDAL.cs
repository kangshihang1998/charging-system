using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enitity;
using System.Data;
namespace IDAL
{
    /// <summary>
    /// 重置学生密码，数据层接口。
    /// </summary>
 public   interface StudentPwdOpertionIDAL
    {
        /// <summary>
        /// 查询卡号信息
        /// </summary>
        /// <param name="userCardno">卡号</param>
        /// <returns>整个卡号信息</returns>
        DataTable SelectUserLoginCardnoInfo(UserLevel userCardno);
        /// <summary>
        /// 更新卡号密码
        /// </summary>
        /// <param name="userPwd">密码</param>
        /// <returns>受影响行数</returns>
        int UpdateLoginPWD(UserLevel userPwd);
    }
}
