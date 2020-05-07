using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Cash
{
    /// <summary>
    /// 抽象的算法类
    /// </summary>
    public abstract class CashSuper
    {
        /// <summary>
        /// 计算结果
        /// </summary>
        ///<param name="TiemSolt">上机时间</param>
        ///<param name="LimtTime">最小上机时长</param>
        /// <returns>计算结果</returns>
        public abstract double GetConsumeMoney(int  TiemSolt,double LimtTime);
    }
}
