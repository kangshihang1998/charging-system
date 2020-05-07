using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enitity;
using Factory;
using IDAL;
using System.Data;
using System.Windows.Forms;
namespace BLL.Level
{
        /// <summary>
        /// 用户等级的抽象类
        /// </summary>
        public abstract class userlevel
        {
            /// <summary>
            /// 级别字段
            /// </summary>
            protected string Level;
          
            /// <summary>
            /// 给等级字段赋值
            /// </summary>
            /// <param name="Level"></param>
            public userlevel(string Level)
            {
                this.Level = Level;
            }
        /// <summary>
        /// 继续处理者字段
        /// </summary>
        protected userlevel user;
        /// <summary>
        /// 设置继续处理者
        /// </summary>
        /// <param name="superior">具体的继续处理者</param>
        public void SetSupertior(userlevel superior)
            {
                this.user = superior;
            }
            /// <summary>
            /// 登录
            /// </summary>
            /// <param name="userlevel">登录实体</param>
            abstract public string UserLogin(UserLevel userlevel,Form form);
        }
    }

