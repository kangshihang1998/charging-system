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
    /// 添加删除用户数据层
    /// </summary>
    public class AddandDeleteUserDAL : AddandDeleteUserIDAL
    {
        //实例化一个SQHelp层，用于连接数据库进行查询。
        SQLHelper sqlHelper = new SQLHelper();
        /// <summary>
        ///  删除管理者身份信息
        /// </summary>
        /// <param name="manidcardno">管理者信息实体</param>
        /// <returns>受影响行数</returns>
        public int DeleteManIDcardno(ManIDcardno manidcardno)
        {
            //定义参数
            SqlParameter[] sqlams = {new SqlParameter("@ManId", manidcardno.Manid)};
            //定义SQL语句
            string sql = @"delete ManIDcardno where ManId=@ManId";
            //执行SQL语句
            int Relst = sqlHelper.ExecuteNonQuery(sql,sqlams,CommandType.Text);
            return Relst;
        }
        /// <summary>
        /// 删除管理者信息
        /// </summary>
        /// <param name="manager">管理者实体</param>
        /// <returns>受影响行数</returns>
        public int DeletetManagerial(Managerial manager)
        {
            //定义参数
            SqlParameter[] sqlams = { new SqlParameter("@ManId", manager.ManId) };
            //定义SQL语句
            string sql = @"delete Managerial where ManId=@ManId";
            //执行SQL语句
            int Relst = sqlHelper.ExecuteNonQuery(sql, sqlams, CommandType.Text);
            return Relst;
        }
        /// <summary>
        /// 删除登录表信息
        /// </summary>
        /// <param name="userMan">登录实体</param>
        /// <returns>受影响行数</returns>
        public int DeleteUserLogin(UserLevel userMan)
        {
            //定义参数
            SqlParameter[] sqlams = { new SqlParameter("@UserID", userMan.UserID) };
            //定义SQL语句
            string sql = @"delete UserLonin where UserID=@UserID";
            //执行SQL语句
            int Relst = sqlHelper.ExecuteNonQuery(sql, sqlams, CommandType.Text);
            return Relst;
        }
        /// <summary>
        /// 向管理者表插入信息
        /// </summary>
        /// <param name="manager">管理者实体</param>
        /// <returns>受影响行数</returns>
        public int InsertManagerial(Managerial manager)
        {
            //定义参数
            SqlParameter[] sqlams = { new SqlParameter("@ManId",manager.ManId)
                                    ,new SqlParameter("@Name",manager.Name)
                                    ,new SqlParameter("@Level",manager.Level)
                                    ,new SqlParameter("@State",manager.State)};
            //定义SQL语句
            string sql = @"insert into Managerial values(@ManId,@Name,@Level,@State)";
            //执行SQL语句
            int Relust = sqlHelper.ExecuteNonQuery(sql,sqlams,CommandType.Text);
            return Relust;
        }
        /// <summary>
        /// 向管理者信息表插入信息
        /// </summary>
        /// <param name="manidcardno">管理者信息实体</param>
        /// <returns>受影响行数</returns>
        public int InsertManIDcardno(ManIDcardno manidcardno)
        {
            //定义参数
            SqlParameter[] sqlams = { new SqlParameter("@ManId",manidcardno.Manid)
                                    ,new SqlParameter("@PhoneNumber",manidcardno.PhoneNumber)
                                    ,new SqlParameter("@Sex",manidcardno.Sex)
                                    ,new SqlParameter("@Age",manidcardno.Age)};
            //定义SQL语句
            string sql = @"insert into ManIDcardno values(@ManId,@PhoneNumber,@Sex,@Age)";
            //执行SQL语句
            int Relust = sqlHelper.ExecuteNonQuery(sql, sqlams, CommandType.Text);
            return Relust;
        }
        /// <summary>
        /// 向登录表插入信息
        /// </summary>
        /// <param name="userMan">登录表实体</param>
        /// <returns>后影响行数</returns>
        public int InsertUserLogin(UserLevel userMan)
        {
            //定义参数
            SqlParameter[] sqlams = { new SqlParameter("@UserID",userMan.UserID)
                                    ,new SqlParameter("@UserLevel",userMan.Userlevel)
                                    ,new SqlParameter("@Pwd",userMan.UserPwd)};
            //定义SQL语句
            string sql = @"insert into UserLonin values(@UserID,@UserLevel,@Pwd)";
            //执行SQL语句
            int Relust = sqlHelper.ExecuteNonQuery(sql, sqlams, CommandType.Text);
            return Relust;
        }
        /// <summary>
        /// 查询管理者信息
        /// </summary>
        /// <param name="manager">管理者实体</param>
        /// <returns>以表形式返回，管理者信息。</returns>
        public DataTable SelectManagerial(Managerial manager)
        {
            //定义参数
            SqlParameter[] sqlams = { new SqlParameter("@ManId", manager.ManId) };
            //定义SQL语句
            string sql = @"select * from Managerial where ManId=@ManId";
            //接受查询结果
            DataTable SelectUserLogingTable = sqlHelper.ExecuteQuery(sql, sqlams, CommandType.Text);
            return SelectUserLogingTable;
        }

        /// <summary>
        /// 查询管理者登录信息
        /// </summary>
        /// <param name="userMan">管理者级别</param>
        /// <returns>以表形式返回登录信息</returns>
        public DataTable SelectUserLogin(UserLevel userMan)
        {
            //定义参数
            SqlParameter[] sqlams = {new SqlParameter("@Userlevel", userMan.Userlevel)};
            //定义SQL语句
            string sql = @"select * from UserLonin where Userlevel=@Userlevel";
            //接受查询结果
            DataTable SelectUserLogingTable = sqlHelper.ExecuteQuery(sql,sqlams,CommandType.Text);
            return SelectUserLogingTable;
        }
        /// <summary>
        /// 查询用户是否已经存在
        /// </summary>
        /// <param name="LoginUserID">用户ID</param>
        /// <returns>用户登录表里的信息</returns>
        public DataTable SelectUserLevel(UserLevel LoginUserID)
        {
            //定义参数
            SqlParameter[] sqlpams = { new SqlParameter("@UserID", LoginUserID.UserID) };
            //定义SQL语句
            string sql = @"select * from UserLonin where UserID=@UserID";
            //接受出现结果
            DataTable UserTable = sqlHelper.ExecuteQuery(sql, sqlpams, CommandType.Text);
            return UserTable;//返回查询结果
        }
    }
}
