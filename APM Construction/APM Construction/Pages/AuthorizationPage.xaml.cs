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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace APM_Construction.Pages
{
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void ToRegistrationPage(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(PageController.RegistrationPage);
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(UserLogin.Text) && !string.IsNullOrEmpty(UserPass.Password))
            {
                var login = UserLogin.Text.Trim();
                var pass = UserPass.Password;
                var user = DataStore.Instance.Users.FirstOrDefault(u => u.Login == login && u.Password == pass);
                if (user != null)
                {
                    DataStore.Instance.CurrentUser = user;
                    PageController.MainPage.CheckUserPermission();
                    NavigationService.Navigate(PageController.MainPage);
                }
                else
                {
                    MessageBox.Show("User not found!", "Something went wrong...", MessageBoxButton.OK);
                }
            }
            else
            {
                MessageBox.Show("Check your data!!", "Data error", MessageBoxButton.OK);
            }
        }
    }
}
