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
    /// 查询充值记录数据层接口
    /// </summary>
 public   interface SelectRechargeIDAL
    {
        /// <summary>
        /// 查询充值记录
        /// </summary>
        /// <param name="recharge">充值实体</param>
        /// <returns>整个充值记录表信息</returns>
        DataTable SelectRecharge(Recharge recharge);
    }
}
