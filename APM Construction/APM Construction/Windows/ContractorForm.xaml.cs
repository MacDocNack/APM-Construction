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
    public partial class ContructorForm : Window
    {
        public ContructorForm()
        {
            InitializeComponent();
        }

        private void OK(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(ContractorName.Text) && !string.IsNullOrEmpty(Phone.Text))
            {
                int contractorId = -1;
                if (DataStore.Instance.Contractors.Count > 0)
                {
                    contractorId = DataStore.Instance.Contractors.Max(t => t.Id);
                }
                Contractor contractor = new()
                {
                    Id = contractorId + 1,
                    Name = ContractorName.Text,
                    Phone = Phone.Text,
                };
                DataStore.Instance.Contractors.Add(contractor);
                MainWindow.ConnectToWeb.ContractorPost(contractor);
                JSONDataSaveService.Instance.SaveContractorData(DataStore.Instance.Contractors);
                Hide();
            }
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            Hide();
        }
    }
}
