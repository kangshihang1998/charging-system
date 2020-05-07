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
    /// 金额返还业务层
    /// </summary>
    public class returnCashBLL : returnCashIBLL
    {
        /// <summary>
        /// 实例化工厂，用于创建D登录查询类。
        /// </summary>
        FactoryDAl fact = new FactoryDAl();
        /// <summary>
        /// 金额返还查询
        /// </summary>
        /// <param name="statDate">开始日期</param>
        /// <param name="EndDat">结束日期</param>
        /// <param name="StrMsg">返回是否有数据的提醒</param>
        /// <returns>返回退卡表的信息</returns>
        public DataTable SelectCardnoCash(string statDate, string EndDat, ref string StrMsg)
        {
            //判断开始日期是否小于终止日期
            DataTable retCashTable=new DataTable();
            if (DateTime.Parse( statDate)<=DateTime.Parse(EndDat))
            {
                //判断起始日期是否大于当前日期
                if (DateTime.Parse(statDate) > DateTime.Now.Date)
                {
                    StrMsg = "起始日期不能大于当前日期！";
                }
                else
                {
                    //判断终止日期是否大于当前日期
                    if (DateTime.Parse(EndDat)>DateTime.Now.Date)
                    {
                        StrMsg = "终止日期不得大于当前日期！";
                    }
                    else
                    {
                        returnCashIDAL retuCashIDAl = (returnCashIDAL)fact.CreateUser("returnCashDAL");
                        //转换日期格式
                        DateTime StartDate = DateTime.Parse(statDate);
                        DateTime EndDate = DateTime.Parse(EndDat);
                        //调用查询返还金额记录方法，获取具体内容。
                         retCashTable = retuCashIDAl.SelectCancelCardInfo(StartDate.ToString(),EndDate.ToString());
                        //判断是否有记录
                        if (retCashTable.Rows.Count != 0)//说明有数据
                        {
                            StrMsg = "查询完毕";
                        }
                        else
                        {
                            StrMsg = "此时间段内没有数据！";
                        }
                    }
                }
            }
            else
            {
                StrMsg = "起始日期不得大于终止日期！";
            }
            return retCashTable;//返回表的信息
        }
    }
}
