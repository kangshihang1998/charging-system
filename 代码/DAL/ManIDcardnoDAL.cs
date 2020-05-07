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
    /// 查询管理者信息数据层
    /// </summary>
    public class ManIDcardnoDAL : ManIDcardnoIDAL
    {
        //实例化一个SQHelp层，用于连接数据库进行查询。
        SQLHelper sqlHelper = new SQLHelper();
        /// <summary>
        /// 查询管理者信息
        /// </summary>
        /// <param name="manidCardnoInfo">管理者信息实体</param>
        /// <returns>整个管理者信息实体</returns>
        public DataTable SelectManIDCardnoInfo(ManIDcardno manidCardnoInfo)
        {
            //定义查询参数
            SqlParameter[] sqlapms = {new SqlParameter("@ManId", manidCardnoInfo.Manid)};
            //定义SQL语句
            string sql = @"select * from ManIDcardno where ManId=@ManId";
            //接受查询结果
            DataTable ManIDInfoTable = sqlHelper.ExecuteQuery(sql,sqlapms,CommandType.Text);
            return ManIDInfoTable;//返回查询结果
        }
    }
}
