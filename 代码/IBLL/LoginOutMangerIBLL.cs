using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
/// <summary>
/// 管理者退出接口
/// </summary>
 public   interface LoginOutMangerIBLL
    {
        /// <summary>
        /// 管理者退出
        /// </summary>
        /// <param name="ManID">管理者ID</param>
        void LoginOutManger(string ManID);
    }
}
