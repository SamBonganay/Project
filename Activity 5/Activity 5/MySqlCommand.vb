Friend Class MySqlCommand
    Public Property CommandText As String
    Public Property Connection As Object

    Friend Sub ExecuteNonQuery()
        Throw New NotImplementedException()
    End Sub

    Friend Function ExecuteReader() As MySqlDataReader
        Throw New NotImplementedException()
    End Function
End Class
