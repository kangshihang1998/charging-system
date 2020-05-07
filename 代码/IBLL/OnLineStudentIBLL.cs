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
    /// 正在上机学生业务层接口
    /// </summary>
 public   interface OnLineStudentIBLL
    {
        /// <summary>
        /// 查询正在上机用户
        /// </summary>
        /// <returns>以表形式返回所有上机学生信息</returns>
        DataTable SelectOnlineStudent(out string StrMsg);
        /// <summary>
        /// 全部学生下机
        /// </summary>
        /// <returns>是否下机成功！</returns>
        string LoginOutAllStudent();
        /// <summary>
        /// 指定学生下机
        /// </summary>
        /// <param name="Cardno">卡号</param>
        /// <returns>是否下机成功！</returns>
        string LoginOutAssignStudent(string Cardno);
    }
}
