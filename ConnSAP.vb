Public Class ConnSAP
	Dim miEmpresa As SAPbobsCOM.Company ' .company  vamos a definir los parametros de la compañia'

	Public Function ConectarSAP(DBServerType As String, DBUserName As String, DbPassword As String, Sv As String, LServer As String, CompanyDB As String, UserN As String, UserPass As String) As String
		If DBServerType = "" Then DBServerType = -1
		miEmpresa = New SAPbobsCOM.Company With {
			.DbServerType = Integer.Parse(DBServerType),
			.DbUserName = DBUserName,
			.DbPassword = DbPassword,
			.UseTrusted = False, 'si la conexion es verificada'
			.Server = Sv,
			.LicenseServer = LServer,
			.CompanyDB = CompanyDB,
			.UserName = UserN,
			.Password = UserPass,
			.language = SAPbobsCOM.BoSuppLangs.ln_Spanish
		}

		Dim respuesta As Integer
		Try
			respuesta = miEmpresa.Connect
			If respuesta = 0 Then
				MsgBox("Conexion exitosa a SAP", MsgBoxStyle.MsgBoxRight)
				Return respuesta
			Else
				Dim sErrmsg As String
				Dim leerrcode As String
				miEmpresa.GetLastError(leerrcode, sErrmsg)
				MsgBox(sErrmsg)
				Return MsgBox("No es posible conectar a SAP", MsgBoxStyle.Critical)
			End If
		Catch ex As Exception
			Return MsgBox(ex.Message.ToString)
		End Try


	End Function
	'Public Function ConnSAP()
	'	miEmpresa = New SAPbobsCOM.Company With {
	'				.DbServerType = 9,
	'				.DbUserName = "SYSTEM",
	'				.DbPassword = "Passw0rd",
	'				.UseTrusted = False, 'si la conexion es verificada'
	'				.Server = "10.2.0.202:30015",
	'				.LicenseServer = "10.2.0.202:40000",
	'				.CompanyDB = "ZZ_CAPACITACIONES",
	'				.UserName = "hsmith",
	'				.Password = "1234",
	'			.language = SAPbobsCOM.BoSuppLangs.ln_Spanish
	'		}
	'	Dim resultado As Integer
	'	Try
	'		resultado = miEmpresa.Connect
	'		If resultado = 0 Then
	'			MsgBox("Conectado a SAP")
	'			'Dim login As New Login
	'			Login.setCadenaSQL = cadenaSQL
	'			Login.conectarSAP(miEmpresa)
	'			Login.Show()
	'			Me.Hide()

	'		Else
	'			Dim sErrmsg As String
	'			Dim leerrcode As String
	'			miEmpresa.GetLastError(leerrcode, sErrmsg)
	'			MsgBox(sErrmsg)
	'			MsgBox("No es posible conectar a SAP")
	'		End If
	'	Catch ex As Exception
	'		MsgBox(ex.Message.ToString) 'msgbox acepta solo strings'

	'	End Try


	'End Function
End Class
