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
using System.Windows.Shapes;

namespace APM_Construction.Windows
{
    public partial class EmployeeForm : Window
    {
        private Employee _employee;
        public EmployeeForm()
        {
            InitializeComponent();
        }

        public EmployeeForm(Employee employee)
        {
            InitializeComponent();
            _employee = employee;
            if (_employee != null)
            {
                EmployeeName.Text = _employee.Name;
                Position.Text = _employee.Position;
                Phone.Text = _employee.Phone;
                Salary.Text = _employee.Salary.ToString();
            }
        }

        private void OK(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(EmployeeName.Text) && !string.IsNullOrEmpty(Position.Text) && !string.IsNullOrEmpty(Phone.Text) && !string.IsNullOrEmpty(Salary.Text))
            {
                if (_employee != null)
                {
                    _employee = new()
                    {
                        Id = _employee.Id,
                        Name = EmployeeName.Text,
                        Position = Position.Text,
                        Phone = Phone.Text,
                        Salary = decimal.Parse(Salary.Text),
                    };
                    DataStore.Instance.Employees[_employee.Id - 1] = _employee;
                    MainWindow.ConnectToWeb.EmployeePut(_employee);
                    Hide();
                }
                else
                {
                    int employeeId = -1;
                    if (DataStore.Instance.Employees.Count > 0)
                    {
                        employeeId = DataStore.Instance.Employees.Max(e => e.Id);
                    }
                    _employee = new()
                    {
                        Id = employeeId + 1,
                        Name = EmployeeName.Text,
                        Position = Position.Text,
                        Phone = Phone.Text,
                        Salary = decimal.Parse(Salary.Text),
                    };
                    DataStore.Instance.Employees.Add(_employee);
                    MainWindow.ConnectToWeb.EmployeePost(_employee);
                    Hide();
                }
                JSONDataSaveService.Instance.SaveEmployeeData(DataStore.Instance.Employees);
            }
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            Hide();
        }
    }
}
