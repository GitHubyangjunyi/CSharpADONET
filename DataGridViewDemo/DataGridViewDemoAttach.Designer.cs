namespace DataGridViewDemo
{
    partial class DataGridViewDemoAttach
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
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.DTP = new System.Windows.Forms.DateTimePicker();
            this.TB_Country = new System.Windows.Forms.TextBox();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.TB_XS = new System.Windows.Forms.TextBox();
            this.L_Birth = new System.Windows.Forms.Label();
            this.L_Country = new System.Windows.Forms.Label();
            this.L_Name = new System.Windows.Forms.Label();
            this.L_XS = new System.Windows.Forms.Label();
            this.L_EmployeeID = new System.Windows.Forms.Label();
            this.L_ID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(417, 467);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 23;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(281, 467);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(75, 23);
            this.Btn_Save.TabIndex = 22;
            this.Btn_Save.Text = "保存";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // DTP
            // 
            this.DTP.Location = new System.Drawing.Point(342, 352);
            this.DTP.Name = "DTP";
            this.DTP.Size = new System.Drawing.Size(200, 21);
            this.DTP.TabIndex = 21;
            // 
            // TB_Country
            // 
            this.TB_Country.Location = new System.Drawing.Point(378, 273);
            this.TB_Country.Name = "TB_Country";
            this.TB_Country.Size = new System.Drawing.Size(100, 21);
            this.TB_Country.TabIndex = 20;
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(378, 203);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(100, 21);
            this.TB_Name.TabIndex = 19;
            // 
            // TB_XS
            // 
            this.TB_XS.Location = new System.Drawing.Point(378, 127);
            this.TB_XS.Name = "TB_XS";
            this.TB_XS.Size = new System.Drawing.Size(100, 21);
            this.TB_XS.TabIndex = 18;
            // 
            // L_Birth
            // 
            this.L_Birth.AutoSize = true;
            this.L_Birth.Location = new System.Drawing.Point(267, 358);
            this.L_Birth.Name = "L_Birth";
            this.L_Birth.Size = new System.Drawing.Size(59, 12);
            this.L_Birth.TabIndex = 17;
            this.L_Birth.Text = "出生日期:";
            // 
            // L_Country
            // 
            this.L_Country.AutoSize = true;
            this.L_Country.Location = new System.Drawing.Point(279, 282);
            this.L_Country.Name = "L_Country";
            this.L_Country.Size = new System.Drawing.Size(35, 12);
            this.L_Country.TabIndex = 16;
            this.L_Country.Text = "国家:";
            // 
            // L_Name
            // 
            this.L_Name.AutoSize = true;
            this.L_Name.Location = new System.Drawing.Point(279, 206);
            this.L_Name.Name = "L_Name";
            this.L_Name.Size = new System.Drawing.Size(35, 12);
            this.L_Name.TabIndex = 15;
            this.L_Name.Text = "名字:";
            // 
            // L_XS
            // 
            this.L_XS.AutoSize = true;
            this.L_XS.Location = new System.Drawing.Point(279, 130);
            this.L_XS.Name = "L_XS";
            this.L_XS.Size = new System.Drawing.Size(35, 12);
            this.L_XS.TabIndex = 14;
            this.L_XS.Text = "姓氏:";
            // 
            // L_EmployeeID
            // 
            this.L_EmployeeID.AutoSize = true;
            this.L_EmployeeID.Location = new System.Drawing.Point(415, 54);
            this.L_EmployeeID.Name = "L_EmployeeID";
            this.L_EmployeeID.Size = new System.Drawing.Size(17, 12);
            this.L_EmployeeID.TabIndex = 13;
            this.L_EmployeeID.Text = "ID";
            // 
            // L_ID
            // 
            this.L_ID.AutoSize = true;
            this.L_ID.Location = new System.Drawing.Point(267, 54);
            this.L_ID.Name = "L_ID";
            this.L_ID.Size = new System.Drawing.Size(59, 12);
            this.L_ID.TabIndex = 12;
            this.L_ID.Text = "雇员编号:";
            // 
            // DataGridViewDemoAttach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.DTP);
            this.Controls.Add(this.TB_Country);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.TB_XS);
            this.Controls.Add(this.L_Birth);
            this.Controls.Add(this.L_Country);
            this.Controls.Add(this.L_Name);
            this.Controls.Add(this.L_XS);
            this.Controls.Add(this.L_EmployeeID);
            this.Controls.Add(this.L_ID);
            this.Name = "DataGridViewDemoAttach";
            this.Text = "DataGridViewDemoAttach";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.DateTimePicker DTP;
        private System.Windows.Forms.TextBox TB_Country;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.TextBox TB_XS;
        private System.Windows.Forms.Label L_Birth;
        private System.Windows.Forms.Label L_Country;
        private System.Windows.Forms.Label L_Name;
        private System.Windows.Forms.Label L_XS;
        private System.Windows.Forms.Label L_EmployeeID;
        private System.Windows.Forms.Label L_ID;
    }
}