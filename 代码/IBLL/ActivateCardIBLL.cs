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
    /// 激活卡号业务层接口
    /// </summary>
  public  interface ActivateCardIBLL
    {
        /// <summary>
        /// 激活卡号
        /// </summary>
        /// <param name="Cardno">卡号</param>
        /// <param name="form">操作员窗体</param>
        /// <returns>返回是否激活成功！</returns>
        string ActicateCardnoInfo(string Cardno,Form form);
    }
}
