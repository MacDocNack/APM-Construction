using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace APM_Construction
{
    public partial class MainWindow : Window
    {
        public static ConnectToWeb ConnectToWeb = new ConnectToWeb();
        public MainWindow()
        {
            InitializeComponent();

            DataContext = DataStore.Instance;

            DataStore.Instance.LoadAll(ConnectToWeb);
            DataStore.Instance.Roles.Add(new Models.Role(0, "Admin"));
            DataStore.Instance.Roles.Add(new Models.Role(1, "Manager"));
            DataStore.Instance.Roles.Add(new Models.Role(2, "Worker"));

            AppFrame.Navigate(PageController.AuthorizationPage);
        }
    }
}