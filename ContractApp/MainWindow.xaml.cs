using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace ContractApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PrintButtonClick(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            IDocumentPaginatorSource source = contractDocument;

            if (printDialog.ShowDialog() == true)
            {
                printDialog.PrintDocument(source.DocumentPaginator, "Contract document");
            }
        }
    }
}
