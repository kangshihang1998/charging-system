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
    /// 正在上机学生业务层
    /// </summary>
    public class OnLineStudentBLL : OnLineStudentIBLL
    {
        /// <summary>
        /// 实例化工厂，用于创建D登录查询类。
        /// </summary>
        FactoryDAl fact = new FactoryDAl();
        
        /// <summary>
        /// 全部学生下机
        /// </summary>
        /// <returns>是否下机成功！</returns>
        public string LoginOutAllStudent()
        {
            OnLineStudentIDAL onlinestuentIDAL = (OnLineStudentIDAL)fact.CreateUser("OnLineStudentDAL");
            DataTable SelectStudentNameTable = new DataTable();//接收学生姓名
            DataTable SelectOnlineStudentTable =onlinestuentIDAL.SelectOnlineStuent();//获取正在上机的学生信息
            string Strms = "";//返回提示信息
            //判断是否有正在上机学生
            if (SelectOnlineStudentTable.Rows.Count!=0)
            {
                //遍历下机
                for (int i = 0; i <SelectOnlineStudentTable.Rows.Count; i++)
                {
                    string StudentCardno = SelectOnlineStudentTable.Rows[i][0].ToString();//获取到卡号
                    //根据上面卡号获取对应姓名
                    StudentInfo studentName = new StudentInfo();
                    studentName.StudentCardno = int.Parse(StudentCardno);
                    SelectStudentNameTable = onlinestuentIDAL.SelectStudentName(studentName);//获取正在上机学生姓名
                    string StudentName = SelectStudentNameTable.Rows[0][0].ToString();//姓名
                    //调用下机方法下机
                    LoginOutStudentALLBLL loginOutAllStudent = new LoginOutStudentALLBLL();
                    loginOutAllStudent.LoginOutStudent(StudentCardno,StudentName);//调用下机方法下机
                }//end for rows

                Strms = "学生已全部下机！";
            }
            else
            {
                Strms = "目前没有正在上机学生！";
            }


            return Strms;
        }
        /// <summary>
        /// 指定学生下机
        /// </summary>
        /// <param name="Cardno">卡号</param>
        /// <returns>是否下机成功！</returns>
        public string LoginOutAssignStudent(string Cardno)
        {
            string str = "";
            int ToInt = 0;//要转换的类型
            //判断卡号是否为空
            if (Cardno.Trim()=="")
            {
                str = "卡号不能为空！";
            }
            else
            {
                //判断卡号是否是数字
                if (int.TryParse(Cardno, out ToInt))
                {
                    #region 指定学生下机
                    OnLineStudentIDAL onlinestuentIDAL = (OnLineStudentIDAL)fact.CreateUser("OnLineStudentDAL");
                    DataTable SelectStudentNameTable = new DataTable();//接收学生姓名
                                                                       //根据上面卡号获取对应姓名
                    StudentInfo studentName = new StudentInfo();
                    studentName.StudentCardno = int.Parse(Cardno);
                    SelectStudentNameTable = onlinestuentIDAL.SelectStudentName(studentName);//获取正在上机学生姓名
                    string StudentName = SelectStudentNameTable.Rows[0][0].ToString();//姓名

                    //调用下机方法下机
                    LoginOutStudentALLBLL loginOutAllStudent = new LoginOutStudentALLBLL();
                    loginOutAllStudent.LoginOutStudent(Cardno, StudentName);//调用下机方法下机
                    #endregion
                    str = "下机成功！";
                }
                else
                {
                    str = "卡号必须为数字！";
                }

            }


            return str;
        }
        /// <summary>
        /// 查询正在上机用户
        /// </summary>
        /// <returns>以表形式返回所有上机学生信息</returns>
        public DataTable SelectOnlineStudent(out string StrMsg)
        {
            OnLineStudentIDAL onlinestuentIDAL = (OnLineStudentIDAL)fact.CreateUser("OnLineStudentDAL");
            DataTable  SelectOnlineStudentTable = onlinestuentIDAL.SelectOnlineStuent();//获取正在上机的学生信息
            //判断是否有正在上机的学生
            if (SelectOnlineStudentTable.Rows.Count!=0)//不等于零说明有正在上机的学生
            {
                StrMsg = "查询完毕！";
            }
            else
            {
                StrMsg = "此时没有正在上机学生！";
            }
            return SelectOnlineStudentTable;
        }


    }
}
