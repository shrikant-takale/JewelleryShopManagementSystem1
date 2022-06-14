Module usercontroller
    Public Sub loadsingleUser(ByVal param As String)
        Try
            con.Open()
            dReader = cmd.ExecuteReader()
            '  obj.Rows.Clear()
            Select Case param
                Case "login"
                    Do While dReader.Read = True
                        If dReader("Numresult") = 1 Then
                            UserName = dReader("UserName")
                            usertype = dReader("UserType")
                            'fullname = dReader("EMPNAME")
                        End If
                    Loop
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            da.Dispose()
            con.Close()
        End Try
    End Sub
End Module
