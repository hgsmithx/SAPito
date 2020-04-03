Imports System.Data.SqlClient
Imports System.Data
Imports SAPbobsCOM
Public Class Splash

    Shared escogeConexion As New ConnSQL
    Shared cadena As String
    Shared miempresa As SAPbobsCOM.Company

    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles Me.Load
        If (ComprobarConexion.VerificarConexionSQL() = True) Then
            Timer1.Start()

            'Login.cadenasql = cadena ' envia la cadena de conexion al login para que este la use en verificar los datos
            'Me.Hide()
            '' Login.Show()
            'VentanaSAP.Show()
        Else
            VentanaSQL.Show() ' si no conecta envia a la conexion por teclado
            Me.Hide()

        End If

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Panel2.Width += 10
        If (Panel2.Width >= 340) Then
            Timer1.Stop()
            Login.cadenasql = ComprobarConexion.cadena
            Me.Hide()
            'Login.Show()
            VentanaSAP.Show()

        End If
    End Sub

    'Public Function VerificarConexionSQL() As Boolean
    '    cadena = escogeConexion.Conexion
    '    Dim conexion As New SqlConnection(cadena)

    '    Try
    '        conexion.Open()
    '        'MsgBox("Estas conectado a SQL")
    '        conexion.Close()
    '        Return True
    '    Catch ex As Exception
    '        MsgBox("Error al conectar a la base de datos")
    '        MsgBox(ex.Message.ToString)
    '        Return False
    '    End Try
    'End Function
    '''------------------------------------------------------------------------------------------------------------
    'Public Function VerificarConexionSAP() As Boolean
    '    miempresa = New SAPbobsCOM.Company With {
    '        .DbServerType = 9,
    '        .DbUserName = "SYSTEM",
    '        .DbPassword = "Passw0rd",
    '        .UseTrusted = False, 'si la conexion es verificada'
    '        .Server = "10.2.0.202:30015",
    '        .LicenseServer = "10.2.0.202:40000",
    '        .CompanyDB = "ZZ_CAPACITACIONES",
    '        .UserName = "hsmith",
    '        .Password = "1234",
    '        .language = SAPbobsCOM.BoSuppLangs.ln_Spanish
    '    }

    '    Dim resultado As Integer

    '    Try
    '        miempresa.Connect()
    '        If resultado = 0 Then
    '            MsgBox("Estas conectado a SAP Business One")
    '            Return True
    '        Else
    '            MsgBox("No ha sido posible conectarse a SAP Business One")
    '            Return False
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message.ToString)
    '        Return False
    '    End Try
    'End Function

End Class