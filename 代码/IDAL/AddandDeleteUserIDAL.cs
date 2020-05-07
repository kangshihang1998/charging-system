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
    /// 添加删除用户数据层接口
    /// </summary>
public    interface AddandDeleteUserIDAL
    {
        /// <summary>
        /// 查询管理者登录信息
        /// </summary>
        /// <param name="userMan">管理者级别</param>
        /// <returns>以表形式返回登录信息</returns>
        DataTable SelectUserLogin(UserLevel userMan);
        /// <summary>
        /// 查询管理者信息
        /// </summary>
        /// <param name="manager">管理者实体</param>
        /// <returns>以表形式返回，管理者信息。</returns>
        DataTable SelectManagerial(Managerial manager);
        /// <summary>
        /// 向登录表插入信息
        /// </summary>
        /// <param name="userMan">登录表实体</param>
        /// <returns>后影响行数</returns>
        int InsertUserLogin(UserLevel userMan);
        /// <summary>
        /// 向管理者表插入信息
        /// </summary>
        /// <param name="manager">管理者实体</param>
        /// <returns>受影响行数</returns>
        int InsertManagerial(Managerial manager);
        /// <summary>
        /// 向管理者信息表插入信息
        /// </summary>
        /// <param name="manidcardno">管理者信息实体</param>
        /// <returns>受影响行数</returns>
        int InsertManIDcardno(ManIDcardno manidcardno);
        /// <summary>
        /// 删除登录表信息
        /// </summary>
        /// <param name="userMan">登录实体</param>
        /// <returns>受影响行数</returns>
        int DeleteUserLogin(UserLevel userMan);
        /// <summary>
        /// 删除管理者信息
        /// </summary>
        /// <param name="manager">管理者实体</param>
        /// <returns>受影响行数</returns>
        int DeletetManagerial(Managerial manager);
        /// <summary>
        ///  删除管理者身份信息
        /// </summary>
        /// <param name="manidcardno">管理者信息实体</param>
        /// <returns>受影响行数</returns>
        int DeleteManIDcardno(ManIDcardno manidcardno);
        /// <summary>
        /// 查询用户是否已经存在
        /// </summary>
        /// <param name="LoginUserID">用户ID</param>
        /// <returns>用户登录表里的信息</returns>
        DataTable SelectUserLevel(UserLevel LoginUserID);
    }
}
