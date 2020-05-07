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
    /// 登录查询
    /// </summary>
    public class LoginDal : LoginIDAL
    {
        //实例化一个SQHelp层，用于连接数据库进行查询。
        SQLHelper sqlHelper = new SQLHelper();
        /// <summary>
        /// 向正在上机学生表插入信息
        /// </summary>
        /// <param name="StudentOnlies">学生上机实体</param>
        /// <returns>返回整个表信息</returns>
        public int InsertStudentOnLie(StudentOnLine StudentOnlies)
        {
            //定义参数
            SqlParameter[] sqlparams = { new SqlParameter("@StudentCardno", StudentOnlies.StudentCardno),
                                         new SqlParameter("@StudentLevel",StudentOnlies.StudentLevel),
                                         new SqlParameter("@NowCash",StudentOnlies.NowCash),
                                         new SqlParameter("@OnDate",StudentOnlies.OnDate),
                                         new SqlParameter("@OnTime",StudentOnlies.OnTime),
                                         new SqlParameter("@Computer",StudentOnlies.Computer) };
            //定义SQL语句
            string sql = @"insert into OnLineStudent values(@StudentCardno,@StudentLevel,@NowCash,@OnDate,@OnTime,@Computer)";
            //接受受影响的行数
            int Relust = sqlHelper.ExecuteNonQuery(sql,sqlparams,CommandType.Text);
            //返回收影响的行数
            return Relust;
        }
        /// <summary>
        /// 向管理者值班表插入信息
        /// </summary>
        /// <param name="UserOnWork">值班表实体</param>
        /// <returns>整个值班表信息</returns>
        public int InsertUser(UserOnWork UserOnWork)
        {
            //定义参数
            SqlParameter[] sqlparams = { new SqlParameter("@ManID",UserOnWork.ManId),
                                        new SqlParameter("@ManLevel",UserOnWork.Level),
                                        new SqlParameter("@OpertionName",UserOnWork.Name),
                                        new SqlParameter("@OnDate",UserOnWork.Ondate),
                                        new SqlParameter("@OnTime",UserOnWork.OnTime),
                                        new SqlParameter("@Computer",UserOnWork.Computer) };
            //定义SQL语句
            string sql = @"insert into OnWorkMan values(@ManID,@ManLevel,@OpertionName,@OnDate,@OnTime,@Computer)";
            //接受受影响的行数
            int Relust = sqlHelper.ExecuteNonQuery(sql,sqlparams,CommandType.Text);
            return Relust;//返回受影响的行数
        }
        /// <summary>
        /// 基础信息
        /// </summary>
        /// <param name="BasitInfo">基础信息实体</param>
        /// <returns>整个基础信息表</returns>
        public DataTable SelectBasitInfo()
        {
            //定义SQL语句
            string sql = @"select * from Basis";
            //获取查询结果
            DataTable BasiTable = sqlHelper.ExecuteQuery(sql,CommandType.Text);
            //返回查询结果
            return BasiTable;
        }

        /// <summary>
        /// 查询学生是否已经上机
        /// </summary>
        /// <param name="OnStudent">学生上机实体</param>
        /// <returns>返回整个表信息</returns>
        public DataTable SelectOnStudent(StudentOnLine OnStudent)
        {
            //定义参数
            SqlParameter[] sqlparams = { new SqlParameter("@StudentCardno",OnStudent.StudentCardno) };
            //定义SQL语句
            string sql = @"select * from OnLineStudent where StudentCardno=@StudentCardno";
            //接受查询结果
            DataTable OnstuTable = sqlHelper.ExecuteQuery(sql,sqlparams,CommandType.Text);
            //返回查询结果
            return OnstuTable;
        }
        /// <summary>
        /// 查询管理者是否已经登录
        /// </summary>
        /// <param name="OnUser">值班表管理者实体</param>
        /// <returns>整个管理者表的信息</returns>
        public DataTable SelectOnUser(UserOnWork OnUser)
        {
            //定义参数
            SqlParameter[] sqlparams = { new SqlParameter("@ManID",OnUser.ManId) };
            //定义SQL语句
            string sql = @"select * from OnWorkMan where ManID=@ManID";
            //把查询结果储存到临时表
            DataTable OnWorkTable =sqlHelper.ExecuteQuery(sql,sqlparams,CommandType.Text);
            //返回整个表的信息
            return OnWorkTable;
        }
        /// <summary>
        /// 管理者使用状态
        /// </summary>
        /// <param name="ManageState">管理者信息</param>
        /// <returns>整个表的管理者信息</returns>
        public DataTable SelectState(Managerial ManageState)
        {
            //定义参数
            SqlParameter[] sqlparams = { new SqlParameter("@ManID",ManageState.ManId)};
            //定义SQL语句
            string sql = @"select * from Managerial where ManID=@ManID";
            //把查询结果储存到临时表
            DataTable ManTable = sqlHelper.ExecuteQuery(sql,sqlparams,CommandType.Text);
            //返回整个表的信息
            return ManTable;

        }
        /// <summary>
        /// 查询卡号信息
        /// </summary>
        /// <param name="StudentCardno">卡号实体</param>
        /// <returns>整个表的卡号信息</returns>
        public DataTable SelectStuCardno(RegistrationCardno StudentCardno)
        {
            //定义参数
            SqlParameter[] sqlparams = { new SqlParameter("@StudentCardno",StudentCardno.StudentCardno) };
            //定义SQL语句
            string sql = @"select * from RegistrationCardno where StudentCardno=@StudentCardno";
            //接受查询结果
            DataTable StuCarTable = sqlHelper.ExecuteQuery(sql,sqlparams,CommandType.Text);
            //一表的形式返回查询结果
            return StuCarTable;
        }
        /// <summary>
        /// 用户是否存在和级别
        /// </summary>
        /// <param name="UserLevel">用户登录实体</param>
        /// <returns>整个登录表</returns>
        public DataTable SelectUserLevel(UserLevel UserLevel)
        {
            //定义需要传递的参数
            SqlParameter[] sqlparams = { new SqlParameter("@UserID", UserLevel.UserID), 
                                          new SqlParameter("@Pwd", UserLevel.UserPwd) };
            //定义SQL语句
            string sql = @"select * from UserLonin where UserId=@UserId and Pwd=@Pwd";
            //把查询结果储存到临时表
            DataTable table = sqlHelper.ExecuteQuery(sql, sqlparams, CommandType.Text);
            return table;//返回整个临时表
        }

    }
      
}
