using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enitity
{
/// <summary>
/// 管理者实体
/// </summary>
 public   class Managerial
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
            set { manId = value;}
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
        set { level = value;  } 
        }
        /// <summary>
        /// 管理者状态字段
        /// </summary>
        private string state;
        /// <summary>
        /// 管理者状态属性
        /// </summary>
        public string State
        {
        get { return state; }
        set { state = value;  } 
        }
    }
}
