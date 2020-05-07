using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enitity
{
    /// <summary>
    /// 管理者身份信息实体
    /// </summary>
  public  class ManIDcardno
    {
        /// <summary>
        /// 管理ID字段
        /// </summary>
        private int manid;
        /// <summary>
        /// 管理者ID属性
        /// </summary>
        public int Manid
        {
            get { return manid; }
            set { manid = value; }
        }
        /// <summary>
        /// 手机号字段
        /// </summary>
        private string phoneNumber;
        /// <summary>
        /// 手机号属性
        /// </summary>
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        /// <summary>
        /// 性别字段
        /// </summary>
        private string sex;
        /// <summary>
        /// 性别属性
        /// </summary>
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        /// <summary>
        /// 年龄字段
        /// </summary>
        private int age;
        /// <summary>
        /// 年龄属性
        /// </summary>
        public int Age
        {
            get { return age;}
            set { age = value;}
        }
    }
}
