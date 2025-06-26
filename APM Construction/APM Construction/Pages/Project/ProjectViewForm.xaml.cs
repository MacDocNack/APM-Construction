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
    public partial class ProjectViewForm : Page
    {
        private Project _projectToView;
        public ProjectViewForm()
        {
            InitializeComponent();
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(PageController.ProjectPage);
        }

        public void GetProjectToView(Project project)
        {
            _projectToView = project;
            ProjectName.Text = _projectToView.Name;
            Budget.Text = _projectToView.Budget.ToString();
            ClientName.Text = DataStore.Instance.Clients[_projectToView.IdClient].Name;
            ClientPhone.Text = DataStore.Instance.Clients[_projectToView.IdClient].Phone;
            ContractorName.Text = DataStore.Instance.Contractors[_projectToView.IdContractor].Name;
            ContractorPhone.Text = DataStore.Instance.Contractors[_projectToView.IdContractor].Phone;
            Description.Text = _projectToView.Description;
            State.Text = _projectToView.State.ToString();
            DateStart.Text = _projectToView.DateStart.ToString();
            DateEnd.Text = _projectToView.DateEnd.ToString();
            if (_projectToView.RequiredResources.Count > 0)
            {
                foreach (var resource in _projectToView.RequiredResources)
                {
                    RequiredResourceList.Items.Add(resource);
                }
            }
        }
    }
}
