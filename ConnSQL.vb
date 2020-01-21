Public Class ConnSQL
    'Para guardar el enlace ingresado por parametros
    Public conexion_remota As String
    Public Function ObtenerCadena(DataS As String, Pto As String, Catalog As String, Userid As String, Pass As String) As String
        Dim parametro As String 'para saber donde estoy: nube/local
        If My.Computer.Network.Ping("10.2.0.111") Then ' si hace ping es pq está dentro de la red

            parametro = "Data Source=" & DataS &
                        "," & Pto & ";Initial Catalog=" & Catalog & ";" &
                         "User ID=" & Userid & ";" &
                            "Password=" & Pass

        Else

            parametro = "Data Source=" & DataS &
                        "," & Pto & ";Initial Catalog=" & Catalog & ";" &
                         "User ID=" & Userid & ";" &
                            "Password=" & Pass

        End If

        Return parametro

    End Function

    Public Function Conexion() As String
        Dim parametro As String 'para saber donde estoy: nube/local
        If My.Computer.Network.Ping("10.2.0.111") Then ' si hace ping es pq está dentro de la red

            parametro = "Data Source=186.10.19.202\CULLULFE, 1433;Initial Catalog=SAPito;User ID=practicaSAP;Password=12345"

        Else

            parametro = "Data Source=186.10.19.202\CULLULFE, 1433;Initial Catalog=SAPito;User ID=practicaSAP;Password=12345"

        End If
        Return parametro
    End Function
    Public Property getConexionRemota()
        Get
            Return conexion_remota
        End Get
        Set(value)
            conexion_remota = value
        End Set
    End Property
End Class
