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
    /// 查询充值记录数据层
    /// </summary>
    public class SelectRechargeDAL : SelectRechargeIDAL
    {
        //实例化一个SQHelp层，用于连接数据库进行查询。
        SQLHelper sqlHelper = new SQLHelper();
        /// <summary>
        /// 查询充值记录
        /// </summary>
        /// <param name="recharge">充值实体</param>
        /// <returns>整个充值记录表信息</returns>
        public DataTable SelectRecharge(Recharge recharge)
        {
            //定义参数
            SqlParameter[] sqlpams = {new SqlParameter("@StudentCardno", recharge.StudentCardno) };
            //定义SQL语句
            string sql = @"select * from Recharge where StudentCardno=@StudentCardno";
            //接受查询返回值
            DataTable RechargeTable = sqlHelper.ExecuteQuery(sql,sqlpams,CommandType.Text);
            return RechargeTable;//返回查询结果
        }
    }
}
