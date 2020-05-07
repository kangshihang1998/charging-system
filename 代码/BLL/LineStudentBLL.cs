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
    /// 上机记录业务
    /// </summary>
    public class LineStudentBLL : LineStudentIBLL
    {

        /// <summary>
        /// 实例化工厂，用于创建D登录查询类。
        /// </summary>
        FactoryDAl fact = new FactoryDAl();
        /// <summary>
        /// 查询上机记录
        /// </summary>
        /// <param name="studentCardno">卡号</param>
        /// <param name="form">上机记录窗体</param>
        /// <returns>上机记录信息</returns>
        public DataTable SelectLineStudent(string studentCardno, Form form, ref string StrMsg)
        {
            //用于返回信息
            StrMsg = "";
            //接受判空返回值，判断文本框是否为空。
            string isNull = IsNull.isNull(form);
            //接受是不是数字的判断返回值
            bool isNumber = IsNull.IsNumber(studentCardno);
            //获取上机记录
            DataTable LineStudentTable = new DataTable();
            //判断文本是否为空
            if (isNull=="")//没有返回值说明文本框不为空！
            {
                 
                //判断输入的卡号是否是数字
                if (isNumber==true)//返回true说明是数字
                {
                  
                    #region  获取上机记录
                    //转换成对应的实体
                    StudentLien studentline = new StudentLien();
                    studentline.StudentCardno = int.Parse(studentCardno);
                    //调用数据层接口和创建DAL层的工厂创建DAL层类
                    LineStudentIDAL LineStudentIDAL = (LineStudentIDAL)fact.CreateUser("LineStudentDAL");
                    //获取上机记录
                    LineStudentTable = LineStudentIDAL.SelectLineStudent(studentline);
                    #endregion
                    #region 判断卡号是否存在，或者有没有上机记录
                    if (LineStudentTable.Rows.Count == 0)//用户不存在或者没有上机记录
                    {
                        StrMsg = "用户不存在或者没有上机记录";
                    }
                    else
                    {
                        StrMsg = "查询完毕！";
                    }
                    #endregion
                }
                else
                {
                    
                    StrMsg = "卡号请输入数字！";
                }

            }
            else
            {
                StrMsg= isNull; //把返回结果赋值给strMsger返回给U层

            }
            
            return LineStudentTable ; //返回处理结果
        }
    }
}
