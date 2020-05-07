using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enitity
{
/// <summary>
/// 学生信息实体
/// </summary>
 public class StudentInfo
    {
        private int studentCardno;
        public int StudentCardno
        {
        get { return studentCardno; }
        set { studentCardno = value; } 
        }
        private string name;
        public string Name
        {
        get { return name; }
        set { name = value; } 
        }
        private string sex;
        public string Sex
        {
        get { return sex; }
        set { sex = value; } 
        }
        private int age;
        public int Age
        {
        get { return age; } 
        set { age = value; }
        }
        private string callNumber;
        public string CallNumber
        {
        get { return callNumber; }
        set { callNumber = value; } 
        }
        private string weChat;
        public string WeChat
        {
        get { return weChat; } 
        set { weChat = value; }
        }
        private string homeAddress;
        public string HomeAddress
        {
        get { return homeAddress; }
        set { homeAddress = value; }
        }
        private string grade;
        public string Grade
        {
        get { return grade; }
        set { grade = value; } 
        }
    }
}
