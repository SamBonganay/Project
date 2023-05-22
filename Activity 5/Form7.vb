Imports Acvitity_4__Bonganay_.Excel
Imports Acvitity_4__Bonganay_.Microsoft.Office.Interop.Excel
Public Class Form7
    'Keep the application object and the workbook object global, so you can
    'retrieve the data in Button2_Click that was set in Button1_Click.
    ReadOnly objApp As Excel.Application
    ReadOnly objBook As Acvitity_4__Bonganay_.Excel._Workbook

    Private ReadOnly Property ObjSheets1 As Excel.Sheets
        Get
            Return ObjSheets()
        End Get
    End Property

    Private Function GetObjSheets(objSheets As Excel.Sheets) As Excel.Sheets
        Return objSheets
    End Function

    Private Function ObjSheets() As Excel.Sheets
        Throw New NotImplementedException()
    End Function
    Private Function ObjSheet() As Excel._Worksheet
        Throw New NotImplementedException()
    End Function

    ReadOnly oldArray(5, 5) As String

    Private Function GetObjSheets(objBook As _Workbook) As Acvitity_4__Bonganay_.Microsoft.Office.Interop.Excel.WorksheetCollection
        Dim worksheets As Excel.Sheets = objBook.Worksheets
        Return worksheets
    End Function

    Private Function GetObjSheets() As Excel.Sheets
        Return ObjSheets()
    End Function


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button1.Click

        ' Create a new instance of Excel and start a new workbook.
        Dim objApp = New Excel.Application()
        Dim objBooks = objApp.Workbooks
        Dim objBook = objBooks.Add
        Dim objSheets = objBook.Worksheets
        Dim objSheet = objSheets.Item(1)

        'Get the range where the starting cell has the address
        'm_sStartingCell and its dimensions are m_iNumRows x m_iNumCols.
        Dim range = objSheet.Range("A1", Reflection.Missing.Value)
        range = range.Resize(5, 5)

        If (Me.FillWithStrings.Checked = False) Then

            'Create an array.
            Dim oldArray(5, 5) As Double

            'Fill the array.
            Dim iRow As Long
            Dim iCol As Long
            For iRow = 0 To 5
                For iCol = 0 To 5

                    'Put a counter in the cell.
                    oldArray(iRow, iCol) = iRow * iCol
                Next iCol
            Next iRow

            'Set the range value to the array.
            range.Value = oldArray
        Else

            'Create an array.
            Dim oldArray(5, 5) As String

            'Fill the array.
            Dim iRow As Long
            Dim iCol As Long
            For iRow = 0 To 5
                For iCol = 0 To 5

                    'Put the row and column address in the cell.
                    oldArray(iRow, iCol) = iRow & "|" & iCol
                Next iCol
            Next iRow

            'Create a new array.
            Dim newArray(5, 5) As String

        End If

        'Return control of Excel to the user.
        objApp.Visible = True
        objApp.UserControl = True

        'Clean up a little.
    End Sub
    Private Function FillWithStrings() As Object
        Throw New NotImplementedException()
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim objSheets As Excel.Sheets
        Dim objSheet As Excel._Worksheet
        Dim range As Excel.Range
        'Get a reference to the first sheet of the workbook.
        On Error GoTo ExcelNotRunning
        objSheets = objBook.Worksheets
        objSheet = objSheets(1)
ExcelNotRunning:
        If (Not (Err.Number = 0)) Then
            MessageBox.Show("Cannot find the Excel workbook. Try clicking
Button1 to " +
            "create an Excel workbook with data before running Button2.",
            "Missing Workbook?")
            'We cannot automate Excel if we cannot find the data we created,
            'so leave the subroutine.
            Exit Sub
        End If
        'Get a range of data.
        range = objSheet.Range("A1", "E5")
        'Retrieve the data from the range.
        Dim saRet(,) As Object
        saRet = range.Value
        'Determine the dimensions of the array.
        Dim iRows As Long
        Dim iCols As Long
        iRows = saRet.GetUpperBound(0)
        iCols = saRet.GetUpperBound(1)
        'Build a string that contains the data of the array.
        Dim valueString As String
        valueString = "Array Data" + vbCrLf
        Dim rowCounter As Long
        Dim colCounter As Long
        For rowCounter = 1 To iRows
            For colCounter = 1 To iCols
                'Write the next value into the string.
                valueString = String.Concat(valueString,
                saRet(rowCounter, colCounter).ToString() + ", ")
            Next colCounter
            'Write in a new line.
            valueString = String.Concat(valueString, vbCrLf)
        Next rowCounter
        'Report the value of the array.
        MessageBox.Show(valueString, "Array Values")
        'Clean up a little.
        range = Nothing
        objSheet = Nothing
        objSheets = Nothing
    End Sub
End Class

