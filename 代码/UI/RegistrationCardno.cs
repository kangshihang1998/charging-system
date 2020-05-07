using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBLL;
using Factory;
using Enitity;
namespace UI
{
    public partial class RegistrationCardno : Form
    {
        public RegistrationCardno()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            //实例化创建BLL层的工厂
            FactoryBLL factBll = new FactoryBLL();
            //调用学生注册接口与创建BLL层工厂实例化BLL层注册学生类
            RegistrationCardnoIBLL RegistIBLL = (RegistrationCardnoIBLL)factBll.CreateUser("RegistrationCardnoBLL");
            //注册
            string StrRegis = RegistIBLL.RegistartonCardno(txtCardno.Text,cmbType.Text,txtPwd.Text,txtCash.Text,txtBlne.Text,cmbState.Text,txtName.Text,cmbSex.Text,txtAge.Text,txtNumber.Text,txtAddes.Text,txtGrade.Text,txtWeixin.Text,this);
            MessageBox.Show(StrRegis);
        }

        private void RegistrationCardno_Load(object sender, EventArgs e)
        {
            //用户类型
            cmbType.Items.Add("固定用户");
            cmbType.Items.Add("临时用户");
            //使用状态
            cmbState.Items.Add("已激活");
            cmbState.Items.Add("未激活");
            //性别
            cmbSex.Items.Add("男");
            cmbSex.Items.Add("女");
        }

        private void RegistrationCardno_FormClosing(object sender, FormClosingEventArgs e)
        {
            //改变注册窗体状态
            UI.OperatorMain.RegisFrom = null;
        }
    }
}
