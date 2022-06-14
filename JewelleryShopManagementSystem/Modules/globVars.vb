Imports System.Data.SqlClient
Module globVars
    Public con As SqlConnection = myconn()
    Public result As Integer
    'Public cmd As New MySqlCommand
    Public cmd As New SqlCommand
    'Public da As New MySqlDataAdapter
    Public da As New SqlDataAdapter
    'Public dReader As MySqlDataReader
    Public dReader As SqlDataReader
    Public ds As New DataSet
    Public sql As String = ""
    Public reportselect, reportname As String
    Public switch, switchcurr As String
    Public issucess As Boolean
    Public fullname As String = ""
    Public usertype As String = ""
    Public UserName As String = ""

    Public GLOBALid As Integer = Nothing
    Public GLOBALMessage As String = ""
    Public SaveMessage As String = ""
    Public Statactive As String

    Public noResult As Integer
    Public RESIDENCEID As Integer
    Public LNAME As String = ""
    Public FNAME As String = ""
    Public MNAME As String = ""
    Public ext As String = ""
    Public NO As String = ""
    Public STREET As String = ""
    Public PRK As String = ""
    Public POB As String = ""
    Public DOB As String = ""
    Public SEX As String = ""
    Public CIVIL As String = ""
    Public CITIZENSHIP As String = ""
    Public OCCUPATION As String = ""
    Public CLEARANCE As String = ""
    Public userMsg As String
    Public imgpath As String
    Public arrImage() As Byte
    Public Query As String
    Public position As String

    Public Sub jokenfindthis(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub
    Public Function jokeninsert(ByVal sql As String) As Boolean

        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql

                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    Return False
                Else
                    Return True
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()

        End Try

    End Function


    Public Function jokenupdate(ByVal sql As String) As Boolean
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then

                    Return False
                Else
                    Return True

                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()

        End Try

    End Function



    Public Function jokendelete(ByVal sql As String) As Boolean
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    Return False
                Else
                    Return True
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()

        End Try

    End Function
End Module
