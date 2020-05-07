using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enitity
{
    /// <summary>
    /// 充值表实体
    /// </summary>
  public  class Recharge
    {
        /// <summary>
        /// 卡号字段
        /// </summary>
        private int studentCardno;
        /// <summary>
        /// 卡号属性
        /// </summary>
        public int StudentCardno
        {
            get { return studentCardno; }
            set { studentCardno = value; }
        }
        /// <summary>
        /// 充值金额字段
        /// </summary>
        private double rechargeCash;
        /// <summary>
        /// 充值金额属性
        /// </summary>
        public double RechargeCash
        {
            get { return rechargeCash; }
            set { rechargeCash = value; }
        }
        /// <summary>
        /// 充值日期字段
        /// </summary>
       private DateTime rechargeDate;
        /// <summary>
        /// 充值日期属性
        /// </summary>
        public DateTime RechargeDate
        {
            get { return rechargeDate; }
            set { rechargeDate = value; }
        }
        /// <summary>
        /// 充值时间字段
        /// </summary>
        private string rechargeTime;
        /// <summary>
        /// 充值时间属性
        /// </summary>
        public string RechargeTime
        {
            get { return rechargeTime; }
            set { rechargeTime = value; }
        }
        /// <summary>
        /// 充值的操作员字段
        /// </summary>
        private int oPertonID;
        /// <summary>
        /// 充值的操作员属性
        /// </summary>
        public int OpertionID
        {
            get { return oPertonID; }
            set { oPertonID = value; }
        }
        /// <summary>
        /// 是否结账
        /// </summary>
        private string state;
        /// <summary>
        /// 是否结账属性
        /// </summary>
        public string State
        {
            get { return state; }
            set { state = value; }
        }
    }
}
