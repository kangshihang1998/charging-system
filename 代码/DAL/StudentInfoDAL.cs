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
/// 学生信息数据访问层
/// </summary>
 public   class StudentInfoDAL:StudentInfoIDAL
    {
        //实例化一个SQHelp层，用于连接数据库进行查询。
        SQLHelper sqlHelper = new SQLHelper();
        /// <summary>
        /// 查询学生信息
        /// </summary>
        /// <param name="studentInfo">学生信息实体</param>
        /// <returns></returns>
        public DataTable SelectStudentInfo(StudentInfo studentInfo)
        {
            //定义参数
            SqlParameter[] sqlparms = { new SqlParameter("@StudentCardno",studentInfo.StudentCardno) };
            //定义SQL语句
            string sql = @"select * from StudentInfo  where StudentCardno=@StudentCardno";
            //接受查询结果
            DataTable StudentInfoTable = sqlHelper.ExecuteQuery(sql,sqlparms,CommandType.Text);
            return StudentInfoTable;//返回结果
        }
    }
}
