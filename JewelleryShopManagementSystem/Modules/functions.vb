Module functions
    Public Function NumRows() As Integer
        Try
            con.Open()
            dReader = cmd.ExecuteReader()
            Do While dReader.Read = True
                Return dReader(0)
            Loop

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Function
End Module
