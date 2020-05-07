
/*
 * 创建人：康世行
 * 创建时间： 2020-4-27 16:23:02
 * 说明：学生上机状态查询数据类
 * 版权所有：康世行
 */
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
    /// 学生上机状态查询数据类
    /// </summary>
    public class StudentOnLineStateDAL : StudentOnLineStateIDAL
    {
        //实例化一个SQHelp层，用于连接数据库进行查询。
        SQLHelper sqlHelper = new SQLHelper();
        /// <summary>
        /// 查询学生上机状态
        /// </summary>
        /// <param name="StuCardno">正在上机实体</param>
        /// <returns></returns>
        public DataTable StudnetOnLineState(StudentOnLine StuCardno)
        {
            //定义参数
            SqlParameter[] sqlparms = { new SqlParameter("@StudentCardno", StuCardno.StudentCardno) };
            //定义SQL语句
            string sql = @"select * from OnLineStudent  where StudentCardno=@StudentCardno";
            //接受查询结果
            DataTable SelectOnleDatable = sqlHelper.ExecuteQuery(sql,sqlparms,CommandType.Text);
            return SelectOnleDatable;
        }
    }
}
