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
    /// 充值业务层接口
    /// </summary>
 public   interface SelectRechargeIBLL
    {
        /// <summary>
        /// 查询充值记录
        /// </summary>
        /// <param name="Cardno">卡号</param>
        /// <param name="form">充值窗体</param>
        /// <param name="StrMsg">返回的信息</param>
        /// <returns>查询到的记录</returns>
        DataTable Selectrechar(string Cardno,Form form,ref string StrMsg);
    }
}
