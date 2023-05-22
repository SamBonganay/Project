Namespace Excel
    Friend Class Application
        Public Property UserControl As Boolean
        Public Property Visible As Boolean

        Friend Function Workbooks() As Workbooks
            Throw New NotImplementedException()
        End Function
    End Class
End Namespace
