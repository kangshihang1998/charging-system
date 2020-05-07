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
/// 管理者退出
/// </summary>
  public  interface LoginOutMangerIDAL
    {

    /// <summary>
    /// 查询正在工作的管理者信息
    /// </summary>
    /// <param name="OnWork">正在工作的管理者实体</param>
    /// <returns>整个表的信息</returns>
        DataTable SelectOnWork(UserOnWork  OnWork);
        /// <summary>
        /// 向操作员工作记录插入信息
        /// </summary>
        /// <param name="OpertionWork">操作台工作记录实体</param>
        /// <returns></returns>
        int InertOpertionWork(OpertionWork OpertionWork);
        /// <summary>
        /// 删除正在工作的管理者
        /// </summary>
        /// <param name="OnWork">正在工作的管理者实体</param>
        /// <returns>整个表的信息</returns>
        int DeleteOnWork(UserOnWork OnWork);
    }
}
