using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BLL
{
/// <summary>
/// 限制输入内容
/// </summary>
 public class IsNull
    {
       /// <summary>
    /// 判断窗体文本是否为空
    /// </summary>
    /// <param name="form">窗体</param>
    /// <returns>是否为空</returns>
        public static string isNull(Form form)
        {
            //返回信息
            string Str = "";
            foreach (var item in form.Controls)
            {
                if (item.GetType().Name.Equals("TextBox") && ((TextBox)item).Text == string.Empty)
                {
                     Str="填写信息不完整，请检查";
                }
            }
            return Str;
        }
        /// <summary>
        /// 判断输入值是否是数字
        /// </summary>
        /// <param name="StrNumber">要转换的内容</param>
        /// <returns></returns>
        public static bool IsNumber(string StrNumber)
        {
            int i = 0;//要转成的类型
            bool Flage= int.TryParse(StrNumber,out i);
            return Flage;
        }
        /// <summary>
        /// 判断一组文本框输入的是否是数字
        /// </summary>
        /// <param name="form"></param>
        /// <returns>是否是数字</returns>
        public static string GroupIsNumber(Form form)
        {
            //返回提示信息
            string flage ="";//默认是“”
            foreach (var item in form.Controls)
            {
                double a = 0;
                if (item.GetType().Name.Equals("TextBox") && double.TryParse(((TextBox)item).Text,out a)!=true)
                {
                    flage = "文本框内容不全是数字，请改为数字！";//改变标签的值为true
                }
            }
            return flage;
        }
    }
}
