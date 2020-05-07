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
/// 学生信息业务
/// </summary>
public    class StudentInfoBLL:StudentInfoIBLL
    {
        /// <summary>
        /// 实例化工厂，用于创建D登录查询类。
        /// </summary>
        FactoryDAl fact = new FactoryDAl();
        /// <summary>
        /// 查询学生信息
        /// </summary>
        /// <param name="studentinfo">学生信息实体</param>
        /// <returns>整个学生信息的临时表</returns>
        public DataTable StudentInfo(int studentinfCardno)
        {
           //转换成实体
            StudentInfo studentinfo = new Enitity.StudentInfo();
            studentinfo.StudentCardno = studentinfCardno;//给卡号赋值
            //使用工厂创建接口实例化
            StudentInfoIDAL idal =(StudentInfoIDAL)fact.CreateUser("StudentInfoDAL");
            //接受学生信息
            DataTable StudntInfoTable = idal.SelectStudentInfo(studentinfo);
            return StudntInfoTable;//返回结果
        }
    }
}
