# How to disable print preview in WinUI DataGrid?

This example describes how to disable print preview in WinUI DataGrid

**Disable print preview**

You can disable the print preview in print dialog by setting [PrintTask.IsPreviewEnabled](https://learn.microsoft.com/en-us/uwp/api/windows.graphics.printing.printtask.ispreviewenabled?view=winrt-19041) property to false.

 ```csharp
sfDataGrid.PrintTaskRequested += DataGrid_PrintTaskRequested;

private void DataGrid_PrintTaskRequested(object sender, DataGridPrintTaskRequestedEventArgs e)
{
    e.PrintTask = e.Request.CreatePrintTask("Printing", sourceRequested =>
    {
        sourceRequested.SetSource(e.PrintDocumentSource);
    });

    e.PrintTask.IsPreviewEnabled = false;
} 
 ```