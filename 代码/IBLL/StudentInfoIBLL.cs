using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace IBLL
{
/// <summary>
/// 学生信息接口
/// </summary>
 public   interface StudentInfoIBLL
    {
    /// <summary>
    /// 学生信息
    /// </summary>
    /// <param name="studentinfCardno">卡号</param>
    /// <returns>返回学生信息表</returns>
        DataTable StudentInfo(int studentinfCardno);
    }
}
