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
    /// 上机记录数据层
    /// </summary>
    public class LineStudentDAL : LineStudentIDAL
    {
        //实例化一个SQHelp层，用于连接数据库进行查询。
        SQLHelper sqlHelper = new SQLHelper();
        /// <summary>
        /// 查询学生上机记录
        /// </summary>
        /// <param name="studentline">学生卡号</param>
        /// <returns>此学生全部的上机记录信息</returns>
        public DataTable SelectLineStudent(StudentLien studentline)
        {
            //定义参数
            SqlParameter[] sqlparms ={new SqlParameter("@StudentCardno", studentline.StudentCardno) };
            //定义SQL语句
            string sql = @"select * from LineStudent where StudentCardno=@StudentCardno";
            //接受返回值
            DataTable LineTable = sqlHelper.ExecuteQuery(sql,sqlparms,CommandType.Text);
            return LineTable;//返回查询结果
        }
    }
}
