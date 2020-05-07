using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enitity
{
   /// <summary>
   /// 操作员工作记录实体
   /// </summary>
  public  class OpertionWork
    {
        /// <summary>
        /// 管理者ID字段
        /// </summary>
        private int manId;
        /// <summary>
        /// 管理者ID属性
        /// </summary>
        public int ManId
        {
            get { return manId; }
            set { manId = value; }
        }
        /// <summary>
        /// 管理姓名字段
        /// </summary>
        private string name;
        /// <summary>
        ///管理者 姓名属性
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// 管理者等级字段
        /// </summary>
        private string level;
        /// <summary>
        /// 管理者等级属性
        /// </summary>
        public string Level
        {
            get { return level; }
            set { level = value; }
        }
        /// <summary>
        /// 上机日期字段
        /// </summary>
        private DateTime onDate;
        /// <summary>
        /// 上机日期属性
        /// </summary>
        public DateTime Ondate
        {
            get { return onDate; }
            set { onDate = value; }
        }
        /// <summary>
        /// 上机时间字段
        /// </summary>
        private string onTime;
        /// <summary>
        /// 上机上机属性
        /// </summary>
        public string OnTime
        {
            get { return onTime; }
            set { onTime = value; }
        }
        /// <summary>
        /// 下机日期字段
        /// </summary>
        private DateTime upDate;
        /// <summary>
        /// 下机日期属性
        /// </summary>
        public DateTime Update
        {
            get { return upDate; }
            set { upDate = value; }
        }
        /// <summary>
        /// 下机时间字段
        /// </summary>
        private string upTime;
        /// <summary>
        ///下机时间属性
        /// </summary>
        public string UPTime
        {
            get { return upTime; }
            set { upTime = value; }
        }
        /// <summary>
        /// 计算机名字段
        /// </summary>
        private string computer;
        /// <summary>
        /// 计算机名属性
        /// </summary>
        public string Computer
        {
            get { return computer; }
            set { computer = value; }
        }
    }
}
