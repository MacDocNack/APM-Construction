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
using System.Windows.Shapes;

namespace APM_Construction.Windows
{
    public partial class ClientForm : Window
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void OK(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(ClientName.Text) && !string.IsNullOrEmpty(Phone.Text))
            {
                int clientId = -1;
                if (DataStore.Instance.Clients.Count > 0)
                {
                    clientId = DataStore.Instance.Clients.Max(t => t.Id);
                }
                Client client = new()
                {
                    Id = clientId + 1,
                    Name = ClientName.Text,
                    Phone = Phone.Text,
                };
                DataStore.Instance.Clients.Add(client);
                MainWindow.ConnectToWeb.ClientPost(client);
                JSONDataSaveService.Instance.SaveClientData(DataStore.Instance.Clients);
                Hide();
            }
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            Hide();
        }
    }
}
