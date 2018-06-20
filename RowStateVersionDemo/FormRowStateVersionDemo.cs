using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RowStateVersionDemo
{
    public partial class FormRowStateVersionDemo : Form
    {
        public FormRowStateVersionDemo()
        {
            InitializeComponent();
        }

        static SqlConnection con = new SqlConnection
            ("Data Source=.;Initial Catalog=Northwind;Integrated Security=True;");
        DataSet dsInitializeData = new DataSet();
        SqlDataAdapter daInitializeData = new SqlDataAdapter("select * from Student", con);

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            this.TB_CurrentID.Text = TB_ID.Text;
            this.TB_CurrentName.Text = TB_Name.Text;
            this.TB_CurrentSex.Text = TB_Sex.Text;
            this.TB_CurrentAddress.Text = TB_Address.Text;
        }

        private void Btn_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow drNew = dsInitializeData.Tables["Student"].NewRow();
                drNew["ID"] = this.TB_ID.Text;
                drNew["Name"] = this.TB_Name.Text;
                drNew["Sex"] = this.TB_Sex.Text;
                drNew["Address"] = this.TB_Address.Text;
                dsInitializeData.Tables["Student"].Rows.Add(drNew);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            UpdateDisplay();
            //注意,在这事件里添加的数据只在本地DataSet,并没有更新到数据库
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow drCurrrentRow = GetRow();
                drCurrrentRow.Delete();
                this.BindingContext[this.dsInitializeData, "Student"].Position += 1;
                UpdateDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            DataRow drCurrrentRow = GetRow();
            drCurrrentRow["Name"] = "已改变";
            UpdateDisplay();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                this.daInitializeData.Update(this.dsInitializeData.Tables["Sudent"]);
                UpdateDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Command_Click(object sender, EventArgs e)
        {
            try
            {
                ////////////////////////////////有bug/////////////////////////////
                SqlCommand sqlCommandUpdate = this.daInitializeData.UpdateCommand;
                DataRow drCurrrentRow = GetRow();
                sqlCommandUpdate.Parameters["@ID"].Value = drCurrrentRow["ID"];
                sqlCommandUpdate.Parameters["@Name"].Value = drCurrrentRow["Name"];
                sqlCommandUpdate.Parameters["@Sex"].Value = drCurrrentRow["Sex"];
                sqlCommandUpdate.Parameters["@Address"].Value = drCurrrentRow["Address"];
                con.Open();
                sqlCommandUpdate.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Fill_Click(object sender, EventArgs e)
        {
            this.dsInitializeData.Tables["Student"].Clear();
            this.daInitializeData.Fill(dsInitializeData, "Student");
            UpdateDisplay();
        }

        private void Btn_Accept_Click(object sender, EventArgs e)
        {
            this.dsInitializeData.AcceptChanges();
            UpdateDisplay();
        }

        private void Btn_Refuse_Click(object sender, EventArgs e)
        {
            this.dsInitializeData.RejectChanges();
            UpdateDisplay();
        }

        private void Btn_Delay_Click(object sender, EventArgs e)
        {
            DataRow drCurrrentRow = GetRow();
            drCurrrentRow.BeginEdit();//开始编辑
            drCurrrentRow["Name"] = this.TB_Name.Text;//修改列名
            MessageBox.Show(drCurrrentRow["Name", DataRowVersion.Proposed].ToString());
            drCurrrentRow.CancelEdit();
        }

        private void Btn_First_Click(object sender, EventArgs e)
        {
            this.BindingContext[this.dsInitializeData, "Student"].Position = 0;
            UpdateDisplay();
        }

        private void Btn_Next_Click(object sender, EventArgs e)
        {
            this.BindingContext[this.dsInitializeData, "Student"].Position -= 1;
            UpdateDisplay();
        }

        private void Btn_Forward_Click(object sender, EventArgs e)
        {
            this.BindingContext[this.dsInitializeData, "Student"].Position += 1;
            UpdateDisplay();
        }

        private void Btn_Last_Click(object sender, EventArgs e)
        {
            this.BindingContext[this.dsInitializeData, "Student"].Position = this.BindingContext[this.dsInitializeData, "Student"].Count - 1;
            UpdateDisplay();
        }

        private DataRow GetRow()
        {
            System.Windows.Forms.BindingManagerBase bm = this.BindingContext[this.dsInitializeData, "Student"];
            DataRowView drvx = (System.Data.DataRowView)bm.Current;
            return drvx.Row;
            throw new NotImplementedException();
        }

        private void UpdateDisplay()
        {
            DataRow drv;
            drv = this.dsInitializeData.Tables["Student"].
                Rows[this.BindingContext[this.dsInitializeData, "Student"].Position];
            this.TB_CurrentID.Text = drv["ID"].ToString();
            this.TB_CurrentName.Text = drv["Name"].ToString();
            this.TB_CurrentSex.Text = drv["Sex"].ToString();
            this.TB_CurrentAddress.Text = drv["Address"].ToString();
            if (drv.HasVersion(DataRowVersion.Original))
            {
                this.TB_OriginalID.Text = drv["ID", DataRowVersion.Original].ToString();
                this.TB_OriginalName.Text = drv["Name", DataRowVersion.Original].ToString();
                this.TB_OriginalSex.Text = drv["Sex", DataRowVersion.Original].ToString();
                this.TB_OriginalAddress.Text = drv["Address", DataRowVersion.Original].ToString();
            }
            else
            {
                this.TB_OriginalID.Text = "";
                this.TB_OriginalName.Text = "";
                this.TB_OriginalSex.Text = "";
                this.TB_OriginalAddress.Text = "";
            }
            switch (drv.RowState)
            {
                case DataRowState.Added:
                    this.Rbtn_New.Checked = true;
                    break;
                case DataRowState.Modified:
                    this.Rbtn_Modified.Checked = true;
                    break;
                case DataRowState.Unchanged:
                    this.Rbtn_Unchanged.Checked = true;
                    break;
            }
            int crIndex = this.BindingContext[this.dsInitializeData, "Student"].Position + 1;
            this.TB_Position.Text = "Student " + crIndex.ToString() + " of " + this.BindingContext[this.dsInitializeData, "Student"].Count.ToString();
        }

        private void InitializeData()
        {
            try
            {
                daInitializeData.Fill(dsInitializeData, "Student");
                UpdateDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void FormRowStateVersionDemo_Load(object sender, EventArgs e)
        {
            InitializeData();
        }
    }
}
