using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enitity;
using IBLL;
using Factory;
namespace UI
{
    public partial class SettleAccounts : Form
    {
        public SettleAccounts()
        {
            InitializeComponent();
        }
        //实例化创建BLL层的工厂
        FactoryBLL factBLL = new FactoryBLL();
        private void cmbOPerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //调用售卡信息方法
            SelectCarndoInfo(cmbOPerID.Text);
            SelectCanCardnoInfo(cmbOPerID.Text);//调用退卡信息查询方法，显示退卡信息
            SelectRegChr(cmbOPerID.Text);//调用充值记录方法，显示充值记录
            //当天余额=充值金额-退卡金额
            txtNowCash.Text = "";//先清楚，在显示
            txtNowCash.Text = (double.Parse(txtRegchr.Text) - double.Parse(txtCanCarndo.Text)).ToString();
        }

        private void tapTable_Click(object sender, EventArgs e)
        {
            
        }

        private void tapTable_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        private void tapTable_MouseDown(object sender, MouseEventArgs e)
        {
             
        }

        private void SettleAccounts_Load(object sender, EventArgs e)
        {
            SettleAccountsIBLL settleAccountIBLL = (SettleAccountsIBLL)factBLL.CreateUser("SettleAccountsBLL");
            string Strm = "";//接受返回信息
            DataTable ManagerInfo = settleAccountIBLL.SelectOpertionInfo("操作员",out Strm);//获取信息
            //初始化下拉框
            cmbOPerID.Text = ManagerInfo.Rows[0][0].ToString();
            //遍历给下拉框添加数据
            for (int i = 0; i <= ManagerInfo.Rows.Count - 1; i++)//获取行数
            {         
               //添加数据
                    cmbOPerID.Items.Add(ManagerInfo.Rows[i][0].ToString());
            }//end for
             SelectCarndoInfo(cmbOPerID.Text);//调用售卡信息方法，显示售卡信息。
             SelectCanCardnoInfo(cmbOPerID.Text);//调用退卡信息查询方法，显示退卡信息
            SelectRegChr(cmbOPerID.Text);//调用充值记录方法，显示充值记录 

            txtOpertion.Text = UserLevel.UserIdall.ToString();//给管理员赋值 
            txtAcDate.Text = DateTime.Now.Date.ToString();//给结账日期赋值    
            //当天余额=充值金额-退卡金额
            txtNowCash.Text = "";//先清楚，在显示
            txtNowCash.Text = (double.Parse(txtRegchr.Text) - double.Parse(txtCanCarndo.Text)).ToString();                                                                                 
        }
        /// <summary>
        /// 查询售卡信息方法
        /// </summary>
        /// <param name="Opertion">操作员ID</param>
        /// <returns>查询状态</returns>
        private void SelectCarndoInfo(string Opertion)
        {
            string Strm = "";//接受返回信息
            SettleAccountsIBLL settleAccountIBLL = (SettleAccountsIBLL)factBLL.CreateUser("SettleAccountsBLL");
            DataTable CardnoInfo = settleAccountIBLL.SelectCardnoInfo(Opertion, out Strm);
            //清楚上次显示记录
            dataGridView3.Rows.Clear();
            //显示数据
            //创建表和填充数据
            for (int i = 0; i <= CardnoInfo.Rows.Count - 1; i++)//获取行数
            {
                int index = this.dataGridView3.Rows.Add();//添加一行
                for (int j = 0; j <= CardnoInfo.Columns.Count - 1; j++)//获取列数
                {
                    //添加数据
                    dataGridView3.Rows[index].Cells[j].Value = CardnoInfo.Rows[i][j].ToString();
                }//end for
            }//end for
            //判断是否给售卡金额赋值
            txtSellCash.Text = "";//显示之前先清空
            double cash = 0;
            if (CardnoInfo.Rows.Count!=0)
            {
                //给售卡金额赋值
               cash = CardnoInfo.Rows.Count * double.Parse(CardnoInfo.Rows[0][2].ToString());
            }
            txtSellCash.Text = cash.ToString();
        }
        /// <summary>
        /// 查询退卡信息
        /// </summary>
        /// <param name="Opertion">操作员ID</param>
        /// <returns>返回提示信息</returns>
        private void SelectCanCardnoInfo(string Opertion)
        {
            string Strm = "";//接受返回信息
            SettleAccountsIBLL settleAccountIBLL = (SettleAccountsIBLL)factBLL.CreateUser("SettleAccountsBLL");
            DataTable CanCardnoInfo = settleAccountIBLL.SelectCanCardno(Opertion, out Strm);
            //清楚上次显示记录
            dataGridView1.Rows.Clear();
            txtCanCarndo.Text = "";
            double Cash = 0;
            //显示数据
            //创建表和填充数据
            for (int i = 0; i <=CanCardnoInfo.Rows.Count - 1; i++)//获取行数
            {
                int index = this.dataGridView1.Rows.Add();//添加一行
                for (int j = 0; j <= CanCardnoInfo.Columns.Count - 1; j++)//获取列数
                {
                    //添加数据
                    dataGridView1.Rows[index].Cells[j].Value = CanCardnoInfo.Rows[i][j].ToString();
                }//end for
                Cash = Cash + double.Parse(CanCardnoInfo.Rows[i][1].ToString());//累加赋值
            }//end for
            txtCanCarndo.Text = Cash.ToString();//给退卡金额赋值
        }
        /// <summary>
        /// 查询充值记录方法
        /// </summary>
        /// <param name="Opertion">操作员ID</param>
        private void SelectRegChr(string Opertion)
        {
            string Strm = "";//接受返回信息
            SettleAccountsIBLL settleAccountIBLL = (SettleAccountsIBLL)factBLL.CreateUser("SettleAccountsBLL");
            DataTable RegdnoInfo = settleAccountIBLL.SelectRegchr(Opertion, out Strm);
            //清楚上次显示记录
            dataGridView2.Rows.Clear();
            txtRegchr.Text = "";
            //显示数据
            //创建表和填充数据
            double Cash =0;
            for (int i = 0; i <= RegdnoInfo.Rows.Count - 1; i++)//获取行数
            {
                int index = this.dataGridView2.Rows.Add();//添加一行
                for (int j = 0; j <= RegdnoInfo.Columns.Count - 1; j++)//获取列数
                {
                    //添加数据
                    dataGridView2.Rows[index].Cells[j].Value = RegdnoInfo.Rows[i][j].ToString();            
                }//end for
                Cash =Cash +double.Parse(RegdnoInfo.Rows[i][1].ToString());//累加赋值
            }//end for
            txtRegchr.Text = Cash.ToString();//给充值金额赋值
        }
        
        private void tapAccount_Click(object sender, EventArgs e)
        {

        }

        private void SettleAccounts_FormClosing(object sender, FormClosingEventArgs e)
        {
            AdminMain.stleAcounts = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Strm = "";//接受返回信息
            SettleAccountsIBLL settleAccountIBLL = (SettleAccountsIBLL)factBLL.CreateUser("SettleAccountsBLL");
            Strm = settleAccountIBLL.InsertRecheck(txtSellCash.Text,txtCanCarndo.Text,txtRegchr.Text,txtNowCash.Text,cmbOPerID.Text,txtAcDate.Text,this,txtOpertion.Text);
            MessageBox.Show(Strm);//弹框提示
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
