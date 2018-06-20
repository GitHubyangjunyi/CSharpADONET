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

namespace DataSetDemo
{
    public partial class FormDataSetDemo : Form
    {
        public FormDataSetDemo()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True;");

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            this.ListBox_DataSetDemo.Items.Clear();
            this.ListBox_DataSetDemoTwo.Items.Clear();
            this.ListBox_DataSetDemoCurrent.Items.Clear();
        }


        private void FormDataSetDemo_Load(object sender, EventArgs e)
        {
            //运行库生成模式如下
            SqlDataAdapter sqlDataAdapterDataSetDemo = new SqlDataAdapter("select CompanyName from Customers", con);
            DataSet dataSet = new DataSet();
            sqlDataAdapterDataSetDemo.Fill(dataSet, "Customers");
            foreach (DataRow row in dataSet.Tables["Customers"].Rows)
            {
                this.ListBox_DataSetDemo.Items.Add(row[0]);
            }
            dataSet.Tables["Customers"].Rows.Add("xxxxxxxx");
            foreach (DataRow row in dataSet.Tables["Customers"].Rows)
            {
                foreach (DataColumn col in dataSet.Tables["Customers"].Columns)
                {
                    this.ListBox_DataSetDemoTwo.Items.Add(row[col, DataRowVersion.Default]);
                }
                foreach (DataColumn col in dataSet.Tables["Customers"].Columns)
                {
                    this.ListBox_DataSetDemoCurrent.Items.Add(row[col, DataRowVersion.Current]);
                }
            }
        }

        private void Btn_Fill_Click(object sender, EventArgs e)
        {
            //手工编码方式创建表
            DataTable products = new DataTable("Products");//实例化表表名Products
            products.Columns.Add(new DataColumn("ProductID", typeof(int)));
            products.Columns.Add(new DataColumn("ProductName", typeof(string)));
            products.Columns.Add(new DataColumn("SupplierID", typeof(int)));
            products.Columns.Add(new DataColumn("CategoryID", typeof(int)));
            products.Columns.Add(new DataColumn("QuantityPerUnit", typeof(string)));
            products.Columns.Add(new DataColumn("UnitPrice", typeof(decimal)));
            products.Columns.Add(new DataColumn("UnitsInStock", typeof(short)));
            products.Columns.Add(new DataColumn("UnitsOnOrder", typeof(short)));
            products.Columns.Add(new DataColumn("ReorderLevel", typeof(short)));
            products.Columns.Add(new DataColumn("Discontinued", typeof(bool)));
            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(products);
            SqlDataAdapter sqlDataAdapterDataSetDemo = new SqlDataAdapter("select * from Products", con);
            //ManufactureProductDataTable(dataSet);//???
            sqlDataAdapterDataSetDemo.Fill(dataSet, "Products");
            this.ListBox_DataSetDemo.Items.Clear();
            this.ListBox_DataSetDemoTwo.Items.Clear();
            this.ListBox_DataSetDemoCurrent.Items.Clear();
            foreach (DataRow row in dataSet.Tables["Products"].Rows)
            {
                this.ListBox_DataSetDemo.Items.Add(row[0]);
                this.ListBox_DataSetDemoTwo.Items.Add(row[0]);
                this.ListBox_DataSetDemoCurrent.Items.Add(row[0]);
            }
        }
    }
}
//DataSet是数据的脱机容器,用来临时存储数据的仓库
//|-------------DataSet-------------|
//|                                 |
//|  |----DataTableCollection----|  |
//|  |                           |  |
//|  | |------DataTable-------|  |  |
//|  | |                      |  |  |
//|  | |  _________________   |  |  |
//|  | | |DataRowCollection|  |  |  |
//|  | | |_________________|  |  |  |
//|  | |  _________________   |  |  |
//|  | | |DataColumnCollection|  |  |
//|  | | |_________________|  |  |  |
//|  | |  _________________   |  |  |
//|  | | |ConstraintCollection|  |  |
//|  | | |_________________|  |  |  |
//|  | |______________________|  |  |
//|  |                           |  |
//|  |___________________________|  |
//|                                 |
//|     DataRelationCollection      |
//|_________________________________|
//DataRow有版本功能,可以接收某一行上指定列的各个值
//1.Current     列中目前存在的值,如果没有进行编辑,该值与初始值相同,如果编辑了,该值就是最后输入的一个有效值
//2.Default     列的任何默认设置值
//3.Original    最初从数据库中选择出来的列值,如果调用了DataRow的AcceptChange方法,该值就更新为Current值
//4.Proposed    对列进行修改时可以检索到这个已改变的值,如果在行上调用了BeginEdit方法,并进行了修改
//              每一列都会有一个推荐值,直到调用了EndEdit或CancelEdit方法
//要从DataRow索引器中检索某个版本的值,应使用索引器的方法,把DataRowVersion值作为一个参考
//整个数据行有一个状态标志RowState,可以用于确定在返回数据库时需要对改行进行什么操作
//RowState标志跟踪对DataTable所作的所有改变
//当数据与数据库同步时,行状态标志用于确定应执行什么样的SQL操作,这些标志由DataRowState枚举定义
//1.Added       把数据行添加到DataTable的Rows集合中,在客户机创建的所有行都设置为这个值,最终在与数据库同步时会使用SQL INSERT语句
//2.Deleted     通过DataRow.Delete方法把DataTable中的数据行标记为删除,但是改行依然存在于DataTable中,在DataTable中标记为删除的数据行将在与数据库同步时从数据库中删除
//3.Detached    数据行在创建后立即显示为这个状态,调用DataRow.Remove也可以返回这个状态
//              分立的行不是任何DataTable的一部分,因此处于这种状态的行不能使用任何SQL语句
//4.Modified    如果列中的值发生了改变,数据行就处于这种状态
//5.UnChanged   自从最后一次调用AcceptChanges以来,数据行都没有发生改变
//行的状态也取决于在其上调用的方法,一般在成功更新数据源,即把改变返回数据库之后调用AcceptChanges
//修改DataRow中数据最常见的方式是使用索引器,但是如果对数据进行了许多修改,就要考虑使用BeginEdit或EndEdit方法
//在对DataRow中的列进行修改后,就会在行的DataTable上引发ColumnChanging事件
//可以重写DataColumnChangeEventArgs类的ProposedValue属性,按照需要修改它,这是在列值上进行某些数据有效性验证的一种方式
//如果在修改前调用BeginEdit方法,就不会引发ColumnChanging事件,于是可以进行多次修改,再调用EndEdit方法,保存修改
//如果要退回到初值,调用CancelEdit方法DataRow可以以某种方式链接到其他数据行上,在数据行之间能够建立可导航的链接
//这在主从数据表中比较常见,DataRow包含了一个GetChildRows方法,可以从同一个DataSet的另一个表中把一组相关行返回为当前行
//
//模式的生成
//为DataTable创建模式有3种方法
//1.让运行库完成      优点方便,缺点是必须利用默认列名来处理(但也可以在SQL中指定别名)
//                    自动生成的DataTable/DataColumn潜在问题是不能控制运行库为列选择的数据类型
//                    运行库可以确定正确的数据类型,但有时候需要对此有更多的控制
//                    例如为给定的列定义枚举类型以简化类的用户代码
//                    如果接受运行库生成的默认列类型,该列就可能是32位整数而不是有预定选项的枚举类型
//                    还有就是使用自动生成的表,不能对DataTable中的数据进行类型安全的访问
//                    因为索引器会返回object的实例,而不是派生的数据类型
//2.编写代码创建表    用生成的代码创建DataTable再用相关的DataColumn来填充
//3.使用XML模式生成器