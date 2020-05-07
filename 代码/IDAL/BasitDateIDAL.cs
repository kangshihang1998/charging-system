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
    /// 基础数据设定，数据层接口。
    /// </summary>
  public  interface BasitDateIDAL
    {
        /// <summary>
        /// 查询基础数据信息
        /// </summary>
        /// <returns></returns>
        DataTable SelectBasitInfo();
        /// <summary>
        /// 删除基础表数据
        /// </summary>
        /// <returns>受影响行数</returns>
        int DeleteBasiInfo();
        /// <summary>
        /// 向基础表插入信息
        /// </summary>
        /// <param name="basit">基础表实体</param>
        /// <returns>受影响行数</returns>
        int InsertBasitInfo(Basis basit);
    }
}
