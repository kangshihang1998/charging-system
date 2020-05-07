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
    /// 正在值班教师数据层接口
    /// </summary>
  public  interface OnManWorkIDAL
    {
        /// <summary>
        /// 查询正在值班教师
        /// </summary>
        /// <param name="userOnWork">管理者正在工作实体</param>
        /// <returns>正在值班管理信息</returns>
        DataTable SelectOnManWork(UserOnWork userOnWork);
    }
}
