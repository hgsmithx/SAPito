Imports System.Data.SqlClient
Imports System.Data

Public Class Login
    Shared sql, cadena As String
    Dim lector As SqlDataReader 'data reader lee'
    'Dim tipoconexion As Cadenas = New Cadenas()
    Public Shared cadenasql As String
    'Dim miEmpresa As SAPbobsCOM.Company

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Application.Exit()
    End Sub

    Private Sub btn_ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click

        'cadenasql = VentanaSQL.cadena
        'MsgBox(cadenasql)
        sql = "SELECT idUsuario,Nombre FROM Usuarios" &
              " WHERE(idUsuario =@codigo And Password=@pass) "

        Dim conexion As New SqlConnection(cadenasql) 'cadena recivida en la primera verificacion 
        Dim comando As New SqlCommand(sql, conexion)

        comando.Parameters.Add("@codigo", SqlDbType.NChar).Value = txtUsuario_fondo.text
        comando.Parameters.Add("@pass", SqlDbType.NChar).Value = txtPass.text

        Try
            conexion.Open()
            lector = comando.ExecuteReader 'lee la base de datos
            '    comando.ExecuteNonQuery()      ''' estas 2 lineas sirven para insert
            '  MsgBox("registro insertado")
            If lector.Read Then
                'MsgBox("login correcto")
                MenúPrincipal.nombreUsuario = lector(1).ToString
                'lblnombre.text=lector(0)+""+lector(1)
                conexion.Close()
                MenúPrincipal.Show()
                Me.Hide()
            Else
                MsgBox("Usuario o contraseña incorrectos", MsgBoxStyle.Critical)
                conexion.Close()
            End If


        Catch ex As Exception  'toma la variable ex que es de excepcion y mandarlo por string 
            MsgBox("Se ha perdido la conexion")
            conexion.Close()
        End Try


    End Sub

    Private Sub txtPass_OnTextChange(sender As Object, e As EventArgs) Handles txtPass.OnTextChange

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
    'Public Property setCadenaSQL()
    '    Get
    '        Return cadenasql
    '    End Get
    '    Set(value)
    '        cadenasql = value
    '    End Set
    'End Property

    'Public Property setObjectSAP()
    '    Get

    '    End Get
    '    Set(value)

    '    End Set
    'End Property
End Class