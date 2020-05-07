using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enitity
{
  /// <summary>
  /// 学生正在上机实体
  /// </summary>
  public  class StudentOnLine
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
        /// 类型字段
        /// </summary>
        private string studentLevel;
        /// <summary>
        /// 类型属性
        /// </summary>
        public string StudentLevel
        {
        get { return studentLevel; }
        set { studentLevel = value; } 
        }
        /// <summary>
        /// 上机日期字段
        /// </summary>
        private DateTime onDate;
        /// <summary>
        /// 上机日期属性
        /// </summary>
        public DateTime OnDate
        { 
        get { return onDate; }
        set { onDate = value; }
        }
        /// <summary>
        /// 上机时间字段
        /// </summary>
        private string onTime;
        /// <summary>
        /// 上机时间属性
        /// </summary>
        public string OnTime
        {
        get { return onTime; }
        set { onTime = value; } 
        }
        /// <summary>
        /// 电脑名字段
        /// </summary>
        private string computer;
        /// <summary>
        /// 电脑名属性
        /// </summary>
        public string Computer
        {
         get { return computer; }
         set { computer = value; }
        }
        private double nowCash;
        /// <summary>
        /// 当前余额属性
        /// </summary>
        public double NowCash
        {
         get { return nowCash; }
         set { nowCash = value; } 
        }
    }
}
