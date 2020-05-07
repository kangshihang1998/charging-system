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
    /// 基础数据设定数据层
    /// </summary>
    public class BasitDateDAL : BasitDateIDAL
    {
        //实例化一个SQHelp层，用于连接数据库进行查询。
        SQLHelper sqlHelper = new SQLHelper();

        /// <summary>
        /// 删除基础表数据
        /// </summary>
        /// <returns>受影响行数</returns>
        public int DeleteBasiInfo()
        {
            //定义SQL语句
            string sql = @"delete Basis";
            //接受受影响行数
            int Relust = sqlHelper.ExecuteNonQuery(sql,CommandType.Text);
            return Relust;
        }
        /// <summary>
        /// 向基础表插入信息
        /// </summary>
        /// <param name="basit">基础表实体</param>
        /// <returns>受影响行数</returns>
        public int InsertBasitInfo(Basis basit)
        {
            //定义参数
            SqlParameter[] sqlpams = { new SqlParameter("@LimtOnCash",basit.LimtOnCash)
                                      ,new SqlParameter("@LimtReCash",basit.LimtReCash)
                                      ,new SqlParameter("@OnpreTime",basit.OnpreTime)
                                      ,new SqlParameter("@FixUser",basit.FixUser)
                                      ,new SqlParameter("@TemUser",basit.TemUser)
                                      ,new SqlParameter("@chargeuni",basit.Chargeuni)
                                      ,new SqlParameter("@Admin",basit.Admin)
                                      ,new SqlParameter("@Date",basit.Date)
                                      ,new SqlParameter("@Time",basit.Time)};
            //定义SQL语句
            string sql = @"insert into Basis values(@LimtOnCash,@LimtReCash,@OnpreTime,@FixUser,@TemUser,@chargeuni,@Admin,@Date,@Time)";
            //接受受影响行数
            int Relust = sqlHelper.ExecuteNonQuery(sql,sqlpams,CommandType.Text);
            return Relust;
        }
        /// <summary>
        /// 查询基础数据信息
        /// </summary>
        /// <returns></returns>
        public DataTable SelectBasitInfo()
        {
            //定义SQL语句
            string sql = @"select * from Basis";
            //接受查询结果
            DataTable SelectBasitTable = sqlHelper.ExecuteQuery(sql,CommandType.Text);
            return SelectBasitTable;
        }
    }
}
