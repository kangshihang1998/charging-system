using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enitity
{
   /// <summary>
   /// 登录用户实体
   /// </summary>
   public class UserLevel
    {
    /// <summary>
    /// 用户ID
    /// </summary>
        private int userid;
        /// <summary>
        ///  用户ID
        /// </summary>
        public int UserID
        {
            get { return userid; }
            set { userid = value; } 
        }
        /// <summary>
        /// 用户密码
        /// </summary>
        private string userpwd;
        /// <summary>
        /// 用户密码
        /// </summary>
        public string UserPwd
        {
            get { return userpwd; }
            set { userpwd = value; } 
        }
        /// <summary>
        /// 用户级别
        /// </summary>
        private string userlevel;
        /// <summary>
        /// 用户级别
        /// </summary>
        public string Userlevel
        {
          get { return userlevel; }
          set { userlevel = value; } 
        }
        /// <summary>
        /// 全局变量
        /// </summary>
        private static int useridall;
        /// <summary>
        /// 全局变量
        /// </summary>
        public static int UserIdall
        {
            get { return useridall; }
            set { useridall = value; }
        }
    }
}
