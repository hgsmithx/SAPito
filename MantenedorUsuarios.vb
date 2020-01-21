Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.DataTable

Public Class MantenedorUsuarios
    Dim sql, cadenaSQL As String
    Dim lectura As SqlDataReader 'data reader lee'
    Dim tipoconexion As Cadenas = New Cadenas()
    Dim tabla As New DataTable
    Dim conexion As New SqlConnection(cadenaSQL)

    Private Sub MantenedorUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'btn_Agregar.Visible = False
        'btn_Agregar.Visible = True
        'cadena = tipoconexion.EscogeConexion
        Dim conexion As New SqlConnection(cadenaSQL)

        sql = "SELECT  idusuario as 'Id de Usuario', Password as 'Contraseña' , Nombre as 'Nombre usuario'  from Usuarios"
        Dim da As New SqlDataAdapter(sql, conexion)
        Try
            conexion.Open()
            tabla.Clear()
            da.Fill(tabla) ' Carga los datos de la consulta en la tabla
            grilla.DataSource = Nothing ' el grid carga la tabla'
            grilla.DataSource = tabla
            grilla.Columns(0).ReadOnly = True 'Para no editar el id
            conexion.Close()
        Catch ex As Exception
            MsgBox("todo mal")
            conexion.Close()
        End Try
        ''Apenas se carga la ventana , se cargan los datos de la bd'
        'cadena = tipoconexion.EscogeConexion
        'Dim conexion As New SqlConnection(cadena)

        'sql = "SELECT idUsuario As 'Id de usuario',Nombre ,Password As 'Contraseña' FROM Usuarios"
        'Dim da As New SqlDataAdapter(sql, conexion) 'adaptador arreglo, que permite hacer cosas en base de datos y cargarlos a algo'
        ''Dim tabla As New DataTable                  'maneja los datos del select'

        'Try
        '    conexion.Open()
        '    da.Fill(tabla)                                    'Fill:actualiza filas'
        '    grilla.DataSource = tabla                    'hasta aqui se obtiene la grilla'
        '    'buni_grilla.Columns(0).Width = 80                 'tamaño de una celda
        '    grilla.Columns(0).ReadOnly = True           'Esa celda no sea editable'

        '    'lbl_mensaje.Text = tabla.Rows.Count.ToString     'cuantas columnas rescató de la base de datos
        '    'btn_buniBuscar.Enabled = True                    'una vez que me cargue va a permitir el boton '

        'Catch ex As Exception
        '    MsgBox(ex.Message.ToString)
        '    conexion.Close()
        'End Try
    End Sub


    '''''''''''''''''''''''''
    '''''boton agregar'''''''
    '''''''''''''''''''''''''
    Private Sub btn_Agregar_Click(sender As Object, e As EventArgs) Handles btn_Agregar.Click
        Dim conexion As New SqlConnection(cadenaSQL)
        If (txtbuni_ID.Text = "" Or txtbuni_Nombre.Text = "" Or txtbuni_Contraseña.Text = "") Then

            MsgBox("No deben existir campos vacios", MsgBoxStyle.Critical)
        Else
            Using conexion
                conexion.Open()
                Dim sql2 As String = "INSERT Usuarios (idUsuario,Nombre,Password) values (@idusuario,@password,@nombre)"


                Try
                    'For Each fila As DataGridViewRow In grilla.Rows ' variable fila recorre hasta que se acaben las columnas
                    Dim comando2 As New SqlCommand(sql2, conexion)
                    'para crear un parametro y cargarle un valor
                    comando2.Parameters.Add("@idusuario", SqlDbType.NChar).Value = txtbuni_ID.Text
                    comando2.Parameters.Add("@password", SqlDbType.NChar).Value = txtbuni_Contraseña.Text
                    comando2.Parameters.Add("@nombre", SqlDbType.NChar).Value = txtbuni_Nombre.Text
                    comando2.ExecuteNonQuery()

                    'hacer un update para no enviar los datos nuevamente'
                    'End Using

                    MsgBox("DATOS GUARDADOS CORRECTAMENTE")
                    Dim da As New SqlDataAdapter(sql, conexion)
                    tabla.Clear()
                    da.Fill(tabla) ' Carga los datos de la consulta en la tabla
                    grilla.DataSource = Nothing ' el grid carga la tabla'
                    grilla.DataSource = tabla
                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                    conexion.Close()
                End Try


            End Using
        End If

    End Sub


    '''''''''''''''''''''''''
    '''''boton eliminar''''''
    '''''''''''''''''''''''''
    Private Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click
        Dim conexion As New SqlConnection(cadenaSQL)

        'Using conexion
        conexion.Open()
        Dim sql2 As String = "Delete FROM Usuarios  Where idUsuario=@codigo"
        ' @selec = grilla.CurrentRow.Cells(0).Value)

        Dim comando2 As New SqlCommand(sql2, conexion)
        comando2.Parameters.Add("@codigo", SqlDbType.NChar).Value = grilla.CurrentRow.Cells(0).Value
        comando2.ExecuteNonQuery()


        grilla.Rows.Remove(grilla.CurrentRow)


    End Sub

    '''''''''''''''''''''''''
    '''''Boton actualizar''''
    '''''''''''''''''''''''''
    Private Sub btn_Actualizar_Click(sender As Object, e As EventArgs) Handles btn_Actualizar.Click
        Dim conexion As New SqlConnection(cadenaSQL)

        Using conexion
            conexion.Open()
            Dim sql2 As String = "UPDATE Usuarios SET Password=@password, Nombre=@nombre" &
                                    " Where idUsuario=@idusuario "

            Try
                For Each fila As DataGridViewRow In grilla.Rows ' variable fila recorre hasta que se acaben las columnas
                    Using comando2 As New SqlCommand(sql2, conexion)
                        'para crear un parametro y cargarle un valor
                        comando2.Parameters.AddWithValue("@idusuario", fila.Cells(0).Value) 'idusuario se le asigna la fila 1 columna 0
                        comando2.Parameters.AddWithValue("@password", fila.Cells(1).Value)
                        comando2.Parameters.AddWithValue("@nombre", fila.Cells(2).Value)
                        comando2.ExecuteNonQuery()

                        'hacer un update para no enviar los datos nuevamente'
                    End Using


                Next
                MsgBox("DATOS GUARDADOS CORRECTAMENTE")
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
                conexion.Close()
            End Try
        End Using
        'Using conexion
        '    conexion.Open()
        '    Dim sql2 As String = "UPDATE Usuarios  SET Password=@password, Nombre=@nombre" &
        '                            " Where idUsuario=@idusuario "

        '    Try
        '        For Each fila As DataGridViewRow In grilla.Rows ' variable fila recorre hasta que se acaben las columnas
        '            Using comando2 As New SqlCommand(sql2, conexion)
        '                'para crear un parametro y cargarle un valor
        '                comando2.Parameters.AddWithValue("@idusuario", fila.Cells(0).Value) 'idusuario se le asigna la fila 1 columna 0
        '                comando2.Parameters.AddWithValue("@password", fila.Cells(1).Value)
        '                comando2.Parameters.AddWithValue("@nombre", fila.Cells(2).Value)
        '                comando2.ExecuteNonQuery()

        '                'hacer un update para no enviar los datos nuevamente'
        '            End Using


        '        Next
        '        MsgBox("DATOS GUARDADOS CORRECTAMENTE")
        '    Catch ex As Exception
        '        MsgBox(ex.Message.ToString)
        '        conexion.Close()
        '    End Try
        'End Using

    End Sub


    '''''''''''''''''''''''''
    '''''boton exit'''''''
    '''''''''''''''''''''''''
    Private Sub btn_buniExit_Click(sender As Object, e As EventArgs) Handles btn_buniExit.Click
        Me.Close()
    End Sub


    '''''''''''''''''''''''''
    '''''boton minimizar'''''
    '''''''''''''''''''''''''
    Private Sub btn_buniMinimizar_Click(sender As Object, e As EventArgs) Handles btn_buniMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub


    ''''''''''''''''''''''''''''''''''''
    ''''consulta que realiza el txt'''''
    ''''''''''''''''''''''''''''''''''''
    'Private Sub consulta_dinamica(ByVal nombre As String, ByVal grilla As DataGridView) 'recibe el nombre a buscar y grilla donde muestra

    '    sql = "SELECT * FROM Usuarios WHERE Nombre like '" & "%" + nombre + "%" & "'" 'consulta a tabla cliente filtro por nombre

    '    Dim conexion As New SqlConnection(cadenaSQL)
    '    Dim da As New SqlDataAdapter(sql, conexion)
    '    'cadenaSQL = tipoconexion.EscogeConexion()
    '    Try
    '        conexion.Open()
    '        da.Fill(tabla) ''llenado datatable con info de adaptador
    '        grilla.DataSource = tabla

    '    Catch ex As Exception
    '        MsgBox(ex.Message.ToString)
    '        conexion.Close()
    '    End Try
    'End Sub

    Private Sub txtbuni_buscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        'consulta_dinamica(txtBuscar.Text, grilla)
        '    cadena = tipoconexion.EscogeConexion
        '    Dim cargar As New OleDbDataAdapter("SELECT idUsuario,Password,Nombre FROM Usuarios where Nombre like'" & txtBuscar.Text & "%'", cadena)
        '    Dim DS As New DataSet
        '    cargar.Fill(DS, Usuarios)
    End Sub


    Public Property getCadenaSQL()
        Get
            Return cadenaSQL
        End Get
        Set(value)
            cadenaSQL = value
        End Set
    End Property
End Class
