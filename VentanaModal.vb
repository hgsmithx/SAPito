Imports SAPbobsCOM
Public Class VentanaModal
    Dim miEmpresa As SAPbobsCOM.Company
    Shared sqlSAP As String
    Dim oRecordset As SAPbobsCOM.Recordset
    Private Sub VentanaModal_Load(sender As Object, e As EventArgs) Handles Me.Load
        'GrillaModal.Columns.Add("Cantidad", "#")
        txtBuscar.Text = ""
        GrillaModal.Columns.Clear()
        GrillaModal.Columns.Add("ItemCode", "Codigo Art")
        GrillaModal.Columns.Add("ItemName", "Nombre Art")


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
                GrillaModal.Rows.Add(oRecordset.Fields.Item("ItemCode").Value.ToString, oRecordset.Fields.Item("ItemName").Value.ToString)
                'DgvModal.Rows.Add()
                oRecordset.MoveNext()
            Loop
            miEmpresa.Disconnect()
        End If
    End Sub

    Public Function BusquedaDinámica()
        '' FUNCIONA PERO EL TIEMPO DE RESPUESTA ES MUY LARGO,SON 5 MIL ARTICULOS
        '' FUNCIONA PERO EL TIEMPO DE RESPUESTA ES MUY LARGO,SON 5 MIL ARTICULOS
        '' FUNCIONA PERO EL TIEMPO DE RESPUESTA ES MUY LARGO,SON 5 MIL ARTICULOS
        If (txtBusqueda.Text <> "") Then
            GrillaModal.CurrentCell = Nothing
            For Each fila As DataGridViewRow In GrillaModal.Rows
                fila.Visible = False
            Next
            'For Each fila As DataGridViewRow In GrillaModal.Rows
            '    For Each celda As DataGridViewCell In fila.Cells
            '        If ((celda.Value.ToString.ToUpper).IndexOf(txtBusqueda.Text.ToUpper) = 0) Then
            '            fila.Visible = True
            '        End If
            '    Next
            'Next
            For Each fila As DataGridViewRow In GrillaModal.Rows
                If (fila.Cells(0).Value.ToString.ToUpper).IndexOf(txtBusqueda.Text.ToUpper) = 0 Then
                    fila.Visible = True
                End If
            Next

        Else
            Dim NumFilas As Integer = 0
            Do Until oRecordset.EoF
                'NumFilas += 1
                GrillaModal.Rows.Add(oRecordset.Fields.Item("ItemCode").Value.ToString, oRecordset.Fields.Item("ItemName").Value.ToString)
                'DgvModal.Rows.Add()
                oRecordset.MoveNext()
            Loop

        End If
    End Function

    Private Sub txtBusqueda_OnValueChanged(sender As Object, e As EventArgs) Handles txtBusqueda.OnValueChanged

    End Sub

    Private Sub btn_SelectArt_Click(sender As Object, e As EventArgs) Handles btn_SelectArt.Click
        Dim item As String = GrillaModal.CurrentRow.Cells(0).Value.ToString
        MsgBox(item.ToString)
        If (Formulario_Produccion.x <> 0) Then
            Formulario_Produccion.dgvDatos_SM.CurrentRow.Cells(1).Value = item
        Else
            Formulario_Produccion.dgvDatos_EM.CurrentRow.Cells(1).Value = item

        End If

        Me.Hide()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        BusquedaDinámica()
    End Sub
End Class