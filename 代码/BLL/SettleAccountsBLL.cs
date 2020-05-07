using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enitity;
using Factory;
using IDAL;
using IBLL;
using System.Data;
using System.Reflection;
using System.Configuration;
using System.Windows.Forms;
namespace BLL
{
    /// <summary>
    /// 结账业务层
    /// </summary>
    public class SettleAccountsBLL : SettleAccountsIBLL
    {
        /// <summary>
        /// 实例化工厂，用于创建D登录查询类。
        /// </summary>
        FactoryDAl fact = new FactoryDAl();
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
        public string InsertRecheck(string SellCash, string CanCash, string RecCAsh, string NowCash, string Opertion, string Date, Form form,string admin)
        {
            string Strms="";
            string isnull = IsNull.isNull(form);//判断文本框是否为空
            string isGroupNumber = IsNull.GroupIsNumber(form);
            //判断文本框是否为空
            if (isnull== "") //没有返回值说明不为空
            {
                //判断文本内容是否是数字
                if (isGroupNumber=="")//没有返回值，说明都是数字
                {
                    SettleAccountsIDAL settAccoutIDAL = (SettleAccountsIDAL)fact.CreateUser("SettleAccountsDAL");
                    //转成售卡实体
                    RegistrationCardno regist = new RegistrationCardno();
                    regist.OpertionID = int.Parse(Opertion);
                    regist.AccountsState = "已结账";
                    settAccoutIDAL.UpdateRegistrationCardno(regist);//更新售卡结账状态

                    //转成充值实体
                    Recharge recharge = new Recharge();
                    recharge.OpertionID = int.Parse(Opertion);
                    recharge.State = "已结账";
                    settAccoutIDAL.UpdateRecharge(recharge);//更新充值结账状态

                    //转成退卡实体
                    CanceCard cancardno = new CanceCard();
                    cancardno.OperationID = int.Parse(Opertion);
                    cancardno.State = "已结账";
                    settAccoutIDAL.UpdateCancelCard(cancardno);//更新退卡结账状态

                    //向报表插入信息
                    //转成报表实体
                    Recheck recheck = new Recheck();
                    recheck.SallCash = double.Parse(SellCash);
                    recheck.RechargeCash = double.Parse(RecCAsh);
                    recheck.CanCash = double.Parse(CanCash);
                    recheck.Currentincome = double.Parse(NowCash);
                    recheck.Opertion = int.Parse(admin);
                    recheck.CheckDate = DateTime.Parse(Date);
                    settAccoutIDAL.InsertRecheck(recheck);
                    Strms = "结账成功！";
                }
                else
                {
                    Strms = isGroupNumber;
                }
            }
            else
            {
                Strms = isnull; 
            }
            return Strms;
        }

        /// <summary>
        /// 查询退卡信息
        /// </summary>
        /// <param name="OpertionID">操作员ID</param>
        /// <param name="StrMsg">返回信息提示</param>
        /// <returns></returns>
        public DataTable SelectCanCardno(string OpertionID, out string StrMsg)
        {
            bool IsNumber = IsNull.IsNumber(OpertionID);
            DataTable CanCardnoTable = new DataTable();//返回表信息
            //调用接口和工厂创建DAL层具体类
            SettleAccountsIDAL setteAcounIDAL = (SettleAccountsIDAL)fact.CreateUser("SettleAccountsDAL");
            //判断操作员ID是否为空
            if (OpertionID.Trim() == "")//说明操作员ID为空
            {
                StrMsg = "操作员ID不能为空";
            }
            else
            {
                //判断操作员ID是否是数字
                if (IsNumber == true)//是数字
                {

                    #region 查询退卡信息
                    CanceCard canCardno = new CanceCard();
                    canCardno.OperationID = int.Parse(OpertionID);
                    canCardno.State = "未结账";
                    CanCardnoTable = setteAcounIDAL.SelectCancelCard(canCardno);//获取卡号信息
                    //判断是否有卡号信息
                    if (CanCardnoTable.Rows.Count != 0)
                    {
                        StrMsg = "查询完毕！";
                    }
                    else
                    {
                        StrMsg = "暂时没有退卡信息！";
                    }

                    #endregion
                }
                else
                {
                    StrMsg = "操作员ID必须输入数字，请从新输入！";
                }


            }
            return CanCardnoTable;//返回表里内容
        }

