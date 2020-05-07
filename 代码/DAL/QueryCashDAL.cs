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
    /// 查询余额数据层
    /// </summary>
    public class QueryCashDAL : QueryCashIDAL
    {
        //实例化一个SQHelp层，用于连接数据库进行查询。
        SQLHelper sqlHelper = new SQLHelper();
        /// <summary>
        /// 查询余额
        /// </summary>
        /// <param name="regiCardnoCash">余额</param>
        /// <returns>卡号信息</returns>
        public DataTable SelectCash(RegistrationCardno regiCardnoCash)
        {
            //定义参数
            SqlParameter[] sqlams = {new SqlParameter("@StudentCardno", regiCardnoCash.StudentCardno)};
            //定义SQL语句
            string sql = @"select Studentbalance from RegistrationCardno where StudentCardno=@StudentCardno";
            //获取查询结果
            DataTable SelectCash = sqlHelper.ExecuteQuery(sql,sqlams,CommandType.Text);
            return SelectCash;//返回查询结果
        }
    }
}
