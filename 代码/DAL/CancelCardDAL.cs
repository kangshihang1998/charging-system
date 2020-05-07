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
    /// 退卡数据层
    /// </summary>
    public class CancelCardDAL : CancelCardIDAL
    {
        //实例化一个SQHelp层，用于连接数据库进行查询。
        SQLHelper sqlHelper = new SQLHelper();
        /// <summary>
        /// 删除卡号表卡号信息
        /// </summary>
        /// <param name="regisCardno">卡号实体</param>
        /// <returns>受影响行数</returns>
        public int DeleteRegiscardnoInfo(RegistrationCardno regisCardno)
        {
            //定义参数
            SqlParameter[] sqlamps = {new SqlParameter("@StudentCardno", regisCardno.StudentCardno)};
            //定义SQL语句
            string sql = @"delete RegistrationCardno where StudentCardno=@StudentCardno";
            //接受受影响行数
            int Relust = sqlHelper.ExecuteNonQuery(sql,sqlamps,CommandType.Text);
            return Relust;
        }
        /// <summary>
        /// 删除卡号的学生信息
        /// </summary>
        /// <param name="studentInfo">学生信息实体</param>
        /// <returns>受影响行数</returns>
        public int DeleteStudentInfo(StudentInfo studentInfo)
        {
            //定义参数
            SqlParameter[] sqlamps = { new SqlParameter("@StudentCardno",studentInfo.StudentCardno) };
            //定义SQL语句
            string sql = @"delete StudentInfo where StudentCardno=@StudentCardno";
            //接受受影响行数
            int Relust = sqlHelper.ExecuteNonQuery(sql, sqlamps, CommandType.Text);
            return Relust;
        }
        /// <summary>
        /// 删除登录表卡号信息
        /// </summary>
        /// <param name="user">登录表实体</param>
        /// <returns>受影响行数</returns>
        public int DeleteUserLoginCardnoInfo(UserLevel user)
        {
            //定义参数
            SqlParameter[] sqlamps = { new SqlParameter("@UserID", user.UserID) };
            //定义SQL语句
            string sql = @"delete UserLonin where UserID=@UserID";
            //接受受影响行数
            int Relust = sqlHelper.ExecuteNonQuery(sql, sqlamps, CommandType.Text);
            return Relust;
        }
        /// <summary>
        /// 向退卡表插入信息
        /// </summary>
        /// <param name="cancelcard">退卡表实体</param>
        /// <returns>受影响行数</returns>
        public int InsertCanCardno(CanceCard cancelcard)
        {
            //定义参数
            SqlParameter[] sqlamps = { new SqlParameter("@StudentCardno", cancelcard.StudentCardno)
                                     ,new SqlParameter("@CanCash",cancelcard.CanCash)
                                     ,new SqlParameter("@CanDate",cancelcard.CanDate)
                                     ,new SqlParameter("@CanTime",cancelcard.CanTime)
                                     ,new SqlParameter("@OperationID",cancelcard.OperationID)
                                     ,new SqlParameter("@State",cancelcard.State)
                                     };

            //定义SQL语句
            string sql = @"insert into CancelCard values(@StudentCardno,@CanCash,@CanDate,@CanTime,@OperationID,@State)";
            //接受受影响行数
            int Relust = sqlHelper.ExecuteNonQuery(sql, sqlamps, CommandType.Text);
            return Relust;
        }
        /// <summary>
        /// 查询卡号是否存在
        /// </summary>
        /// <param name="regisCardno">卡号实体</param>
        /// <returns>返回卡号信息</returns>
        public DataTable SelectRegisCardnoInfo(RegistrationCardno regisCardno)
        {
            //定义参数
            SqlParameter[] sqlamps = { new SqlParameter("@StudentCardno", regisCardno.StudentCardno) };
            //定义SQL语句
            string sql = @"select * from RegistrationCardno where StudentCardno=@StudentCardno";
            //接受查询结果
            DataTable RegisCardnoInfo = sqlHelper.ExecuteQuery(sql,sqlamps,CommandType.Text);
            return RegisCardnoInfo;
        }
    }
}
