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
/// 管理者退出
/// </summary>
 public   class LoginOutMangerBLL:LoginOutMangerIBLL
    {
        /// <summary>
        /// 实例化工厂，用于创建D登录查询类。
        /// </summary>
        FactoryDAl fact = new FactoryDAl();
        /// <summary>
        /// 删除管理者正在值班信息
        /// </summary>
        /// <param name="ManID">管理者ID</param>
        private void DeleteOnWork(UserOnWork ManID)
        {
            //利用退出接口，和工厂创建退出的数据管理类。
            LoginOutMangerIDAL idal = (LoginOutMangerIDAL)fact.CreateUser("LoginOutMangerDAL");
            //删除管理者正在值班信息
            idal.DeleteOnWork(ManID);
        }
        /// <summary>
        /// 管理者退出
        /// </summary>
        /// <param name="ManID">管理者ID</param>
        /// <returns>是否退出成功！</returns>
        public void LoginOutManger(string ManID)
        {
           
            //转换成正在值班的管理者实体
            UserOnWork OnWork = new UserOnWork();
            OnWork.ManId = int.Parse(ManID);
            //利用退出接口，和工厂创建退出的数据管理类。
            LoginOutMangerIDAL idal =(LoginOutMangerIDAL)fact.CreateUser("LoginOutMangerDAL");
            //接受正在值班者信息
            DataTable OnWorkTable = idal.SelectOnWork(OnWork);
            //判断级别
            if (OnWorkTable.Rows[0][1].ToString()=="管理员")
            {
                //删除正在上机记录
                DeleteOnWork(OnWork);
                   
            }
            else if (OnWorkTable.Rows[0][1].ToString()=="操作员")
            {
                #region 操作员工作记录实体赋值
                OpertionWork opertionWork = new OpertionWork();
                opertionWork.ManId = int.Parse(OnWorkTable.Rows[0][0].ToString());//管理者ID
                opertionWork.Level = OnWorkTable.Rows[0][1].ToString();//管理者等级
                opertionWork.Name = OnWorkTable.Rows[0][2].ToString();//管理者姓名
                opertionWork.Ondate = DateTime.Parse(OnWorkTable.Rows[0][3].ToString());//管理者登录日期
                opertionWork.OnTime = OnWorkTable.Rows[0][4].ToString();//管理者登录时间
                opertionWork.Update = DateTime.Now.Date;//管理者下机日期
                opertionWork.UPTime = DateTime.Now.ToShortTimeString();//管理者下机时间
                opertionWork.Computer = OnWorkTable.Rows[0][5].ToString();//电脑名字
                #endregion
                //更新操作员工作记录
                idal.InertOpertionWork(opertionWork);
                //删除正在上机记录
                DeleteOnWork(OnWork);
            }
            Environment.Exit(0);//退出程序    
        }
    }
}
