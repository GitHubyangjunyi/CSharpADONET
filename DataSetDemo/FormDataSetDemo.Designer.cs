namespace DataSetDemo
{
    partial class FormDataSetDemo
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Fill = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.ListBox_DataSetDemoCurrent = new System.Windows.Forms.ListBox();
            this.ListBox_DataSetDemoTwo = new System.Windows.Forms.ListBox();
            this.ListBox_DataSetDemo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Btn_Fill
            // 
            this.Btn_Fill.Location = new System.Drawing.Point(204, 455);
            this.Btn_Fill.Name = "Btn_Fill";
            this.Btn_Fill.Size = new System.Drawing.Size(115, 25);
            this.Btn_Fill.TabIndex = 9;
            this.Btn_Fill.Text = "手工编码方式填充";
            this.Btn_Fill.UseVisualStyleBackColor = true;
            this.Btn_Fill.Click += new System.EventHandler(this.Btn_Fill_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Location = new System.Drawing.Point(63, 453);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(75, 25);
            this.Btn_Clear.TabIndex = 8;
            this.Btn_Clear.Text = "清空";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // ListBox_DataSetDemoCurrent
            // 
            this.ListBox_DataSetDemoCurrent.FormattingEnabled = true;
            this.ListBox_DataSetDemoCurrent.ItemHeight = 12;
            this.ListBox_DataSetDemoCurrent.Location = new System.Drawing.Point(600, 11);
            this.ListBox_DataSetDemoCurrent.Margin = new System.Windows.Forms.Padding(2);
            this.ListBox_DataSetDemoCurrent.Name = "ListBox_DataSetDemoCurrent";
            this.ListBox_DataSetDemoCurrent.Size = new System.Drawing.Size(268, 400);
            this.ListBox_DataSetDemoCurrent.TabIndex = 7;
            // 
            // ListBox_DataSetDemoTwo
            // 
            this.ListBox_DataSetDemoTwo.FormattingEnabled = true;
            this.ListBox_DataSetDemoTwo.ItemHeight = 12;
            this.ListBox_DataSetDemoTwo.Location = new System.Drawing.Point(307, 11);
            this.ListBox_DataSetDemoTwo.Margin = new System.Windows.Forms.Padding(2);
            this.ListBox_DataSetDemoTwo.Name = "ListBox_DataSetDemoTwo";
            this.ListBox_DataSetDemoTwo.Size = new System.Drawing.Size(268, 400);
            this.ListBox_DataSetDemoTwo.TabIndex = 6;
            // 
            // ListBox_DataSetDemo
            // 
            this.ListBox_DataSetDemo.FormattingEnabled = true;
            this.ListBox_DataSetDemo.ItemHeight = 12;
            this.ListBox_DataSetDemo.Location = new System.Drawing.Point(11, 11);
            this.ListBox_DataSetDemo.Margin = new System.Windows.Forms.Padding(2);
            this.ListBox_DataSetDemo.Name = "ListBox_DataSetDemo";
            this.ListBox_DataSetDemo.Size = new System.Drawing.Size(268, 400);
            this.ListBox_DataSetDemo.TabIndex = 5;
            // 
            // FormDataSetDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.Btn_Fill);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.ListBox_DataSetDemoCurrent);
            this.Controls.Add(this.ListBox_DataSetDemoTwo);
            this.Controls.Add(this.ListBox_DataSetDemo);
            this.Name = "FormDataSetDemo";
            this.Text = "DataSetDemo";
            this.Load += new System.EventHandler(this.FormDataSetDemo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Fill;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.ListBox ListBox_DataSetDemoCurrent;
        private System.Windows.Forms.ListBox ListBox_DataSetDemoTwo;
        private System.Windows.Forms.ListBox ListBox_DataSetDemo;
    }
}

