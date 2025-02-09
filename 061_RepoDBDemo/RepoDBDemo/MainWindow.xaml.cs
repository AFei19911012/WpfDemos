using RepoDb;
using RepoDb.Extensions;
using System.Data.SQLite;
using System.Windows;

namespace RepoDBDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // 初始化依赖项
            GlobalConfiguration.Setup().UseSQLite();

            // 数据库
            var connectionString = "Data Source=DemoDB.db";

            // 本地存在 Person 表
            var person = new Person
            {
                Name = "John Doe",
                Age = 54,
                CreatedDateUtc = DateTime.UtcNow
            };

            // 单个插入
            using var connection = new SQLiteConnection(connectionString);
            var id = connection.Insert(person);

            // 批量插入
            var people = GetPeople(10);
            var rowsInserted = connection.InsertAll(people);

            // 查询
            var person1 = connection.Query<Person>(e => e.Id == 1);

            // 合并
            var person2 = new Person
            {
                Id = 1,
                Name = "John Doe",
                Age = 57,
                CreatedDateUtc = DateTime.UtcNow
            };
            var id2 = connection.Merge(person2);

            // 批量合并
            var people2 = GetPeople(10);
            people2.ForEach(p => p.Name = $"{p.Name} (Merged)");
            var affectedRecords = connection.MergeAll(people2);

            // 删除
            var deletedRow = connection.Delete<Person>(1);

            // 删除全部
            var deletedRows = connection.DeleteAll<Person>();

            // 更新
            var person3 = new Person
            {
                Id = 1,
                Name = "James Doe",
                Age = 55,
                CreatedDateUtc = DateTime.UtcNow
            };
            var updatedRows = connection.Update<Person>(person);

            // 更新所有
            var people3 = GetPeople(10);
            people3.ForEach(p => p.Name = $"{p.Name} (Updated)");
            var updatedRows2 = connection.UpdateAll(people3);


            // 执行查询语句
            var sql = "DELETE FROM [Person] WHERE Id = @Id;";
            var affectedRecords2 = connection.ExecuteNonQuery(sql, new { Id = 40 });

            sql = "SELECT * FROM [Person] ORDER BY Id ASC;";
            var people4 = connection.ExecuteQuery<Person>(sql);

            sql = "SELECT MAX(Id) FROM [Person];";
            var maxId = connection.ExecuteScalar(sql);

            sql = "SELECT * FROM [Person] ORDER BY Id ASC;";
            using var reader = connection.ExecuteReader(sql);
        }

        private List<Person> GetPeople(int num)
        {
            List<Person> people = [];
            for (int i = 0; i < num; i++)
            {
                var person = new Person
                {
                    Name = $"Name-{i + 1}",
                    Age = 33,
                    CreatedDateUtc = DateTime.UtcNow
                };
                people.Add(person);
            }
            return people;
        }
    }


    public class Person
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime CreatedDateUtc { get; set; }
    }
}