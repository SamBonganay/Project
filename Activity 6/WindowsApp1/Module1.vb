Imports Microsoft.Office.Interop
Module Module1
    '==================================================================
    'Demonstrates Using a Delegate for Event Handling
    '==================================================================
    Private xlApp As Excel.Application
    Private xlBook As Excel.Workbook
    Private xlSheet1 As Excel.Worksheet
    Private xlSheet2 As Excel.Worksheet
    Private xlSheet3 As Excel.Worksheet
    Private EventDel_BeforeBookClose As
Excel.AppEvents_WorkbookBeforeCloseEventHandler
 Private EventDel_CellsChange As Excel.DocEvents_ChangeEventHandler
    Public Sub UseDelegate()
        'Start Excel and then create a new workbook.
        xlApp = CreateObject("Excel.Application")
        xlBook = xlApp.Workbooks.Add()
        xlBook.Windows(1).Caption = "Uses WithEvents"
        'Get references to the three worksheets.
        xlSheet1 = xlBook.Worksheets.Item(1)
        xlSheet2 = xlBook.Worksheets.Item(2)
        xlSheet3 = xlBook.Worksheets.Item(3)
        CType(xlSheet1, Excel._Worksheet).Activate()
        'Add an event handler for the WorkbookBeforeClose event of the
        'Application object.
        EventDel_BeforeBookClose = New
Excel.AppEvents_WorkbookBeforeCloseEventHandler(
 AddressOf BeforeBookClose)
        AddHandler xlApp.WorkbookBeforeClose, EventDel_BeforeBookClose
        'Add an event handler for the Change event of both Worksheet
        'objects.
        EventDel_CellsChange = New Excel.DocEvents_ChangeEventHandler(
        AddressOf CellsChange)
        AddHandler xlSheet1.Change, EventDel_CellsChange
        AddHandler xlSheet2.Change, EventDel_CellsChange
        AddHandler xlSheet3.Change, EventDel_CellsChange
        'Make Excel visible and give the user control.
 xlApp.Visible = True
 xlApp.UserControl = True
 End Sub
Private Sub CellsChange(ByVal Target As Excel.Range)
 'This is called when a cell or cells on a worksheet are changed.
 Debug.WriteLine("Delegate: You Changed Cells " + Target.Address +
" on " + _
 Target.Worksheet.Name())
 End Sub
Private Sub BeforeBookClose(ByVal Wb As Excel.Workbook, ByRef Cancel
As Boolean)
 'This is called when you choose to close the workbook in Excel.
 'The event handlers are removed and then the workbook is closed
 'without saving changes.
 Debug.WriteLine("Delegate: Closing the workbook and removing
event handlers.")
 RemoveHandler xlSheet1.Change, EventDel_CellsChange
 RemoveHandler xlSheet2.Change, EventDel_CellsChange
 RemoveHandler xlSheet3.Change, EventDel_CellsChange
 RemoveHandler xlApp.WorkbookBeforeClose, EventDel_BeforeBookClose
 Wb.Saved = True 'Set the dirty flag to true so there is no prompt
to save.
 End Sub
End Module
