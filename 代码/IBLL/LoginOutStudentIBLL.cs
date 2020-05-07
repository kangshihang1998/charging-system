using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
/// <summary>
/// 学生下机接口
/// </summary>
   public interface LoginOutStudentIBLL
    {
    /// <summary>
    /// 学生下机方法
    /// </summary>
    /// <param name="StuentCardno">学生卡号</param>
    /// <param name="stuName">学生姓名</param>
        void LoginOutStudent(string StuentCardno, string stuName);
    }
}
