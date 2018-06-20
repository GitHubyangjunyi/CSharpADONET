using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAdapterDemo
{
    public partial class FormDataAdapterDemo : Form
    {
        public FormDataAdapterDemo()
        {
            InitializeComponent();
        }
    }
}
//在ADO.NET编程中不能使用一个DataAdapter对象向多个DataTable填充数据
//为了控制DataAdapter的Fill方法如何在填充数据之前向DataSet加载数据源架信息
//可在调用该方法前将DataAdapter的MissingSchemaAction属性设为AddWithKey
//使得Fill方法在填充数据前向DataSet架构添加额外的表和列并且给DataTable添加主键信息
//为了提高性能,在使用DataAdapter填充DataSet前,可以将DataSet对象的EnforceConstraints属性值设为false
//1.如何创建和配置DataAdapter为断开连接的应用程序提供对Microsoft SQL Server 2000数据库的只读访问？
//解答：在代码中通过编程方式或使用数据适配器配置向导创建一个SqlDataAdapter对象
//初始化DataAdapter的SelectCommand属性
//必须指定SqlConnection对象,还必须指定一个从数据源检索数据的查询
//要完成此操作可以定义一条SQL SELECT语句或者使用一个新的或现有的存储过程
//2.使用DataAdapter填充DataSet的最有效方式是什么？
//解答：首先创建一个与DataAdapter传入的数据结构相同的类型化DataSet
//当准备填充DataSet时调用BeginLoadData方法来在加载数据的过程中禁用约束检查和索引维护
//然后调用DataAdapter的Fill方法填充DataSet中的指定DataTable
//最后在完全加载数据之后调用EndLoadData
//3.如何配置DataAdapter以允许根据DataSet的内容更新数据源？
//解答：当创建DataAdapter对象时为它的InsertCommand、UpdateCommand和DeleteCommand属性定义SqlCommand或OleDbCommand对象
//DataAdapter隐式地使用这些命令对象将DataSet的更改传回数据源
//4.如何将数据更改持久保存到数据源以及如何控制不同类型的更改进行持久保存的顺序？
//解答：调用DataAdapter的FillSchema方法
//如果DataSet中包含几个DataTable可能需要在其它操作之前先执行一些update操作以避免外键约束错误
//在这种情况下调用DataSet的GetChanges方法,获得每个表上的更改(修改更新或删除)的子集
//分别调用每个更改集上的Update方法以控制将更改持久保存到数据源的顺序
//5.当在断开连接的应用程序中更新数据源时会出现什么类型的冲突？如何发现并解决这些冲突？
//解答：断开连接应用程序使用开放式并发
//就是说在应用程序与数据源断开连接时可能会有其他用户插入/更新或删除一些行,这样当试图将你的更改保存到数据源时就可能产生冲突
//这种情况下会出现一个异常,可以捕获这个异常并通过检查DataSet、DataTable和DataRow的HasErrors属性来发现问题的位置
//在定位了问题之后可以决定是拒绝提出的更改,强制对数据源进行更改,还是将更改在本地保存到DataSet中以便用户在以后保存更改