using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace IBLL
{
/// <summary>
/// 注册卡号业务层接口
/// </summary>
 public   interface RegistrationCardnoIBLL
    {
        /// <summary>
        /// 注册卡号方法
        /// </summary>
        /// <param name="Cardno">卡号</param>
        /// <param name="CardnoType">卡号类型</param>
        /// <param name="CardnoPwd">密码</param>
        /// <param name="CardnoCash">余额</param>
        /// <param name="Cardnoblane">开卡金额</param>
        /// <param name="CardnoState">卡号状态</param>
        /// <param name="CardnoName">姓名</param>
        /// <param name="CardnoSex">性别</param>
        /// <param name="CardnoAge">年龄</param>
        /// <param name="CarnodNumber">电话号</param>
        /// <param name="CardnoAddess">住址</param>
        /// <param name="CardnoGarde">年级</param>
        /// <param name="weChat">微信</param>
        /// <returns></returns>
        string RegistartonCardno(string Cardno,string CardnoType,string CardnoPwd,string CardnoCash,string Cardnoblane,
        string CardnoState,string CardnoName,string CardnoSex,string CardnoAge,string CarnodNumber,
        string CardnoAddess,string CardnoGarde,string weChat,Form form);
        

    }
}
