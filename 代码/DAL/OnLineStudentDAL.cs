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
    /// 正在上机学生数据层
    /// </summary>
    public class OnLineStudentDAL : OnLineStudentIDAL
    {
        //实例化一个SQHelp层，用于连接数据库进行查询。
        SQLHelper sqlHelper = new SQLHelper();
        /// <summary>
        /// 查询正在上机学生
        /// </summary>
        /// <param name="studentOnline">正在上机实体</param>
        /// <returns>以表形式返回</returns>
        public DataTable SelectOnlineStuent()
        {
            //定义查询语句
            string sql = @"select * from OnLineStudent";
            //接受查询返回值
            DataTable SelectOnlineStudnet = sqlHelper.ExecuteQuery(sql,CommandType.Text);
            return SelectOnlineStudnet;
        }
        /// <summary>
        /// 获取正在上机的学生姓名
        /// </summary>
        /// <param name="studentName">学生信息实体</param>
        /// <returns>学生姓名，以表形式返回。</returns>
        public DataTable SelectStudentName(StudentInfo studentName)
        {
            //定义参数 
            SqlParameter[] sqlpams = {new SqlParameter("@StudentCardno", studentName.StudentCardno)};
            //定义sql语句
            string sql = @"select Name from StudentInfo where StudentCardno=@StudentCardno";
            //获取查询结果
            DataTable StudentNameTable = sqlHelper.ExecuteQuery(sql,sqlpams,CommandType.Text);
            return StudentNameTable;
        }
    }
}
