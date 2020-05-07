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
    /// 激活卡号数据层接口
    /// </summary>
  public  interface ActivateCardIDAL
    {
        /// <summary>
        /// 查询卡号信息
        /// </summary>
        /// <param name="registarCardno">卡号实体</param>
        /// <returns>卡号信息：以DataTable形式返回</returns>
        DataTable SelectRegistartCardnoInfo(RegistrationCardno registarCardno);
        /// <summary>
        /// 更新卡号状态
        /// </summary>
        /// <param name="registarCardno">卡号实体</param>
        /// <returns> 受影响行数</returns>
        int UpdateCardnoState(RegistrationCardno registarCardno);
    }
}
