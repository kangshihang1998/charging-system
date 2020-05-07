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
    /// 登录接口
    /// </summary>
    public interface LoginIDAL
    {
        
        /// <summary>
        /// 判断用户是否存在和用户等级。
        /// </summary>
        /// <param name="UserLevel">用户</param>
        /// <returns>临时表</returns>
        DataTable SelectUserLevel(UserLevel UserLevel);
        /// <summary>
        /// 获取管理者账号的使用状态
        /// </summary>
        /// <param name="ManageState">管理者实体</param>
        /// <returns>整个管理者表的信息</returns>
        DataTable SelectState(Managerial ManageState);
        /// <summary>
        ///  判断管理者是否已经登录
        /// </summary>
        /// <param name="OnUser">管理者</param>
        /// <returns>临时表</returns>
        DataTable SelectOnUser(UserOnWork OnUser);
        /// <summary>
        /// 查询卡号信息
        /// </summary>
        /// <param name="StudentCardno">卡号实体</param>
        /// <returns>整个表的卡号信息</returns>
        DataTable SelectStuCardno(RegistrationCardno StudentCardno);
        /// <summary>
        ///  判断学生是否已经登录
        /// </summary>
        /// <param name="OnStudent">学生</param>
        /// <returns>临时表</returns>
        DataTable SelectOnStudent(StudentOnLine OnStudent);
        /// <summary>
        /// 基础信息
        /// </summary>
        /// <param name="BasitInfo">基础信息实体</param>
        /// <returns>整个基础信息表</returns>
        DataTable SelectBasitInfo();
        /// <summary>
        /// 向正在上机的学生表插入数据
        /// </summary>
        /// <param name="StudentOnlies"></param>
        /// <returns></returns>
        int InsertStudentOnLie(StudentOnLine StudentOnlies);
        /// <summary>
        /// 向正在值班的管理者表插入管理者信息
        /// </summary>
        /// <param name="UserOnWork">管理者</param>
        /// <returns>整型</returns>
        int InsertUser(UserOnWork UserOnWork);

    }
}
