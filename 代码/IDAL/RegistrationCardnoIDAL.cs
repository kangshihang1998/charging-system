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
/// 注册卡号数据层接口
/// </summary>
 public   interface RegistrationCardnoIDAL
    {
        /// <summary>
        /// 查询用户是否已经存在
        /// </summary>
        /// <param name="LoginUserID">用户ID</param>
        /// <returns>用户登录表里的信息</returns>
        DataTable SelectUserLevel(UserLevel LoginUserID);
        /// <summary>
        /// 查询基础表
        /// </summary>
        /// <returns>返回整个基础表信息</returns>
        DataTable SelectBasit();
        /// <summary>
        /// 查询卡号信息
        /// </summary>
        /// <param name="CardnoState">卡号实体</param>
        /// <returns>卡号信息</returns>
        DataTable SelectRegistCardno(RegistrationCardno CardnoState);
        /// <summary>
        /// 更新卡号使用状态
        /// </summary>
        /// <param name="CardnoState">卡号使用状态</param>
        /// <returns>受影响的行数</returns>
        int UpdateCardnoState(RegistrationCardno CardnoState);
        /// <summary>
        /// 向登录表插入信息
        /// </summary>
        /// <param name="userLogin">登录实体</param>
        /// <returns>受影响行数</returns>
        int InsertUserLogin(UserLevel userLogin);
        /// <summary>
        /// 向卡号表插入卡号信息
        /// </summary>
        /// <param name="Cardno">卡号实体</param>
        /// <returns></returns>
        int InsertCarndo(RegistrationCardno Cardno);
        /// <summary>
        /// 向学生信息表插入信息
        /// </summary>
        /// <param name="studentinfo">学生实体</param>
        /// <returns>受影响行数</returns>
        int InsertStudentInfo(StudentInfo studentinfo);
    }
}
