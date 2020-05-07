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
/// 学生退出接口
/// </summary>
public interface LoginOutStudentIDAL
    {
        /// <summary>
        /// 查询基础信息
        /// </summary>
        /// <param name="basitInf">基础信息实体</param>
        /// <returns></returns>
        DataTable SelectBasit();
        /// <summary>
        /// 查询正在上机学生信息
        /// </summary>
        /// <param name="StudentOnlien">正在上机学生实体</param>
        /// <returns></returns>
        DataTable SelectOnLineStudent(StudentOnLine StudentOnlien);
        /// <summary>
        /// 向学生上机记录插入信息
        /// </summary>
        /// <param name="stuLine">上机记录实体</param>
        /// <returns></returns>
        int InsertLineStudent(StudentLien stuLine);
        /// <summary>
        /// 删除正在上机信息
        /// </summary>
        /// <param name="StudentOnlien">正在上机实体</param>
        /// <returns></returns>
        int DeleteOnLineStudent(StudentOnLine StudentOnlien);
        /// <summary>
        /// 更新卡号余额
        /// </summary>
        /// <param name="studentCsh">卡号实体</param>
        /// <returns>受影响行数</returns>
        int UpdateRegiCardno(RegistrationCardno studentCsh);
    }
}
