Imports System.Data.SqlClient
Public Class VentanaSQL
    Public cadena As String
    Dim tipoConexion As ConnSQL = New ConnSQL
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Carga los datos del servidor a los textBox
        txtDataSource.Text = "186.10.19.202\CULLULFE"
        txtPuerto.Text = "1433"
        txtNombreDB.Text = "SAPito"
        txtIdUsuario.Text = "practicaSAP"
        txtContraseña.Text = "12345"
    End Sub

    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        'Envia los datos para establecer la conexiñon
        Dim Data, Puerto, NombreDB, Usuario, Contraseña As String
        Data = txtDataSource.Text
        Puerto = txtPuerto.Text
        NombreDB = txtNombreDB.Text
        Usuario = txtIdUsuario.Text
        Contraseña = txtContraseña.Text
        'cadena que almacena los datos de la conexion
        cadena = tipoConexion.ObtenerCadena(Data, Puerto, NombreDB, Usuario, Contraseña) 'Envia datos a funcion de ConSQL
        'MsgBox(cadena)
        'Funcion retorna un String

        'Dim VentanaSAP As New Form_SAP ' Objeto de formulario sap 
        'VentanaSAP.setCadenaSQL = cadena ' setea en el objeto de sap la cadena de SQL 


        Dim conexion As New SqlConnection(cadena)
        Try
            conexion.Open()
            'MsgBox("Conexion exitosa", MsgBoxStyle.MsgBoxRight)
            conexion.Close()
            VentanaSAP.setCadenaSQL = cadena
            VentanaSAP.Show()
            'Form_SAP.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox("Error al conectar a SQL")
            conexion.Close()
        End Try
    End Sub

    Private Sub btn_buniExit_Click(sender As Object, e As EventArgs) Handles btn_buniExit.Click
        Me.Close()
    End Sub

    Private Sub btn_buniMinimizar_Click(sender As Object, e As EventArgs) Handles btn_buniMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

End Class

