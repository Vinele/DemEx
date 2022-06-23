using FabricsShop.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FabricsShop.Views
{
    /// <summary>
    /// Логика взаимодействия для StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
        }

        private void productsListButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            StoreWindow storeWindow = new StoreWindow();
            storeWindow.ShowDialog();
            Show();
        }

        private void regButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            RegistrationWindow registrationWindow = new RegistrationWindow();
            DBContext dBContext = new DBContext();

            //registration
            User user = new User() { UserSurname = "", UserName = "", UserPatronymic = "", UserLogin = "", UserPassword = "", UserRole = 3};
            dBContext.User.Add(user);
            dBContext.SaveChanges();
            //auth
            string login = null;
            string password = null;
            dBContext.User.FirstOrDefault(authUser => authUser.UserLogin == login && authUser.UserPassword == password);
        }

        private void authButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
