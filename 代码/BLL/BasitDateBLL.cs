using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enitity;
using Factory;
using IDAL;
using IBLL;
using System.Data;
using System.Windows.Forms;
namespace BLL
{
    /// <summary>
    /// 基础数据设定业务层
    /// </summary>
    public class BasitDateBLL : BasitDateIBLL
    {
        /// <summary>
        /// 实例化工厂，用于创建D登录查询类。
        /// </summary>
        FactoryDAl fact = new FactoryDAl();
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
        public string InsertBaistInfo(string LimintOnCash, string LimintRecCash, string OnpreTime, string FixUser, string TemUser, string chargeuni, string Admin, string Date, string Time, Form form)
        {
            //用于返回信息
            string strMsger = "";
            //接受判空返回值，判断文本框是否为空。
            string isNull = IsNull.isNull(form);
            //判断文本框内容是否是数字
            string GroupIsNumber = IsNull.GroupIsNumber(form);
            //判断文本框是否为空
            if (isNull=="")//没有返回值说明不为空
            {
                //判断文本框内容是否是数字
                if (GroupIsNumber=="")//没有返回值说明，是数字！ 
                {
                    BasitDateIDAL basitIDAL = (BasitDateIDAL)fact.CreateUser("BasitDateDAL");
                    //删除上次数据
                    basitIDAL.DeleteBasiInfo();
                    //转换成实体
                    Basis basiInfo = new Basis();
                    basiInfo.LimtOnCash = double.Parse(LimintOnCash);
                    basiInfo.LimtReCash = double.Parse(LimintRecCash);
                    basiInfo.OnpreTime = OnpreTime;
                    basiInfo.FixUser = double.Parse(FixUser);
                    basiInfo.Admin = Admin;
                    basiInfo.Chargeuni = chargeuni;
                    basiInfo.Date = DateTime.Parse(Date);
                    basiInfo.Time = DateTime.Parse(Time);
                    basiInfo.TemUser = double.Parse(TemUser);
                    //调用插入方法,插入新的数据
                    basitIDAL.InsertBasitInfo(basiInfo);
                    strMsger = "更新成功！";
                }
                else
                {
                    strMsger =GroupIsNumber;
                }
               
            }
            else
            {
                strMsger = isNull;
            }
            

            return strMsger;
        }
        /// <summary>
        /// 查询基础信息
        /// </summary>
        /// <returns>以表的形式返回</returns>
        public DataTable SelectBasitInfo(out string Strmsg)
        {
            DataTable SelectBasitable = new DataTable();
            BasitDateIDAL basitIDAL = (BasitDateIDAL)fact.CreateUser("BasitDateDAL");
            SelectBasitable = basitIDAL.SelectBasitInfo();//获取基础表信息
            //判断基础数据是否有内容
            if (SelectBasitable.Rows.Count!=0)//说明有数据
            {
                Strmsg = "查询完毕！";
            }
            else
            {
                Strmsg = "基础数据表没有数据，请尽快设定！";
            }
            return SelectBasitable;
        }
    }
}
