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
    /// 重置学生密码数据层
    /// </summary>
 public   class StudentPwdOpertionDAL:StudentPwdOpertionIDAL
    {
        //实例化一个SQHelp层，用于连接数据库进行查询。
        SQLHelper sqlHelper = new SQLHelper();
        /// <summary>
        /// 查询卡号信息
        /// </summary>
        /// <param name="userCardno">卡号</param>
        /// <returns>整个卡号信息</returns>
        public DataTable SelectUserLoginCardnoInfo(UserLevel userCardno)
        {
            //定义参数
            SqlParameter[] sqlpams = {new SqlParameter("@UserID",userCardno.UserID),
                                      new SqlParameter("@Userlevel",userCardno.Userlevel)};
            //定义SQL语句
            string sql = @"select * from UserLonin where UserID=@UserID and UserLevel=@Userlevel";
            //接受查询结果
            DataTable SelectLoginTable = sqlHelper.ExecuteQuery(sql,sqlpams,CommandType.Text);
            return SelectLoginTable;//返回查询结果
        }
        /// <summary>
        /// 更新卡号密码
        /// </summary>
        /// <param name="userPwd">密码</param>
        /// <returns>受影响行数</returns>
        public int UpdateLoginPWD(UserLevel userPwd)
        {
            //定义参数
            SqlParameter[] sqlpams = {new SqlParameter("@UserID",userPwd.UserID),
                                      new SqlParameter("@Pwd",userPwd.UserPwd)};
            //定义SQL语句
            string sql = @"update UserLonin set Pwd=@Pwd where UserID=@UserID";
            //接受返回值
            int Relust = sqlHelper.ExecuteNonQuery(sql,sqlpams,CommandType.Text);
            return Relust;//返回受影响行数
        }
    }
}
