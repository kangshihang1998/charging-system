using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enitity
{
    /// <summary>
    /// 退卡表实体
    /// </summary>
  public  class CanceCard
    {

        private int studentCardno;
        /// <summary>
        /// 卡号
        /// </summary>
        public int StudentCardno
        {
            get { return studentCardno; }
            set { studentCardno = value; }
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
        private DateTime canDate;
        /// <summary>
        /// 退卡日期
        /// </summary>
        public DateTime CanDate
        {
            get { return canDate; }
            set { canDate = value; }
        }
        private string canTime;
        /// <summary>
        /// 退卡时间
        /// </summary>
        public string CanTime
        {
            get { return canTime;}
            set { canTime = value; }
        }
        private int operationID;
        /// <summary>
        /// 操作员ID
        /// </summary>
        public int OperationID
        {
            get { return operationID; }
            set { operationID = value; }
        }
        private string state;
        /// <summary>
        /// 卡号是否结账
        /// </summary>
        public string State
        {
            get { return state; }
            set { state = value; }
        }
    }
}
