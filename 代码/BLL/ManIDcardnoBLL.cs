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
    /// 查询管理者信息业务层
    /// </summary>
    public class ManIDcardnoBLL : ManIDcardnoIBLL
    {
        /// <summary>
        /// 实例化工厂，用于创建D登录查询类。
        /// </summary>
        FactoryDAl fact = new FactoryDAl();
        /// <summary>
        /// 查询管理者信息
        /// </summary>
        /// <param name="ManId">管理者ID</param>
        /// <returns>整个表</returns>
        public DataTable SelectManIDInfo(string ManId)
        {
            //转换成实体
            ManIDcardno manidCardno = new ManIDcardno();
            manidCardno.Manid = int.Parse(ManId);
            //调用查询管理者信息数据层接口
            ManIDcardnoIDAL manIDAL = (ManIDcardnoIDAL)fact.CreateUser("ManIDcardnoDAL");
            //调用查询方法
            DataTable ManInfoTable=manIDAL.SelectManIDCardnoInfo(manidCardno);
            return ManInfoTable;//返回查询信息
        }
    }
}
