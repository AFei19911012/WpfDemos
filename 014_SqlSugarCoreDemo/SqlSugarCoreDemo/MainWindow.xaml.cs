using SqlSugar;
using System.Windows;

namespace SqlSugarCoreDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Init();
        }

        /// <summary>
        /// 创建数据库
        /// </summary>
        /// <returns></returns>
        private ISqlSugarClient CreateDB()
        {
            var connectionString = "Data Source=DemoDB.db";
            SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = connectionString,//连接符字串
                DbType = DbType.Sqlite,
                IsAutoCloseConnection = true
            });
            return db;
        }

        /// <summary>
        /// 初始化数据库
        /// </summary>
        private void Init()
        {
            // 创建数据库
            var db = CreateDB();
            // 建库
            db.DbMaintenance.CreateDatabase();
            // 建表
            db.CodeFirst.InitTables(typeof(Table_Demo));

            // 查询数据
            var list = db.Queryable<Table_Demo>().ToList();
            // 如果没有数据则初始化数据
            if (list.Count == 0)
            {
                lb.Items.Add("初始化数据库");
                for (int i = 0; i < 5; i++)
                {
                    var data = new Table_Demo()
                    {
                        Uid = Guid.NewGuid().ToString(),
                        Name = "default",
                        Remark = "",
                        IsChecked = false,
                    };
                    db.Insertable(data).ExecuteCommand();
                    lb.Items.Add(data.ToString());
                }
            }
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            Table_Demo data = new Table_Demo
            {
                Uid = Guid.NewGuid().ToString(),
                Name = "new",
                IsChecked = true,
            };
            var db = CreateDB();
            db.Insertable(data).ExecuteCommand();
        }

        private void ButtonDel_Click(object sender, RoutedEventArgs e)
        {
            var db = CreateDB();
            var data = db.Queryable<Table_Demo>().Where(p => p.Name == "new").First();
            db.Deleteable(data).ExecuteCommand();
        }

        private void ButtonUpdate_Click(object sender, RoutedEventArgs e)
        {
            var db = CreateDB();
            var data = db.Queryable<Table_Demo>().Where(p => p.Name == "new").First();
            data.Remark = "Updated";
            db.Updateable(data).ExecuteCommand();
        }

        private void ButtonSearch_Click(object sender, RoutedEventArgs e)
        {
            var db = CreateDB();
            var list = db.Queryable<Table_Demo>().ToList();
            lb.Items.Add(string.Format("现有数据 {0} 条", list.Count));

            foreach (var item in list)
            {
                lb.Items.Add(item.ToString());
            }
        }
    }
}