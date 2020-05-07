using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enitity
{
    
        /// <summary>
        /// 学生上机记录实体
        /// </summary>
        public class StudentLien
    {
            /// <summary>
            /// 卡号字段
            /// </summary>
            private int studentCardno;
            /// <summary>
            /// 卡号属性
            /// </summary>
            public int StudentCardno
            {
                get { return studentCardno; }
                set { studentCardno = value; }
            }
            /// <summary>
            /// 类型字段
            /// </summary>
            private string studentLevel;
            /// <summary>
            /// 类型属性
            /// </summary>
            public string StudentLevel
            {
                get { return studentLevel; }
                set { studentLevel = value; }
            }
            /// <summary>
            /// 上机日期字段
            /// </summary>
            private DateTime onDate;
            /// <summary>
            /// 上机日期属性
            /// </summary>
            public DateTime OnDate
            {
                get { return onDate; }
                set { onDate = value; }
            }
            /// <summary>
            /// 上机时间字段
            /// </summary>
            private string onTime;
            /// <summary>
            /// 上机时间属性
            /// </summary>
            public string OnTime
            {
                get { return onTime; }
                set { onTime = value; }
            }
            /// <summary>
            /// 姓名字段
            /// </summary>
            private string studentNam;
            /// <summary>
            /// 姓名属性
            /// </summary>
           public string StudentNam
            {
            get { return studentNam; }
            set { studentNam = value; } 
            }
            /// <summary>
            /// 下机日期字段
            /// </summary>
            private DateTime upDate;
            /// <summary>
            /// 下机日期属性
            /// </summary>
            public DateTime UpDate
            {
            get { return upDate; }
            set { upDate = value; } 
            }
            /// <summary>
            /// 下机时间字段
            /// </summary>
            private string upTime;
            /// <summary>
            /// 下机时间属性
            /// </summary>
            public string UpTime
            {
            get { return upTime; }
            set { upTime = value; } 
            }
            /// <summary>
            /// 在线时长字段
            /// </summary>
            private string onLineMin;
            /// <summary>
            /// 在线时长属性
            /// </summary>
            public string OnLineMin
            {
             get { return onLineMin; }
             set { onLineMin = value; } 
            }
            /// <summary>
            /// 消费金额字段
            /// </summary>
            private double consumptionCash;
            /// <summary>
            /// 消费金额属性
            /// </summary>
            public double ConsumptionCash
            { 
                get { return consumptionCash; }
                set { consumptionCash = value; }
            }
            /// <summary>
            /// 余额字段
            /// </summary>
            private double nowCash;
            /// <summary>
            /// 余额属性
            /// </summary>
            public double NowCash
            {
                get { return nowCash; }
                set { nowCash = value; } 
            }
            /// <summary>
            /// 电脑名字段
            /// </summary>
            private string computer;
            /// <summary>
            /// 电脑名属性
            /// </summary>
            public string Computer
            {
                get { return computer; }
                set { computer = value; }
            }
        }
    }
 
