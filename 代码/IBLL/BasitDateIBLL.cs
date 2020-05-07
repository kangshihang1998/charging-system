using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
namespace IBLL
{
    /// <summary>
    /// 基础数据设定业务逻辑层接口
    /// </summary>
public    interface BasitDateIBLL
    {
        /// <summary>
        /// 查询基础信息
        /// </summary>
        /// <returns>以表的形式返回</returns>
        DataTable SelectBasitInfo(out string Strmsg);
        /// <summary>
        /// 向基础表插入信息
        /// </summary>
        /// <param name="LimintOnCash">最小上机金额</param>
        /// <param name="LimintRecCash">最小充值金额</param>
        /// <param name="OnpreTime">准备时间</param>
        /// <param name="FixUser">固定用户收费标准</param>
        /// <param name="TemUser">临时用户收费标准</param>
        /// <param name="chargeuni">计时单位</param>
        /// <param name="Admin">管理员</param>
        /// <param name="Date">日期</param>
        /// <param name="Time">时间</param>
        /// <returns>以表形式返回</returns>
        string  InsertBaistInfo(string LimintOnCash,string LimintRecCash,string OnpreTime,string FixUser,string TemUser,string chargeuni,string Admin,string Date,string Time,Form form);
    }
}
