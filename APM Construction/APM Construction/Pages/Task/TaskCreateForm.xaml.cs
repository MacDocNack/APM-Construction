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
using Task = APM_Construction.Models.Task;

namespace APM_Construction.Pages
{
    public partial class TaskCreateForm : Page
    {
        public TaskCreateForm()
        {
            InitializeComponent();

            ProjectId.SetBinding(ComboBox.ItemsSourceProperty, new Binding()
            {
                Source = DataStore.Instance.Projects.Select(p => p.Id)
            });
            
            State.Items.Add("В процессе");
            State.Items.Add("Завершен");
            State.Items.Add("Приостановлено");

            Priority.Items.Add("Низкий");
            Priority.Items.Add("Средний");
            Priority.Items.Add("Высокий");
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(PageController.TaskPage);
        }

        private void CreateTask(object sender, RoutedEventArgs e)
        {
            if (ProjectId.SelectedItem != null && !string.IsNullOrEmpty(TaskName.Text) && State.SelectedItem != null && Priority.SelectedItem != null)
            {
                int taskId = -1;
                if (DataStore.Instance.Tasks.Count > 0)
                {
                    taskId = DataStore.Instance.Tasks.Max(t => t.Id);
                }
                Task task = new()
                {
                    Id = taskId + 1,
                    IdProject = (int)ProjectId.SelectedItem,
                    Name = TaskName.Text,
                    State = State.SelectedItem.ToString(),
                    Priority = Priority.SelectedItem.ToString(),
                    Description = Description.Text,
                    DateStart = DateOnly.Parse(DateStart.Text),
                    DateEnd = DateOnly.Parse(DateEnd.Text)
                };
                DataStore.Instance.Tasks.Add(task);
                MainWindow.ConnectToWeb.TaskPost(task);
                JSONDataSaveService.Instance.SaveTaskData(DataStore.Instance.Tasks);
                ProjectId.SelectedIndex = -1;
                TaskName.Clear();
                State.SelectedIndex = -1;
                Priority.SelectedIndex = -1;
                Description.Clear();
                DateEnd.Text = DateStart.Text;
                NavigationService.Navigate(PageController.TaskPage);
            }
        }
    }
}
