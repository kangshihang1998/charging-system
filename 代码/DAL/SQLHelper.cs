using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enitity;
using IDAL;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace DAL
{
    /// <summary>
    /// 操作查询类---数据访问层
    /// </summary>
  public  class SQLHelper
    {
        //定义数据库连接操作，指定在数控上的操作类型。
        //定义数据库读取操作
        private SqlConnection conn = null;//连接
        private SqlCommand cmd = null;//命令
        private SqlDataReader sdr = null;//数据集
         
         /// <summary>
         /// 数据库连接,初始化类的时候链接数据库！
        /// </summary>
        public SQLHelper()
        {
            //通过配置文件，获取数据库的账号密码
            string connStr = ConfigurationManager.AppSettings["connStr"];
            conn = new SqlConnection(connStr);//链接数据
        }
        /// <summary>
        /// 判断数据库状态
        /// </summary>
        /// <returns>是否打开</returns>
        private SqlConnection GetConn()
        {
            //判断状态是否为空打开状态
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();//打开
            }//end if
            return conn;
        }
        /// <summary>
        /// 执行不带参数的数据库操作或储存过程
        /// </summary>
        /// <param name="cmdText">增删改操作</param>
        /// <param name="ct">命令类型</param>
        /// <returns>返回受影响的行数</returns>
        public int ExecuteNonQuery(string cmdText, CommandType ct)
        {
            //受影响的行数
            int res;
            //执行SQL命令
            cmd = new SqlCommand(cmdText, GetConn());
            //命令的类型
            cmd.CommandType = ct;
            //受影响的行数
            res = cmd.ExecuteNonQuery();
            //使用完之后释放连接
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            return res;
        }
        /// <summary>
        /// 执行带参数的数据库操作或储存过程
        /// </summary>
        /// <param name="cmdText">增删改操作</param>
        /// <param name="ct">命令类型</param>
        /// <returns>返回受影响的行数</returns>
        public int ExecuteNonQuery(string cmdText, SqlParameter[] paras, CommandType ct)
        {
            int res;
            using (cmd = new SqlCommand(cmdText, GetConn()))
            {
                cmd.CommandType = ct;
                cmd.Parameters.AddRange(paras);
                res = cmd.ExecuteNonQuery();
            }
            return res;
        }
        /// <summary>
        /// 执行不带参数的SQL查询语句或储存过程
        /// </summary>
        /// <param name="cmdText">查询sql语句或储存过程</param>
        /// <param name="ct">命令类型</param>
        /// <returns>返回受影响行数</returns>
        public DataTable ExecuteQuery(string cmdText, CommandType ct)
        {
            //存储读取到的内容
            DataTable dt = new DataTable();
            cmd = new SqlCommand(cmdText, GetConn());
            cmd.CommandType = ct;
            //
            using (sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
            {
                dt.Load(sdr);//向DataTable填充值
            }
            return dt;//把表里的内容返回给本方法
        }
        /// <summary>
        /// 执行带参数的sql语句查询或储存过程
        /// </summary>
        /// <param name="cmdText">查询SQL语句或储存过程</param>
        /// <param name="paras">参数集合</param>
        /// <param name="ct">命令类型</param>
        /// <returns>返回受影响的行数</returns>
        public DataTable ExecuteQuery(string cmdText, SqlParameter[] paras, CommandType ct)
        {
            DataTable dt = new DataTable();
            cmd = new SqlCommand(cmdText, GetConn());
            cmd.CommandType = ct;
            cmd.Parameters.AddRange(paras);
            using (sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
            {
                dt.Load(sdr);
            }

            return dt;
        }

    }
}
