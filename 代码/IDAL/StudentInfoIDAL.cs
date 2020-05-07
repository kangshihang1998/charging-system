using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enitity;
using System.Data;
namespace IDAL
{
/// <summary>
/// 学生信息接口
/// </summary>
 public   interface StudentInfoIDAL
    {
        /// <summary>
        /// 查询学生信息
        /// </summary>
        /// <param name="studentInfo">学生信息实体</param>
        /// <returns></returns>
        DataTable SelectStudentInfo(StudentInfo studentInfo);
    }
}
