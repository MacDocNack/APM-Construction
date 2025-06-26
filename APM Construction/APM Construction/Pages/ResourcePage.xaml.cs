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
    public partial class ResourcePage : Page
    {
        public ResourcePage()
        {
            InitializeComponent();

            ResourceList.SetBinding(DataGrid.ItemsSourceProperty, new Binding()
            {
                Source = DataStore.Instance.Resources
            });
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            ResourcesForm resourcesForm = new ResourcesForm();
            resourcesForm.Show();
            if (resourcesForm.DialogResult == false) resourcesForm.Hide();
        }

        private void Edit(object sender, RoutedEventArgs e)
        {
            if (ResourceList.SelectedItem != null)
            {
                ResourcesForm resourcesForm = new ResourcesForm(ResourceList.SelectedItem as Resource);
                resourcesForm.Show();
            }
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            if (ResourceList.SelectedItem != null)
            {
                MainWindow.ConnectToWeb.ResourceDelete(ResourceList.SelectedItem as Resource);
                DataStore.Instance.Resources.Remove(ResourceList.SelectedItem as Resource);
                ResourceList.Items.Refresh();
                JSONDataSaveService.Instance.SaveResourceData(DataStore.Instance.Resources);
            }
        }
        private void GoBack(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
