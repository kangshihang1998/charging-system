using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Cash
{
    /// <summary>
    /// 临时用户收费算法
    /// </summary>
    public class CashNormal : CashSuper
    {
        /// <summary>
        /// 每小时收费标准
        /// </summary>
        private double moneyRebate = 1d;
        /// <summary>
        /// 给moneyRebat赋值
        /// </summary>
        /// <param name="moneyRebate">每小时收费标准</param>
        public CashNormal(double moneyRebate)
        {
            this.moneyRebate = moneyRebate;
        }
        /// <summary>
        /// 计算临时用户消费金额
        /// </summary>
        /// <param name="TiemSolt">消费时间</param>
        /// <param name="LimtTime">最小上机时长</param>
        /// <returns>消费金额</returns>
        public override double GetConsumeMoney(int  TiemSolt, double LimtTime)
        {
            double money = 2d;//收费
            //结账，收费标准
            if (TiemSolt <= LimtTime)//小于等于准备时间，不收费。
            {
                money = 0.0;//返回零，不收费       
            }
            else if (TiemSolt <= 30)//小于等三十分钟。
            {
                money = moneyRebate * 0.5;//收半小时费用
            }
            else if (TiemSolt >= 30 & TiemSolt <= 60)//大于等于三十分钟和小于等于一小时。
            {
                money = moneyRebate * 1;//收费一小时费用
            }
            else if (TiemSolt > 60)//大于一小时
            {
                money = moneyRebate * (TiemSolt / 60.0);//实时收费
            }

            return money;
             
        }
    }

}
