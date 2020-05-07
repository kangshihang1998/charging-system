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
    /// 激活卡号业务层
    /// </summary>
   public class ActivateCardBLL:ActivateCardIBLL
    {
        /// <summary>
        /// 实例化工厂，用于创建D登录查询类。
        /// </summary>
        FactoryDAl fact = new FactoryDAl();
        /// <summary>
        /// 激活卡号
        /// </summary>
        /// <param name="Cardno">卡号</param>
        /// <param name="form">操作员窗体</param>
        /// <returns>返回是否激活成功！</returns>
        public string ActicateCardnoInfo(string Cardno, Form form)
        {
            //用于返回信息
            string strMsger = "";
            //接受判空返回值，判断文本框是否为空。
            string isNull = IsNull.isNull(form);
            //接受是不是数字的判断返回值
            bool isNumber = IsNull.IsNumber(Cardno);
            //判断卡号是否为空
            if (isNull=="")//没有返回值，说明不为空。
            {
                //判断卡号是否位数字
                if (isNumber==true)//是数字
                {
                    #region 激活卡号
                    //调用激活卡号的数据层接口和创建DAL层工厂，实例化具体的DAL层类
                    ActivateCardIDAL activaIDAL =(ActivateCardIDAL)fact.CreateUser("ActivateCardDAL");
                    //转换为实体
                    RegistrationCardno registCardno = new RegistrationCardno();
                    registCardno.StudentCardno = int.Parse(Cardno);//给实体卡号赋值
                    //获取卡号信息
                    DataTable CardnoInfoTable = activaIDAL.SelectRegistartCardnoInfo(registCardno);
                    //判断卡号是否存在
                    if (CardnoInfoTable.Rows.Count!=0)//说明卡号存在
                    {
                        //判断卡号目前的使用状态，是否已经被激活。
                        if (CardnoInfoTable.Rows[0][4].ToString()=="已激活")
                        {
                            strMsger = "此卡号已经被激活，请勿重复操作！";
                        }
                        else
                        {
                            //更新卡号状态为，已激活。
                            registCardno.State = "已激活";//给卡号状态从新赋值
                            activaIDAL.UpdateCardnoState(registCardno);//更新卡号状态
                            strMsger = "卡号激活成功！";
                        }

                    }
                    else
                    {
                        //说明卡号不存在
                        strMsger = "卡号不存在，请从新输入！";
                    }
                    #endregion
                }
                else
                {
                    strMsger = "卡号请输入数字！";
                }
            }
            else
            {
                //否则为空
                strMsger = isNull;
            }
            return strMsger;
        }
    }
}
