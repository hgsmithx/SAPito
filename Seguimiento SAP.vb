Imports SAPbobsCOM
Public Class SeguimientoSAP
    Dim miEmpresa As SAPbobsCOM.Company
    Public sErrMsg As String
    Public lErrCode As Integer
    Public lRetCode As Integer
    Dim idPedido As String
    Dim retval As Long
    Dim contador As Integer ' timer de progress


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        'desactiva el boton buscar
        btnBuscar.Enabled = False

        'desactiva los textbox de encabezados
        txtSolPedido.Enabled = False
        txtbox_Solicitante.Enabled = False

        panel_groupbox.Visible = True

        'ProgressBar
        progressbar_oferta.Visible = True

        btn_OK.Visible = True


        miEmpresa = New SAPbobsCOM.Company
        miEmpresa.DbServerType = 9
        miEmpresa.DbUserName = "SYSTEM"
        miEmpresa.DbPassword = "Passw0rd"
        miEmpresa.UseTrusted = False
        miEmpresa.Server = "10.2.0.202:30015"
        miEmpresa.LicenseServer = "10.2.0.202:40000"
        miEmpresa.CompanyDB = "ZZ_CAPACITACIONES"
        miEmpresa.UserName = "wcastillo"
        miEmpresa.Password = "1234"
        miEmpresa.language = SAPbobsCOM.BoSuppLangs.ln_Spanish_La

        Dim resultado As Integer
        Dim oRecordset, oRecordsetPedido, oRecordsetRecepcion As SAPbobsCOM.Recordset
        resultado = miEmpresa.Connect
        oRecordset = miEmpresa.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oRecordsetPedido = miEmpresa.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oRecordsetRecepcion = miEmpresa.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)

        Dim sqlSap As String = "SELECT T0.""DocNum"", T0.""WddStatus"", T1.""BaseRef"" FROM OPQT T0  INNER JOIN PQT1 T1 ON T0.""DocEntry"" = T1.""DocEntry"" WHERE T1.""BaseRef"" = '" & txtSolPedido.Text & "' and T0.""DocStatus"" ='C'"
        oRecordset.DoQuery(sqlSap)
        
        ' Oferta
        If oRecordset.RecordCount > 0 Then

            'barra carga
            progressbar_oferta.Value += 10

            oRecordset.MoveFirst()
            txtOferta.Text = oRecordset.Fields.Item("DocNum").Value.ToString
            'lblOferta.Text = oRecordset.Fields.Item("WddStatus").Value.ToString
            Select Case (oRecordset.Fields.Item("WddStatus").Value.ToString) ' Mostrar el estado del documento
                Case ("-")
                    lblOferta.Text = "Sin estado"
                Case ("A")
                    lblOferta.Text = "Generada"
                Case ("C")
                    lblOferta.Text = "Cancelado"
                Case ("N")
                    lblOferta.Text = "Rechazado"
                Case ("P")
                    lblOferta.Text = "Generada"
                Case ("W")
                    lblOferta.Text = "Pendiente"
                Case ("Y")
                    lblOferta.Text = "Aprobada"
                Case Else
                    MsgBox("No se ha verificado ninguna de las condiciones previstas")
            End Select
            'barra carga
            progressbar_oferta.Value += 10
            imgOfertaOk.Visible = True
        Else
            'barra carga
            progressbar_oferta.Value = 20

            lblMensaje.Text = "Tu solicitud de" & vbCrLf & "pedido aún no ha" & vbCrLf & "sido procesada"

            'imagen de cancelado
            imgOfertaCancel.Visible = True
            imgPedidoCancel.Visible = True
            imgRecepCancel.Visible = True
            Exit Sub
        End If

        ' Pedido
        If imgOfertaOk.Visible = True Then

            sqlSap = "SELECT T0.""DocNum"",T0.""WddStatus"", T0.""DocStatus"", T1.""BaseRef"" FROM OPOR T0  INNER JOIN POR1 T1 ON T0.""DocEntry"" = T1.""DocEntry"" WHERE T1.""BaseRef"" ='" & txtOferta.Text & "'"
            oRecordsetPedido.DoQuery(sqlSap)
            If oRecordsetPedido.RecordCount > 0 Then
                oRecordsetPedido.MoveFirst()
                txtPedido.Text = oRecordsetPedido.Fields.Item("DocNum").Value.ToString
                'lblPedido.Text = oRecordsetPedido.Fields.Item("WddStatus").Value.ToString
                Select Case (oRecordsetPedido.Fields.Item("WddStatus").Value.ToString) ' Mostrar el estado del documento
                    Case ("-")
                        lblPedido.Text = "Sin estado"
                    Case ("A")
                        lblPedido.Text = "Generada"
                    Case ("C")
                        lblPedido.Text = "Cancelado"
                    Case ("N")
                        lblPedido.Text = "Rechazado"
                    Case ("P")
                        lblPedido.Text = "Generada"
                    Case ("W")
                        lblPedido.Text = "Pendiente"
                    Case ("Y")
                        lblPedido.Text = "Aprobada"
                    Case Else
                        MsgBox("No se ha verificado ninguna de las condiciones previstas")
                End Select

                'barra carga
                progressbar_oferta.Value += 10
                imgPedidoOk.Visible = True
            Else
                progressbar_oferta.Value += 15
                lblMensaje.Text = "Tu pedido aún" & vbCrLf & "no ha sido" & vbCrLf & "procesado"


                imgPedidoCancel.Visible = True
                imgRecepCancel.Visible = True
                Exit Sub
            End If
        Else
            progressbar_oferta.Value += 15
            imgPedidoCancel.Visible = True
            imgRecepCancel.Visible = True
        End If

        'recepcion
        If imgPedidoOk.Visible = True Then
            'barra carga
            progressbar_oferta.Value += 25

            sqlSap = "SELECT T0.""DocNum"",T0.""WddStatus"", T1.""BaseRef"" FROM OPDN T0  INNER JOIN PDN1 T1 ON T0.""DocEntry"" = T1.""DocEntry"" WHERE T1.""BaseRef"" = '" & txtPedido.Text & "'"
            oRecordsetRecepcion.DoQuery(sqlSap)
            If oRecordsetRecepcion.RecordCount > 0 Then
                oRecordsetRecepcion.MoveFirst()
                txtRecepcion.Text = oRecordsetRecepcion.Fields.Item("DocNum").Value.ToString
                'lblRecepcion.Text = oRecordsetRecepcion.Fields.Item("WddStatus").Value.ToString
                Select Case (oRecordsetRecepcion.Fields.Item("WddStatus").Value.ToString) ' Mostrar el estado del documento
                    Case ("-")
                        lblRecepcion.Text = "Sin estado"
                    Case ("A")
                        lblRecepcion.Text = "Generada"
                    Case ("C")
                        lblRecepcion.Text = "Cancelado"
                    Case ("N")
                        lblRecepcion.Text = "Rechazado"
                    Case ("P")
                        lblRecepcion.Text = "Generada"
                    Case ("W")
                        lblRecepcion.Text = "Pendiente"
                    Case ("Y")
                        lblRecepcion.Text = "Aprobada"
                    Case Else
                        MsgBox("No se ha verificado ninguna de las condiciones previstas")
                End Select

                lblMensaje.Text = "Pedido " & vbCrLf & "recepcionado"
                'barra carga
                progressbar_oferta.Value += 45
                imgRecepcionOk.Visible = True
            Else
                lblMensaje.Text = "La recepción del " & vbCrLf & "pedido aún no " & vbCrLf & "ha sido procesada"

                imgRecepCancel.Visible = True

                Exit Sub
            End If
        Else
            progressbar_oferta.Value += 65
            imgRecepCancel.Visible = True
        End If

    End Sub

    Private Sub SeguimientoSAP_Load(sender As Object, e As EventArgs) Handles Me.Load
        timePicker_fechaCreacion.Value = Now
        '  Textbox de numero solicitud
        txtSolPedido.Enabled = True

        ' Imagenes
        imgOfertaOk.Visible = False
        imgPedidoOk.Visible = False
        imgRecepcionOk.Visible = False

        imgOfertaCancel.Visible = False
        imgPedidoCancel.Visible = False
        imgRecepCancel.Visible = False

        'botones
        btn_OK.Visible = False

        'progressbar
        progressbar_oferta.Visible = False

        'panel de gropbox
        panel_groupbox.Visible = False
    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub btn_OK_Click(sender As Object, e As EventArgs) Handles btn_OK.Click
        'ocultar la barra y reset
        progressbar_oferta.Value = 0
        progressbar_oferta.Visible = False

        'ocultar las imagenes
        imgOfertaOk.Visible = False
        imgPedidoOk.Visible = False
        imgRecepcionOk.Visible = False
        imgOfertaCancel.Visible = False
        imgPedidoCancel.Visible = False
        imgRecepCancel.Visible = False

        'vacias los text
        txtOferta.Text = ""
        txtPedido.Text = ""
        txtRecepcion.Text = ""
        txtSolPedido.Text = ""

        'habilita los text de encabezado
        txtSolPedido.Enabled = True
        txtbox_Solicitante.Enabled = True

        'esconder el panel con los groupbox
        panel_groupbox.Visible = False

        'habilitar boton de buscar
        btnBuscar.Enabled = True

        'limpia los label
        lblMensaje.Text = ""
    End Sub

    Private Sub btn_Minimizar_Click(sender As Object, e As EventArgs) Handles btn_Minimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_SalirS_Click(sender As Object, e As EventArgs) Handles btn_SalirS.Click
        Me.Close()
    End Sub
End Class