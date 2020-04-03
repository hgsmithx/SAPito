Imports System.Data.SqlClient
Imports SAPbobsCOM
Public Class ComprobarConexion
    Public Shared escogeConexion As New ConnSQL
    Public Shared cadena As String
    Public Shared miempresa As SAPbobsCOM.Company



    Public Shared Function VerificarConexionSQL() As Boolean
        cadena = escogeConexion.Conexion
        Dim conexion As New SqlConnection(cadena)

        Try
            conexion.Open()
            'MsgBox("Estas conectado a SQL")
            conexion.Close()
            Return True
        Catch ex As Exception
            MsgBox("Error al conectar a la base de datos")
            MsgBox(ex.Message.ToString)
            Return False
        End Try
    End Function
    ''------------------------------------------------------------------------------------------------------------
    Public Shared Function VerificarConexionSAP() As Boolean
        miempresa = New SAPbobsCOM.Company With {
            .DbServerType = 9,
            .DbUserName = "SYSTEM",
            .DbPassword = "Passw0rd",
            .UseTrusted = False, 'si la conexion es verificada'
            .Server = "10.2.0.202:30015",
            .LicenseServer = "10.2.0.202:40000",
            .CompanyDB = "ZZ_CAPACITACIONES",
            .UserName = "hsmith",
            .Password = "1234",
            .language = SAPbobsCOM.BoSuppLangs.ln_Spanish
        }

        Dim resultado As Integer

        Try
            miempresa.Connect()
            If resultado = 0 Then
                MsgBox("Estas conectado a SAP Business One")
                Return True
            Else
                MsgBox("No ha sido posible conectarse a SAP Business One")
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            Return False
        End Try
    End Function
End Class
