Public Class VentanaSAP
    Dim cadenaSQL, cadenaSAP As String
    Dim SAP As ConnSAP = New ConnSAP
    Dim DBServerType, DBUserName, DbPassword, Sv, LServer, CompanyDB, UserN, UserPass As String



    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        DBServerType = txtDBServerType.Text
        DBUserName = txtDbUserName.Text
        DbPassword = txtDbPassword.Text
        Sv = txtServer.Text
        LServer = txtLicenseServer.Text
        CompanyDB = txtCompanyDB.Text
        UserN = txtUserName.Text
        UserPass = txtPassword.Text
        'Llama a la funcion conectarSap 

        cadenaSAP = SAP.ConectarSAP(DBServerType, DBUserName, DbPassword, Sv, LServer, CompanyDB, UserN, UserPass)

        'login.setCadenaSAP = cadenaSAP
        'login.setCadenaSQL = cadenaSQL

        If cadenaSAP = 0 Then
            Dim login As New Login
            login.setCadenaSQL = cadenaSQL
            login.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub Form_SAP_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtDBServerType.Text = 9
        txtDbUserName.Text = "SYSTEM"
        txtDbPassword.Text = "Passw0rd"
        txtServer.Text = "10.2.0.202:30015"
        txtLicenseServer.Text = "10.2.0.202:40000"
        txtCompanyDB.Text = "ZZ_CAPACITACIONES"
        txtUserName.Text = "hsmith"
        txtPassword.Text = "1234"
    End Sub

    Public Property setCadenaSQL() As String
        Get
            Return Me.cadenaSQL
        End Get
        Set(value As String)
            Me.cadenaSQL = value
        End Set
    End Property
    Private Sub btn_buniExit_Click(sender As Object, e As EventArgs) Handles btn_buniExit.Click
        Me.Close()
    End Sub

    Private Sub btn_buniMinimizar_Click(sender As Object, e As EventArgs) Handles btn_buniMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub VentanaSAP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class