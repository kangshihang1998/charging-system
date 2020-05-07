
/*
 * 创建人：康世行
 * 创建时间：2020-4-28 17:00:25
 * 说明：组合查询数据类
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
    /// 组合查询数据类
    /// </summary>
    public class GroupQuerDAL : GroupQuerIDAL
    {
        //实例化一个SQHelp层，用于连接数据库进行查询。
        SQLHelper sqlHelper = new SQLHelper();
        /// <summary>
        /// 组合查询方法
        /// </summary>
        /// <param name="dic">条件</param>
        /// <returns>查询内容</returns>
        public DataTable SelectGroupQuer(GroupQuery gropuQuery)
        {
            DataTable dt = new DataTable();
            string sql = "PROC_GroupCheck";//存储过程  
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter ("@comboFields1",gropuQuery.Field1),
                new SqlParameter ("@comboFields2", gropuQuery.Field2),
                new SqlParameter ("@comboFields3", gropuQuery.Field3),
                new SqlParameter ("@comboOperators1", gropuQuery.Operator1  ),
                new SqlParameter ("@comboOperators2", gropuQuery.Operator2),
                new SqlParameter ("@comboOperators3", gropuQuery.Operator3  ),
                new SqlParameter ("@textBox1",gropuQuery.Content1),
                new SqlParameter ("@textBox2", gropuQuery.Content2),
                new SqlParameter ("@textBox3", gropuQuery.Content3),
                new SqlParameter ("@comboCheck1", gropuQuery.Relation1),
                new SqlParameter ("@comboCheck2", gropuQuery.Relation2  ),
                new SqlParameter("@DbName",gropuQuery.DbName)
            };
            dt = sqlHelper.ExecuteQuery(sql, paras, CommandType.StoredProcedure);

            return dt;  
 
        }
    }
}
