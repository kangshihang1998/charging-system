namespace UI
{
    partial class ResutUserPwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResutUserPwd));
            this.OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOldPwd = new System.Windows.Forms.TextBox();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.txtNewPwdOk = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.Color.Transparent;
            this.OK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OK.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OK.Location = new System.Drawing.Point(223, 172);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(90, 34);
            this.OK.TabIndex = 1;
            this.OK.Text = "修改";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.UseWaitCursor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "旧密码：";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "新密码：";
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(10, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "确认密码：";
            this.label3.UseWaitCursor = true;
            // 
            // txtOldPwd
            // 
            this.txtOldPwd.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtOldPwd.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOldPwd.Location = new System.Drawing.Point(81, 12);
            this.txtOldPwd.Name = "txtOldPwd";
            this.txtOldPwd.Size = new System.Drawing.Size(231, 35);
            this.txtOldPwd.TabIndex = 5;
            this.txtOldPwd.UseWaitCursor = true;
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtNewPwd.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNewPwd.Location = new System.Drawing.Point(82, 62);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.Size = new System.Drawing.Size(231, 35);
            this.txtNewPwd.TabIndex = 6;
            this.txtNewPwd.UseWaitCursor = true;
            // 
            // txtNewPwdOk
            // 
            this.txtNewPwdOk.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtNewPwdOk.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNewPwdOk.Location = new System.Drawing.Point(81, 118);
            this.txtNewPwdOk.Name = "txtNewPwdOk";
            this.txtNewPwdOk.Size = new System.Drawing.Size(232, 35);
            this.txtNewPwdOk.TabIndex = 7;
            this.txtNewPwdOk.UseWaitCursor = true;
            // 
            // ResutUserPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(322, 218);
            this.Controls.Add(this.txtNewPwdOk);
            this.Controls.Add(this.txtNewPwd);
            this.Controls.Add(this.txtOldPwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResutUserPwd";
            this.Text = "重置用户密码";
            this.UseWaitCursor = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResutUserPwd_FormClosing);
            this.Load += new System.EventHandler(this.ResutUserPwd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOldPwd;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.TextBox txtNewPwdOk;
    }
}