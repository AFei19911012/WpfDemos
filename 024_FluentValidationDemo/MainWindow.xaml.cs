using FluentValidation;
using System.Windows;
using FluentValidation.Results;

namespace FluentValidationDemo
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
            Customer customer = new Customer();
            CustomerValidator validator = new CustomerValidator();
            ValidationResult results = validator.Validate(customer);
            if (!results.IsValid)
            {
                lb.Items.Clear();
                foreach (var item in results.Errors)
                {
                    lb.Items.Add($"Property {item.PropertyName} failed validation. Error was: {item.ErrorMessage}");
                }
                lb.Items.Add("");
            }

            // 信息以 ~ 分隔
            string allMessages = results.ToString("~");
            lb.Items.Add(allMessages);
            lb.Items.Add("");

            try
            {
                validator.ValidateAndThrow(customer);
                validator.Validate(customer, options => options.ThrowOnFailures());
            }
            catch (Exception ex)
            {
                lb.Items.Add(ex.Message);
            }
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Forename { get; set; }
        public decimal Discount { get; set; }


        public string Name { get; set; }
        public Address Address { get; set; }
    }

    public class Address
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Town { get; set; }
        public string Country { get; set; }
        public string Postcode { get; set; }
    }

    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(address => address.Postcode).NotNull();
        }
    }

    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(customer => customer.Surname).NotNull();
            RuleFor(customer => customer.Surname).NotNull().NotEqual("foo");

            RuleFor(customer => customer.Name).NotNull();
            RuleFor(customer => customer.Address).SetValidator(new AddressValidator());

            // 或者采用以下写法
            //RuleFor(customer => customer.Address.Postcode).NotNull()

            // 设定条件，否则验证不会执行
            //RuleFor(customer => customer.Address.Postcode).NotNull().When(customer => customer.Address != null)
        }
    }

}