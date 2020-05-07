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
    /// 在线学生数据层接口
    /// </summary>
   public interface OnLineStudentIDAL
    {
        /// <summary>
        /// 查询正在上机学生
        /// </summary>
        /// <param name="studentOnline">正在上机实体</param>
        /// <returns>以表形式返回</returns>
        DataTable SelectOnlineStuent();
        /// <summary>
        /// 获取正在上机的学生姓名
        /// </summary>
        /// <param name="studentName">学生信息实体</param>
        /// <returns>学生姓名，以表形式返回。</returns>
        DataTable SelectStudentName(StudentInfo studentName);
    }
}
