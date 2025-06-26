using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Navigation;
using Task = APM_Construction.Models.Task;

namespace APM_Construction.Pages
{
    public partial class TaskPage : Page
    {
        public TaskPage()
        {
            InitializeComponent();

            TaskList.SetBinding(ListView.ItemsSourceProperty, new Binding()
            {
                Source = DataStore.Instance.Tasks
            });
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(PageController.MainPage);
        }

        private void Create(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(PageController.TaskCreateForm);
        }

        private void Follow(object sender, RoutedEventArgs e)
        {
            if (TaskList.SelectedItem != null)
            {
                PageController.TaskViewForm.GetTaskToView(TaskList.SelectedItem as Task);
                NavigationService.Navigate(PageController.TaskViewForm);
            }
        }

        private void Edit(object sender, RoutedEventArgs e)
        {
            if (TaskList.SelectedItem != null)
            {
                PageController.TaskEditForm.GetTaskToEdit(TaskList.SelectedItem as Task);
                NavigationService.Navigate(PageController.TaskEditForm);
            }
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            if (TaskList.SelectedItem != null)
            {
                MainWindow.ConnectToWeb.TaskDelete(TaskList.SelectedItem as Task);
                DataStore.Instance.Tasks.Remove(TaskList.SelectedItem as Task);
                TaskList.Items.Refresh();
                JSONDataSaveService.Instance.SaveTaskData(DataStore.Instance.Tasks);
                MessageBox.Show("Task successful deleted", "Task delete", MessageBoxButton.OK);
            }
        }
        public void CheckUserPermission()
        {
            var user = DataStore.Instance.CurrentUser;
            if (user != null)
            {
                switch (user.Role)
                {
                    case "Admin":
                        bNewTask.IsEnabled = true;
                        bFollow.IsEnabled = true;
                        bEdit.IsEnabled = true;
                        bDelete.IsEnabled = true;
                        break;
                    case "Manager":
                        bNewTask.IsEnabled = true;
                        bFollow.IsEnabled = true;
                        bEdit.IsEnabled = true;
                        bDelete.IsEnabled = false;
                        break;
                    case "Worker":
                        bNewTask.IsEnabled = false;
                        bFollow.IsEnabled = true;
                        bEdit.IsEnabled = false;
                        bDelete.IsEnabled = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
