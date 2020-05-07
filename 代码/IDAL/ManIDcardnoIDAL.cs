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
    /// 查询管理者信息数据层接口
    /// </summary>
 public   interface ManIDcardnoIDAL
    {
        /// <summary>
        /// 查询管理者信息
        /// </summary>
        /// <param name="manidCardnoInfo">管理者信息实体</param>
        /// <returns>整个管理者信息实体</returns>
        DataTable SelectManIDCardnoInfo(ManIDcardno manidCardnoInfo);

    }
}
