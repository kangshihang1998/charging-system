namespace UI
{
    partial class ReCheckDay
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReCheckDay));
            this.RecheckBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new UI.DataSet1();
            this.RechecWeekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet2 = new UI.DataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RecheckTableAdapter = new UI.DataSet1TableAdapters.RecheckTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RechecWeekTableAdapter = new UI.DataSet2TableAdapters.RechecWeekTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RecheckBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RechecWeekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // RecheckBindingSource
            // 
            this.RecheckBindingSource.DataMember = "Recheck";
            this.RecheckBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RechecWeekBindingSource
            // 
            this.RechecWeekBindingSource.DataMember = "RechecWeek";
            this.RechecWeekBindingSource.DataSource = this.DataSet2;
            // 
            // DataSet2
            // 
            this.DataSet2.DataSetName = "DataState";
            this.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.RecheckBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UI.ReCheckDay.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 58);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(843, 480);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // RecheckTableAdapter
            // 
            this.RecheckTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(29, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "当前日期:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(128, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 56;
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.Color.Transparent;
            this.OK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OK.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OK.Location = new System.Drawing.Point(765, 15);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(90, 34);
            this.OK.TabIndex = 57;
            this.OK.Text = "周报表";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.UseWaitCursor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(710, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 58;
            this.label2.Text = "返回";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.RechecWeekBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "UI.ReCheckWeekDay.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(12, 58);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(843, 480);
            this.reportViewer2.TabIndex = 59;
            this.reportViewer2.Visible = false;
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(183, 24);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 21);
            this.dateStart.TabIndex = 60;
            this.dateStart.Visible = false;
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(504, 24);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 21);
            this.dateEnd.TabIndex = 61;
            this.dateEnd.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(389, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 62;
            this.label4.Text = "结束日期：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(78, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 63;
            this.label5.Text = "开始日期:";
            this.label5.Visible = false;
            // 
            // RechecWeekTableAdapter
            // 
            this.RechecWeekTableAdapter.ClearBeforeFill = true;
            // 
            // ReCheckDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(867, 550);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReCheckDay";
            this.Text = " 日报表";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReCheckDay_FormClosing);
            this.Load += new System.EventHandler(this.ReCheckDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RecheckBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RechecWeekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RecheckBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.RecheckTableAdapter RecheckTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private DataSet2 DataSet2;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource RechecWeekBindingSource;
        private DataSet2TableAdapters.RechecWeekTableAdapter RechecWeekTableAdapter;
    }
}