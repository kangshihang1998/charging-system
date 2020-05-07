using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
namespace IBLL
{
    /// <summary>
    /// 组合查询业务层接口
    /// </summary>
 public   interface GroupQuerIBLL
    {
        /// <summary>
        /// 组合查询方法
        /// </summary>
        /// <param name="comf1">字段1</param>
        /// <param name="comf2">字段2</param>
        /// <param name="comf3">字段3</param>
        /// <param name="comoper1">操作符1</param>
        /// <param name="comoper2">操作符2</param>
        /// <param name="comoper3">操作符3</param>
        /// <param name="contetn1">内容1</param>
        /// <param name="content2">内容2</param>
        /// <param name="contetn3">内容3</param>
        /// <param name="rel1">组合关系1</param>
        /// <param name="rel2">组合关系2</param>
        /// <param name="form">组合查询窗体</param>
        /// <returns></returns>
        DataTable SelectGroupQuer(string comf1,string comf2,string comf3,string comoper1,string comoper2,string comoper3,string contetn1,string content2,string contetn3,string rel1,string rel2, string DbName,Form form);
    }
}
