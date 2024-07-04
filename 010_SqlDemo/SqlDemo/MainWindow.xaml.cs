using System.Windows;
using System.Data.SqlClient;
using System.Data;
using System.Data.Entity;
using System.Linq;

namespace SqlDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        private string SqlStr { get; set; }

        /// <summary>
        /// 数据库连接对象
        /// </summary>
        private SqlConnection SqlCon { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            // 数据库连接字符串
            SqlStr = "Server=W0021;UID=sa;PWD=weisitec;DataBase=mydb1";
            // 数据库连接对象
            SqlCon = new SqlConnection(SqlStr);

            // 从数据库中获取数据
            GetData();
        }

        /// <summary>
        /// 从数据库中获取数据
        /// </summary>
        private void GetData()
        {
            // 判断连接是否开启
            if (SqlCon.State == ConnectionState.Open)
            {
                SqlCon.Close();
            }
            SqlCon.Open();

            SqlCommand cmd = new SqlCommand("select * from Table_1 order by ID asc", SqlCon);
            SqlDataReader sqlReader = cmd.ExecuteReader();

            // 读取到 ListBox
            LB_Data.Items.Clear();
            _ = LB_Data.Items.Add("编号   姓名     年龄");
            if (sqlReader.HasRows)
            {
                while (sqlReader.Read())
                {
                    string str = string.Format("{0}     {1}     {2}", sqlReader["ID"], sqlReader["Name"], sqlReader["Age"]);
                    _ = LB_Data.Items.Add(str);
                }
            }
            sqlReader.Close();
            SqlCon.Close();
        }

        /// <summary>
        /// 连接 SQL Server 数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOpen_Click(object sender, RoutedEventArgs e)
        {
            // 打开数据库连接
            SqlCon.Open();
            // 判断连接是否打开
            if (SqlCon.State == ConnectionState.Open)
            {
                TB_sqlState.Text = "SQL Server 数据库连接开启！";
            }
        }

        /// <summary>
        /// 关闭 SQL Server 数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            // 关闭数据库连接
            SqlCon.Close();
            // 判断连接是否关闭
            if (SqlCon.State == ConnectionState.Closed)
            {
                TB_sqlState.Text = "SQL Server 数据库连接关闭！";
            }
        }

        /// <summary>
        /// 添加：SqlCommand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (SqlCon.State == ConnectionState.Open)
            {
                SqlCon.Close();
            }
            SqlCon.Open();

            // 定义添加数据的 SQL 语句
            // 报错：INSERT 语句中列的数目大于 VALUES 子句中指定的值的数目
            // 解决：注意标点符号
            string sqlCmd = string.Format("insert into Table_1(Name,Age) values('{0}',{1})", TB_Name.Text, TB_Age.Text);
            // 创建 SQLCommand 对象
            SqlCommand cmd = new SqlCommand(sqlCmd, SqlCon);
            // 判断是否添加成功
            int ret = cmd.ExecuteNonQuery();
            TB_sqlState.Text = ret > 0 ? "添加成功！" : "添加失败";

            // 关闭数据库连接
            SqlCon.Close();

            GetData();
        }

        /// <summary>
        /// 添加：存储过程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd2_Click(object sender, RoutedEventArgs e)
        {
            if (SqlCon.State == ConnectionState.Open)
            {
                SqlCon.Close();
            }
            SqlCon.Open();

            // 存储过程 需要设置 SET NOCOUNT OFF;
            SqlCommand cmd = new SqlCommand
            {
                Connection = SqlCon,
                CommandType = CommandType.StoredProcedure,
                CommandText = "proc_Add",
            };
            cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = TB_Name.Text;
            cmd.Parameters.Add("@age", SqlDbType.Int).Value = TB_Age.Text;

            // 判断是否添加成功
            int ret = cmd.ExecuteNonQuery();
            // 注意设置主键
            TB_sqlState.Text = ret > 0 ? "添加成功！" : "添加失败";

            // 关闭数据库连接
            SqlCon.Close();

            GetData();
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            if (SqlCon.State == ConnectionState.Open)
            {
                SqlCon.Close();
            }
            SqlCon.Open();

            string sqlCmd = "delete from Table_1 where ID=" + TB_Id.Text;
            SqlCommand cmd = new SqlCommand(sqlCmd, SqlCon);
            int ret = cmd.ExecuteNonQuery();
            TB_sqlState.Text = ret > 0 ? "删除成功！" : "删除失败";
            SqlCon.Close();
            GetData();
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (SqlCon.State == ConnectionState.Open)
            {
                SqlCon.Close();
            }
            SqlCon.Open();

            string sqlCmd = string.Format("update Table_1 set Name='{0}',Age={1} where ID = {2}", TB_Name.Text, TB_Age.Text, TB_Id.Text);
            SqlCommand cmd = new SqlCommand(sqlCmd, SqlCon);
            int ret = cmd.ExecuteNonQuery();
            TB_sqlState.Text = ret > 0 ? "修改成功！" : "修改失败";
            SqlCon.Close();
            GetData();
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCheck_Click(object sender, RoutedEventArgs e)
        {
            if (SqlCon.State == ConnectionState.Open)
            {
                SqlCon.Close();
            }
            SqlCon.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from Table_1 where age between 10 and 50", SqlCon);
            // 实例化数据集对象
            DataSet ds = new DataSet();
            // 填充数据集中的指定表
            _ = da.Fill(ds);
            DG_Data.ItemsSource = ds.Tables[0].DefaultView;

            // 读取到 ListView
            LV_Data.ItemsSource = ds.Tables[0].DefaultView;

            SqlCon.Close();
        }

        /// <summary>
        /// 显示当前行的信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DG_Data_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            int idx = DG_Data.SelectedIndex;
            if (idx >= 0)
            {
                if (DG_Data.SelectedItem is DataRowView row)
                {
                    TB_Id.Text = row.Row[0].ToString();
                    TB_Name.Text = row.Row[1].ToString();
                    TB_Age.Text = row.Row[2].ToString();
                }
                else if (DG_Data.SelectedItem is Table_1 tb)
                {
                    TB_Id.Text = tb.Id.ToString();
                    TB_Name.Text = tb.Name.ToString();
                    TB_Age.Text = tb.Age.ToString();
                }
            }
        }

        /// <summary>
        /// 获取数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnData_Click(object sender, RoutedEventArgs e)
        {
            // 读取到 DataGrid
            using (mydb1Entities db = new mydb1Entities())
            {
                db.Table_1.Load();
                DG_Data.ItemsSource = db.Table_1.Local;
                LV_Data.ItemsSource = db.Table_1.Local;
            }
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd3_Click(object sender, RoutedEventArgs e)
        {
            using (mydb1Entities db = new mydb1Entities())
            {
                db.Table_1.Load();
                Table_1 tb = new Table_1
                {
                    Name = TB_Name.Text,
                    Age = int.Parse(TB_Age.Text),
                };
                _ = db.Table_1.Add(tb);
                _ = db.SaveChanges();
                DG_Data.ItemsSource = db.Table_1.Local;
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDel2_Click(object sender, RoutedEventArgs e)
        {
            using (mydb1Entities db = new mydb1Entities())
            {
                db.Table_1.Load();
                Table_1 tb = db.Table_1.Where(w => w.Id.ToString() == TB_Id.Text).FirstOrDefault();
                if (tb != null)
                {
                    _ = db.Table_1.Remove(tb);
                    _ = db.SaveChanges();
                    DG_Data.ItemsSource = db.Table_1.Local;
                }
            }
        }
    }
}