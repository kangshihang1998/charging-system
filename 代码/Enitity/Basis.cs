using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enitity
{
/// <summary>
/// 基础表实体
/// </summary>
 public   class Basis
    {
        /// <summary>
        /// 最小上机金额
        /// </summary>
        private double limtOnCash;
        /// <summary>
        /// 最小上机金额
        /// </summary>
        public double LimtOnCash
        {
            get { return limtOnCash; }
            set { limtOnCash = value; }
        }
        /// <summary>
        /// 最小充值金额
        /// </summary>
        private double limtReCash;
             
        public double LimtReCash
        {
            get { return limtReCash; }
            set { limtReCash = value; }
        }
        /// <summary>
        /// 上机准备时间
        /// </summary>
        private string onpreTime;
        /// <summary>
        /// 上机准备时间
        /// </summary>
        public string OnpreTime
        {
            get { return onpreTime; }
            set { onpreTime = value; }
        }
        /// <summary>
        /// 固定用用户收费标准
        /// </summary>
        private double fixUser;
        /// <summary>
        /// 固定用用户收费标准
        /// </summary>
        public double FixUser
        {
            get { return fixUser; }
            set { fixUser = value; }
        }
        /// <summary>
        /// 临时用户收费标准
        /// </summary>
        private double temUser;
        /// <summary>
        /// 临时用户收费标准
        /// </summary>
        public double TemUser
        {
            get { return temUser; }
            set { temUser = value; }
        }
        /// <summary>
        /// 计时单位
        /// </summary>
        private  string chargeuni;
        /// <summary>
        /// 计时单位
        /// </summary>
        public string Chargeuni
        {
            get { return chargeuni; }
            set { chargeuni = value; }
        }
        /// <summary>
        /// 设定员
        /// </summary>
        private string admin;
        /// <summary>
        /// 设定员
        /// </summary>
        public string Admin
        {
            get { return admin; }
            set { admin = value; }
        }
        /// <summary>
        /// 日期
        /// </summary>
        private DateTime date;
        /// <summary>
        /// 日期
        /// </summary>
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        /// <summary>
        /// 时间
        /// </summary>
        private DateTime time;
        /// <summary>
        /// 时间
        /// </summary>
        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }
 
    }
}
