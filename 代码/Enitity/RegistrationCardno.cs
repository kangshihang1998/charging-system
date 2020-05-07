using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enitity
{
/// <summary>
/// 卡号注册实体
/// </summary>
  public  class RegistrationCardno
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
        /// 余额字段
        /// </summary>
        private double studentbalanc;
        /// <summary>
        /// 余额属性
        /// </summary>
        public double Studentbalance
        {
            get { return studentbalanc; }
            set { studentbalanc = value; } 
        }
        /// <summary>
        /// 开卡金额字段
        /// </summary>
        private int initialamount;
        /// <summary>
        /// 开卡金额属性
        /// </summary>
        public int Initialamount
        {
        get { return initialamount; }
        set { initialamount = value; } 
        }
        /// <summary>
        /// 卡号类型字段
        /// </summary>
        private string studentLeve;
        /// <summary>
        /// 卡号类型属性
        /// </summary>
        public string StudentLeve
        {
         get { return studentLeve; }
         set { studentLeve = value; }
        }
        /// <summary>
        /// 卡号使用状态字段
        /// </summary>
        private string state;
        /// <summary>
        /// 卡号使用状态属性
        /// </summary>
        public string State
        {
        get { return state; }
        set { state = value;  } 
        }
        private int opertionID;
        public int OpertionID
        {
            get { return opertionID; }
            set { opertionID = value; }
        }
        private string accountsState;
        /// <summary>
        /// 结账状态
        /// </summary>
        public string AccountsState
        {
            get { return accountsState; }
            set { accountsState = value; }
        }
    }
}
