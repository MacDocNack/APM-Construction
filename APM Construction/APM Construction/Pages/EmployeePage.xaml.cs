using APM_Construction.Windows;
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
    public partial class EmployeePage : Page
    {
        public EmployeePage()
        {
            InitializeComponent();

            EmployeeList.SetBinding(DataGrid.ItemsSourceProperty, new Binding()
            {
                Source = DataStore.Instance.Employees
            });
        }

        private void AddEmployee(object sender, RoutedEventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.Show();
        }

        private void EditEmployee(object sender, RoutedEventArgs e)
        {
            if (EmployeeList.SelectedItem != null)
            {
                EmployeeForm employeeForm = new EmployeeForm(EmployeeList.SelectedItem as Employee);
                employeeForm.Show();
            }
        }

        private void DeleteEmployee(object sender, RoutedEventArgs e)
        {
            if (EmployeeList.SelectedItem != null)
            {
                MainWindow.ConnectToWeb.EmployeeDelete(EmployeeList.SelectedItem as Employee);
                DataStore.Instance.Employees.Remove(EmployeeList.SelectedItem as Employee);
                EmployeeList.Items.Refresh();
            }
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
