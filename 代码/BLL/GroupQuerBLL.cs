
/*
 * 创建人：康世行
 * 创建时间： 2020-4-28 17:17:20
 * 说明：组合查询业务层类
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
    /// 组合查询业务层类
    /// </summary>
    public class GroupQuerBLL : GroupQuerIBLL
    {
        /// <summary>
        /// 实例化工厂，用于创建D登录查询类。
        /// </summary>
        FactoryDAl fact = new FactoryDAl();
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
        public DataTable SelectGroupQuer(string comf1, string comf2, string comf3, string comoper1, string comoper2, string comoper3, string contetn1, string content2, string contetn3, string rel1, string rel2, string DbName, Form form)
        {
            DataTable SelectGroupQuerTable = new DataTable();
            //调用接口与工厂
            GroupQuerIDAL groupQuerIDAL = (GroupQuerIDAL)fact.CreateUser("GroupQuerDAL");
            #region 第一组条件赋值
            GroupQuery groupQuery = new GroupQuery();
            groupQuery.Field1 =comf1;
            groupQuery.Operator1 = comoper1;
            groupQuery.Content1 = contetn1;
            groupQuery.DbName = DbName;
            #endregion
            #region 第二组条件赋值
            groupQuery.Relation1 =rel1;
            groupQuery.Field2 = comf2;
            groupQuery.Operator2 = comoper2;
            groupQuery.Content2 = content2;
            #endregion
            #region 第三组条件赋值
            groupQuery.Field3 = comf3;
            groupQuery.Operator3 = comoper3;
            groupQuery.Content3 = contetn3;
            groupQuery.Relation2 = rel2;
            #endregion
            #region 组合查询逻辑
            //判断第一个组合关系是否被选中
            if (rel1.Trim()!="")//被选中
            {
                #region 判断第二个组合关系是否被玄宗
                if (rel2.Trim()!="")//被选中
                {
                    #region 判断所有控件内容是否为空
                    if (comf1.Trim() != "" && comoper1.Trim() != "" && contetn1.Trim() != "")
                    {
                        if (comf2.Trim() != "" && comoper2.Trim() != "" && content2.Trim() != "")
                        {
                            if (comf3.Trim() != "" && comoper3.Trim() != "" && contetn3.Trim() != "")
                            {
                                //查询具体内容
                                SelectGroupQuerTable = groupQuerIDAL.SelectGroupQuer(groupQuery);
                            }//第三组
                        }//第二组
                    }//第一组
                    #endregion
                }
                else
                {
                    #region 判断前两组控件的内容是否为空
                    if (comf1.Trim() != "" && comoper1.Trim() != "" && contetn1.Trim() != "")
                    {
                        if (comf2.Trim() != "" && comoper2.Trim() != "" && content2.Trim() != "")
                        {
                            //查询具体内容
                            SelectGroupQuerTable = groupQuerIDAL.SelectGroupQuer(groupQuery);
                        }//第二组
                    }//第一组
                    #endregion
                }
                #endregion
            }
            else//没被选中
            {
                #region 判断第一组控件内容是否为空
                if (comf1.Trim() != "" && comoper1.Trim() != "" && contetn1.Trim() != "")
                {
                    //查询具体内容
                    SelectGroupQuerTable = groupQuerIDAL.SelectGroupQuer(groupQuery);
                }
                #endregion
            }
            #endregion
            return SelectGroupQuerTable;
        }
    }
}
