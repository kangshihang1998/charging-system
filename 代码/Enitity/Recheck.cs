using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enitity
{
    /// <summary>
    /// 报表实体
    /// </summary>
 public   class Recheck
    {
        private double sallCash;
        /// <summary>
        /// 售卡金额
        /// </summary>
        public double SallCash
        {
            get { return sallCash; }
            set { sallCash = value; }
        }
        private double rechargeCash;
        /// <summary>
        /// 充值金额
        /// </summary>
        public double RechargeCash
        {
            get { return rechargeCash; }
            set { rechargeCash = value; }
        }
        private double canCash;
        /// <summary>
        /// 退卡金额
        /// </summary>
        public double CanCash
        {
            get { return canCash; }
            set { canCash = value; }
        }
        private double currentincome;
        /// <summary>
        /// 本期金额
        /// </summary>
        public double Currentincome
        {
            get { return currentincome; }
            set { currentincome = value; }
        }
        private int opertion;
        /// <summary>
        /// 操作员
        /// </summary>
        public int Opertion
        {
            get { return opertion; }
            set { opertion = value; }
        }
        private DateTime checkDate;
        /// <summary>
        /// 结账日期
        /// </summary>
        public DateTime CheckDate
        {
            get { return checkDate; }
            set { checkDate = value; }
        }
    }
}
