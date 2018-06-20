namespace CommandDemo
{
    partial class FormCommandDemo
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
            this.Btn_ExcProcedure = new System.Windows.Forms.Button();
            this.Btn_Exc = new System.Windows.Forms.Button();
            this.Btn_Count = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_ExcProcedure
            // 
            this.Btn_ExcProcedure.Location = new System.Drawing.Point(408, 248);
            this.Btn_ExcProcedure.Name = "Btn_ExcProcedure";
            this.Btn_ExcProcedure.Size = new System.Drawing.Size(160, 25);
            this.Btn_ExcProcedure.TabIndex = 5;
            this.Btn_ExcProcedure.Text = "执行存储过程DeleteOnLame";
            this.Btn_ExcProcedure.UseVisualStyleBackColor = true;
            this.Btn_ExcProcedure.Click += new System.EventHandler(this.Btn_ExcProcedure_Click);
            // 
            // Btn_Exc
            // 
            this.Btn_Exc.Location = new System.Drawing.Point(256, 247);
            this.Btn_Exc.Name = "Btn_Exc";
            this.Btn_Exc.Size = new System.Drawing.Size(125, 25);
            this.Btn_Exc.TabIndex = 4;
            this.Btn_Exc.Text = "执行带参数的SQL";
            this.Btn_Exc.UseVisualStyleBackColor = true;
            this.Btn_Exc.Click += new System.EventHandler(this.Btn_Exc_Click);
            // 
            // Btn_Count
            // 
            this.Btn_Count.Location = new System.Drawing.Point(160, 247);
            this.Btn_Count.Name = "Btn_Count";
            this.Btn_Count.Size = new System.Drawing.Size(75, 25);
            this.Btn_Count.TabIndex = 3;
            this.Btn_Count.Text = "计算";
            this.Btn_Count.UseVisualStyleBackColor = true;
            this.Btn_Count.Click += new System.EventHandler(this.Btn_Count_Click);
            // 
            // FormCommandDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Btn_ExcProcedure);
            this.Controls.Add(this.Btn_Exc);
            this.Controls.Add(this.Btn_Count);
            this.Name = "FormCommandDemo";
            this.Text = "CommandDemo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_ExcProcedure;
        private System.Windows.Forms.Button Btn_Exc;
        private System.Windows.Forms.Button Btn_Count;
    }
}

