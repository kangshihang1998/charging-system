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
    /// 充值数据层
    /// </summary>
    public class RechargeDAL : RechargeIDAL
    {

        //实例化一个SQHelp层，用于连接数据库进行查询。
        SQLHelper sqlHelper = new SQLHelper();
        /// <summary>
        /// 向充值表插入信息
        /// </summary>
        /// <param name="recharge">充值实体</param>
        /// <returns>返回受影响行数</returns>
        public int InsertRecharge(Recharge recharge)
        {
            //定义参数
            SqlParameter[] sqlams = {new SqlParameter("@StudentCardno",recharge.StudentCardno),
                                     new SqlParameter("@RechargeCash",recharge.RechargeCash),
                                     new SqlParameter("@RechargeDate",recharge.RechargeDate),
                                     new SqlParameter("@RechargeTime",recharge.RechargeTime),
                                     new SqlParameter("@OpertionID",recharge.OpertionID),
                                     new SqlParameter("@State",recharge.State)};
            //定义SQL语句
            string sql = @"insert into Recharge values(@StudentCardno,@RechargeCash,@RechargeDate,@RechargeTime,@OpertionID,@State)";
            //执行SQL语句
            int Relust = sqlHelper.ExecuteNonQuery(sql,sqlams,CommandType.Text);
            return Relust;//返回受影响行数
        }
        /// <summary>
        /// 查询基础表
        /// </summary>
        /// <returns>整个基础表信息</returns>
        public DataTable SelectBast()
        {
            //定义SQL语句
            string sql = @"select * from Basis";
            //接受返回值
            DataTable SelectBast = sqlHelper.ExecuteQuery(sql,CommandType.Text);
            return SelectBast;//返回结果
        }

        /// <summary>
        /// 查询卡号是否存在
        /// </summary>
        /// <param name="StudentCardno">卡号实体</param>
        /// <returns>整个卡号信息表</returns>
        public DataTable SelectStudentCardno(RegistrationCardno StudentCardno)
        {
            //定义参数
            SqlParameter[] sqlams = {new SqlParameter("@StudentCardno",StudentCardno.StudentCardno)};
            //定义SQL语句
            string sql = @"select * from RegistrationCardno where StudentCardno=@StudentCardno";
            //执行SQL语句
            DataTable RegistraTable = sqlHelper.ExecuteQuery(sql,sqlams,CommandType.Text);
            return RegistraTable;//返回查询结果
        }
        /// <summary>
        /// 更新卡号余额
        /// </summary>
        /// <param name="StudentCash">卡号余额</param>
        /// <returns>受影响行数</returns>
        public int UpdateCardnoCash(RegistrationCardno StudentCash)
        {
            //定义参数
            SqlParameter[] sqlams = {new SqlParameter("@StudentCardno",StudentCash.StudentCardno),
                                    new SqlParameter("@Studentbalance",StudentCash.Studentbalance)};
            //定义SQL语句
            string sql = @"update RegistrationCardno set Studentbalance=@Studentbalance where StudentCardno=@StudentCardno";
            //执行SQL语句
            int Relust = sqlHelper.ExecuteNonQuery(sql, sqlams, CommandType.Text);
            return Relust;//返回受影响行数
        }
    }
}
