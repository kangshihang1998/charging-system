namespace UI
{
    partial class ManIDcardno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManIDcardno));
            this.txtCardno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCardno
            // 
            this.txtCardno.Enabled = false;
            this.txtCardno.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCardno.Location = new System.Drawing.Point(129, 42);
            this.txtCardno.Name = "txtCardno";
            this.txtCardno.Size = new System.Drawing.Size(116, 30);
            this.txtCardno.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(24, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 103;
            this.label3.Text = "管理者ID:";
            // 
            // cmbSex
            // 
            this.cmbSex.Enabled = false;
            this.cmbSex.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Location = new System.Drawing.Point(337, 36);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(85, 28);
            this.cmbSex.TabIndex = 102;
            // 
            // txtNumber
            // 
            this.txtNumber.Enabled = false;
            this.txtNumber.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNumber.Location = new System.Drawing.Point(129, 93);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(144, 30);
            this.txtNumber.TabIndex = 95;
            // 
            // txtAge
            // 
            this.txtAge.Enabled = false;
            this.txtAge.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAge.Location = new System.Drawing.Point(369, 95);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(50, 30);
            this.txtAge.TabIndex = 94;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(56, 95);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 20);
            this.label14.TabIndex = 92;
            this.label14.Text = "手机号:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(282, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 20);
            this.label11.TabIndex = 91;
            this.label11.Text = "性别:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(314, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 90;
            this.label10.Text = "年龄:";
            // 
            // ManIDcardno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(442, 145);
            this.Controls.Add(this.txtCardno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSex);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManIDcardno";
            this.Text = "管理者信息";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManIDcardno_FormClosing);
            this.Load += new System.EventHandler(this.ManIDcardno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCardno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}