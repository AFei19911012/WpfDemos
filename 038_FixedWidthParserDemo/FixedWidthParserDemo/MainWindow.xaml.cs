using SoftCircuits.Parsers;
using System.Windows;

namespace FixedWidthParserDemo
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
            // 定义指定宽度
            FixedWidthField[] PersonFields =
            [
                new FixedWidthField(5),
                new FixedWidthField(10),
                new FixedWidthField(10),
            ];

            string filename = "test.txt";
            // 保存到本地
            using (FixedWidthWriter writer = new(PersonFields, filename))
            {
                writer.Write("1", "Bill", "Smith");
                writer.Write("2", "Karen", "Williams");
                writer.Write("3", "Tom", "Phillips");
                writer.Write("4", "Jack", "Carpenter");
                writer.Write("5", "Julie", "Samson");
            }
            // 从本地读取
            using (FixedWidthReader reader = new(PersonFields, filename))
            {
                while (reader.Read())
                {
                    var v = reader.Values;
                }
            }
            

            // 生成数据
            List<Product> Products = new List<Product>
            {
                new Product { Id = Guid.NewGuid(), Description = "Coffee Table", Category = "Furniture", Rating = 4.5 },
                new Product { Id = Guid.NewGuid(), Description = "Spoons", Category = "Utensils", Rating = 4.2 },
                new Product { Id = Guid.NewGuid(), Description = "Carpet", Category = "Flooring", Rating = 4.5 },
                new Product { Id = Guid.NewGuid(), Description = "Knives", Category = "Utensils", Rating = 4.7 },
                new Product { Id = Guid.NewGuid(), Description = "Recliner", Category = "Furniture", Rating = 4.5 },
                new Product { Id = Guid.NewGuid(), Description = "Floor Tiles", Category = "Flooring", Rating = 4.5 },
            };

            filename = "test2.txt";
            // 写数据
            using (FixedWidthWriter<Product> writer = new(filename))
            {
                foreach (var product in Products)
                {
                    writer.Write(product);
                }
            }

            // 读数据
            List<Product> results = [];
            using (FixedWidthReader<Product> reader = new(filename))
            {
                while (reader.Read())
                {
                    results.Add(reader.Item);
                }
            }

            // 转换器
            List<Person> People = new()
            {
                new Person { Id = 1, FirstName = "Bill", LastName = "Smith", BirthDate = new DateTime(1982, 2, 7) },
                new Person { Id = 1, FirstName = "Gary", LastName = "Parker", BirthDate = new DateTime(1989, 8, 2) },
                new Person { Id = 1, FirstName = "Karen", LastName = "Wilson", BirthDate = new DateTime(1978, 6, 24) },
                new Person { Id = 1, FirstName = "Jeff", LastName = "Johnson", BirthDate = new DateTime(1972, 4, 18) },
                new Person { Id = 1, FirstName = "John", LastName = "Carter", BirthDate = new DateTime(1982, 12, 21) },
            };

            filename = "test3.txt";
            // 写数据
            using (FixedWidthWriter<Person> writer = new(filename))
            {
                foreach (var person in People)
                {
                    writer.Write(person);
                }
            }

            // 读数据
            List<Person> results2 = new();
            using (FixedWidthReader<Person> reader = new(filename))
            {
                while (reader.Read())
                {
                    results2.Add(reader.Item);
                }
            }


            filename = "test4.txt";
            // 手动映射
            using (FixedWidthWriter<Person> writer = new(filename))
            {
                writer.MapField(m => m.Id, 20);
                writer.MapField(m => m.FirstName, 12);
                writer.MapField(m => m.LastName, 12);
                writer.MapField(m => m.BirthDate, 12).SetConverterType(typeof(BirthDateConverter));

                foreach (var person in People)
                {
                    writer.Write(person);
                }
            }
        }
    }

    public class Product
    {
        [FixedWidthField(36)]
        public Guid Id { get; set; }
        [FixedWidthField(12)]
        public string Description { get; set; }
        [FixedWidthField(12)]
        public string Category { get; set; }
        [FixedWidthField(10)]
        public double Rating { get; set; }
    }

    public class Person
    {
        [FixedWidthField(8)]
        public int Id { get; set; }
        [FixedWidthField(12)]
        public string FirstName { get; set; }
        [FixedWidthField(12)]
        public string LastName { get; set; }
        [FixedWidthField(12, ConverterType = typeof(BirthDateConverter))]
        public DateTime BirthDate { get; set; }
    }

    public class BirthDateConverter : DataConverter<DateTime>
    {
        private const string Format = "yyyyMMdd";

        public override string ConvertToString(DateTime value) => value.ToString(Format);

        public override bool TryConvertFromString(string? s, out DateTime value)
        {
            return DateTime.TryParseExact(s, Format, null, System.Globalization.DateTimeStyles.None, out value);
        }
    }
}