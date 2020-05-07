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
    /// 激活卡号数据层
    /// </summary>
    public class ActivateCardDAL : ActivateCardIDAL
    {
        //实例化一个SQHelp层，用于连接数据库进行查询。
        SQLHelper sqlHelper = new SQLHelper();
        /// <summary>
        /// 查询卡号信息
        /// </summary>
        /// <param name="registarCardno">卡号实体</param>
        /// <returns>卡号信息：以DataTable形式返回</returns>
        public DataTable SelectRegistartCardnoInfo(RegistrationCardno registarCardno)
        {
            //定义参数
            SqlParameter[] sqlpams = {new SqlParameter("@StudentCardno", registarCardno.StudentCardno)};
            //定义SQL语句
            string sql = @"select * from RegistrationCardno where StudentCardno=@StudentCardno";
           DataTable CardnoInfoTable = sqlHelper.ExecuteQuery(sql,sqlpams,CommandType.Text);//接受查询结果
            return CardnoInfoTable;//返回查询结果
        }
        /// <summary>
        /// 更新卡号状态
        /// </summary>
        /// <param name="registarCardno">卡号实体</param>
        /// <returns> 受影响行数</returns>
        public int UpdateCardnoState(RegistrationCardno registarCardno)
        {
            //定义参数
            SqlParameter[] sqlpams = { new SqlParameter("@StudentCardno", registarCardno.StudentCardno),
                                       new SqlParameter("@State",registarCardno.State)};
            //定义SQL语句
            string sql = @" update RegistrationCardno set State=@State where StudentCardno=@StudentCardno";
            int Relust = sqlHelper.ExecuteNonQuery(sql,sqlpams,CommandType.Text);//受影响行数
            return Relust;//返回受影响行数
        }
    }
}
