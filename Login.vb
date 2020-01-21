Imports System.Data.SqlClient
Imports System.Data

Public Class Login
    Dim sql, cadena As String
    Dim lector As SqlDataReader 'data reader lee'
    Dim tipoconexion As Cadenas = New Cadenas()
    Public cadenasql As String
    Dim miEmpresa As SAPbobsCOM.Company

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Application.Exit()
    End Sub

    Private Sub btn_ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click


        sql = "SELECT idUsuario,Nombre FROM Usuarios" &
              " WHERE(idUsuario =@codigo And Password=@pass) "
        'sql = "INSERT INTO Usuarios (idUsuario,Password) VALUES " &    'estos dos no se pueden mezclar en  este mismo momento
        '     " (@codigo,@pass)"
        'cadena = tipoconexion.EscogeConexion()

        Dim conexion As New SqlConnection(cadenasql)
        Dim comando As New SqlCommand(sql, conexion)

        comando.Parameters.Add("@codigo", SqlDbType.NChar).Value = txtUsuario.text
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
                'Login debe recibir la cadena sql y enviarla al menu
                MenúPrincipal.getCadenaSQL = cadenasql
                MenúPrincipal.Show()
            Else
                MsgBox("Usuario o contraseña incorrectos", MsgBoxStyle.Critical)
                conexion.Close()
            End If


        Catch ex As Exception  'toma la variable ex que es de excepcion y mandarlo por string 
            MsgBox(ex.Message.ToString)
            conexion.Close()
        End Try


    End Sub
    Public Property setCadenaSQL()
        Get
            Return cadenasql
        End Get
        Set(value)
            cadenasql = value
        End Set
    End Property

    Public Property setObjectSAP()
        Get

        End Get
        Set(value)

        End Set
    End Property


    Public Function objectSAP(objeto As SAPbobsCOM.Company)

        miEmpresa = objeto
        ' miEmpresa.Connect()
        'If miEmpresa.Connect = 0 Then
        MsgBox("conectado")
        ' End If

    End Function
End Class