        /// <summary>
        /// 查询卡号信息记录
        /// </summary>
        /// <param name="OpertionID">操作员ID</param>
        /// <param name="Sate">结账状态</param>
        /// <returns></returns>
        public DataTable SelectCardnoInfo(string OpertionID,out string StrMsg)
        {
            bool IsNumber = IsNull.IsNumber(OpertionID);
            DataTable CardnoTable = new DataTable();//返回表信息
            //调用接口和工厂创建DAL层具体类
            SettleAccountsIDAL setteAcounIDAL = (SettleAccountsIDAL)fact.CreateUser("SettleAccountsDAL");
            //判断操作员ID是否为空
            if (OpertionID.Trim()=="")//说明操作员ID为空
            {
                StrMsg = "操作员ID不能为空";
            }
            else
            {
                //判断操作员ID是否是数字
                if (IsNumber==true)//是数字
                {

                    #region 查询卡号信息
                    RegistrationCardno registarCardno = new RegistrationCardno();
                    registarCardno.OpertionID = int.Parse(OpertionID);
                    registarCardno.AccountsState = "未结账";
                     CardnoTable = setteAcounIDAL.SelectRegistrationCardno(registarCardno);//获取卡号信息
                    //判断是否有卡号信息
                    if (CardnoTable.Rows.Count!=0)
                    {
                        StrMsg = "查询完毕！";
                    }
                    else
                    {
                        StrMsg = "暂时没有卡号信息！";
                    }
                    
                    #endregion     
                }
                else
                {
                    StrMsg = "操作员ID必须输入数字，请从新输入！";
                }
               

            }
            return CardnoTable;//返回表里内容
        }

        /// <summary>
        /// 查询操作员信息
        /// </summary>
        /// <param name="OperLevel">操作员</param>
        /// <returns></returns>
        public DataTable SelectOpertionInfo(string OperLevel, out string StrMsg)
        {
            DataTable OpertionTable = new DataTable();//返回表信息
            //调用接口和工厂创建DAL层具体类
            SettleAccountsIDAL setteAcounIDAL = (SettleAccountsIDAL)fact.CreateUser("SettleAccountsDAL");
            Managerial manger = new Managerial();//管理者实体
            manger.Level = OperLevel;
            OpertionTable = setteAcounIDAL.SelectManagerial(manger);//获取操作员信息
            //判断是否有操作员
            if (OpertionTable.Rows.Count!=0)
            {
                StrMsg = "查询完毕！";
            }
            else
            {
                StrMsg = "没有可查询的操作员！";
            }
            return OpertionTable;
        }
        /// <summary>
        /// 查询充值记录
        /// </summary>
        /// <param name="OpertionID">操作员ID</param>
        /// <param name="StrMsg">返回的提示信息</param>
        /// <returns></returns>
        public DataTable SelectRegchr(string OpertionID, out string StrMsg)
        {
            bool IsNumber = IsNull.IsNumber(OpertionID);
            DataTable RegCardnoTable = new DataTable();//返回表信息
            //调用接口和工厂创建DAL层具体类
            SettleAccountsIDAL setteAcounIDAL = (SettleAccountsIDAL)fact.CreateUser("SettleAccountsDAL");
            //判断操作员ID是否为空
            if (OpertionID.Trim() == "")//说明操作员ID为空
            {
                StrMsg = "操作员ID不能为空";
            }
            else
            {
                //判断操作员ID是否是数字
                if (IsNumber == true)//是数字
                {

                    #region 查询退卡信息
                     Recharge  RegCardno = new Recharge();
                     RegCardno.OpertionID = int.Parse(OpertionID);
                     RegCardno.State = "未结账";
                    RegCardnoTable = setteAcounIDAL.SelectRecharge(RegCardno);//获取卡号信息
                    //判断是否有充值信息
                    if (RegCardnoTable.Rows.Count != 0)
                    {
                        StrMsg = "查询完毕！";
                    }
                    else
                    {
                        StrMsg = "暂时没有充值信息！";
                    }

                    #endregion
                }
                else
                {
                    StrMsg = "操作员ID必须输入数字，请从新输入！";
                }


            }
            return RegCardnoTable;//返回表里内容
        }
    }
}
