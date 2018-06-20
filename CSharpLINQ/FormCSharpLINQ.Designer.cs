namespace CSharpLINQ
{
    partial class FormCSharpLINQ
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
            this.CB_UserName = new System.Windows.Forms.ComboBox();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.TB_PWD = new System.Windows.Forms.TextBox();
            this.Lable_One = new System.Windows.Forms.Label();
            this.Btn_Select = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Insert = new System.Windows.Forms.Button();
            this.DGV_Show = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Show)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_UserName
            // 
            this.CB_UserName.FormattingEnabled = true;
            this.CB_UserName.Location = new System.Drawing.Point(338, 32);
            this.CB_UserName.Margin = new System.Windows.Forms.Padding(2);
            this.CB_UserName.Name = "CB_UserName";
            this.CB_UserName.Size = new System.Drawing.Size(100, 20);
            this.CB_UserName.TabIndex = 18;
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(339, 76);
            this.TB_Name.Margin = new System.Windows.Forms.Padding(2);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(100, 21);
            this.TB_Name.TabIndex = 17;
            // 
            // TB_PWD
            // 
            this.TB_PWD.Location = new System.Drawing.Point(339, 54);
            this.TB_PWD.Margin = new System.Windows.Forms.Padding(2);
            this.TB_PWD.Name = "TB_PWD";
            this.TB_PWD.Size = new System.Drawing.Size(100, 21);
            this.TB_PWD.TabIndex = 16;
            // 
            // Lable_One
            // 
            this.Lable_One.AutoSize = true;
            this.Lable_One.Location = new System.Drawing.Point(276, 35);
            this.Lable_One.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lable_One.Name = "Lable_One";
            this.Lable_One.Size = new System.Drawing.Size(59, 60);
            this.Lable_One.TabIndex = 15;
            this.Lable_One.Text = "用户名:\r\n\r\n密码:\r\n\r\n真实姓名:";
            // 
            // Btn_Select
            // 
            this.Btn_Select.Location = new System.Drawing.Point(491, 164);
            this.Btn_Select.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Select.Name = "Btn_Select";
            this.Btn_Select.Size = new System.Drawing.Size(75, 25);
            this.Btn_Select.TabIndex = 14;
            this.Btn_Select.Text = "查询";
            this.Btn_Select.UseVisualStyleBackColor = true;
            this.Btn_Select.Click += new System.EventHandler(this.Btn_Select_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Location = new System.Drawing.Point(416, 164);
            this.Btn_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(75, 25);
            this.Btn_Delete.TabIndex = 13;
            this.Btn_Delete.Text = "删除";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.Location = new System.Drawing.Point(341, 164);
            this.Btn_Update.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(75, 25);
            this.Btn_Update.TabIndex = 12;
            this.Btn_Update.Text = "修改";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Insert
            // 
            this.Btn_Insert.Location = new System.Drawing.Point(266, 164);
            this.Btn_Insert.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Insert.Name = "Btn_Insert";
            this.Btn_Insert.Size = new System.Drawing.Size(75, 25);
            this.Btn_Insert.TabIndex = 11;
            this.Btn_Insert.Text = "增加";
            this.Btn_Insert.UseVisualStyleBackColor = true;
            this.Btn_Insert.Click += new System.EventHandler(this.Btn_Insert_Click);
            // 
            // DGV_Show
            // 
            this.DGV_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Show.Location = new System.Drawing.Point(11, 11);
            this.DGV_Show.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_Show.Name = "DGV_Show";
            this.DGV_Show.RowTemplate.Height = 30;
            this.DGV_Show.Size = new System.Drawing.Size(233, 200);
            this.DGV_Show.TabIndex = 10;
            // 
            // FormCSharpLINQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.CB_UserName);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.TB_PWD);
            this.Controls.Add(this.Lable_One);
            this.Controls.Add(this.Btn_Select);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Btn_Insert);
            this.Controls.Add(this.DGV_Show);
            this.Name = "FormCSharpLINQ";
            this.Text = "CSharpLINQ";
            this.Load += new System.EventHandler(this.FormCSharpLINQ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_UserName;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.TextBox TB_PWD;
        private System.Windows.Forms.Label Lable_One;
        private System.Windows.Forms.Button Btn_Select;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Insert;
        private System.Windows.Forms.DataGridView DGV_Show;
    }
}

