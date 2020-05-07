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
    /// 正在值班教师业务层
    /// </summary>
    public class OnManWorkBLL : OnManWorkIBLL
    {
        /// <summary>
        /// 实例化工厂，用于创建D登录查询类。
        /// </summary>
        FactoryDAl fact = new FactoryDAl();
        /// <summary>
        /// 查询值班的管理者
        /// </summary>
        /// <param name="ManLevel">值班管理者等级</param>
        /// <param name="Strmsg">返回提示信息</param>
        /// <returns>操作员信息</returns>
        public DataTable selectOnManWork(string ManLevel, ref string Strmsg)
        {
            //转换成对应实体
            UserOnWork userOnWork = new UserOnWork();
            userOnWork.Level = ManLevel;
            //调用查询正在值班教师数据层接口
            OnManWorkIDAL onmanWorkIDAL = (OnManWorkIDAL)fact.CreateUser("OnManWorkDAL");
            //调用查询方法
            DataTable SelectOnManWork = onmanWorkIDAL.SelectOnManWork(userOnWork);
            //判断是否有操作员值班信息
            if (SelectOnManWork.Rows.Count!=0)//说明有正在值班操作员数据
            {
                Strmsg = "已显示当前全部值班操作员";
            }
            else
            {
                Strmsg = "暂时没有值班的操作员！";
            }
            return SelectOnManWork;
        }
    }
}
