Imports SAPbobsCOM
Imports System.Data
Imports System.Data.SqlClient
Public Class Formularios
    'Dim sql, cadenaSQL As String
    'Dim lectura As SqlDataReader 'data reader lee'
    'Dim tipoconexion As Cadenas = New Cadenas()
    'Dim tabla As New DataTable
    'Dim conexion As New SqlConnection(cadenaSQL)

    Dim miEmpresa As SAPbobsCOM.Company
    Dim numDocumento As Integer
    Private Sub Formularios_Load(sender As Object, e As EventArgs) Handles Me.Load
        'PROGRESBAR.VISIBLE = FALSE
        dgvDatos.Columns.Add("ItemCode", "Código")
        dgvDatos.Columns.Add("LineVendor", "Proveedor")
        dgvDatos.Columns.Add("RequireDate", "Fecha necesaria")
        dgvDatos.Columns.Add("Quantity", "Cantidad")
        dgvDatos.Columns.Add("PriceAfterVAT", "Precio")
        dgvDatos.Columns.Add("TaxCode", "Indicador de impuestos")

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        'MsgBox("Hola mundo")
    End Sub

    Private Sub btn_Crear_Click(sender As Object, e As EventArgs) Handles btn_Crear.Click
        'progresbar.visible = true
        'progresBar.Value = 
        Dim retval As Long
        miEmpresa = New SAPbobsCOM.Company
        miEmpresa.DbServerType = 9
        miEmpresa.DbUserName = "SYSTEM"
        miEmpresa.DbPassword = "Passw0rd"
        miEmpresa.UseTrusted = False
        miEmpresa.Server = "10.2.0.202:30015"
        miEmpresa.LicenseServer = "10.2.0.202:40000"
        miEmpresa.CompanyDB = "ZZ_CAPACITACIONES"
        miEmpresa.UserName = "hsmith"
        miEmpresa.Password = "1234"
        miEmpresa.language = SAPbobsCOM.BoSuppLangs.ln_Spanish
        Panel99.Width += 50
        Dim resultado As Integer


        Try
            resultado = miEmpresa.Connect
            'ProgressBar.value +=20
            Panel99.Width += 50
            If resultado = 0 Then
                Panel99.Width += 25
                'MsgBox("conectado a SAP")

                Try
                    Panel99.Width += 50
                    Dim PedidoCompra As SAPbobsCOM.Documents
                    PedidoCompra = miEmpresa.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oPurchaseRequest)
                    Panel99.Width += 50
                    'Parámetros de encabezado del documento
                    PedidoCompra.Requester = txtSolicitante.Text
                    Panel99.Width += 25
                    PedidoCompra.DocDate = FechaContable.Value.Date
                    PedidoCompra.DocDueDate = FechaValidez.Value.Date
                    PedidoCompra.TaxDate = FechaDocumento.Value.Date
                    PedidoCompra.RequriedDate = FechaNecesaria.Value
                    Panel99.Width += 25

                    For Each fila As DataGridViewRow In dgvDatos.Rows

                        If fila.Cells(0).Value <> "" Then
                            PedidoCompra.Lines.ItemCode = fila.Cells(0).Value
                            PedidoCompra.Lines.LineVendor = fila.Cells(1).Value
                            PedidoCompra.Lines.RequiredDate = fila.Cells(2).Value 'Convierte String a DateTime
                            PedidoCompra.Lines.Quantity = fila.Cells(3).Value
                            PedidoCompra.Lines.PriceAfterVAT = fila.Cells(4).Value
                            PedidoCompra.Lines.TaxCode = fila.Cells(5).Value
                            PedidoCompra.Lines.Add()


                            '10896 Pintura Spry Blanca Codigos de producto de prueba
                            '10897 Pintura Spray Negro

                            'comando2.Parameters.AddWithValue("@idusuario", fila.Cells(0).Value)
                            'comando2.Parameters.AddWithValue("@Password", fila.Cells(1).Value)
                            'comando2.Parameters.AddWithValue("@Nombre", fila.Cells(2).Value)
                            'comando2.ExecuteNonQuery()

                        End If

                        'Lineas del documento. 

                    Next
                    Panel99.Width += 25
                    retval = PedidoCompra.Add
                    Dim oDoc As SAPbobsCOM.Documents
                    'Panel99.Width += 50
                    'oDoc = miEmpresa.GetBusinessObject(BoObjectTypes.oPurchaseRequest)
                    Panel99.Width += 25
                    'If oDoc.GetByKey(miEmpresa.GetNewObjectKey) Then
                    'lbl_nomdoc.Text = oDoc.DocNum.ToString
                    'End If

                    Panel99.Width += 25
                    If retval = 0 Then

                        MsgBox("Solicitud agregada con éxito")

                    Else
                        MsgBox("No ha sido posible realizar la Solicitud")
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                    Panel99.Width = 0
                End Try

            Else
                Dim sErrmsg As String
                Dim leerrcode As Integer
                miEmpresa.GetLastError(leerrcode, sErrmsg)
                MsgBox(sErrmsg)
                MsgBox("TODO ESTA MAL!")

            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try


    End Sub

    'boton minimizar
    Private Sub btn_Minimizar_Click(sender As Object, e As EventArgs) Handles btn_Minimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    ''boton cerrar
    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub

    ''boton salir
    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub btn_Maximizar_Click(sender As Object, e As EventArgs) Handles btn_Maximizar.Click
        btn_Restaurar.Visible = True
        btn_Maximizar.Visible = False
        'WindowState = FormWindowState.Maximized
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
    End Sub
    Private Sub btn_Restaurar_Click(sender As Object, e As EventArgs) Handles btn_Restaurar.Click
        btn_Restaurar.Visible = False
        btn_Maximizar.Visible = True
        WindowState = FormWindowState.Normal
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click

        ''Dim conexion As New SqlConnection(cadenaSQL)

        ''Using conexion
        'conexion.Open()
        'Dim sql2 As String = "Delete FROM Usuarios  Where idUsuario=@codigo"
        '' @selec = grilla.CurrentRow.Cells(0).Value)

        'Dim comando2 As New SqlCommand(sql2, conexion)
        'comando2.Parameters.Add("@codigo", SqlDbType.NChar).Value = dgvDatos.CurrentRow.Cells(0).Value
        'comando2.ExecuteNonQuery()


        'dgvDatos.Rows.Remove(dgvDatos.CurrentRow)

    End Sub

    Private Sub dgvDatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellContentClick

    End Sub
End Class