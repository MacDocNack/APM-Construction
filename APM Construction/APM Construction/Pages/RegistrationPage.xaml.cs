using APM_Construction.Models;
using APM_Construction.Windows;
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
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();

            EmployeeIdList.SetBinding(ComboBox.ItemsSourceProperty, new Binding()
            {
                Source = DataStore.Instance.Employees
            });

            RoleList.SetBinding(ComboBox.ItemsSourceProperty, new Binding()
            {
                Source = DataStore.Instance.Roles
            });
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(PageController.AuthorizationPage);
        }

        private void OpenEmployeeWindow(object sender, RoutedEventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.Show();
        }

        private void Registration(object sender, RoutedEventArgs e)
        {
            if (EmployeeIdList.SelectedItem != null && RoleList.SelectedItem != null && !string.IsNullOrEmpty(UserLogin.Text) && !string.IsNullOrEmpty(UserPassword.Password))
            {
                User containUser = DataStore.Instance.Users.Select(u => u.Login == UserLogin.Text && u.Password == UserPassword.Password) as User;
                if (containUser == null)
                {
                    int userId = -1;
                    if (DataStore.Instance.Users.Count > 0)
                    {
                        userId = DataStore.Instance.Users.Max(x => x.Id);
                    }
                    User user = new()
                    {
                        Id = userId + 1,
                        EmployeeId = (EmployeeIdList.SelectedItem as Employee).Id,
                        Login = UserLogin.Text,
                        Password = UserPassword.Password,
                        Role = (RoleList.SelectedItem as Role).Name
                    };
                    DataStore.Instance.Users.Add(user);
                    MainWindow.ConnectToWeb.UserPost(user);
                    JSONDataSaveService.Instance.SaveUsersData(DataStore.Instance.Users);
                    MessageBox.Show("User has been registrated!", "Nice!", MessageBoxButton.OK);
                    NavigationService.Navigate(PageController.AuthorizationPage);
                }
                else
                {
                    MessageBox.Show("User with this login already exist!", "Something went wrong...", MessageBoxButton.OK);
                }
            }
            else
            {
                MessageBox.Show("Check your data!!", "Data error", MessageBoxButton.OK);
            }
        }
    }
}
