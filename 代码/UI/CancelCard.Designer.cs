namespace UI
{
    partial class CancelCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelCard));
            this.txtCardno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCardno
            // 
            this.txtCardno.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCardno.Location = new System.Drawing.Point(94, 23);
            this.txtCardno.Name = "txtCardno";
            this.txtCardno.Size = new System.Drawing.Size(154, 30);
            this.txtCardno.TabIndex = 61;
            this.txtCardno.Text = "请输入卡号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(13, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 60;
            this.label3.Text = "卡号:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(51, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "卡号:";
            // 
            // OK
            // 
            this.OK.AutoSize = true;
            this.OK.BackColor = System.Drawing.Color.Transparent;
            this.OK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OK.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OK.Location = new System.Drawing.Point(229, 110);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(90, 34);
            this.OK.TabIndex = 69;
            this.OK.Text = "确认";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.UseWaitCursor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // CancelCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(329, 159);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCardno);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CancelCard";
            this.Text = "退卡";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CancelCard_FormClosing);
            this.Load += new System.EventHandler(this.CancelCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCardno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OK;
    }
}