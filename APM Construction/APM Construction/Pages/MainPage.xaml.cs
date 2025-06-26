using APM_Construction.Models;
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
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ToEmployee(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(PageController.EmployeePage);
        }

        private void ToResource(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(PageController.ResourcePage);
        }

        private void ToProject(object sender, RoutedEventArgs e)
        {
            PageController.ProjectPage.CheckUserPermission();
            NavigationService.Navigate(PageController.ProjectPage);
        }

        private void ToTask(object sender, RoutedEventArgs e)
        {
            PageController.TaskPage.CheckUserPermission();
            NavigationService.Navigate(PageController.TaskPage);
        }

        private void LogOut(object sender, RoutedEventArgs e)
        {
            DataStore.Instance.CurrentUser = null;
            NavigationService.Navigate(PageController.AuthorizationPage);
        }

        public void CheckUserPermission()
        {
            var user = DataStore.Instance.CurrentUser;
            if (user != null)
            {
                switch (user.Role)
                {
                    case "Admin":
                        Projects.IsEnabled = true;
                        Resources.IsEnabled = true;
                        Tasks.IsEnabled = true;
                        Employee.IsEnabled = true;
                        break;
                    case "Manager":
                        Projects.IsEnabled = true;
                        Resources.IsEnabled = false;
                        Tasks.IsEnabled = true;
                        Employee.IsEnabled = false;
                        break;
                    case "Worker":
                        Projects.IsEnabled = false;
                        Resources.IsEnabled = false;
                        Tasks.IsEnabled = true;
                        Employee.IsEnabled = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
