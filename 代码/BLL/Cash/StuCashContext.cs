using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Cash
{
    /// <summary>
    /// 根据条件选择收费标准
    /// </summary>
    public class StuCashContext
    {
        CashSuper cs = null;//声明一个CashSuper类
        /// <summary>
        /// 选择收费算法
        /// </summary>
        /// <param name="type">用户类型</param>
        /// <param name="Mylist">收费标准</param>
        public StuCashContext(string type, double Cash)
        {

            //根据用户类型，选择不同的收费算法。
            switch (type)
            {
                case "固定用户":
                    CashVIP cs1 = new CashVIP(Cash);
                    cs = cs1;//把实例化的固定用户赋值给抽象层策略类
                    break;
                case "临时用户":
                    CashNormal cs0 = new CashNormal(Cash);
                    cs = cs0;
                    break;
            }//end switch

        }
        /// <summary>
        /// 计算分结果
        /// </summary>
        /// <param name="TimeSolt">消费时间</param>
        /// <param name="LimtTime">最小上机时间</param>
        /// <returns>计算结果</returns>
        public double GetResult(string TimeSolt,double LimtTime)
        {
            
           string hour = TimeSolt.Substring(0,2);//获取上机几小时
            string min = TimeSolt.Substring(3,2);//获取上机几分钟
            int Mint =(int.Parse(hour)*60)+int.Parse(min);//合并小时和时间，获取总的上机分钟数。
            //返回计算结果
            return cs.GetConsumeMoney(Mint,LimtTime);
        }
    }
 
}
