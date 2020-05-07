namespace UI
{
    partial class SettleAccounts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettleAccounts));
            this.tapTable = new System.Windows.Forms.TabControl();
            this.tapSell = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tapRech = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tapCan = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tapAccount = new System.Windows.Forms.TabPage();
            this.txtAcDate = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNowCash = new System.Windows.Forms.TextBox();
            this.txtRegchr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOpertion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCanCarndo = new System.Windows.Forms.TextBox();
            this.txtSellCash = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbOPerID = new System.Windows.Forms.ComboBox();
            this.tapTable.SuspendLayout();
            this.tapSell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tapRech.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tapCan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tapAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // tapTable
            // 
            this.tapTable.Controls.Add(this.tapSell);
            this.tapTable.Controls.Add(this.tapRech);
            this.tapTable.Controls.Add(this.tapCan);
            this.tapTable.Controls.Add(this.tapAccount);
            this.tapTable.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tapTable.Location = new System.Drawing.Point(2, 103);
            this.tapTable.Name = "tapTable";
            this.tapTable.SelectedIndex = 0;
            this.tapTable.Size = new System.Drawing.Size(963, 465);
            this.tapTable.TabIndex = 0;
            this.tapTable.SelectedIndexChanged += new System.EventHandler(this.tapTable_SelectedIndexChanged);
            this.tapTable.Click += new System.EventHandler(this.tapTable_Click);
            this.tapTable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tapTable_MouseDown);
            // 
            // tapSell
            // 
            this.tapSell.BackColor = System.Drawing.Color.Transparent;
            this.tapSell.Controls.Add(this.dataGridView3);
            this.tapSell.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tapSell.Location = new System.Drawing.Point(4, 45);
            this.tapSell.Name = "tapSell";
            this.tapSell.Padding = new System.Windows.Forms.Padding(3);
            this.tapSell.Size = new System.Drawing.Size(955, 416);
            this.tapSell.TabIndex = 0;
            this.tapSell.Text = "售卡";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView3.Location = new System.Drawing.Point(-1, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(956, 404);
            this.dataGridView3.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "卡号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 130;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "当前余额";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 130;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "售卡金额";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 130;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "用户类型";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 130;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "使用状态";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 130;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "操作员ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 130;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "结账状态";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 130;
            // 
            // tapRech
            // 
            this.tapRech.BackColor = System.Drawing.Color.Transparent;
            this.tapRech.Controls.Add(this.dataGridView2);
            this.tapRech.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tapRech.Location = new System.Drawing.Point(4, 45);
            this.tapRech.Name = "tapRech";
            this.tapRech.Padding = new System.Windows.Forms.Padding(3);
            this.tapRech.Size = new System.Drawing.Size(955, 416);
            this.tapRech.TabIndex = 1;
            this.tapRech.Text = "充值";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.dataGridView2.Location = new System.Drawing.Point(-5, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(956, 404);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "卡号";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "充值余额";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "充值日期";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 200;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "充值时间";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "操作员ID";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 130;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "结账状态";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 130;
            // 
            // tapCan
            // 
            this.tapCan.BackColor = System.Drawing.Color.Transparent;
            this.tapCan.Controls.Add(this.dataGridView1);
            this.tapCan.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tapCan.Location = new System.Drawing.Point(4, 45);
            this.tapCan.Name = "tapCan";
            this.tapCan.Size = new System.Drawing.Size(955, 416);
            this.tapCan.TabIndex = 2;
            this.tapCan.Text = "退卡";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(956, 404);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "卡号";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "退卡余额";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "退卡日期";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "退卡时间";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "操作员ID";
            this.Column6.Name = "Column6";
            this.Column6.Width = 130;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "结账状态";
            this.Column5.Name = "Column5";
            this.Column5.Width = 130;
            // 
            // tapAccount
            // 
            this.tapAccount.BackColor = System.Drawing.Color.Transparent;
            this.tapAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tapAccount.BackgroundImage")));
            this.tapAccount.Controls.Add(this.txtAcDate);
            this.tapAccount.Controls.Add(this.button3);
            this.tapAccount.Controls.Add(this.label1);
            this.tapAccount.Controls.Add(this.txtNowCash);
            this.tapAccount.Controls.Add(this.txtRegchr);
            this.tapAccount.Controls.Add(this.label2);
            this.tapAccount.Controls.Add(this.label4);
            this.tapAccount.Controls.Add(this.txtOpertion);
            this.tapAccount.Controls.Add(this.label6);
            this.tapAccount.Controls.Add(this.txtCanCarndo);
            this.tapAccount.Controls.Add(this.txtSellCash);
            this.tapAccount.Controls.Add(this.label14);
            this.tapAccount.Controls.Add(this.label9);
            this.tapAccount.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tapAccount.Location = new System.Drawing.Point(4, 45);
            this.tapAccount.Name = "tapAccount";
            this.tapAccount.Size = new System.Drawing.Size(955, 416);
            this.tapAccount.TabIndex = 3;
            this.tapAccount.Text = "结账";
            this.tapAccount.Click += new System.EventHandler(this.tapAccount_Click);
            // 
            // txtAcDate
            // 
            this.txtAcDate.AutoSize = true;
            this.txtAcDate.BackColor = System.Drawing.Color.Transparent;
            this.txtAcDate.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAcDate.Location = new System.Drawing.Point(638, 252);
            this.txtAcDate.Name = "txtAcDate";
            this.txtAcDate.Size = new System.Drawing.Size(0, 20);
            this.txtAcDate.TabIndex = 64;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(820, 340);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 40);
            this.button3.TabIndex = 63;
            this.button3.Text = "结账";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(533, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "结账日期:";
            // 
            // txtNowCash
            // 
            this.txtNowCash.Enabled = false;
            this.txtNowCash.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNowCash.Location = new System.Drawing.Point(383, 249);
            this.txtNowCash.Name = "txtNowCash";
            this.txtNowCash.Size = new System.Drawing.Size(144, 30);
            this.txtNowCash.TabIndex = 60;
            // 
            // txtRegchr
            // 
            this.txtRegchr.Enabled = false;
            this.txtRegchr.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRegchr.Location = new System.Drawing.Point(147, 247);
            this.txtRegchr.Name = "txtRegchr";
            this.txtRegchr.Size = new System.Drawing.Size(75, 30);
            this.txtRegchr.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(278, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 58;
            this.label2.Text = "当天余额:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(42, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 57;
            this.label4.Text = "充值金额:";
            // 
            // txtOpertion
            // 
            this.txtOpertion.Enabled = false;
            this.txtOpertion.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOpertion.Location = new System.Drawing.Point(627, 133);
            this.txtOpertion.Name = "txtOpertion";
            this.txtOpertion.Size = new System.Drawing.Size(147, 30);
            this.txtOpertion.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(542, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 55;
            this.label6.Text = "管理员:";
            // 
            // txtCanCarndo
            // 
            this.txtCanCarndo.Enabled = false;
            this.txtCanCarndo.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCanCarndo.Location = new System.Drawing.Point(383, 134);
            this.txtCanCarndo.Name = "txtCanCarndo";
            this.txtCanCarndo.Size = new System.Drawing.Size(144, 30);
            this.txtCanCarndo.TabIndex = 54;
            // 
            // txtSellCash
            // 
            this.txtSellCash.Enabled = false;
            this.txtSellCash.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSellCash.Location = new System.Drawing.Point(147, 132);
            this.txtSellCash.Name = "txtSellCash";
            this.txtSellCash.Size = new System.Drawing.Size(75, 30);
            this.txtSellCash.TabIndex = 53;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(278, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 20);
            this.label14.TabIndex = 52;
            this.label14.Text = "退卡金额:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(42, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 51;
            this.label9.Text = "售卡金额:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(335, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "被结账操作员ID:";
            // 
            // cmbOPerID
            // 
            this.cmbOPerID.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbOPerID.FormattingEnabled = true;
            this.cmbOPerID.Location = new System.Drawing.Point(500, 45);
            this.cmbOPerID.Name = "cmbOPerID";
            this.cmbOPerID.Size = new System.Drawing.Size(156, 28);
            this.cmbOPerID.TabIndex = 55;
            this.cmbOPerID.SelectedIndexChanged += new System.EventHandler(this.cmbOPerID_SelectedIndexChanged);
            // 
            // SettleAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(964, 567);
            this.Controls.Add(this.cmbOPerID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tapTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettleAccounts";
            this.Text = "结账";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettleAccounts_FormClosing);
            this.Load += new System.EventHandler(this.SettleAccounts_Load);
            this.tapTable.ResumeLayout(false);
            this.tapSell.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tapRech.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tapCan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tapAccount.ResumeLayout(false);
            this.tapAccount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tapTable;
        private System.Windows.Forms.TabPage tapSell;
        private System.Windows.Forms.TabPage tapRech;
        private System.Windows.Forms.TabPage tapCan;
        private System.Windows.Forms.TabPage tapAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbOPerID;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNowCash;
        private System.Windows.Forms.TextBox txtRegchr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOpertion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCanCarndo;
        private System.Windows.Forms.TextBox txtSellCash;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label txtAcDate;
    }
}