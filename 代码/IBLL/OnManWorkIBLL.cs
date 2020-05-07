using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace IBLL
{
    /// <summary>
    /// 正在值班教师业务层接口
    /// </summary>
  public  interface OnManWorkIBLL
    {
        /// <summary>
        /// 查询值班的管理者
        /// </summary>
        /// <param name="ManLevel">值班管理者等级</param>
        /// <param name="Strmsg">返回提示信息</param>
        /// <returns>操作员信息</returns>
        DataTable selectOnManWork(string ManLevel,ref string Strmsg);
    }
}
