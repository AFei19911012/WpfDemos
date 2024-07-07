using Dapper;
using Microsoft.Data.Sqlite;
using System.Windows;

namespace DapperDemo
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

        private void Init()
        {
            using var con = new SqliteConnection("Data Source=DemoDB.db");
            // 创建表
            con.Execute("CREATE TABLE IF NOT EXISTS Person (Id INTEGER PRIMARY KEY, Name TEXT)");

            // 插入数据
            con.Execute("INSERT INTO Person (Name) VALUES (@Name)", new { Name = "Alice" });
            // 批量插入数据
            var datas = new List<Person>
            {
                new Person { Name = "TextA" },
                new Person { Name = "TextB" },
                new Person { Name = "TextC" }
            };
            int rowsAffected = con.Execute("INSERT INTO Person (Name) VALUES (@Name)", datas);

            // 查询数据
            var table = con.Query<Person>("SELECT * FROM Person").ToList();
            lb.Items.Add("查询数据库");
            foreach (var item in table)
            {
                lb.Items.Add(item.ToString());
            }
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public override string ToString()
        {
            return $"Id = {Id}, Name = {Name}";
        }
    }
}