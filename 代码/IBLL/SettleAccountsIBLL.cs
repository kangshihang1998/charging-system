using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
namespace IBLL
{
    /// <summary>
    /// 结账业务层接口
    /// </summary>
  public  interface SettleAccountsIBLL
    {
        /// <summary>
        /// 查询操作员信息
        /// </summary>
        /// <param name="OperLevel">操作员</param>
        /// <returns></returns>
        DataTable SelectOpertionInfo(string OperLevel,out string StrMsg);
        /// <summary>
        /// 查询卡号信息记录
        /// </summary>
        /// <param name="OpertionID">操作员ID</param>
        /// <param name="Sate">结账状态</param>
        /// <param name="StrMsg">返回提示信息</param>
        /// <returns></returns>
        DataTable SelectCardnoInfo(string OpertionID,out string StrMsg);
        /// <summary>
        /// 查询退卡信息
        /// </summary>
        /// <param name="OpertionID">操作员ID</param>
        /// <param name="StrMsg">返回信息提示</param>
        /// <returns></returns>
        DataTable SelectCanCardno(string OpertionID, out string StrMsg);
        /// <summary>
        /// 查询充值记录
        /// </summary>
        /// <param name="OpertionID">操作员ID</param>
        /// <param name="StrMsg">返回的提示信息</param>
        /// <returns></returns>
        DataTable SelectRegchr(string OpertionID, out string StrMsg);
        /// <summary>
        /// 向报表插入信息
        /// </summary>
        /// <param name="SellCash">售卡金额</param>
        /// <param name="CanCash">退卡金额</param>
        /// <param name="RecCAsh">充值金额</param>
        /// <param name="NowCash">本期金额</param>
        /// <param name="Opertion">操作员</param>
        /// <param name="Date">结账日期</param>
        /// <returns></returns>
        string InsertRecheck(string SellCash,string CanCash,String RecCAsh,string NowCash,string Opertion,string Date,Form form, string admin);
    }
}
