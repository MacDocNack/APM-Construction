using APM_Construction.Models;
using System.Windows;

namespace APM_Construction.Windows
{
    public partial class ResourcesForm : Window
    {
        private Resource _resource;
        public ResourcesForm()
        {
            InitializeComponent();
        }

        public ResourcesForm(Resource resource)
        {
            InitializeComponent();
            _resource = resource;
            if (_resource != null)
            {
                ResourceName.Text = _resource.Name;
                Unit.Text = _resource.Unit.ToString();
                PriceForUnit.Text = _resource.PriceForUnit.ToString();
            }
        }

        private void OK(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(ResourceName.Text) && !string.IsNullOrEmpty(Unit.Text) && !string.IsNullOrEmpty(PriceForUnit.Text))
            {
                if (_resource != null)
                {
                    _resource = new()
                    {
                        Id = _resource.Id,
                        Name = ResourceName.Text,
                        Unit = Unit.Text,
                        PriceForUnit = decimal.Parse(PriceForUnit.Text),
                    };
                    DataStore.Instance.Resources[_resource.Id - 1] = _resource;
                    MainWindow.ConnectToWeb.ResourcePut(_resource);
                    Hide();
                }
                else
                {
                    _resource = new()
                    {
                        Id = DataStore.Instance.Resources.Max(r => r.Id) + 1,
                        Name = ResourceName.Text,
                        Unit = Unit.Text,
                        PriceForUnit = decimal.Parse(PriceForUnit.Text),
                    };
                    DataStore.Instance.Resources.Add(_resource);
                    MainWindow.ConnectToWeb.ResourcePost(_resource);
                    Hide();
                }
                JSONDataSaveService.Instance.SaveResourceData(DataStore.Instance.Resources);
            }
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            Hide();
        }
    }
}
