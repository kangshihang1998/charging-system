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
/// 上机记录业务层接口
/// </summary>
 public   interface LineStudentIBLL
    {
        /// <summary>
        /// 查询上机记录
        /// </summary>
        /// <param name="studentCardno">卡号</param>
        /// <param name="form">上机记录窗体</param>
        /// <returns>上机记录信息</returns>
        DataTable SelectLineStudent(string studentCardno,Form form,ref string StrMsg);
    }
}
