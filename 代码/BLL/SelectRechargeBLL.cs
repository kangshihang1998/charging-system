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
    /// 查询充值记录业务层
    /// </summary>
    public class SelectRechargeBLL : SelectRechargeIBLL
    {
        /// <summary>
        /// 实例化工厂，用于创建D登录查询类。
        /// </summary>
        FactoryDAl fact = new FactoryDAl();
        /// <summary>
        /// 查询充值记录
        /// </summary>
        /// <param name="Cardno">卡号</param>
        /// <param name="form">充值窗体</param>
        /// <returns>查询到的记录</returns>
        DataTable SelectRechargeIBLL.Selectrechar(string Cardno, Form form, ref string StrMsg)
        {
            //用于返回信息
            StrMsg = "";
            //接受判空返回值，判断文本框是否为空。
            string isNull = IsNull.isNull(form);
            //接受是不是数字的判断返回值
            bool isNumber = IsNull.IsNumber(Cardno);
            //接受返回的充值记录
            DataTable Selectrechar = new DataTable();
            //判断卡号是否为空
            if (isNull=="")//没有返回值，说明不为空
            {
                //判断卡号是不是数字
                if (isNumber==true)//是数字
                {
                    //调用查询记录的数据层接口和创建DAL层工厂，创建DAL层具体的类。
                    SelectRechargeIDAL selectRecharIDAL = (SelectRechargeIDAL)fact.CreateUser("SelectRechargeDAL");
                    //实例化充值实体与赋值
                    Recharge recharge = new Recharge();
                    recharge.StudentCardno = int.Parse(Cardno);//卡号赋值
                    Selectrechar = selectRecharIDAL.SelectRecharge(recharge);//查询充值记录里
                    #region 查询充值记录
                    //判断卡号是否存在
                    if (Selectrechar.Rows.Count==0)//等于零说明账号不存在！
                    {
                        StrMsg = "账号不存在，或者没有充值记录！";
                    }
                    else
                    {
                        StrMsg = "查询完毕！";
                    }
                    #endregion
                }
                else
                {
                    StrMsg = "卡号请输入数字!";
                }
            }
            else
            {
                StrMsg = isNull;
            }

            return Selectrechar;//返回查询信息
        }

    }
}
