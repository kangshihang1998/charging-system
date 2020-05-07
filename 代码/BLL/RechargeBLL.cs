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
    /// 充值业务层
    /// </summary>
    public class RechargeBLL : RechargeIBLL

    {
        /// <summary>
        /// 实例化工厂，用于创建D登录查询类。
        /// </summary>
        FactoryDAl fact = new FactoryDAl();
        /// <summary>
        /// 充值方法
        /// </summary>
        /// <param name="Cardno">充值的卡号</param>
        /// <param name="Cash">充值金额</param>
        /// <returns>是否充值成功</returns>
        public string Rechargebll(string Cardno, Form form, string Cash)
        {
            //用于返回信息
            string strMsger = "";
            //接受判空返回值，判断文本框是否为空。
            string isNull = IsNull.isNull(form);
            //接受是不是数字的判断返回值
            bool isNumber = IsNull.IsNumber(Cardno);
            bool isCash = IsNull.IsNumber(Cash);
            //判断文本是否为空
            if (isNull=="")//没有返回值说明不为空
            {
                //判断输入的卡号是否为数字
                if (isNumber!=true)//不是数字
                {
                    strMsger = "卡号请输入数字";
                }
                else//否则是数字
                {
                    #region 获取卡号信息
                    //调用充值接口和创建DAL层的工厂，实例化DAL层具体的类
                    RechargeIDAL RecarIDAL = (RechargeIDAL)fact.CreateUser("RechargeDAL");
                    //转换为卡号实体
                    RegistrationCardno RegistCardno = new RegistrationCardno();
                    RegistCardno.StudentCardno = int.Parse(Cardno);//给卡号赋值
                    //获取卡号信息
                    DataTable CardnoInfoTable = RecarIDAL.SelectStudentCardno(RegistCardno);
                    #endregion
                    #region 充值
                    //判断卡号是否存在
                    if (CardnoInfoTable.Rows.Count!=0)//不等于零，说明卡号存在。
                    {
                        //判断卡号使用状态
                        if (CardnoInfoTable.Rows[0][4].ToString()=="已激活")
                        {
                            //获取基础表信息
                            DataTable Baist = RecarIDAL.SelectBast();
                            #region 判断充值金额
                            if (isCash!=true)//充值金额不是数字
                            {
                                strMsger = "充值金额请输入数字！";
                            }
                            else
                            {
                                //判断充值金额是否大于或等于最小充值金额
                                if (double.Parse(Cash)>=double.Parse(Baist.Rows[0][1].ToString()))
                                {
                                    //插入充值记录
                                    Recharge recahrge = new Recharge();//实例化充值表实体
                                    recahrge.StudentCardno = int.Parse(Cardno);//充值卡号
                                    recahrge.RechargeCash =double.Parse(Cash);//充值金额
                                    recahrge.OpertionID = UserLevel.UserIdall;//充值的操作员
                                    recahrge.RechargeDate = DateTime.Now.Date;//充值日期
                                    recahrge.RechargeTime = DateTime.Now.ToShortTimeString();//充值时间
                                    recahrge.State = "未结账";//结账状态
                                    //调用插入方法
                                    RecarIDAL.InsertRecharge(recahrge);
                                    //更新当前余额
                                    double NowCash =double.Parse( CardnoInfoTable.Rows[0][1].ToString());//当前余额
                                    double NewCash = NowCash+double.Parse(Cash);//新余额=当前余额+充值余额
                                    RegistCardno.Studentbalance = NewCash;//给余额赋值
                                    //调用更新方法
                                    RecarIDAL.UpdateCardnoCash(RegistCardno);
                                    strMsger = "充值成功！";
                                }
                                else
                                {
                                    strMsger = "充值金额不能小于最小充值金额，请从新输入！";
                                }
                            }
                            #endregion
                        }
                        else
                        {
                            strMsger = "卡号未激活，请先激活。";
                        }
                    }
                    else
                    {
                        strMsger = "卡号不存在，请先注册！";
                    }

                    #endregion

                }
            }
            else
            {
                //否则说明为空
                strMsger = isNull;
            }
            return strMsger;
        }
    }
}
