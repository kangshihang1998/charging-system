using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace IBLL
{
    /// <summary>
    /// 查询管理者信息业务层接口
    /// </summary>
  public  interface ManIDcardnoIBLL
    {
        /// <summary>
        /// 查询管理者信息
        /// </summary>
        /// <param name="ManId">管理者ID</param>
        /// <returns>整个表</returns>
        DataTable SelectManIDInfo(string ManId);
    }
}
