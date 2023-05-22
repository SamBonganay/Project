Imports Acvitity_4__Bonganay_.Excel

Namespace Microsoft
    Friend Class Office
        Friend Class Interop
            Friend Class Excel
                Friend Class Worksheet
                    Friend Function Range(v1 As String, v2 As String) As Range
                        Throw New NotImplementedException()
                    End Function

                    Public Shared Narrowing Operator CType(v As _Worksheet) As Worksheet
                        Throw New NotImplementedException()
                    End Operator
                End Class

                Friend Class WorksheetCollection
                    Public Shared Widening Operator CType(v As Sheets) As WorksheetCollection
                        Throw New NotImplementedException()
                    End Operator

                    Public Shared Widening Operator CType(v As Acvitity_4__Bonganay_.Excel.Sheets) As WorksheetCollection
                        Throw New NotImplementedException()
                    End Operator
                End Class

                Friend Class Sheets
                    Friend Function Item(v As Integer) As Object
                        Throw New NotImplementedException()
                    End Function
                End Class
            End Class
        End Class
    End Class
End Namespace
