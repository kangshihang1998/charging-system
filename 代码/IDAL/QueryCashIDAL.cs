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
    /// 余额查询数据层接口
    /// </summary>
  public  interface QueryCashIDAL
    {
           /// <summary>
           /// 查询余额
           /// </summary>
           /// <param name="regiCardnoCash">余额</param>
           /// <returns>卡号信息</returns>
        DataTable SelectCash(RegistrationCardno regiCardnoCash);
    }
}
