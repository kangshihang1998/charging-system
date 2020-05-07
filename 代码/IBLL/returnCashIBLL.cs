using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
namespace IBLL
{
    /// <summary>
    /// 金额返还查询业务层接口
    /// </summary>
   public interface returnCashIBLL
    {
        /// <summary>
        /// 金额返还查询
        /// </summary>
        /// <param name="statDate">开始日期</param>
        /// <param name="EndDat">结束日期</param>
        /// <param name="StrMsg">返回是否有数据的提醒</param>
        /// <returns>返回退卡表的信息</returns>
        DataTable SelectCardnoCash(string statDate,string EndDat,ref String StrMsg);
    }
}
