using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace IBLL
{
    /// <summary>
    /// 退卡业务层接口
    /// </summary>
public    interface CancelCardIBLL
    {
        /// <summary>
        /// 退卡
        /// </summary>
        /// <param name="cardno">卡号</param>
        /// <param name="form">退卡窗体</param>
        /// <returns>是否退卡成功！</returns>
        string CancelCard(string cardno,Form form);
    }
}
