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
    /// 激活操作员数据层
    /// </summary>
    public class ActivateOpertionDAL : ActivateOpertionIDAL
    {
        //实例化一个SQHelp层，用于连接数据库进行查询。
        SQLHelper sqlHelper = new SQLHelper();
        /// <summary>
        /// 查询管理者是否存在
        /// </summary>
        /// <param name="manager">管理者实体</param>
        /// <returns></returns>
        public DataTable ActivateManagerial(Managerial manager)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 更新管理者使用状态
        /// </summary>
        /// <param name="manager">管理者实体</param>
        /// <returns>受影响行数</returns>
        public int UpdateManagerial(Managerial manager)
        {
            throw new NotImplementedException();
        }
    }
}
