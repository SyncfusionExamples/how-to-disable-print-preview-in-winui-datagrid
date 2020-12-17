using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Syncfusion.UI.Xaml.DataGrid.Print;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUIDemoApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.sfDataGrid.PrintTaskRequested += DataGrid_PrintTaskRequested;
        }

       

        private void DataGrid_PrintTaskRequested(object sender, DataGridPrintTaskRequestedEventArgs e)
        {
            e.PrintTask = e.Request.CreatePrintTask("Printing", sourceRequested =>
            {
                sourceRequested.SetSource(e.PrintDocumentSource);
            });
            e.PrintTask.IsPreviewEnabled = false;
        }

        private void printButton_Click(object sender, RoutedEventArgs e)
        {           
            sfDataGrid.PrintSettings.FitColumnsOnSinglePage = true;
            sfDataGrid.Print();
        }
    }
}
