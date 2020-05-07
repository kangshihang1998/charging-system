namespace UI
{
    partial class StudentPwdOpertion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentPwdOpertion));
            this.txtNewPwdOk = new System.Windows.Forms.TextBox();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.txtCardno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNewPwdOk
            // 
            this.txtNewPwdOk.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtNewPwdOk.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNewPwdOk.Location = new System.Drawing.Point(72, 144);
            this.txtNewPwdOk.Name = "txtNewPwdOk";
            this.txtNewPwdOk.Size = new System.Drawing.Size(232, 35);
            this.txtNewPwdOk.TabIndex = 14;
            this.txtNewPwdOk.UseWaitCursor = true;
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtNewPwd.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNewPwd.Location = new System.Drawing.Point(73, 88);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.Size = new System.Drawing.Size(231, 35);
            this.txtNewPwd.TabIndex = 13;
            this.txtNewPwd.UseWaitCursor = true;
            // 
            // txtCardno
            // 
            this.txtCardno.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtCardno.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCardno.Location = new System.Drawing.Point(72, 38);
            this.txtCardno.Name = "txtCardno";
            this.txtCardno.Size = new System.Drawing.Size(231, 35);
            this.txtCardno.TabIndex = 12;
            this.txtCardno.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(1, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "确认密码：";
            this.label3.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(3, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "新密码：";
            this.label2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(1, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "卡号：";
            this.label1.UseWaitCursor = true;
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.Color.Transparent;
            this.OK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OK.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OK.Location = new System.Drawing.Point(214, 198);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(90, 34);
            this.OK.TabIndex = 8;
            this.OK.Text = "修改";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.UseWaitCursor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // StudentPwdOpertion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(306, 242);
            this.Controls.Add(this.txtNewPwdOk);
            this.Controls.Add(this.txtNewPwd);
            this.Controls.Add(this.txtCardno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StudentPwdOpertion";
            this.Text = "重置密码";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentPwdOpertion_FormClosing);
            this.Load += new System.EventHandler(this.StudentPwdOpertion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewPwdOk;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.TextBox txtCardno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OK;
    }
}