using APM_Construction.Models;
using APM_Construction.Windows;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Navigation;

namespace APM_Construction.Pages
{
    public partial class ProjectCreateForm : Page
    {
        public ProjectCreateForm()
        {
            InitializeComponent();

            StateList.Items.Add("В процессе");
            StateList.Items.Add("Завершён");
            StateList.Items.Add("Приостановлен");
            StateList.SelectedIndex = 0;

            ClientList.SetBinding(ComboBox.ItemsSourceProperty, new Binding()
            {
                Source = DataStore.Instance.Clients
            });

            ContractorList.SetBinding(ComboBox.ItemsSourceProperty, new Binding()
            {
                Source = DataStore.Instance.Contractors
            });
        }

        private void CreateClient(object sender, RoutedEventArgs e)
        {
            ClientForm clientForm = new ClientForm();
            clientForm.Show();
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(PageController.ProjectPage);
        }

        private void CreateContractor(object sender, RoutedEventArgs e)
        {
            ContructorForm contructorForm = new ContructorForm();
            contructorForm.Show();
        }

        private void CreateProject(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(ProjectName.Text) && !string.IsNullOrEmpty(Budget.Text) && ClientList.SelectedItem != null && ContractorList.SelectedItem != null)
            {
                int projectId = -1;
                if (DataStore.Instance.Projects.Count > 0)
                {
                    projectId = DataStore.Instance.Projects.Max(p => p.Id);
                }
                Project project = new()
                {
                    Id = projectId + 1,
                    Name = ProjectName.Text,
                    Budget = decimal.Parse(Budget.Text),
                    DateStart = DateOnly.Parse(DateStart.Text),
                    DateEnd = DateOnly.Parse(DateEnd.Text),
                    Description = Description.Text,
                    IdClient = (ClientList.SelectedItem as Client).Id,
                    IdContractor = (ContractorList.SelectedItem as Contractor).Id,
                    State = StateList.Text
                };
                if (RequiredResourceList.Items.Count > 0)
                {
                    foreach (Resource resource in RequiredResourceList.Items)
                    {
                        project.RequiredResources.Add(resource);
                    }
                }
                DataStore.Instance.Projects.Add(project);
                MainWindow.ConnectToWeb.ProjectPost(project);
                JSONDataSaveService.Instance.SaveProjectData(DataStore.Instance.Projects);
                ProjectName.Clear();
                Budget.Clear();
                Description.Clear();
                ClientList.SelectedIndex = -1;
                ContractorList.SelectedIndex = -1;
                StateList.SelectedIndex = -1;
                RequiredResourceList.Items.Clear();
                NavigationService.Navigate(PageController.ProjectPage);
            }
        }

        private void AddRequiredResource(object sender, RoutedEventArgs e)
        {
            RequiredResources requiredResources = new RequiredResources("ProjectCreateForm");
            requiredResources.Show();
        }

        private void RemoveRequiredResource(object sender, RoutedEventArgs e)
        {
            if (RequiredResourceList.SelectedItem != null)
            {
                RequiredResourceList.Items.Remove(RequiredResourceList.SelectedItem);
            }
        }

        private void ClearAllRequiredResources(object sender, RoutedEventArgs e)
        {
            RequiredResourceList.Items.Clear();
        }

        private void Budget_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }
    }
}
