Imports SAPbobsCOM
Imports System.Data
Imports System.Data.SqlClient

Public Class Formulario_Produccion
    Public x As Integer
    Dim miEmpresa As SAPbobsCOM.Company
    Dim numDocumento As Integer
    Public sErrMsg As String
    Public lErrCode As Integer

    'muestra los datos al cargar 
    Private Sub Formulario_Produccion_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Mostrar progress bar
        ProgressBar_EM.Visible = False
        txtNumDocSM.Enabled = False
        txtNumDocEM.Enabled = False
        Dim btn As DataGridViewButtonColumn = New DataGridViewButtonColumn ' para poder agregar un boton como columna al DGV
        Dim btn2 As DataGridViewButtonColumn = New DataGridViewButtonColumn

        'propeidades del BTN
        btn.HeaderText = "Buscar Artículo"
        btn.Name = "btn"
        btn.Text = "Buscar art."
        btn.UseColumnTextForButtonValue = True
        btn2.HeaderText = "Buscar Artículo"
        btn2.Name = "btn2"
        btn2.Text = "Buscar art."
        btn2.UseColumnTextForButtonValue = True

        ' btn.Width = 80
        'btn.AutoSizeMode = False
        'datagrid de entrada de mercancia
        dgvDatos_EM.Columns.Add(btn2)
        dgvDatos_EM.Columns.Add("ItemCode", "Código")
        dgvDatos_EM.Columns.Add("Quantity", "Cantidad")
        dgvDatos_EM.Columns.Add("PriceAfterVAT", "Precio valor")
        dgvDatos_EM.Columns.Add("WarehouseCode", "Bodega")
        dgvDatos_EM.Columns.Add("UnitPrice", "Precio producto")

        'datagrid de salida de mercancia
        dgvDatos_SM.Columns.Add(btn)
        dgvDatos_SM.Columns.Add("ItemCode", "Código")
        dgvDatos_SM.Columns.Add("Quantity", "Cantidad")
        dgvDatos_SM.Columns.Add("PriceAfterVAT", "Precio valor")
        dgvDatos_SM.Columns.Add("WarehouseCode", "Bodega")
        dgvDatos_SM.Columns.Add("UnitPrice", "Precio producto")

        'esconder panel entrada de mercancia
        panel_EM.Parent = Nothing

    End Sub

    'boton crear EM 
    Private Sub btn_EntradaM(sender As Object, e As EventArgs) Handles btn_crearEM.Click
        ProgressBar_EM.Visible = True

        If (txt_SolicitanteEM.Text = "" Or txt_prefijoFolioEM.Text = "" Or txt_numFolioEM.Text = "") Then
            MsgBox("No deben existir campos vacios", MsgBoxStyle.Critical)
        Else

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
            ProgressBar_EM.Value = 10

            Dim resultado As Integer

            Try
                resultado = miEmpresa.Connect
                'ProgressBar
                ProgressBar_EM.Value = 20

                If resultado = 0 Then
                    Try
                        'carga de progress bar
                        ProgressBar_EM.Value = 40

                        Dim IngresoProduccion As SAPbobsCOM.Documents
                        IngresoProduccion = miEmpresa.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oInventoryGenEntry)

                        ''  Parámetros de encabezado del documento
                        IngresoProduccion.Reference2 = txt_SolicitanteEM.Text
                        IngresoProduccion.FolioPrefixString = txt_prefijoFolioEM.Text
                        IngresoProduccion.FolioNumber = txt_numFolioEM.Text

                        IngresoProduccion.Comments = txtbox_comentariosEM.Text '"Produccion ingresada vía sistema de integración"

                        'progress bar
                        ProgressBar_EM.Value = 50

                        For Each fila As DataGridViewRow In dgvDatos_EM.Rows

                            If fila.Cells(0).Value <> "" Then
                                IngresoProduccion.Lines.ItemCode = fila.Cells(1).Value
                                IngresoProduccion.Lines.Quantity = fila.Cells(2).Value
                                IngresoProduccion.Lines.PriceAfterVAT = fila.Cells(3).Value
                                IngresoProduccion.Lines.WarehouseCode = fila.Cells(4).Value
                                IngresoProduccion.Lines.UnitPrice = fila.Cells(5).Value
                                IngresoProduccion.Lines.Add()
                            End If
                        Next

                        'progress bar
                        ProgressBar_EM.Value = 70

                        retval = IngresoProduccion.Add()

                        Dim oDoc As SAPbobsCOM.Documents
                        oDoc = miEmpresa.GetBusinessObject(BoObjectTypes.oInventoryGenEntry)

                        If oDoc.GetByKey(miEmpresa.GetNewObjectKey) Then ' NUMERO DEL DOCUMENTO
                            txtNumDocEM.Text = oDoc.DocNum.ToString
                        End If

                        'progress bar
                        ProgressBar_EM.Value = 100

                        If retval = 0 Then
                            MsgBox("Entrada de mercancia exitosa")

                            'progress bar
                            ProgressBar_EM.Value = 0
                            ProgressBar_EM.Visible = False

                        Else
                            MsgBox("No ha sido posible realizar la Solicitud")
                            Dim sErrmsg As String
                            Dim leerrcode As Integer
                            miEmpresa.GetLastError(leerrcode, sErrmsg)
                            MsgBox(sErrmsg)

                            'progress bar
                            ProgressBar_EM.Value = 0
                            ProgressBar_EM.Visible = False
                        End If

                    Catch ex As Exception
                        'MsgBox("Completa todos los campos de la solicitud")
                        'MsgBox(ex.Message.ToString)

                        'carga progress bar
                        ProgressBar_EM.Value = 0
                        ProgressBar_EM.Visible = False
                    End Try

                Else
                    Dim sErrmsg As String
                    Dim leerrcode As Integer
                    miEmpresa.GetLastError(leerrcode, sErrmsg)
                    MsgBox(sErrmsg)
                    MsgBox("Te has desconectado de SAP")

                    'progress bar
                    ProgressBar_EM.Value = 0
                    ProgressBar_EM.Visible = False
                End If


            Catch ex As Exception
                MsgBox("Algo salió mal")
                MsgBox(ex.Message.ToString)

                ProgressBar_EM.Value = 0
                ProgressBar_EM.Visible = False
            End Try
        End If
    End Sub

    'boton eliminar de EntradaMercancia
    Private Sub btn_eliminarEM_Click(sender As Object, e As EventArgs) Handles btn_eliminarEM.Click
        Dim NumFilas As Integer
        NumFilas = dgvDatos_EM.Rows.Count()
        'MsgBox(NumFilas)
        If NumFilas <> dgvDatos_EM.CurrentRow.Index + 1 Then
            dgvDatos_EM.Rows.Remove(dgvDatos_EM.CurrentRow) ' elimina la celda actual del DataGrid
        Else
            MsgBox("No se puede eliminar")
        End If
    End Sub


    ''''''''''''''''''''''''''''''''''''''''
    '''boton crear SALIDA de mercancia''''''
    ''''''''''''''''''''''''''''''''''''''''
    Private Sub boton_salidaM(sender As Object, e As EventArgs) Handles btn_Siguiente.Click
        'Mostrar progress bar
        progressbar_SM.Visible = True

        'Dim retvalEM As Long
        Dim retvalSM As Long

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


        'progress bar
        progressbar_SM.Value = 10

        Dim resultado As Integer

        Try
            resultado = miEmpresa.Connect()     'Verificamos si la conexion a sap es exitosa
            If resultado = 0 Then
                'progress bar
                progressbar_SM.Value = 20
                Try
                    'SalidaProduccion es de tipo documento (SALIDA PRODUCCION)
                    Dim SalidaProduccion As SAPbobsCOM.Documents
                    SalidaProduccion = miEmpresa.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oInventoryGenExit)

                    'progress bar
                    progressbar_SM.Value = 30

                    ''  Parámetros de encabezado de salida de mercancia
                    SalidaProduccion.Reference2 = txt_solicitanteSM.Text                ' wcastillo
                    SalidaProduccion.FolioPrefixString = txt_prefijoFolioSM.Text        ' prefijo del folio de SM
                    SalidaProduccion.FolioNumber = txt_numFolioSM.Text                  ' numero de oflio de SM
                    SalidaProduccion.Comments = txtbox_comentariosSM.Text               ' comentario en SM 

                    'progress bar
                    progressbar_SM.Value = 60

                    '' Datagrid de SALIDA DE MERCANCIA''
                    For Each fila As DataGridViewRow In dgvDatos_SM.Rows

                        If fila.Cells(0).Value <> "" Then
                            SalidaProduccion.Lines.ItemCode = fila.Cells(1).Value
                            SalidaProduccion.Lines.Quantity = fila.Cells(2).Value
                            SalidaProduccion.Lines.PriceAfterVAT = fila.Cells(3).Value
                            SalidaProduccion.Lines.WarehouseCode = fila.Cells(4).Value
                            SalidaProduccion.Lines.UnitPrice = fila.Cells(5).Value
                            SalidaProduccion.Lines.AccountCode = "_SYS00000002870" 'codigo ingresado por falta de definicion de cuenta de compensación de stock en SM
                            SalidaProduccion.Lines.Add()
                        End If
                    Next

                    'progress bar
                    progressbar_SM.Value = 80

                    retvalSM = SalidaProduccion.Add()

                    Dim oDocSM As SAPbobsCOM.Documents
                    oDocSM = miEmpresa.GetBusinessObject(BoObjectTypes.oInventoryGenExit)

                    If oDocSM.GetByKey(miEmpresa.GetNewObjectKey) Then
                        txtNumDocSM.Text = oDocSM.DocNum.ToString
                    End If

                    'progress bar
                    progressbar_SM.Value = 100

                    If retvalSM = 0 Then
                        MsgBox("Salida de mercancias exitosa")

                        panel_EM.Parent = tabControl_EMSM       ' Volver a mostrar el panel SM
                        tabControl_EMSM.SelectedTab = panel_EM  ' Al apretar se cargue el panel SM
                        'reset progress bar
                        progressbar_SM.Value = 0
                        progressbar_SM.Visible = False
                    Else
                        miEmpresa.GetLastError(lErrCode, sErrMsg)
                        MsgBox(sErrMsg)
                        'reset progress bar
                        progressbar_SM.Value = 0
                        progressbar_SM.Visible = False
                    End If

                Catch ex As Exception
                    miEmpresa.GetLastError(lErrCode, sErrMsg)
                    MsgBox(sErrMsg)
                    MsgBox(ex.Message.ToString)
                    'reset progress bar
                    progressbar_SM.Value = 0
                    progressbar_SM.Visible = False

                End Try
            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString)

            'reset progress bar
            progressbar_SM.Value = 0
            progressbar_SM.Visible = False
        End Try
    End Sub

    ' Boton salir del formulario
    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles btn_salirEM.Click
        Me.Close()
    End Sub

    'boton ELIMINAR de SalidaMercancia
    Private Sub btn_eliminarSM_Click(sender As Object, e As EventArgs) Handles btn_eliminarSM.Click
        Dim NumFilas As Integer
        NumFilas = dgvDatos_EM.Rows.Count()
        'MsgBox(NumFilas)
        If NumFilas <> dgvDatos_EM.CurrentRow.Index + 1 Then

            dgvDatos_EM.Rows.Remove(dgvDatos_EM.CurrentRow) ' elimina la celda actual del DataGrid
        Else
            MsgBox("No se puede eliminar")
        End If
    End Sub

    ' boton minimizar 
    Private Sub btn_Minimizar_Click(sender As Object, e As EventArgs) Handles btn_Minimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub


    'boton salir de la ventana
    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub dgvDatos_SM_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos_SM.CellContentClick
        If (e.ColumnIndex = 0) Then

            VentanaModal2.Button2.Visible = True    ' Mostrar el boton de SM
            VentanaModal2.btn_EM.Visible = False    ' Esconder el boton EM

            VentanaModal2.ShowDialog()
        End If
    End Sub

    Private Sub dgvDatos_EM_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos_EM.CellContentClick
        If (e.ColumnIndex = 0) Then
            VentanaModal2.btn_EM.Visible = True     ' Mostrar el boton EM
            VentanaModal2.Button2.Visible = False   ' Esconder el boton de SM

            VentanaModal2.ShowDialog()
            x = 0 ' para saber de donde se pidió abrir la ventana modal
        End If
    End Sub
End Class