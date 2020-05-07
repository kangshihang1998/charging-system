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
/// 卡号注册业务
/// </summary>
 public   class RegistrationCardnoBLL:RegistrationCardnoIBLL
    {
        /// <summary>
        /// 实例化工厂，用于创建D登录查询类。
        /// </summary>
        FactoryDAl fact = new FactoryDAl();
        /// <summary>
        /// 注册卡号方法
        /// </summary>
        /// <param name="Cardno">卡号</param>
        /// <param name="CardnoType">卡号类型</param>
        /// <param name="CardnoPwd">密码</param>
        /// <param name="CardnoCash">余额</param>
        /// <param name="Cardnoblane">开卡金额</param>
        /// <param name="CardnoState">卡号状态</param>
        /// <param name="CardnoName">姓名</param>
        /// <param name="CardnoSex">性别</param>
        /// <param name="CardnoAge">年龄</param>
        /// <param name="CarnodNumber">电话号</param>
        /// <param name="CardnoAddess">住址</param>
        /// <param name="CardnoGarde">年级</param>
        /// <param name="weChat">微信</param>
        /// <returns></returns>
        public string RegistartonCardno(string Cardno, string CardnoType, string CardnoPwd, string CardnoCash, string Cardnoblane, string CardnoState, string CardnoName, string CardnoSex, string CardnoAge, string CarnodNumber, string CardnoAddess, string CardnoGarde, string weChat,Form form)
        {
            //用于返回信息
            string strMsger = "";
            //接受判空返回值，判断文本框是否为空。
            string isNull = IsNull.isNull(form);
            //接受是不是数字的判断返回值
            bool isNumber = IsNull.IsNumber(Cardno);
            //判断是否有值
            if (isNull=="")//不为空
            {
                //判断卡号是否是数字
                if (isNumber==true)//返回true说明是数字
                {
                    //调用注册接口和工厂创建DAL层查询。
                    RegistrationCardnoIDAL RegistIdal = (RegistrationCardnoIDAL)fact.CreateUser("RegistrationCardnoDAL");
                    #region 注册卡号

                    //查询卡号是否已经存在。
                    RegistrationCardno user = new RegistrationCardno();
                    user.StudentCardno = int.Parse(Cardno);//卡号赋值
                    DataTable RegitTable = RegistIdal.SelectRegistCardno(user);//获取卡号表内容


                    RegistrationCardno StuCarndo = new RegistrationCardno();//实例化卡号实体
                    #region 判断卡号是否已经注册
                    if (RegitTable.Rows.Count == 0)//没有查到用户，说明没有注册。就可以进行注册
                    {
                        //获取基础表信息的最小充值金额
                        DataTable BasiTable = RegistIdal.SelectBasit();
                        double LimetRegch = double.Parse(BasiTable.Rows[0][1].ToString());//最小充值金额

                        #region 判断金额是否大于等于最小充值金额
                        if (double.Parse(CardnoCash) >= LimetRegch)
                        {
                            UserLevel userlevel = new UserLevel();
                            userlevel.UserID = int.Parse(Cardno);
                            DataTable SeleceLevel = RegistIdal.SelectUserLevel(userlevel);
                            //判断卡号是否和管理者冲突
                            if(SeleceLevel.Rows.Count==0)
                            {
                                #region 添加注册信息
                                //添加登录信息
                                UserLevel use = new UserLevel();
                                use.UserID = int.Parse(Cardno);
                                use.Userlevel = "学生";//级别
                                use.UserPwd = CardnoPwd;//密码
                                RegistIdal.InsertUserLogin(use);  //向登录表添加信息

                                #region 给卡号实体赋值
                                StuCarndo.StudentCardno = int.Parse(Cardno);//卡号
                                StuCarndo.StudentLeve = CardnoType;//学生类型
                                StuCarndo.Initialamount = int.Parse(Cardnoblane);//开卡金额
                                StuCarndo.State = CardnoState;//使用状态
                                StuCarndo.Studentbalance = double.Parse(CardnoCash);//余额
                                StuCarndo.OpertionID = UserLevel.UserIdall;//操作员ID
                                StuCarndo.AccountsState = "未结账";//结账状态
                                #endregion
                                RegistIdal.InsertCarndo(StuCarndo);//向卡号表插入信息
                                #region 实例化学生信息与赋值
                                StudentInfo studentinfo = new StudentInfo();
                                studentinfo.StudentCardno = int.Parse(Cardno);//卡号
                                studentinfo.Grade = CardnoGarde;//年级
                                studentinfo.HomeAddress = CardnoAddess;//住址
                                studentinfo.Name = CardnoName;//姓名
                                studentinfo.Sex = CardnoSex;//性别
                                studentinfo.WeChat = weChat;//微信
                                studentinfo.Age = int.Parse(CardnoAge);//年龄
                                studentinfo.CallNumber = CarnodNumber;//手机号码
                                #endregion
                                RegistIdal.InsertStudentInfo(studentinfo);//向学生信息表插入信息
                                #region 向充值记录表添加信息
                                //调用充值接口和创建DAL层的工厂，实例化DAL层具体的类
                                RechargeIDAL RecarIDAL = (RechargeIDAL)fact.CreateUser("RechargeDAL");
                                //插入充值记录
                                Recharge recahrge = new Recharge();//实例化充值表实体
                                recahrge.StudentCardno = int.Parse(Cardno);//充值卡号
                                recahrge.RechargeCash = double.Parse(CardnoCash);//充值金额
                                recahrge.OpertionID = UserLevel.UserIdall;//充值的操作员
                                recahrge.RechargeDate = DateTime.Now.Date;//充值日期
                                recahrge.RechargeTime = DateTime.Now.ToShortTimeString();//充值时间
                                recahrge.State = "未结账";//结账状态
                                                       //调用插入方法
                                RecarIDAL.InsertRecharge(recahrge);
                                #endregion
                                #endregion
                                strMsger = "注册成功！";
                            }
                            else
                            {
                                strMsger = "此卡号与管理者冲突，请从新输入！";
                            }

                           
                        }
                        else//否则提醒，充值金额小于最小充值金额！
                        {
                            strMsger = "温馨提示，充值金额不得小于" + LimetRegch + "元";
                        }//end if
                        #endregion
                    }
                    else//否则说明已经注册，就进行激活或者提醒卡号已注册。
                    {

                        StuCarndo.StudentCardno = int.Parse(Cardno);
                        DataTable CardnoTable = RegistIdal.SelectRegistCardno(StuCarndo);//获取卡号信息
                                                                                         //判断卡号是否已经激活
                        if (CardnoTable.Rows[0][4].ToString() != "已激活")
                        {
                            //进行激活操作
                            StuCarndo.State = "已激活";
                            RegistIdal.UpdateCardnoState(StuCarndo);//激活卡号
                            strMsger = "卡号激活成功！";
                        }
                        else
                        {
                            strMsger = "此卡号已激活，请从新输入卡号！";
                        }
                    }
                    #endregion
                    #endregion
                }
                else
                {
                    strMsger = "卡号请输入数字！";
                }

            }
            else
            {
                strMsger = isNull;//返回错误
            }//end if
            return strMsger;
        }
    }
}
