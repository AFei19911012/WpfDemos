using Mapster;
using MapsterMapper;
using System.Windows;

namespace MapsterDemo
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
            // 默认配置为 TypeAdapterConfig.GlobalSettings
            Foo foo = new Foo { ID = 1, Name = "Tim", Sex = "Boy" };
            // 映射为新对象
            FooDto dto = foo.Adapt<FooDto>();
            // 在目标对象的基础上进行映射
            FooDto dto1 = new FooDto();
            foo.Adapt(dto1);

            lb.Items.Clear();

            lb.Items.Add("Foo");
            lb.Items.Add("  ID = 1, Name = Tim, Sex = Boy");
            lb.Items.Add("FooDto");
            lb.Items.Add($"  ID = {dto.ID}, Name = {dto.Name}, Sex = {dto.UserSex}");

            // 自定义规则
            var config = new TypeAdapterConfig();
            config.ForType<Foo, FooDto>()
                .Map(dst => dst.UserSex, src => src.Sex)
                // 忽略空值映射
                .IgnoreNullValues(true);
            var dto2 = foo.Adapt<FooDto>(config);


            // 务必设置为单例
            //var mapper = new Mapper(config);
            //var dto2 = mapper.Map<FooDto>(foo);

            lb.Items.Add("FooDto");
            lb.Items.Add($"  ID = {dto2.ID}, Name = {dto2.Name}, Sex = {dto2.UserSex}");
            lb.Items.Add("");


            Employee employee = new Employee
            {
                ID = 1,
                Name = "Tim",
                Department = new Department { DepartmentID = 1, DepartmentName = "AA" }
            };
            EmployeeDto dto3 = employee.Adapt<EmployeeDto>();

            var config2 = new TypeAdapterConfig();
            config2.ForType<Employee, EmployeeDto>()
                //.Ignore(dst => dst.Name)
                .Map(dst => dst.DepartmentID, src => src.Department.DepartmentID)
                .Map(dst => dst.DepartmentName, src => src.Department.DepartmentName);
            EmployeeDto dto4 = employee.Adapt<EmployeeDto>(config2);

            // 务必设置为单例
            var mapper = new Mapper(config2);
            var dto5 = mapper.Map<EmployeeDto>(employee);

            lb.Items.Add("Employee");
            lb.Items.Add("  ID = 1, Name = Tim, Department.DepartmentID = 1, Department.DepartmentName = AA");
            lb.Items.Add("EmployeeDto");
            lb.Items.Add($"  ID = {dto3.ID}, Name = {dto3.Name}, DepartmentID = {dto3.DepartmentID}, DepartmentName = {dto3.DepartmentName}");
            lb.Items.Add("EmployeeDto");
            lb.Items.Add($"  ID = {dto4.ID}, Name = {dto4.Name}, DepartmentID = {dto4.DepartmentID}, DepartmentName = {dto4.DepartmentName}");
            lb.Items.Add("EmployeeDto");
            lb.Items.Add($"  ID = {dto5.ID}, Name = {dto5.Name}, DepartmentID = {dto5.DepartmentID}, DepartmentName = {dto5.DepartmentName}");
        }
    }
}


public class Foo
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Sex { get; set; }
}

public class FooDto
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string UserSex { get; set; }
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