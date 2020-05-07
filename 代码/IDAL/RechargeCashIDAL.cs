using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enitity;
using System.Data;
namespace IDAL
{
    /// <summary>
    /// 收取金额数据层接口
    /// </summary>
 public   interface RechargeCashIDAL
    {
        /// <summary>
        /// 查询充值表信息
        /// </summary>
        /// <param name="StartTime">开始时间</param>
        /// <param name="EndTime">结束时间</param>
        /// <returns>以表的形式返回，充值表里的信息</returns>
        DataTable SelectCancelCardInfo(string StartTime, string EndTime);
    }
}
