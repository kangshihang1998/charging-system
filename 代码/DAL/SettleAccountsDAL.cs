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
    /// 结账数据层
    /// </summary>
    public class SettleAccountsDAL : SettleAccountsIDAL
    {
        //实例化一个SQHelp层，用于连接数据库进行查询。
        SQLHelper sqlHelper = new SQLHelper();
        /// <summary>
        /// 向报表插入内容
        /// </summary>
        /// <param name="rechck">报表实体</param>
        /// <returns>受影响行数</returns>
        public int InsertRecheck(Recheck rechck)
        {
            //定义参数
            SqlParameter[] sqlpams = {new SqlParameter("@SallCash",rechck.SallCash),
                                     new SqlParameter("@RechargeCash",rechck.RechargeCash),
                                    new SqlParameter("@CanCash",rechck.CanCash),
                                    new SqlParameter("@currentincome",rechck.Currentincome),
                                    new SqlParameter("@Opertion",rechck.Opertion),
                                    new SqlParameter("@CheckDate",rechck.CheckDate)};
            //定义SQL语句
            string sql = @"insert into Recheck values(@SallCash,@RechargeCash,@CanCash,@currentincome,@Opertion,@CheckDate)";
            int Relust = sqlHelper.ExecuteNonQuery(sql,sqlpams,CommandType.Text);
            return Relust;
        }
        /// <summary>
        /// 查询退卡记录
        /// </summary>
        /// <param name="cancecard">退卡实体</param>
        /// <returns></returns>
        public DataTable SelectCancelCard(CanceCard cancecard)
        {
            //定义参数
            SqlParameter[] sqlpams = {new SqlParameter("@OperationID", cancecard.OperationID),
                                     new SqlParameter("@State",cancecard.State)};
            //定义SQL语句
            string sql = @"select * from CancelCard where OperationID=@OperationID and State=@State";
            //接受查询的返回值
            DataTable SelectCancelCardnTable = sqlHelper.ExecuteQuery(sql,sqlpams,CommandType.Text);
            return SelectCancelCardnTable;
        }
        /// <summary>
        /// 查询操作员信息
        /// </summary>
        /// <param name="managerial"></param>
        /// <returns></returns>
        public DataTable SelectManagerial(Managerial managerial)
        {
            //定义参数
            SqlParameter[] sqlpams = { new SqlParameter("@Level",managerial.Level)};
            //定义SQL语句
            string sql = @"select * from Managerial where Level=@Level";
            //接受查询的返回值
            DataTable SelectManagerialTable = sqlHelper.ExecuteQuery(sql, sqlpams, CommandType.Text);
            return SelectManagerialTable;
        }
        /// <summary>
        /// 查询充值记录
        /// </summary>
        /// <param name="recharge">充值记录实体</param>
        /// <returns></returns>
        public DataTable SelectRecharge(Recharge recharge)
        {
            //定义参数
            SqlParameter[] sqlpams = {new SqlParameter("@OPertonID",recharge.OpertionID),
                                     new SqlParameter("@State",recharge.State)};
            //定义SQL语句
            string sql = @"select * from Recharge where OPertonID=@OPertonID and State=@State";
            //接受查询的返回值
            DataTable SelectRechargeTable = sqlHelper.ExecuteQuery(sql, sqlpams, CommandType.Text);
            return SelectRechargeTable;
        }
        /// <summary>
        /// 卡号信息查询
        /// </summary>
        /// <param name="registration">注册卡号实体</param>
        /// <returns></returns>
        public DataTable SelectRegistrationCardno(RegistrationCardno registration)
        {
            //定义参数
            SqlParameter[] sqlpams = {new SqlParameter("@OpertionID",registration.OpertionID),
                                     new SqlParameter("@AccountsState",registration.AccountsState)};
            //定义SQL语句
            string sql = @"select * from RegistrationCardno where OpertionID=@OpertionID and AccountsState=@AccountsState";
            //接受查询的返回值
            DataTable SelectRegistrationCardnoTable = sqlHelper.ExecuteQuery(sql, sqlpams, CommandType.Text);
            return SelectRegistrationCardnoTable;
        }
        /// <summary>
        /// 更新退卡的结账状态
        /// </summary>
        /// <param name="cancecard">退卡表实体</param>
        /// <returns>受影响行数</returns>
        public int UpdateCancelCard(CanceCard cancecard)
        {
            //定义参数
            SqlParameter[] sqlpams = {new SqlParameter("@OperationID",cancecard.OperationID),
                                     new SqlParameter("@State",cancecard.State)};
             
            //定义查询参数
            string sql = @"update CancelCard set State=@State where OperationID=@OperationID and State='未结账'";
            //接受受影响行数
            int Relust = sqlHelper.ExecuteNonQuery(sql,sqlpams,CommandType.Text);
            return Relust;
        }
        /// <summary>
        /// 更新充值表结账状态
        /// </summary>
        /// <param name="recharge">充值表实体</param>
        /// <returns>受影响行数</returns>
        public int UpdateRecharge(Recharge recharge)
        {
            //定义参数
            SqlParameter[] sqlpams = {new SqlParameter("@OPertonID",recharge.OpertionID),
                                     new SqlParameter("@State",recharge.State)};
            //定义查询参数
            string sql = @"update Recharge set State=@State where OPertonID=@OPertonID and State='未结账'";
            //接受受影响行数
            int Relust = sqlHelper.ExecuteNonQuery(sql, sqlpams, CommandType.Text);
            return Relust;
        }
        /// <summary>
        /// 更新卡号表结账状态
        /// </summary>
        /// <param name="registration">注册表实体</param>
        /// <returns>受影响行数</returns>
        public int UpdateRegistrationCardno(RegistrationCardno registration)
        {
            //定义参数
            SqlParameter[] sqlpams = {new SqlParameter("@OpertionID",registration.OpertionID),
                                     new SqlParameter("@AccountsState",registration.AccountsState)};
            //定义查询参数
            string sql = @"update RegistrationCardno set AccountsState=@AccountsState where OpertionID=@OpertionID and AccountsState='未结账'";
            //接受受影响行数
            int Relust = sqlHelper.ExecuteNonQuery(sql, sqlpams, CommandType.Text);
            return Relust;
        }
    }
}
