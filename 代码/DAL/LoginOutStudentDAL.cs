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
    /// 学生退出数据访问层
    /// </summary>
    public class LoginOutStudentDAL : LoginOutStudentIDAL
    {
        //实例化一个SQHelp层，用于连接数据库进行查询。
        SQLHelper sqlHelper = new SQLHelper();
        /// <summary>
        /// 删除正在上机记录
        /// </summary>
        /// <param name="StudentOnlien">正在上机实体</param>
        /// <returns>受影响行数</returns>
        public int DeleteOnLineStudent(StudentOnLine StudentOnlien)
        {
            //定义参数
            SqlParameter[] sqlParms = { new SqlParameter("@StudentCardno", StudentOnlien.StudentCardno)};
            //定义SQL语句
            string sql = @"delete OnLineStudent where StudentCardno=@StudentCardno";
            //接受查询结果
            int Relust = sqlHelper.ExecuteNonQuery(sql,sqlParms,CommandType.Text);
            return Relust;//返回结果
        }
        /// <summary>
        /// 向上机记录表插入信息
        /// </summary>
        /// <param name="stuLine">上机记录实体</param>
        /// <returns>受影响行数</returns>
        public int InsertLineStudent(StudentLien stuLine)
        {
            //定义参数
            SqlParameter[] sqlParms = { new SqlParameter("@StudentCardno",stuLine.StudentCardno),
                                        new SqlParameter("@StudentName",stuLine.StudentNam),
                                        new SqlParameter("@StudentLevel",stuLine.StudentLevel),
                                        new SqlParameter("@OnDate",stuLine.OnDate),
                                        new SqlParameter("@OnTime",stuLine.OnTime),
                                        new SqlParameter("@UpDate",stuLine.UpDate),
                                        new SqlParameter("@UpTime",stuLine.UpTime),
                                        new SqlParameter("@OnLineMin",stuLine.OnLineMin),
                                        new SqlParameter("@ConsumptionCash",stuLine.ConsumptionCash),
                                        new SqlParameter("@NowCash",stuLine.NowCash),
                                        new SqlParameter("@Computer",stuLine.Computer) };
            //定义SQL语句
            string sql = @"insert into  LineStudent values(@StudentCardno,@StudentName,@StudentLevel,@OnDate,@OnTime,@UpDate,@UpTime,@OnLineMin,@ConsumptionCash,@NowCash,@Computer)";
            //接受查询结果
            int Relust = sqlHelper.ExecuteNonQuery(sql,sqlParms,CommandType.Text);
            return Relust;//返回结果
        }
        /// <summary>
        /// 查询基础信息
        /// </summary>
        /// <param name="basitInf">基础信息实体</param>
        /// <returns>基础信息临时表</returns>
        public DataTable SelectBasit()
        {
            //定义SQL语句
            string sql = @"select * from Basis";
            //获取查询结果
            DataTable BasiTable = sqlHelper.ExecuteQuery(sql, CommandType.Text);
            //返回查询结果
            return BasiTable;
        }
        /// <summary>
        /// 查询正在上机学生信息
        /// </summary>
        /// <param name="StudentOnlien">正在上机学生实体</param>
        /// <returns></returns>
        public DataTable SelectOnLineStudent(StudentOnLine StudentOnlien)
        {
            //定义参数
            SqlParameter[] sqlParms = {new SqlParameter("@StudentCardno",StudentOnlien.StudentCardno) };
            //定义SQL语句
            string sql = @"select * from OnLineStudent where StudentCardno=@StudentCardno";
            //接受查询结果
            DataTable OnlietTable = sqlHelper.ExecuteQuery(sql,sqlParms,CommandType.Text);
            return OnlietTable;//返回结果
        }
        /// <summary>
        /// 更新卡号余额和使用方法
        /// </summary>
        /// <param name="studentCsh">余额实体</param>
        /// <returns>受影响行数</returns>
        public int UpdateRegiCardno(RegistrationCardno studentCsh)
        {
            //定义参数
            SqlParameter[] sqlParms = { new SqlParameter("@Studentbalance",studentCsh.Studentbalance),
                                        new SqlParameter("@StudentCardno",studentCsh.StudentCardno),
                                       new SqlParameter("@State",studentCsh.State)};
            //定义SQL语句
            string sql = @"update RegistrationCardno set Studentbalance=@Studentbalance,State=@State  where StudentCardno=@StudentCardno";
            //接受查询结果
            int Relust = sqlHelper.ExecuteNonQuery(sql,sqlParms,CommandType.Text);
            return Relust;//返回结果
        }
    }
}
