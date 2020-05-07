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
    /// 金额返还数据层接口
    /// </summary>
  public  interface returnCashIDAL
    {
        /// <summary>
        /// 查询退卡表信息
        /// </summary>
        /// <param name="StartTime">开始时间</param>
        /// <param name="EndTime">结束时间</param>
        /// <returns>以表的形式返回，退卡表里的信息</returns>
        DataTable SelectCancelCardInfo(string StartTime,string EndTime);
    }
}
