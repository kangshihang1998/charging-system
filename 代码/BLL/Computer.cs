using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    /// <summary>
    /// 获取计算名字
    /// </summary>
 public  class Computer
    {
        /// <summary>
        /// 获取计算机名
        /// </summary>
        /// <returns>计算机名</returns>
        public static string GetMachineName()
        {
            try
            {
                return System.Environment.MachineName;
            }
            catch (Exception ex)
            {

                return  ex.Message;
            }//end try catch
        }

    }
}
