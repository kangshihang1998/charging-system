namespace UI
{
    partial class Recharge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recharge));
            this.txtCardno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCardno
            // 
            this.txtCardno.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCardno.Location = new System.Drawing.Point(113, 43);
            this.txtCardno.Name = "txtCardno";
            this.txtCardno.Size = new System.Drawing.Size(154, 30);
            this.txtCardno.TabIndex = 55;
            this.txtCardno.Text = "请输入数字";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(32, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 54;
            this.label3.Text = "卡号:";
            // 
            // txtCash
            // 
            this.txtCash.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCash.Location = new System.Drawing.Point(113, 112);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(154, 30);
            this.txtCash.TabIndex = 57;
            this.txtCash.Text = "请输入充值金额";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(32, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "金额:";
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.Color.Transparent;
            this.OK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OK.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OK.Location = new System.Drawing.Point(219, 208);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(90, 34);
            this.OK.TabIndex = 58;
            this.OK.Text = "确认";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.UseWaitCursor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Recharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(311, 245);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCardno);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Recharge";
            this.Text = "充值窗体";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Recharge_FormClosing);
            this.Load += new System.EventHandler(this.Recharge_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCardno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OK;
    }
}