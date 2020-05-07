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
    /// 操作员激活接口
    /// </summary>
 public   interface ActivateOpertionIDAL
    {
        /// <summary>
        /// 查询管理者是否存在
        /// </summary>
        /// <param name="manager">管理者实体</param>
        /// <returns></returns>
        DataTable ActivateManagerial(Managerial manager);
        /// <summary>
        /// 更新管理者使用状态
        /// </summary>
        /// <param name="manager">管理者实体</param>
        /// <returns>受影响行数</returns>
        int UpdateManagerial(Managerial manager);
    }
}
