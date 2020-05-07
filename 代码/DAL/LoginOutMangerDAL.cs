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
    /// 管理退出
    /// </summary>
    public class LoginOutMangerDAL : LoginOutMangerIDAL
    {

        //实例化一个SQHelp层，用于连接数据库进行查询。
        SQLHelper sqlHelper = new SQLHelper();
        /// <summary>
        /// 删除正在值班的管理者
        /// </summary>
        /// <param name="OnWork">值班管理者实体</param>
        /// <returns>受影响行数</returns>
        public int DeleteOnWork(UserOnWork OnWork)
        {
            //定义参数
            SqlParameter[] sqlparams = { new SqlParameter("@ManID", OnWork.ManId) };
            //定义SQL语句
            string sql = @"delete OnWorkMan where ManID=@ManID";
            //接受受影响行数
            int Relust = sqlHelper.ExecuteNonQuery(sql,sqlparams,CommandType.Text);
            return Relust;//返回受影响行数
        }
        /// <summary>
        /// 向操作员工作记录插入信息
        /// </summary>
        /// <param name="OpertionWork">操作员工作记录实体</param>
        /// <returns>受影响行数</returns>
        public int InertOpertionWork(OpertionWork OpertionWork)
        {
            //定义参数
            SqlParameter[] sqlparams = { new SqlParameter("@ManID", OpertionWork.ManId),
                                        new SqlParameter("@ManLevel",OpertionWork.Level),
                                        new SqlParameter("@ManName",OpertionWork.Name),
                                        new SqlParameter("@OnDate",OpertionWork.Ondate),
                                        new SqlParameter("@OnTime",OpertionWork.OnTime),
                                        new SqlParameter("@UpDate",OpertionWork.Update),
                                        new SqlParameter("@UpTime",OpertionWork.UPTime),
                                        new SqlParameter("@Computer",OpertionWork.Computer) };
            //定义SQL语句
            string sql = @"insert into OpertionWork values(@ManID,@ManLevel,@ManName,@OnDate,@OnTime,@UpDate,@UpTime,@Computer)";
            //接受受影响行数
            int Relust = sqlHelper.ExecuteNonQuery(sql,sqlparams,CommandType.Text);
            return Relust;//返回受影响的行数

        }
        /// <summary>
        /// 查询正在值班管理者信息
        /// </summary>
        /// <param name="OnWork">正在值班管理实体</param>
        /// <returns>整个值班表信息</returns>
        public DataTable SelectOnWork(UserOnWork OnWork)
        {
            //定义参数
            SqlParameter[] sqlparams = { new SqlParameter("@ManID", OnWork.ManId) };
            //定义SQL语句
            string sql = @"select * from OnWorkMan where ManID=@ManID";
            //把查询结果储存到临时表
            DataTable OnWorkTable = sqlHelper.ExecuteQuery(sql, sqlparams, CommandType.Text);
            //返回整个表的信息
            return OnWorkTable;
        }
    }
}
