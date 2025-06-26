using APM_Construction.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    public partial class ProjectPage : Page
    {
        public ProjectPage()
        {
            InitializeComponent();

            ProjectList.SetBinding(ListView.ItemsSourceProperty, new Binding()
            {
                Source = DataStore.Instance.Projects
            });
        }
        private void GoBack(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(PageController.MainPage);
        }

        private void Create(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(PageController.ProjectCreateForm);
        }

        private void Edit(object sender, RoutedEventArgs e)
        {
            if (ProjectList.SelectedItem != null)
            {
                PageController.ProjectEditForm.GetProjectToEdit(ProjectList.SelectedItem as Project);
                NavigationService.Navigate(PageController.ProjectEditForm);
            }
        }

        private void Follow(object sender, RoutedEventArgs e)
        {
            if (ProjectList.SelectedItem != null)
            {
                PageController.ProjectViewForm.GetProjectToView(ProjectList.SelectedItem as Project);
                NavigationService.Navigate(PageController.ProjectViewForm);
            }
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            if (ProjectList.SelectedItem != null)
            {
                MainWindow.ConnectToWeb.ProjectDelete(ProjectList.SelectedItem as Project);
                DataStore.Instance.Projects.Remove(ProjectList.SelectedItem as Project);
                JSONDataSaveService.Instance.SaveProjectData(DataStore.Instance.Projects);
                ProjectList.Items.Refresh();
                MessageBox.Show("Project successful deleted", "Project delete", MessageBoxButton.OK);
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
                        bNewProject.IsEnabled = true;
                        bFollow.IsEnabled = true;
                        bEdit.IsEnabled = true;
                        bDelete.IsEnabled = true;
                        break;
                    case "Manager":
                        bNewProject.IsEnabled = true;
                        bFollow.IsEnabled = true;
                        bEdit.IsEnabled = true;
                        bDelete.IsEnabled = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
