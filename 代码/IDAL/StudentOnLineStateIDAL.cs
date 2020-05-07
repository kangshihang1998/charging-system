using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enitity;
using System.Data;
namespace IDAL
{
    /// <summary>
    /// 指定学生下机数据层接口
    /// </summary>
public    interface StudentOnLineStateIDAL
    {
        /// <summary>
        /// 查询学生上机状态
        /// </summary>
        /// <param name="StuCardno">正在上机实体</param>
        /// <returns></returns>
        DataTable StudnetOnLineState(StudentOnLine StuCardno);
    }
}
