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

namespace DataReaderDemo
{
    public partial class FormDataReaderDemo : Form
    {
        public FormDataReaderDemo()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=pubs;Integrated Security=True;");

        private void Btn_Show_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand sqlCommandShow = new SqlCommand
            {
                CommandText = "select au_fname from authors",
                Connection = con
            };
            SqlDataReader sqlDataReaderShow = sqlCommandShow.ExecuteReader();//创建一个SqlDataReader对象并将sqlCommandShow.ExecuteReader()执行返回的结果给它
            ListBox_Show.Items.Clear();//加载前先清空
            while (sqlDataReaderShow.Read())//sqlDataReaderShow.Read()返回假时说明记录的指针已经指向末尾,否则指向下一个记录并显示
            {
                ListBox_Show.Items.Add(sqlDataReaderShow.GetString(0));
            }
            sqlDataReaderShow.Close();
            con.Close();
        }

        private void Btn_Exc_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand sqlCommandExcTwo = new SqlCommand
            {
                CommandText = "selectFromTwoTable",
                Connection = con,
                CommandType = CommandType.StoredProcedure
            };
            SqlDataReader sqlDataReaderExcTwo = sqlCommandExcTwo.ExecuteReader();//创建一个SqlDataReader对象并将sqlCommandShow.ExecuteReader()执行返回的结果给它
            ListBox_Show.Items.Clear();//加载前先清空
            while (sqlDataReaderExcTwo.Read())//sqlDataReaderShow.Read()返回假时说明记录的指针已经指向末尾,否则指向下一个记录并显示
            {
                ListBox_Show.Items.Add(sqlDataReaderExcTwo.GetString(0));
            }
            sqlDataReaderExcTwo.NextResult();//切换到下一个数据集
            ListBox_ShowTwo.Items.Clear();//加载前先清空
            while (sqlDataReaderExcTwo.Read())//sqlDataReaderShow.Read()返回假时说明记录的指针已经指向末尾,否则指向下一个记录并显示
            {
                ListBox_ShowTwo.Items.Add(sqlDataReaderExcTwo.GetString(0));
            }
            sqlDataReaderExcTwo.Close();
            con.Close();
        }
    }
}