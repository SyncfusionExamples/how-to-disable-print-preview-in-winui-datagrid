using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.UI.Xaml.Printing;
using Syncfusion.UI.Xaml.Data;
using Syncfusion.UI.Xaml.DataGrid;
using Syncfusion.UI.Xaml.DataGrid.Print;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Printing;
using Windows.Graphics.Printing.OptionDetails;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SfDataGrid_Demo
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            sfDataGrid.PrintTaskRequested += SfDataGrid_PrintTaskRequested;

        }

        private void SfDataGrid_PrintTaskRequested(object sender, DataGridPrintTaskRequestedEventArgs e)
        {
            e.PrintTask = e.Request.CreatePrintTask("Printing", sourceRequested => {
                sourceRequested.SetSource(e.PrintDocumentSource);
            }); e.PrintTask.IsPreviewEnabled = false;
        }

        private void OnPrint(object sender, RoutedEventArgs e)
        {
            sfDataGrid.Print(this);
        }
    }
}
