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
    /// 学生上机状态业务层接口
    /// </summary>
   public interface StudentOnLineStateIBLL
    {
        /// <summary>
        /// 学生上机状态查询
        /// </summary>
        /// <param name="Cardno">卡号</param>
        /// <param name="form">学生窗体</param>
        /// <returns></returns>
        void StudnetOnLineState(string Cardno, Form form);
    }
}
