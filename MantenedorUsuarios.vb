﻿Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.DataTable

Public Class MantenedorUsuarios
    Dim sql As String
    Dim lectura As SqlDataReader 'data reader lee'
    'Dim tipoconexion As Cadenas = New Cadenas()
    Dim tabla As New DataTable
    'Dim conexion As New SqlConnection(cadenaSQL)
    Dim cadenaSQL As String = Login.cadenasql

    Private Sub MantenedorUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'btn_Agregar.Visible = False
        'btn_Agregar.Visible = True
        'cadena = tipoconexion.EscogeConexion
        cargarTabla()

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

                If verificarRegistro(txtbuni_ID.Text) = False Then
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

                        MsgBox("Datos guardados")
                        Dim da As New SqlDataAdapter(sql, conexion)
                        tabla.Clear()
                        da.Fill(tabla) ' Carga los datos de la consulta en la tabla
                        grilla.DataSource = Nothing ' el grid carga la tabla'
                        grilla.DataSource = tabla
                    Catch ex As Exception
                        MsgBox("Error en el procedimiento ")
                        conexion.Close()
                    End Try
                Else
                    MsgBox("Este usuario ya está registrado")
                End If

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
        grilla.CurrentCell = Nothing
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
                MsgBox("Datos guardados con exito")
            Catch ex As Exception
                MsgBox("Algo ha salido mal, intentalo otra vez o verifica la conexión")
                conexion.Close()
            End Try
        End Using


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


    Private Sub txtbuni_buscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        '''''''''''''''''''''''''''
        '''''Busqueda dinámica'''''
        '''''''''''''''''''''''''''
        If (txtBuscar.Text <> "") Then
            grilla.CurrentCell = Nothing
            For Each fila As DataGridViewRow In grilla.Rows
                fila.Visible = False
            Next
            For Each fila As DataGridViewRow In grilla.Rows
                For Each celda As DataGridViewCell In fila.Cells
                    If ((celda.Value.ToString.ToUpper).IndexOf(txtBuscar.Text.ToUpper) = 0) Then
                        fila.Visible = True
                    End If
                Next
            Next
        Else
            cargarTabla()
        End If
    End Sub


    Public Property getCadenaSQL()
        Get
            Return cadenaSQL
        End Get
        Set(value)
            cadenaSQL = value
        End Set
    End Property

    Public Function verificarRegistro(ByVal id As String) As Boolean
        Dim resultado As Boolean = False
        Dim sql As String
        Dim conexion As New SqlConnection(cadenaSQL)
        Dim lector As SqlDataReader
        Try
            conexion.Open()
            sql = "Select * FROM Usuarios where idUsuario='" & id & "'"
            Dim comando As New SqlCommand(sql, conexion)
            lector = comando.ExecuteReader()
            If lector.Read Then
                resultado = True
            End If
            conexion.Close()
        Catch ex As Exception
            MsgBox("Error en el procedimiento")
        End Try
        Return resultado
    End Function
    Public Function cargarTabla()
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
            MsgBox("Se ha perdido la conexion")
            conexion.Close()
        End Try
    End Function


End Class
