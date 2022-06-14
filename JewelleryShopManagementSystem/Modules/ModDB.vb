Imports System.Data.SqlClient
Module ModDB
    Public Function myconn() As SqlConnection
        Return New SqlConnection("Data Source=SHRIKANT;Initial Catalog=Jewellery;Integrated Security=True")
    End Function
End Module
