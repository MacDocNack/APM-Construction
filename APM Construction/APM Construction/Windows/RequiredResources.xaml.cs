using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace APM_Construction.Windows
{
    public partial class RequiredResources : Window
    {
        private string _currentNamePage;
        public RequiredResources(string namePage)
        {
            InitializeComponent();

            _currentNamePage = namePage;

            ResourceList.SetBinding(DataGrid.ItemsSourceProperty, new Binding()
            {
                Source = DataStore.Instance.Resources
            });
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            Hide();
        }

        private void Select(object sender, RoutedEventArgs e)
        {
            if (ResourceList.SelectedItem != null)
            {
                PageController.GetPageForSelectedResource(_currentNamePage, ResourceList.SelectedItem);
                Hide();
            }
        }
    }
}
