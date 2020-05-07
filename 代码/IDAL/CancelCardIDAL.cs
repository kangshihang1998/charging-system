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
    /// 退卡数据层接口
    /// </summary>
 public   interface CancelCardIDAL
    {
        /// <summary>
        /// 查询卡号是否存在
        /// </summary>
        /// <param name="regisCardno">卡号实体</param>
        /// <returns>返回卡号信息</returns>
        DataTable SelectRegisCardnoInfo(RegistrationCardno regisCardno);
        /// <summary>
        /// 向退卡表插入信息
        /// </summary>
        /// <param name="cancelcard">退卡表实体</param>
        /// <returns>受影响行数</returns>
        int InsertCanCardno(CanceCard cancelcard);
        /// <summary>
        /// 删除登录表卡号信息
        /// </summary>
        /// <param name="user">登录表实体</param>
        /// <returns>受影响行数</returns>
        int DeleteUserLoginCardnoInfo(UserLevel user);
        /// <summary>
        /// 删除卡号表卡号信息
        /// </summary>
        /// <param name="regisCardno">卡号实体</param>
        /// <returns>受影响行数</returns>
        int DeleteRegiscardnoInfo(RegistrationCardno regisCardno);
        /// <summary>
        /// 删除卡号的学生信息
        /// </summary>
        /// <param name="studentInfo">学生信息实体</param>
        /// <returns>受影响行数</returns>
        int DeleteStudentInfo(StudentInfo studentInfo);
    }
}
