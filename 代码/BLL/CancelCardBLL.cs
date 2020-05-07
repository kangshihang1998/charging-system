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
    /// 退卡业务层
    /// </summary>
    public class CancelCardBLL : CancelCardIBLL
    {
        /// <summary>
        /// 实例化工厂，用于创建D登录查询类。
        /// </summary>
        FactoryDAl fact = new FactoryDAl();
        /// <summary>
        /// 退卡
        /// </summary>
        /// <param name="cardno">卡号</param>
        /// <param name="form">退卡窗体</param>
        /// <returns>是否退卡成功！</returns>
        public string CancelCard(string cardno, Form form)
        {
            //用于返回信息
            string strMsger = "";
            //接受判空返回值，判断文本框是否为空。
            string isNull = IsNull.isNull(form);
            //接受是不是数字的判断返回值
            bool isNumber = IsNull.IsNumber(cardno);
            //判断卡号是否为空
            if (isNull=="")//没有返回值说明，文本框不为空。
            {
                //判断卡号是否是数字
                if (isNumber==true)//返回true是数字
                {
                    #region 退卡
                    CancelCardIDAL cancardnoIDAL = (CancelCardIDAL)fact.CreateUser("CancelCardDAL");
                    //实例化实体
                    RegistrationCardno registCardno = new RegistrationCardno();
                    registCardno.StudentCardno = int.Parse(cardno);
                    //获取卡号信息
                    DataTable CardnoInfoTable = cancardnoIDAL.SelectRegisCardnoInfo(registCardno);
                    //判断卡号是否存在
                    if (CardnoInfoTable.Rows.Count!=0)//不等于零说明，存在。
                    {
                        //向CanCardno表插入数据
                        CanceCard carnCardno = new CanceCard();
                        carnCardno.StudentCardno = int.Parse(cardno);
                        carnCardno.CanCash =double.Parse( CardnoInfoTable.Rows[0][1].ToString());
                        carnCardno.CanDate = DateTime.Now.Date;//充值日期
                        carnCardno.CanTime = DateTime.Now.ToShortTimeString();//充值时间
                        carnCardno.OperationID = UserLevel.UserIdall;
                        carnCardno.State = "未结账";
                        cancardnoIDAL.InsertCanCardno(carnCardno);
                        //删除卡号信息
                        cancardnoIDAL.DeleteRegiscardnoInfo(registCardno);
                        //删除登录表信息
                        UserLevel user = new UserLevel();
                        user.UserID = int.Parse(cardno);
                        cancardnoIDAL.DeleteUserLoginCardnoInfo(user);
                        //删除学生信息
                        StudentInfo student = new StudentInfo();
                        student.StudentCardno = int.Parse(cardno);
                        cancardnoIDAL.DeleteStudentInfo(student);
                        strMsger = "退卡成功！";
                    }
                    else
                    {
                        strMsger = "卡号不存在，请重新输入！";
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
                strMsger = isNull;
            }
            return strMsger;
        }
    }
}
