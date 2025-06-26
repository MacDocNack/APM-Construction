using Task = APM_Construction.Models.Task;
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
    public partial class TaskViewForm : Page
    {
        public TaskViewForm()
        {
            InitializeComponent();
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(PageController.TaskPage);
        }

        public void GetTaskToView(Task task)
        {
            ProjectId.Text = task.IdProject.ToString();
            TaskName.Text = task.Name;
            State.Text = task.State;
            Priority.Text = task.Priority;
            DateStart.Text = task.DateStart.ToString();
            DateEnd.Text = task.DateEnd.ToString();
            Description.Text = task.Description;
        }
    }
}
