using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewDemo
{
    public partial class FormDataGridViewDemo : Form
    {
        public FormDataGridViewDemo()
        {
            InitializeComponent();
        }
    }
}
//DataTable对象用来表示DataSet中的表,一个DataTable表示内存中的关系数据的一个表
//数据对于它所驻留的.NET应用程序是本地的,但它不能用现有的数据源填充
//在DataTable中不能直接创建新行而是必须单独创建DataRow对象,并添加到DataTable的Rows集合中
//若要向DataTable添加一个新行,首先要声明一个DataRow类型的变量
//当前调用NewRow根据DataColumnCollection定义的表的结构来创建DataRow对象
//向DataTable添加了新行之后可以使用索引或列名操作新行
//在数据插入到新行后,使用Add方法将该行添加到DataRowCollection中
//1.DataRow对象是什么？
//解答：DataTable中的每一行都是通过DataRow对象呈现的，DataRow对象主要作为DataTable对象的Rows集合的一个元素而存在
//从概念上看数据库行固有的链接到了某个给定表的结构,行与Rows集合的关系决定了该行的状态,行的状态信息存储在DataRow对象的RowState属性中
//2.RowState和RowVersion属性有什么不同？
//解答：RowState属性的值表示自从第一次创建DataTable或从数据库加载DataTable开始是否更改行/如何更改行以及以何种方法更改行
//当使用Item属性(DataRow索引器)或DataRow对象的GetChildRows方法检索在DataRow中找到的值时,使用DataRowVersion值
//3.在数据更新过程中如何为DataRow设置新的标准？
//解答：数据更新过程的最后一步是为DataRow设置新的标准,该操作可用AcceptChanges方法完成,DataAdatapter的Update方法自动调用AcceptChanges
//4.DataSet中数据更改的信息可以通过两种方式来记录和维护:
//1.对行的状态作出标记指示该行是否已被修改
//2.保留DataRow的多个版本,利用这些更改信息,进程可以确定DataSet中有哪些修改并将这些修改发送到数据源
//5.如何从一个DataSet的表中删除记录？
//解答：可以使用两个方法从一个DataSet的表中删除记录：DataRowCollection对象的Remove方法和DataRow对象的Delete方法
//Remove方法从DataRowCollection中删除DataRow,而Delete方法只将行标记为删除
//DataView对象类似于SQL Server中的视图,它表示DataTable中数据子集的对象