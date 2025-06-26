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
    public partial class TaskEditForm : Page
    {
        private Task _taskToEdit;
        public TaskEditForm()
        {
            InitializeComponent();

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

        private void EditTask(object sender, RoutedEventArgs e)
        {
            Task existTask = DataStore.Instance.Tasks.FirstOrDefault(t => t.Id == _taskToEdit.Id);
            existTask.State = State.SelectedItem.ToString();
            existTask.Priority = Priority.SelectedItem.ToString();
            existTask.DateEnd = DateOnly.Parse(DateEnd.Text);
            PageController.TaskPage.TaskList.Items.Refresh();
            MainWindow.ConnectToWeb.TaskPut(existTask);
            JSONDataSaveService.Instance.SaveTaskData(DataStore.Instance.Tasks);
            State.SelectedIndex = -1;
            Priority.SelectedIndex = -1;
            NavigationService.Navigate(PageController.TaskPage);
            MessageBox.Show("Task successful updated!", "Nice!", MessageBoxButton.OK);
        }

        public void GetTaskToEdit(Task task)
        {
            _taskToEdit = task;
            ProjectId.Text = _taskToEdit.IdProject.ToString();
            TaskName.Text = _taskToEdit.Name;
            State.SelectedItem = _taskToEdit.State;
            Priority.SelectedItem = _taskToEdit.Priority;
            DateStart.Text = _taskToEdit.DateStart.ToString();
            DateEnd.Text = _taskToEdit.DateEnd.ToString();
            Description.Text = _taskToEdit.Description;
        }
    }
}
