namespace UI
{
    partial class AddandDeleteUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddandDeleteUser));
            this.cmblevel = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.cmbStat = new System.Windows.Forms.ComboBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.UaweAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmblevel
            // 
            this.cmblevel.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmblevel.FormattingEnabled = true;
            this.cmblevel.Location = new System.Drawing.Point(131, 12);
            this.cmblevel.Name = "cmblevel";
            this.cmblevel.Size = new System.Drawing.Size(118, 28);
            this.cmblevel.TabIndex = 45;
            this.cmblevel.SelectedIndexChanged += new System.EventHandler(this.cmblevel_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(32, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 20);
            this.label13.TabIndex = 44;
            this.label13.Text = "用户级别:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView2.Location = new System.Drawing.Point(1, 60);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(343, 370);
            this.dataGridView2.TabIndex = 46;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "用户ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "用户级别";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "用户密码";
            this.Column3.Name = "Column3";
            // 
            // cmbSex
            // 
            this.cmbSex.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Location = new System.Drawing.Point(404, 188);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(85, 28);
            this.cmbSex.TabIndex = 98;
            // 
            // cmbStat
            // 
            this.cmbStat.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbStat.FormattingEnabled = true;
            this.cmbStat.Location = new System.Drawing.Point(626, 192);
            this.cmbStat.Name = "cmbStat";
            this.cmbStat.Size = new System.Drawing.Size(85, 28);
            this.cmbStat.TabIndex = 97;
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPwd.Location = new System.Drawing.Point(592, 260);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(107, 30);
            this.txtPwd.TabIndex = 96;
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNumber.Location = new System.Drawing.Point(600, 126);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(144, 30);
            this.txtNumber.TabIndex = 95;
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAge.Location = new System.Drawing.Point(404, 257);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(50, 30);
            this.txtAge.TabIndex = 94;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.Location = new System.Drawing.Point(404, 125);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(75, 30);
            this.txtName.TabIndex = 93;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(527, 263);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 20);
            this.label15.TabIndex = 92;
            this.label15.Text = "密码:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(527, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 91;
            this.label3.Text = "使用状态:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(527, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 20);
            this.label14.TabIndex = 90;
            this.label14.Text = "手机号:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(349, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 20);
            this.label11.TabIndex = 89;
            this.label11.Text = "性别:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(349, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 88;
            this.label10.Text = "年龄:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(349, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 87;
            this.label9.Text = "姓名:";
            // 
            // level
            // 
            this.level.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.level.FormattingEnabled = true;
            this.level.Location = new System.Drawing.Point(626, 72);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(118, 28);
            this.level.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(521, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 99;
            this.label1.Text = "用户级别:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtId.Location = new System.Drawing.Point(425, 70);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(75, 30);
            this.txtId.TabIndex = 102;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(349, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 101;
            this.label2.Text = "用户ID:";
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.Color.Transparent;
            this.OK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OK.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OK.Location = new System.Drawing.Point(410, 325);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(90, 34);
            this.OK.TabIndex = 103;
            this.OK.Text = "删除";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.UseWaitCursor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // UaweAdd
            // 
            this.UaweAdd.BackColor = System.Drawing.Color.Transparent;
            this.UaweAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.UaweAdd.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UaweAdd.Location = new System.Drawing.Point(546, 325);
            this.UaweAdd.Name = "UaweAdd";
            this.UaweAdd.Size = new System.Drawing.Size(90, 34);
            this.UaweAdd.TabIndex = 104;
            this.UaweAdd.Text = "添加";
            this.UaweAdd.UseVisualStyleBackColor = false;
            this.UaweAdd.UseWaitCursor = true;
            this.UaweAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddandDeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(748, 432);
            this.Controls.Add(this.UaweAdd);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.level);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSex);
            this.Controls.Add(this.cmbStat);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.cmblevel);
            this.Controls.Add(this.label13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddandDeleteUser";
            this.Text = "添加删除用户";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddandDeleteUser_FormClosing);
            this.Load += new System.EventHandler(this.AddandDeleteUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmblevel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.ComboBox cmbStat;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox level;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button UaweAdd;
    }
}