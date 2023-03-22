using System.Windows;
using WpfApp.Services;



namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly CaseService _caseService;


        public MainWindow()
        {
            InitializeComponent();
            _caseService = new CaseService();
        }

        private async void BtnAdd_Click(object sender, RoutedEventArgs e)
        {

            await _caseService.SaveAsync(new Models.CaseAddModel
            {
                Title = Title.Text,
                Description = Description.Text,
                User = new Models.UserModel()
                {
                    FirstName = FirstName.Text,
                    LastName = LastName.Text,
                    Email = Email.Text,
                    PhoneNumber = PhoneNumber.Text,
                    StreetName = StreetName.Text,
                    PostalCode = PostalCode.Text,
                    City = City.Text,
                    UserType = "Customer"
                }
            });
        }
    }
}

//namespace WpfApp
//{
//    /// <summary>
//    /// Interaction logic for MainWindow.xaml
//    /// </summary>
//    public partial class MainWindow : Window
//    {
//        private readonly CaseService _caseService;
//        public MainWindow()
//        {
//            InitializeComponent();
//            _caseService = new CaseService();
//        }

//        ///Button - Async utan att ändra till en Task
//        private async void BtnAdd_Click(object sender, RoutedEventArgs e)
//        {


//            await _caseService.SaveAsync(new Models.CaseAddModel
//            {
//                Title = Title.Text,
//                Description = Description.Text,

//                User = new Models.UserModel
//                {
//                    FirstName = FirstName.Text,
//                    LastName = LastName.Text,
//                    Email = Email.Text,
//                    PhoneNumber = PhoneNumber.Text,
//                    StreetName = StreetName.Text,
//                    PostalCode = PostalCode.Text,
//                    City = City.Text,
//                    UserType = "Customer"
//                }
//            });

//        }
//    }
//}