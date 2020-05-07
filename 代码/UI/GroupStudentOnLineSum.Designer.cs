namespace UI
{
    partial class GroupStudentOnLineSum
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
            this.dateViConten = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.query = new System.Windows.Forms.Button();
            this.clare = new System.Windows.Forms.Button();
            this.toExcel = new System.Windows.Forms.Button();
            this.txtCont2 = new System.Windows.Forms.TextBox();
            this.txtCont3 = new System.Windows.Forms.TextBox();
            this.txtCont1 = new System.Windows.Forms.TextBox();
            this.combFile2 = new System.Windows.Forms.ComboBox();
            this.combFile3 = new System.Windows.Forms.ComboBox();
            this.combOper1 = new System.Windows.Forms.ComboBox();
            this.combOper2 = new System.Windows.Forms.ComboBox();
            this.combOper3 = new System.Windows.Forms.ComboBox();
            this.combRel1 = new System.Windows.Forms.ComboBox();
            this.combRel2 = new System.Windows.Forms.ComboBox();
            this.combFile1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dateViConten)).BeginInit();
            this.SuspendLayout();
            // 
            // dateViConten
            // 
            this.dateViConten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dateViConten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dateViConten.Location = new System.Drawing.Point(1, 212);
            this.dateViConten.Name = "dateViConten";
            this.dateViConten.RowTemplate.Height = 23;
            this.dateViConten.Size = new System.Drawing.Size(942, 354);
            this.dateViConten.TabIndex = 111;
            this.dateViConten.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dateViConten_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "姓名";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "类型";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "上机日期";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "上机时间";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "下机日期";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "下机时间";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "在线时长";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "消费金额";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "目前余额";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "计算机名称";
            this.Column11.Name = "Column11";
            // 
            // query
            // 
            this.query.AutoSize = true;
            this.query.BackColor = System.Drawing.Color.Transparent;
            this.query.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.query.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.query.ForeColor = System.Drawing.Color.Black;
            this.query.Location = new System.Drawing.Point(829, 78);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(90, 34);
            this.query.TabIndex = 110;
            this.query.Text = "查询";
            this.query.UseVisualStyleBackColor = false;
            this.query.UseWaitCursor = true;
            this.query.Click += new System.EventHandler(this.query_Click);
            // 
            // clare
            // 
            this.clare.AutoSize = true;
            this.clare.BackColor = System.Drawing.Color.Transparent;
            this.clare.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clare.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clare.ForeColor = System.Drawing.Color.Black;
            this.clare.Location = new System.Drawing.Point(829, 146);
            this.clare.Name = "clare";
            this.clare.Size = new System.Drawing.Size(90, 34);
            this.clare.TabIndex = 109;
            this.clare.Text = "清空";
            this.clare.UseVisualStyleBackColor = false;
            this.clare.UseWaitCursor = true;
            this.clare.Click += new System.EventHandler(this.clare_Click);
            // 
            // toExcel
            // 
            this.toExcel.AutoSize = true;
            this.toExcel.BackColor = System.Drawing.Color.Transparent;
            this.toExcel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.toExcel.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toExcel.ForeColor = System.Drawing.Color.Black;
            this.toExcel.Location = new System.Drawing.Point(814, 11);
            this.toExcel.Name = "toExcel";
            this.toExcel.Size = new System.Drawing.Size(129, 34);
            this.toExcel.TabIndex = 108;
            this.toExcel.Text = "导出为Excel";
            this.toExcel.UseVisualStyleBackColor = false;
            this.toExcel.UseWaitCursor = true;
            this.toExcel.Click += new System.EventHandler(this.toExcel_Click);
            // 
            // txtCont2
            // 
            this.txtCont2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCont2.Location = new System.Drawing.Point(457, 105);
            this.txtCont2.Name = "txtCont2";
            this.txtCont2.Size = new System.Drawing.Size(182, 30);
            this.txtCont2.TabIndex = 107;
            // 
            // txtCont3
            // 
            this.txtCont3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCont3.Location = new System.Drawing.Point(457, 153);
            this.txtCont3.Name = "txtCont3";
            this.txtCont3.Size = new System.Drawing.Size(182, 30);
            this.txtCont3.TabIndex = 106;
            // 
            // txtCont1
            // 
            this.txtCont1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCont1.Location = new System.Drawing.Point(457, 56);
            this.txtCont1.Name = "txtCont1";
            this.txtCont1.Size = new System.Drawing.Size(182, 30);
            this.txtCont1.TabIndex = 105;
            // 
            // combFile2
            // 
            this.combFile2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.combFile2.FormattingEnabled = true;
            this.combFile2.Location = new System.Drawing.Point(52, 105);
            this.combFile2.Name = "combFile2";
            this.combFile2.Size = new System.Drawing.Size(121, 28);
            this.combFile2.TabIndex = 104;
            // 
            // combFile3
            // 
            this.combFile3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.combFile3.FormattingEnabled = true;
            this.combFile3.Location = new System.Drawing.Point(52, 155);
            this.combFile3.Name = "combFile3";
            this.combFile3.Size = new System.Drawing.Size(121, 28);
            this.combFile3.TabIndex = 103;
            // 
            // combOper1
            // 
            this.combOper1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.combOper1.FormattingEnabled = true;
            this.combOper1.Location = new System.Drawing.Point(288, 56);
            this.combOper1.Name = "combOper1";
            this.combOper1.Size = new System.Drawing.Size(121, 28);
            this.combOper1.TabIndex = 102;
            // 
            // combOper2
            // 
            this.combOper2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.combOper2.FormattingEnabled = true;
            this.combOper2.Location = new System.Drawing.Point(288, 105);
            this.combOper2.Name = "combOper2";
            this.combOper2.Size = new System.Drawing.Size(121, 28);
            this.combOper2.TabIndex = 101;
            // 
            // combOper3
            // 
            this.combOper3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.combOper3.FormattingEnabled = true;
            this.combOper3.Location = new System.Drawing.Point(288, 155);
            this.combOper3.Name = "combOper3";
            this.combOper3.Size = new System.Drawing.Size(121, 28);
            this.combOper3.TabIndex = 100;
            // 
            // combRel1
            // 
            this.combRel1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.combRel1.FormattingEnabled = true;
            this.combRel1.Location = new System.Drawing.Point(682, 82);
            this.combRel1.Name = "combRel1";
            this.combRel1.Size = new System.Drawing.Size(121, 28);
            this.combRel1.TabIndex = 99;
            // 
            // combRel2
            // 
            this.combRel2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.combRel2.FormattingEnabled = true;
            this.combRel2.Location = new System.Drawing.Point(682, 142);
            this.combRel2.Name = "combRel2";
            this.combRel2.Size = new System.Drawing.Size(121, 28);
            this.combRel2.TabIndex = 98;
            // 
            // combFile1
            // 
            this.combFile1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.combFile1.FormattingEnabled = true;
            this.combFile1.Location = new System.Drawing.Point(52, 56);
            this.combFile1.Name = "combFile1";
            this.combFile1.Size = new System.Drawing.Size(121, 28);
            this.combFile1.TabIndex = 97;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(691, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 96;
            this.label4.Text = "组合关系";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(539, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 95;
            this.label3.Text = "查询内容";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(296, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 94;
            this.label2.Text = "操作符";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 93;
            this.label1.Text = "字段名";
            // 
            // GroupStudentOnLineSum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.背景;
            this.ClientSize = new System.Drawing.Size(943, 564);
            this.Controls.Add(this.dateViConten);
            this.Controls.Add(this.query);
            this.Controls.Add(this.clare);
            this.Controls.Add(this.toExcel);
            this.Controls.Add(this.txtCont2);
            this.Controls.Add(this.txtCont3);
            this.Controls.Add(this.txtCont1);
            this.Controls.Add(this.combFile2);
            this.Controls.Add(this.combFile3);
            this.Controls.Add(this.combOper1);
            this.Controls.Add(this.combOper2);
            this.Controls.Add(this.combOper3);
            this.Controls.Add(this.combRel1);
            this.Controls.Add(this.combRel2);
            this.Controls.Add(this.combFile1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GroupStudentOnLineSum";
            this.Text = "学生上机统计";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GroupStudentOnLineSum_FormClosing);
            this.Load += new System.EventHandler(this.GroupStudentOnLineSum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateViConten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dateViConten;
        private System.Windows.Forms.Button query;
        private System.Windows.Forms.Button clare;
        private System.Windows.Forms.Button toExcel;
        private System.Windows.Forms.TextBox txtCont2;
        private System.Windows.Forms.TextBox txtCont3;
        private System.Windows.Forms.TextBox txtCont1;
        private System.Windows.Forms.ComboBox combFile2;
        private System.Windows.Forms.ComboBox combFile3;
        private System.Windows.Forms.ComboBox combOper1;
        private System.Windows.Forms.ComboBox combOper2;
        private System.Windows.Forms.ComboBox combOper3;
        private System.Windows.Forms.ComboBox combRel1;
        private System.Windows.Forms.ComboBox combRel2;
        private System.Windows.Forms.ComboBox combFile1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
    }
}