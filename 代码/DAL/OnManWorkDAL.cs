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
    /// 正在值班教师数据层
    /// </summary>
    public class OnManWorkDAL : OnManWorkIDAL
    {
        //实例化一个SQHelp层，用于连接数据库进行查询。
        SQLHelper sqlHelper = new SQLHelper();
        /// <summary>
        /// 查询正在值班教师
        /// </summary>
        /// <param name="userOnWork">管理者正在工作实体</param>
        /// <returns>正在值班管理信息</returns>
        public DataTable SelectOnManWork(UserOnWork userOnWork)
        {
            //定义参数
            SqlParameter[] sqlpams = {new SqlParameter("@ManLevel", userOnWork.Level)};
            //定义查询参数
            string sql = @"select ManID, ManLevel,OpertionName from OnWorkMan where ManLevel=@ManLevel";
            //接受查询返回值
            DataTable SelectOnWorkTable = sqlHelper.ExecuteQuery(sql,sqlpams,CommandType.Text);
            return SelectOnWorkTable;
        }
    }
}
