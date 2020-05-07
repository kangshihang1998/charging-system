
/*
 * 创建人：康世行
 * 创建时间： 2020-4-27 16:33:06
 * 说明：查询学生正在上机状态业务类
 * 版权所有：康世行
 */
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
    /// 查询学生正在上机状态业务类
    /// </summary>
 public   class StudentOnLineStateBLL:StudentOnLineStateIBLL
    {
        /// <summary>
        /// 实例化工厂，用于创建D登录查询类。
        /// </summary>
        FactoryDAl fact = new FactoryDAl();
        /// <summary>
        /// 创建Ui层窗体工厂
        /// </summary>
        FactoryUI factUi = new FactoryUI();
        /// <summary>
        /// 学生上机状态查询
        /// </summary>
        /// <param name="Cardno">卡号</param>
        /// <param name="form">学生窗体</param>
        /// <returns></returns>
        public void StudnetOnLineState(string Cardno, Form form)
        {
            //转成实体
            StudentOnLine stuOnline = new StudentOnLine();
            stuOnline.StudentCardno = int.Parse(Cardno);
            //利用接口和工厂实例化具体的查询正在上机状态的数据类
            StudentOnLineStateIDAL studentlineStateIDAL = (StudentOnLineStateIDAL)fact.CreateUser("StudentOnLineStateDAL");
            DataTable SelectOnlineStudnetTable=studentlineStateIDAL.StudnetOnLineState(stuOnline);//获取上机表此学生上机信息
            //判断学生上机状态
            if (SelectOnlineStudnetTable.Rows.Count==0)//说明已经被强制下机
            {
                //关闭学生窗体
                form.Close();
                //显示登录窗体
                Form forlogin =factUi.CreatFrom("LoginUser");
                forlogin.Show();
            }
        }
    }
}
