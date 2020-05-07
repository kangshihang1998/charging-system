using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace IBLL
{
    /// <summary>
    /// 查询余额业务层接口
    /// </summary>
public    interface QueryCashIBLL
    {
        /// <summary>
        /// 查询余额
        /// </summary>
        /// <param name="Cardno">卡号</param>
        /// <returns>余额</returns>
        string SelectCash(string Cardno,Form form);
    }
}
