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
/// 重置用户密码
/// </summary>
   public interface RestUserInfoPwdIDAL
    {
        /// <summary>
        /// 查询旧密码是否正确
        /// </summary>
        /// <param name="UserID">用户实体</param>
        /// <returns>登录表信息</returns>
        DataTable SelectUserInfPwd(UserLevel UserID);
        /// <summary>
        /// 更新用户密码
        /// </summary>
        /// <param name="UserID">用户实体</param>
        /// <returns>受影响行数</returns>
        int UpdateUserInfoPwd(UserLevel UserID);
    }
}
