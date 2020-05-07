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
    /// 结账数据层接口
    /// </summary>
 public   interface SettleAccountsIDAL
    {
        /// <summary>
        /// 查询操作员是否存在
        /// </summary>
        /// <param name="managerial">管理者实体</param>
        /// <returns>以表形式返回操作员ID和姓名</returns>
        DataTable SelectManagerial(Managerial managerial);
        /// <summary>
        /// 查询退卡表信息
        /// </summary>
        /// <param name="cancecard">退卡实体</param>
        /// <returns>以表形式返回退卡信息</returns>
        DataTable SelectCancelCard(CanceCard cancecard);
        /// <summary>
        /// 查询售卡信息
        /// </summary>
        /// <param name="registration">注册卡号实体</param>
        /// <returns>以表形式返回注册卡信息</returns>
        DataTable SelectRegistrationCardno(RegistrationCardno registration);
        /// <summary>
        /// 查询充值信息
        /// </summary>
        /// <param name="recharge">充值实体</param>
        /// <returns></returns>
        DataTable SelectRecharge(Recharge recharge);
        /// <summary>
        /// 更新充值记录表结账状态
        /// </summary>
        /// <param name="recharge">充值表实体</param>
        /// <returns>受影响行数</returns>
        int UpdateRecharge(Recharge recharge);
        /// <summary>
        /// 更新退卡表结账状态
        /// </summary>
        /// <param name="cancecard">退卡表实体</param>
        /// <returns>受影响行数</returns>
        int UpdateCancelCard(CanceCard cancecard);
        /// <summary>
        /// 更新注册表结账状态
        /// </summary>
        /// <param name="registration">注册表实体</param>
        /// <returns>受影响行数</returns>
        int UpdateRegistrationCardno(RegistrationCardno registration);
        /// <summary>
        /// 向报表插入内容
        /// </summary>
        /// <param name="rechck">报表实体</param>
        /// <returns>受影响行数</returns>
        int InsertRecheck(Recheck rechck);


    }
}
