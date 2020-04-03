Imports SAPbobsCOM
Imports System.Data
Imports System.Data.SqlClient
Public Class Formularios
    Dim miEmpresa As SAPbobsCOM.Company
    Dim numDocumento As Integer

    Private Sub Formularios_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Mostrar progress bar
        Panel99.Visible = False
        PanelFondo.Visible = False

        dgvDatos.Columns.Add("ItemCode", "Código")
        dgvDatos.Columns.Add("LineVendor", "Proveedor")
        dgvDatos.Columns.Add("RequireDate", "Fecha necesaria")
        dgvDatos.Columns.Add("Quantity", "Cantidad")
        dgvDatos.Columns.Add("PriceAfterVAT", "Precio")
        dgvDatos.Columns.Add("TaxCode", "Indicador de impuestos")

    End Sub

    Private Sub btn_Crear_Click(sender As Object, e As EventArgs) Handles btn_Crear.Click
        'Mostrar progress bar
        Panel99.Visible = True
        PanelFondo.Visible = True

        Dim retval As Long

        miEmpresa = New SAPbobsCOM.Company
        miEmpresa.DbServerType = Integer.Parse(VentanaSAP.txtDBServerType.Text)
        miEmpresa.DbUserName = VentanaSAP.txtDbUserName.Text
        miEmpresa.DbPassword = VentanaSAP.txtDbPassword.Text
        miEmpresa.UseTrusted = False
        miEmpresa.Server = VentanaSAP.txtServer.Text
        miEmpresa.LicenseServer = VentanaSAP.txtLicenseServer.Text
        miEmpresa.CompanyDB = VentanaSAP.txtCompanyDB.Text
        miEmpresa.UserName = VentanaSAP.txtUserName.Text
        miEmpresa.Password = VentanaSAP.txtPassword.Text
        miEmpresa.language = SAPbobsCOM.BoSuppLangs.ln_Spanish

        'carga de progress bar
        Panel99.Width += 50

        Dim resultado As Integer

        Try

            resultado = miEmpresa.Connect

            'ProgressBar
            Panel99.Width += 50

            If resultado = 0 Then

                'carga de progress bar
                Panel99.Width += 25

                Try
                    'carga de progress bar
                    Panel99.Width += 50

                    Dim PedidoCompra As SAPbobsCOM.Documents
                    PedidoCompra = miEmpresa.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oPurchaseRequest)

                    'carga progress bar
                    Panel99.Width += 50

                    'Parámetros de encabezado del documento
                    PedidoCompra.Requester = txtSolicitante.Text
                    PedidoCompra.DocDate = FechaContable.Value.Date
                    PedidoCompra.DocDueDate = FechaValidez.Value.Date
                    PedidoCompra.TaxDate = FechaDocumento.Value.Date
                    PedidoCompra.RequriedDate = FechaNecesaria.Value.Date

                    'carga de progress bar
                    Panel99.Width += 25

                    For Each fila As DataGridViewRow In dgvDatos.Rows

                        If fila.Cells(0).Value <> "" Then
                            PedidoCompra.Lines.ItemCode = fila.Cells(0).Value
                            PedidoCompra.Lines.LineVendor = fila.Cells(1).Value
                            PedidoCompra.Lines.RequiredDate = Convert.ToDateTime(fila.Cells(2).Value) 'Convierte String a DateTime
                            PedidoCompra.Lines.Quantity = fila.Cells(3).Value
                            PedidoCompra.Lines.PriceAfterVAT = fila.Cells(4).Value
                            PedidoCompra.Lines.TaxCode = fila.Cells(5).Value
                            PedidoCompra.Lines.Add()

                            '10896 Pintura Spry Blanca Codigos de producto de prueba
                            '10897 Pintura Spray Negro

                            'comando2.Parameters.AddWithValue("@idusuario", fila.Cells(0).Value)
                            'comando2.ExecuteNonQuery()
                        End If
                    Next

                    'carga de progress bar
                    Panel99.Width += 100

                    retval = PedidoCompra.Add
                    Dim oDoc As SAPbobsCOM.Documents
                    oDoc = miEmpresa.GetBusinessObject(BoObjectTypes.oPurchaseRequest)

                    If oDoc.GetByKey(miEmpresa.GetNewObjectKey) Then ' NUMERO DEL DOCUMENTO
                        txtNumDoc.Text = oDoc.DocNum.ToString
                    End If

                    'carga de progress bar
                    Panel99.Width += 50

                    If retval = 0 Then
                        MsgBox("Solicitud enviada con exito")

                        'progress bar
                        Panel99.Width = 0
                        PanelFondo.Visible = False
                    Else
                        MsgBox("No ha sido posible realizar la Solicitud")

                        'progress bar
                        Panel99.Width = 0
                        PanelFondo.Visible = False
                    End If

                Catch ex As Exception

                    'MsgBox(ex.Message.ToString)
                    Dim sErrmsg As String
                    Dim leerrcode As Integer
                    miEmpresa.GetLastError(leerrcode, sErrmsg)
                    MsgBox(sErrmsg)


                    'progress bar
                    Panel99.Width = 0
                    PanelFondo.Visible = False
                End Try

            Else
                Dim sErrmsg As String
                Dim leerrcode As Integer
                miEmpresa.GetLastError(leerrcode, sErrmsg)
                MsgBox(sErrmsg)
                MsgBox("Te has desconectado de SAP")

                'progress bar
                Panel99.Width = 0
                PanelFondo.Visible = False
            End If


        Catch ex As Exception
            MsgBox("Algo salió mal")
            MsgBox(ex.Message.ToString)
            Panel99.Width = 0
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

    ''boton maximizar
    Private Sub btn_Maximizar_Click(sender As Object, e As EventArgs) Handles btn_Maximizar.Click
        btn_Restaurar.Visible = True
        btn_Maximizar.Visible = False
        'WindowState = FormWindowState.Maximized
        'Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        'Me.Size = Screen.PrimaryScreen.WorkingArea.Size
    End Sub

    ''boton restaurar
    Private Sub btn_Restaurar_Click(sender As Object, e As EventArgs) Handles btn_Restaurar.Click
        btn_Restaurar.Visible = False
        btn_Maximizar.Visible = True
        'windowState = FormWindowState.Normal
    End Sub


    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click

        dgvDatos.Rows.Remove(dgvDatos.CurrentRow)

    End Sub

End Class