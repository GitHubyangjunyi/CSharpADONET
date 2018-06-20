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

namespace CommandDemo
{
    public partial class FormCommandDemo : Form
    {
        public FormCommandDemo()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=pubs;Integrated Security=True;");

        private void Btn_Count_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand sqlCommandCount = new SqlCommand
            {
                CommandText = "select AVG(price) from titles",
                Connection = con
            };
            double result = Convert.ToDouble(sqlCommandCount.ExecuteScalar());
            MessageBox.Show(result.ToString());
            con.Close();
        }

        private void Btn_Exc_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand sqlCommandExc = new SqlCommand
            {
                CommandText = "select AVG(price) from titles where type=@type",
                Connection = con
            };
            SqlParameter sqlParameterExc = new SqlParameter
            {
                ParameterName = "@type",
                SqlDbType = SqlDbType.VarChar,
                Value = "business"
            };
            sqlCommandExc.Parameters.Add(sqlParameterExc);
            double result = Convert.ToDouble(sqlCommandExc.ExecuteScalar());
            MessageBox.Show(result.ToString());
            con.Close();
        }

        private void Btn_ExcProcedure_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand sqlCommandExcProcedure = new SqlCommand
            {
                CommandText = "DeleteOnLname",
                Connection = con,
                CommandType = CommandType.StoredProcedure
            };
            SqlParameter sqlParameterExcProcedure = new SqlParameter
            {
                ParameterName = "@Lname",
                SqlDbType = SqlDbType.VarChar,
                Value = "xxxx"
            };
            sqlCommandExcProcedure.Parameters.Add(sqlParameterExcProcedure);
            double result = Convert.ToDouble(sqlCommandExcProcedure.ExecuteScalar());
            MessageBox.Show(result.ToString() + "行被删除!");
            con.Close();
        }
    }
}
//存储过程DeleteOnLname
//--create procedure DeleteOnLname--匹配名字删除
//--(
//--	@lname varchar(40)
//--)
//--as
//--delete from employee where lname=@lname
//--return