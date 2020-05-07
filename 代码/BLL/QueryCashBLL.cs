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
using System.Reflection;
using System.Configuration;
using System.Windows.Forms;
namespace BLL
{
    /// <summary>
    /// 查询余额业务
    /// </summary>
  public  class QueryCashBLL:QueryCashIBLL
    {
        /// <summary>
        /// 实例化工厂，用于创建D登录查询类。
        /// </summary>
        FactoryDAl fact = new FactoryDAl();
        /// <summary>
        /// 查询余额
        /// </summary>
        /// <param name="Cardno">卡号</param>
        /// <returns>余额</returns>
        public string SelectCash(string Cardno, Form form)
        {
            //用于返回信息
            string strMsger = "";
            //接受判空返回值，判断文本框是否为空。
            string isNull = IsNull.isNull(form);
            //接受是不是数字的判断返回值
            bool isNumber = IsNull.IsNumber(Cardno);
            //判断文本框是否为空
            if (isNull=="")//没有返回值，说明不为空。
            {
                //判断卡号是否是数字
                if (isNumber==true)//是数字
                {
                    //调用查询余额数据层接口和实例化DAL数据层工厂，实例化具体的DAL层类
                    QueryCashIDAL queryIDAL =(QueryCashIDAL) fact.CreateUser("QueryCashDAL");
                    //转换成卡号实体
                    RegistrationCardno regCardno = new RegistrationCardno();
                    regCardno.StudentCardno = int.Parse(Cardno);
                    //获取卡号余额
                    DataTable SelectStuCash = queryIDAL.SelectCash(regCardno);
                    //判断卡号是否存在
                    if (SelectStuCash.Rows.Count==0)//卡号不存在
                    {
                        strMsger = "卡号不存在，请从新输入！";
                    }
                    else
                    {
                        strMsger = SelectStuCash.Rows[0][0].ToString();//返回余额
                    }
                }
                else
                {
                    strMsger = "卡号请输入数字！";
                }
            }
            else
            {
                strMsger =isNull;
            }
            return strMsger;
        }
    }
}
