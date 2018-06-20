namespace DataReaderDemo
{
    partial class FormDataReaderDemo
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
            this.Btn_Exc = new System.Windows.Forms.Button();
            this.ListBox_ShowTwo = new System.Windows.Forms.ListBox();
            this.Btn_Show = new System.Windows.Forms.Button();
            this.ListBox_Show = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Btn_Exc
            // 
            this.Btn_Exc.Location = new System.Drawing.Point(200, 418);
            this.Btn_Exc.Name = "Btn_Exc";
            this.Btn_Exc.Size = new System.Drawing.Size(180, 40);
            this.Btn_Exc.TabIndex = 7;
            this.Btn_Exc.Text = "执行两个select的存储过程";
            this.Btn_Exc.UseVisualStyleBackColor = true;
            this.Btn_Exc.Click += new System.EventHandler(this.Btn_Exc_Click);
            // 
            // ListBox_ShowTwo
            // 
            this.ListBox_ShowTwo.FormattingEnabled = true;
            this.ListBox_ShowTwo.ItemHeight = 12;
            this.ListBox_ShowTwo.Location = new System.Drawing.Point(200, 12);
            this.ListBox_ShowTwo.Name = "ListBox_ShowTwo";
            this.ListBox_ShowTwo.Size = new System.Drawing.Size(150, 400);
            this.ListBox_ShowTwo.TabIndex = 6;
            // 
            // Btn_Show
            // 
            this.Btn_Show.Location = new System.Drawing.Point(12, 418);
            this.Btn_Show.Name = "Btn_Show";
            this.Btn_Show.Size = new System.Drawing.Size(180, 40);
            this.Btn_Show.TabIndex = 5;
            this.Btn_Show.Text = "显示pubs数据库中Authors表中读者的姓名到ListBox_Show中";
            this.Btn_Show.UseVisualStyleBackColor = true;
            this.Btn_Show.Click += new System.EventHandler(this.Btn_Show_Click);
            // 
            // ListBox_Show
            // 
            this.ListBox_Show.FormattingEnabled = true;
            this.ListBox_Show.ItemHeight = 12;
            this.ListBox_Show.Location = new System.Drawing.Point(12, 12);
            this.ListBox_Show.Name = "ListBox_Show";
            this.ListBox_Show.Size = new System.Drawing.Size(150, 400);
            this.ListBox_Show.TabIndex = 4;
            // 
            // FormDataReaderDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Btn_Exc);
            this.Controls.Add(this.ListBox_ShowTwo);
            this.Controls.Add(this.Btn_Show);
            this.Controls.Add(this.ListBox_Show);
            this.Name = "FormDataReaderDemo";
            this.Text = "DataReaderDemo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Exc;
        private System.Windows.Forms.ListBox ListBox_ShowTwo;
        private System.Windows.Forms.Button Btn_Show;
        private System.Windows.Forms.ListBox ListBox_Show;
    }
}

