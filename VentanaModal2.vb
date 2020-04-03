Imports SAPbobsCOM2
Public Class VentanaModal2
    Dim miEmpresa As SAPbobsCOM.Company
    Shared sqlSAP As String
    Dim oRecordset As SAPbobsCOM.Recordset
    Private Sub VentanaModal2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'GrillaModal.Columns.Add("Cantidad", "#")
        txtBuscar.Text = ""
        GrillaModal2.Columns.Clear()
        GrillaModal2.Columns.Add("ItemCode", "Codigo Art")
        GrillaModal2.Columns.Add("ItemName", "Nombre Art")


        Dim retval As Long
        miEmpresa = New SAPbobsCOM.Company
        miEmpresa.DbServerType = 9
        miEmpresa.DbUserName = "SYSTEM"
        miEmpresa.DbPassword = "Passw0rd"
        miEmpresa.UseTrusted = False
        miEmpresa.Server = "10.2.0.202:30015"
        miEmpresa.LicenseServer = "10.2.0.202:40000"
        miEmpresa.CompanyDB = "ZZ_CAPACITACIONES"
        miEmpresa.UserName = "csomorrostro"
        miEmpresa.Password = "1234"
        miEmpresa.language = SAPbobsCOM.BoSuppLangs.ln_Spanish_La
        Dim resultado As Integer

        resultado = miEmpresa.Connect
        'Es un recordset pero de mi Empresa

        ' Consulta a la tabla de articulos (SELECT T0."ItemCode", T0."ItemName" FROM OITM T0)
        sqlSAP = "SELECT T0.""ItemCode"", T0.""ItemName"" FROM OITM T0"
        oRecordset = miEmpresa.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oRecordset.DoQuery(sqlSAP) ' Se le pasa la consulta al recordset
        If oRecordset.RecordCount > 0 Then

            oRecordset.MoveFirst()
            'txtorigen.Text = oRecordset.Fields.Item("DocNum").Value.ToString
            'txtDocumentoReferencia.Text = oRecordset.Fields.Item("BaseRef").Value.ToString
            Dim NumFilas As Integer = 0
            Do Until oRecordset.EoF
                NumFilas += 1
                GrillaModal2.Rows.Add(oRecordset.Fields.Item("ItemCode").Value.ToString, oRecordset.Fields.Item("ItemName").Value.ToString)
                'DgvModal.Rows.Add()
                oRecordset.MoveNext()
            Loop
            miEmpresa.Disconnect()
        End If
    End Sub
    Public Function BusquedaDinamica()
        '' FUNCIONA PERO EL TIEMPO DE RESPUESTA ES MUY LARGO,SON 5 MIL ARTICULOS
        '' FUNCIONA PERO EL TIEMPO DE RESPUESTA ES MUY LARGO,SON 5 MIL ARTICULOS
        '' FUNCIONA PERO EL TIEMPO DE RESPUESTA ES MUY LARGO,SON 5 MIL ARTICULOS
        If (txtBuscar.Text <> "") Then
            GrillaModal2.CurrentCell = Nothing
            For Each fila As DataGridViewRow In GrillaModal2.Rows
                fila.Visible = False
            Next
            'For Each fila As DataGridViewRow In GrillaModal.Rows
            '    For Each celda As DataGridViewCell In fila.Cells
            '        If ((celda.Value.ToString.ToUpper).IndexOf(txtBusqueda.Text.ToUpper) = 0) Then
            '            fila.Visible = True
            '        End If
            '    Next
            'Next
            For Each fila As DataGridViewRow In GrillaModal2.Rows
                If (fila.Cells(0).Value.ToString.ToUpper).IndexOf(txtBuscar.Text.ToUpper) = 0 Then
                    fila.Visible = True
                End If
            Next

        Else
            Dim NumFilas As Integer = 0
            Do Until oRecordset.EoF
                'NumFilas += 1
                GrillaModal2.Rows.Add(oRecordset.Fields.Item("ItemCode").Value.ToString, oRecordset.Fields.Item("ItemName").Value.ToString)
                'DgvModal.Rows.Add()
                oRecordset.MoveNext()
            Loop

        End If
    End Function

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        BusquedaDinamica()
    End Sub

    'boton dirigido a salida de mercancia
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_EM.Click
        Dim item As String
        item = GrillaModal2.CurrentRow.Cells(0).Value
        Formulario_Produccion.dgvDatos_EM.CurrentRow.Cells(1).Value = item
        Me.Hide()
    End Sub

    'boton dirigido a entrada de mercancia
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim item As String
        item = GrillaModal2.CurrentRow.Cells(0).Value
        Formulario_Produccion.dgvDatos_SM.CurrentRow.Cells(1).Value = item
        Me.Hide()
    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub btn_Minimizar_Click(sender As Object, e As EventArgs) Handles btn_Minimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_cerrarSM_Click(sender As Object, e As EventArgs) Handles btn_cerrarSM.Click
        Me.Close()
    End Sub
End Class