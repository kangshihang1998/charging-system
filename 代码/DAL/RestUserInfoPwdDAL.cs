using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//引用
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using IDAL;
using Enitity;
namespace DAL
{
/// <summary>
/// 重置用户密码数据控制层
/// </summary>
 public   class RestUserInfoPwdDAL:RestUserInfoPwdIDAL
    {
        //实例化一个SQHelp层，用于连接数据库进行查询。
        SQLHelper sqlHelper = new SQLHelper();
        /// <summary>
        /// 查询旧密码是否正确
        /// </summary>
        /// <param name="UserID">用户实体</param>
        /// <returns>登录信息</returns>
        public DataTable SelectUserInfPwd(UserLevel UserID)
        {
            //定义参数
            SqlParameter[] sqlparms = {new SqlParameter("@UserID", UserID.UserID),
                                       new SqlParameter("@Pwd",UserID.UserPwd)};
            //定义SQL语句
            string sql = @"select * from UserLonin where UserID=@UserID and Pwd=@Pwd";
            //接受查询结果
            DataTable UserTablePwd = sqlHelper.ExecuteQuery(sql,sqlparms,CommandType.Text);
            return UserTablePwd;//返回结果
        }
        /// <summary>
        /// 重置密码
        /// </summary>
        /// <param name="UserID">用户实体</param>
        /// <returns>受影响行数</returns>
        public int UpdateUserInfoPwd(UserLevel UserID)
        {
            //定义参数
            SqlParameter[] sqlparms = {new SqlParameter("@UserID", UserID.UserID),
                                       new SqlParameter("@Pwd",UserID.UserPwd)};
            //定义SQL语句
            string sql = @"update UserLonin set Pwd=@Pwd where UserID=@UserID";
            //接受受影响行数
            int Relust = sqlHelper.ExecuteNonQuery(sql,sqlparms,CommandType.Text);
            return Relust;//返回结果
        }
    }
}
