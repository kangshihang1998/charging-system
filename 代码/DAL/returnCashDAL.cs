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
    /// 金额返回数据层
    /// </summary>
    public class returnCashDAL : returnCashIDAL
    {
        //实例化一个SQHelp层，用于连接数据库进行查询。
        SQLHelper sqlHelper = new SQLHelper();
        /// <summary>
        /// 查询退卡表信息
        /// </summary>
        /// <param name="StartTime">开始日期</param>
        /// <param name="EndTime">结束日期</param>
        /// <returns>以表的形式返回，退卡表里的信息</returns>
        public DataTable SelectCancelCardInfo(string StartTime, string EndTime)
        {
            //定义参数
            SqlParameter[] sqlpams = {new SqlParameter("@StartTime",StartTime),
                                      new SqlParameter("@EndTime",EndTime)};
            //定义SQL语句
            string sql = @"select * from CancelCard where CanDate  between @StartTime and @EndTime";
            //接受查询的返回值
            DataTable SelectCardnInfoTable = sqlHelper.ExecuteQuery(sql,sqlpams,CommandType.Text);
            return SelectCardnInfoTable;
        }  
    }
}
