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
    public partial class AddandDeleteUser : Form
    {
        public AddandDeleteUser()
        {
            InitializeComponent();
        }
        //实例化创建BLL层的工厂
        FactoryBLL factBll = new FactoryBLL();
        private void AddandDeleteUser_Load(object sender, EventArgs e)
        {
            cmblevel.Items.Add("操作员");
            cmblevel.Items.Add("管理员");

            level.Items.Add("操作员");
            level.Items.Add("管理员");

            cmbSex.Items.Add("男");
            cmbSex.Items.Add("女");

            cmbStat.Items.Add("使用");
            cmbStat.Items.Add("未使用");
        }

        private void cmblevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddandDeleteUserIBLL addanddeleteIBLL = (AddandDeleteUserIBLL)factBll.CreateUser("AddandDeleteUserBLL");
            string strmsg = "";//接受返回信息
            DataTable SelectLogin = addanddeleteIBLL.SelectLogin(cmblevel.Text,out strmsg);
            dataGridView2.Rows.Clear();//清空上次数据，在显示新数据。
            #region 显示数据到DataGridView2上
            //创建表和填充数据
            for (int i = 0; i <= SelectLogin.Rows.Count - 1; i++)//获取行数
            {
                int index = this.dataGridView2.Rows.Add();//添加一行
                for (int j = 0; j <= SelectLogin.Columns.Count - 1; j++)//获取列数
                {
                    //添加数据
                    dataGridView2.Rows[index].Cells[j].Value = SelectLogin.Rows[i][j].ToString();
                }

            }
            #endregion
            this.Text = strmsg;
        }

        private void AddandDeleteUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            AdminMain.addanddelete = null;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            //  问题：如何动态获取dataGridView2里ID列内容
            AddandDeleteUserIBLL addanddeleteIBLL = (AddandDeleteUserIBLL)factBll.CreateUser("AddandDeleteUserBLL");
            string str = addanddeleteIBLL.DeleteUserManInfo(dataGridView2.CurrentCell.Value.ToString());
            MessageBox.Show(str);
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            AddandDeleteUserIBLL addanddeleteIBLL = (AddandDeleteUserIBLL)factBll.CreateUser("AddandDeleteUserBLL");
            string str = addanddeleteIBLL.AddUserManInfo(txtId.Text, level.Text, txtPwd.Text, txtName.Text, cmbStat.Text, txtNumber.Text, cmbSex.Text, txtAge.Text, this);
            MessageBox.Show(str);

        }
    }
}
