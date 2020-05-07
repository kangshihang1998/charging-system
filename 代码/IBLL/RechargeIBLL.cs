using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace IBLL
{
    /// <summary>
    /// 充值业务层接口
    /// </summary>
 public interface RechargeIBLL
    {
        /// <summary>
        /// 充值方法
        /// </summary>
        /// <param name="Cardno">充值的卡号</param>
        /// <param name="Cash">充值金额</param>
        /// <returns>是否充值成功</returns>
        string Rechargebll(string Cardno,Form form,string Cash);
    }
}
