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
/// 上机记录数据层接口
/// </summary>
public    interface LineStudentIDAL
    {
        /// <summary>
        /// 查询学生上机记录
        /// </summary>
        /// <param name="studentline">学生卡号</param>
        /// <returns>此学生全部的上机记录信息</returns>
        DataTable SelectLineStudent(StudentLien studentline);
    }
}
