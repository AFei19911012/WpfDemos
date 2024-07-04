using AutoMapper;
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

namespace AutoMapperDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Foo, FooDto>();
                cfg.CreateMap<Employee, EmployeeDto>().IncludeMembers(e => e.Department);
                cfg.CreateMap<Department, EmployeeDto>();
            });
            var mapper = config.CreateMapper();

            Foo foo = new Foo { ID = 1, Name = "Tim" };
            FooDto dto = mapper.Map<FooDto>(foo);

            lb.Items.Clear();

            lb.Items.Add("Foo");
            lb.Items.Add("  ID = 1, Name = Tim");

            lb.Items.Add("FooDto");
            lb.Items.Add($"  ID = {dto.ID}, Name = {dto.Name}");
            lb.Items.Add("");

            Employee employee = new Employee
            {
                ID = 1,
                Name = "Tim",
                Department = new Department { DepartmentID = 1, DepartmentName = "AA" }
            };
            EmployeeDto empdto = mapper.Map<EmployeeDto>(employee);

            lb.Items.Add("Employee");
            lb.Items.Add("  ID = 1, Name = Tim, Department.DepartmentID = 1, Department.DepartmentName = AA");

            lb.Items.Add("EmployeeDto");
            lb.Items.Add($"  ID = {empdto.ID}, Name = {empdto.Name}, DepartmentID = {empdto.DepartmentID}, DepartmentName = {empdto.DepartmentName}");
        }
    }

    public class Foo
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class FooDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Department Department { get; set; }
    }

    public class EmployeeDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
    }
}