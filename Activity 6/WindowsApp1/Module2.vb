Imports Microsoft.Office.Interop
Module Module2
    '==================================================================
    'Demonstrates Using WithEvents for Event Handling
    '==================================================================
    Private WithEvents xlApp As Excel.Application
    Private xlBook As Excel.Workbook
    Private WithEvents xlSheet1 As Excel.Worksheet
    Private WithEvents xlSheet2 As Excel.Worksheet
    Private WithEvents xlSheet3 As Excel.Worksheet
    Public Sub UseWithEvents()
        'Start Excel and then create a new workbook.
        xlApp = CreateObject("Excel.Application")
        xlBook = xlApp.Workbooks.Add()
        xlBook.Windows(1).Caption = "Uses WithEvents"
        'Get references to the three worksheets.
        xlSheet1 = xlBook.Worksheets.Item(1)
        xlSheet2 = xlBook.Worksheets.Item(2)
        xlSheet3 = xlBook.Worksheets.Item(3)
        CType(xlSheet1, Excel._Worksheet).Activate()
        'Make Excel visible and give the user control.
        xlApp.Visible = True
        xlApp.UserControl = True
    End Sub
    Private Sub xlApp_WorkbookBeforeClose(ByVal Wb As Excel.Workbook,
 ByRef Cancel As Boolean) Handles xlApp.WorkbookBeforeClose
        Debug.WriteLine("WithEvents: Closing the workbook.")
        Wb.Saved = True 'Set the dirty flag to true so there is no prompt
to save
 End Sub
    Private Sub xlSheet1_Change(ByVal Target As Excel.Range) Handles
xlSheet1.Change
        Debug.WriteLine("WithEvents: You Changed Cells " + Target.Address
+ " on Sheet1")
 End Sub
    Private Sub xlSheet2_Change(ByVal Target As Excel.Range) Handles
xlSheet2.Change
        Debug.WriteLine("WithEvents: You Changed Cells " + Target.Address
+ " on Sheet2")
 End Sub
    Private Sub xlSheet3_Change(ByVal Target As Excel.Range) Handles
xlSheet3.Change
        Debug.WriteLine("WithEvents: You Changed Cells " + Target.Address
+ " on Sheet3")
 End Sub

End Module
