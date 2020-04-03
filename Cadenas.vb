Imports System.Data.SqlClient
Imports System.Data

Public Class Cadenas
    Dim sql As String

    Public Function EscogeConexion() As String
        Dim parametro As String
        If My.Computer.Network.Ping("10.2.0.111") Then

            parametro = " Data Source=186.10.19.202\CULLULFE,1433;Initial Catalog=SAPito; User ID=practicaSAP;Password=12345"
        Else
            parametro = " Data Source=186.10.19.202\CULLULFE,1433;Initial Catalog=SAPito; User ID=practicaSAP;Password=12345"
        End If
        Return parametro
    End Function
End Class
