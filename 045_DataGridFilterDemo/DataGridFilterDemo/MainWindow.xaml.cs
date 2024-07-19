using Bogus;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataGridFilterDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Employee> Employees { get; set; }

        private ICollectionView CollectionView { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Employees = new(Employee.FakeMany(10));
            CollectionView = CollectionViewSource.GetDefaultView(Employees);

            dataGrid.ItemsSource = CollectionView;

            CollectionView.Filter = (item) =>
            {
                var em = item as Employee;
                return em.FirstName.Contains(filterTextBox.Text) || em.LastName.Contains(filterTextBox.Text);
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Employees.Add(Employee.FakeOne());
            CollectionView.Refresh();
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            CollectionView.Refresh();
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly Birthday { get; set; }
        public int Salay { get; set; }

        public static Employee FakeOne() => employeeFaker.Generate();

        public static IEnumerable<Employee> FakeMany(int count) => employeeFaker.Generate(count);


        private static readonly Faker<Employee> employeeFaker = new Faker<Employee>()
            .RuleFor(x => x.Id, x => x.IndexFaker)
            .RuleFor(x => x.FirstName, x => x.Person.FirstName)
            .RuleFor(x => x.LastName, x => x.Person.LastName)
            .RuleFor(x => x.Birthday, x => DateOnly.FromDateTime(x.Person.DateOfBirth))
            .RuleFor(x => x.Salay, x => x.Random.Int(6, 30) * 1000);
    }
}