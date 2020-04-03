Public Class ConnSAP
	Public Shared miEmpresa As SAPbobsCOM.Company ' .company  vamos a definir los parametros de la compañia'

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
				'MsgBox("Conexion exitosa a SAP", MsgBoxStyle.MsgBoxRight)
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

End Class
