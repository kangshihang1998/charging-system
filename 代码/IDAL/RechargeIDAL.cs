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
    /// 充值数据访问层接口
    /// </summary>
 public   interface RechargeIDAL
    {
        /// <summary>
        /// 查询卡号是否存在
        /// </summary>
        /// <param name="StudentCardno">卡号实体</param>
        /// <returns>整个卡号信息表</returns>
        DataTable SelectStudentCardno(RegistrationCardno StudentCardno);
        /// <summary>
        /// 查询基础表
        /// </summary>
        /// <returns>整个基础表信息</returns>
        DataTable SelectBast();
        /// <summary>
        /// 更新卡号余额
        /// </summary>
        /// <param name="StudentCash">卡号余额</param>
        /// <returns>受影响行数</returns>
        int UpdateCardnoCash(RegistrationCardno StudentCash);
        /// <summary>
        /// 向充值表插入信息
        /// </summary>
        /// <param name="recharge">充值实体</param>
        /// <returns>返回受影响行数</returns>
        int InsertRecharge(Recharge recharge);

    }
}
