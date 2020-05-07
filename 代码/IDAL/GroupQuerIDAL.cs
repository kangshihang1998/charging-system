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
    /// 组合查询数据层接口
    /// </summary>
 public   interface GroupQuerIDAL
    {
        /// <summary>
        /// 组合查询方法
        /// </summary>
        /// <param name="dic">条件</param>
        /// <returns>查询内容</returns>
        DataTable SelectGroupQuer(GroupQuery gropuQuery);
    }
}
