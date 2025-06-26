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
    public partial class ProjectEditForm : Page
    {
        private Project _projectToEdit;

        public ProjectEditForm()
        {
            InitializeComponent();

            StateList.Items.Add("В процессе");
            StateList.Items.Add("Завершён");
            StateList.Items.Add("Приостановлен");
            StateList.SelectedIndex = 0;
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(PageController.ProjectPage);
        }

        private void EditProject(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Budget.Text) && DateStart.Text != DateEnd.Text)
            {
                Project existProject = DataStore.Instance.Projects.FirstOrDefault(p => p.Id == _projectToEdit.Id);
                existProject.Name = ProjectName.Text;
                existProject.Budget = decimal.Parse(Budget.Text);
                existProject.State = StateList.Text;
                existProject.DateStart = DateOnly.Parse(DateStart.Text);
                existProject.DateEnd = DateOnly.Parse(DateEnd.Text);
                if (RequiredResourceList.Items.Count > 0)
                {
                    foreach (Resource resource in RequiredResourceList.Items)
                    {
                        existProject.RequiredResources.Add(resource);
                    }
                }
                PageController.ProjectPage.ProjectList.Items.Refresh();
                MainWindow.ConnectToWeb.ProjectPut(existProject);
                JSONDataSaveService.Instance.SaveProjectData(DataStore.Instance.Projects);
                Budget.Clear();
                RequiredResourceList.Items.Clear();
                NavigationService.Navigate(PageController.ProjectPage);
            }
        }

        private void AddRequiredResource(object sender, RoutedEventArgs e)
        {
            RequiredResources requiredResources = new RequiredResources("ProjectEditForm");
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

        public void GetProjectToEdit(Project project)
        {
            RequiredResourceList.Items.Clear();
            _projectToEdit = project;
            ProjectName.Text = _projectToEdit.Name;
            Budget.Text = _projectToEdit.Budget.ToString();
            ClientName.Text = DataStore.Instance.Clients[_projectToEdit.IdClient].Name;
            ClientPhone.Text = DataStore.Instance.Clients[_projectToEdit.IdClient].Phone;
            ContractorName.Text = DataStore.Instance.Contractors[_projectToEdit.IdContractor].Name;
            ContractorPhone.Text = DataStore.Instance.Contractors[_projectToEdit.IdContractor].Phone;
            Description.Text = _projectToEdit.Description;
            StateList.SelectedItem = _projectToEdit.State;
            DateStart.Text = _projectToEdit.DateStart.ToString();
            DateEnd.Text = _projectToEdit.DateEnd.ToString();
            if (_projectToEdit.RequiredResources.Count > 0)
            {
                foreach (var resource in _projectToEdit.RequiredResources)
                {
                    RequiredResourceList.Items.Add(resource);
                }
            }
        }

        private void Budget_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }
    }
}
