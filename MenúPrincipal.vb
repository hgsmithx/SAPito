Imports FontAwesome.Sharp
Imports System.Data
Imports System

Public Class MenúPrincipal
    Public nombreUsuario As String

    ''''''''''''''''''''''''''''''''''''''
    ''4 Botones del panel menu izquierdo
    ''' '''''''''''''''''''''''''''''''
    Private Sub btn_solCompra_Click(sender As Object, e As EventArgs) Handles bunibtn_Compras.Click
        'ActivateButton(sender, Color.FromArgb(173, 255, 182))
        showSubmenu(bunifPanel_SolCompras)
    End Sub

    Private Sub btn_Produccion_Click(sender As Object, e As EventArgs) Handles bunifbtn_Produccion.Click
        'ActivateButton(sender, Color.FromArgb(254, 194, 163))
        showSubmenu(buniPanel_produccion)
    End Sub

    Private Sub btn_Configuracion_Click(sender As Object, e As EventArgs) Handles bunibtn_Config.Click
        'ActivateButton(sender, Color.FromArgb(173, 255, 182))
        showSubmenu(buniPanel_config)
    End Sub

    Private Sub iconbtn_Rendiciones_Click(sender As Object, e As EventArgs) Handles bunibtn_Rendiciones.Click
        'ActivateButton(sender, Color.FromArgb(254, 194, 163))
        hideSubmenu()
    End Sub


    ''''''''''Botones sair,max, etc''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Application.Exit()
    End Sub

    Private Sub btn_Maximizar_Click(sender As Object, e As EventArgs) Handles btn_Maximizar.Click
        btn_Restaurar.Visible = True
        btn_Maximizar.Visible = False
        'WindowState = FormWindowState.Maximized

    End Sub

    Private Sub btn_Minimizar_Click(sender As Object, e As EventArgs) Handles btn_Minimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_Restaurar_Click(sender As Object, e As EventArgs) Handles btn_Restaurar.Click
        btn_Restaurar.Visible = False
        btn_Maximizar.Visible = True
        WindowState = FormWindowState.Normal
    End Sub



    'Load menu principal'
    Private Sub MenúPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubmenu()
        'Me.Show()
        lblNomUsuario.Text = nombreUsuario
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size ' ventana se cargue del tamaño de escritorio
    End Sub


    ''funcion ocultar submenus
    Private Sub hideSubmenu()
        bunifPanel_SolCompras.Visible = False
        buniPanel_produccion.Visible = False
        buniPanel_config.Visible = False
    End Sub


    'ocultar panel lateral izquierdo con el boton de 3 lineas
    Private Sub btn_hideMenu_Click(sender As Object, e As EventArgs) Handles btn_hideMenu.Click
        If PanelMenu.Width = 214 Then
            'PanelMenu.Hide()
            PanelMenu.Width = 60
            hideSubmenu()                       ''Al apretar, se esconda el submenu
        Else
            PanelMenu.Width = 214
        End If
    End Sub


    ''funcion mostrar sub menu
    Private Sub showSubmenu(submenu As Panel) 'todos son paneles, se envia paneles como dato
        If submenu.Visible = False Then
            hideSubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    'boton solicitud de compra
    Private Sub btn_solCompra_Click_1(sender As Object, e As EventArgs) Handles btn_solCompra.Click
        Formularios.Show()
    End Sub

    Public Property getCadenaSQL()
        Get
            'Return CadenaSQL
        End Get
        Set(value)
            'CadenaSQL = value
        End Set
    End Property

    'Boton mantenedor de usuarios
    Private Sub btn_buniUsuarios_Click(sender As Object, e As EventArgs) Handles btn_buniUsuarios.Click
        MantenedorUsuarios.Show()
    End Sub

    'boton de parametros SQL
    Private Sub btn_buniParamSQL_Click(sender As Object, e As EventArgs) Handles btn_buniParamSQL.Click
        VentanaSQL.Show()
    End Sub

    'boton de parametros SAP
    Private Sub btn_buniParamSAP_Click(sender As Object, e As EventArgs) Handles btn_buniParamSAP.Click
        VentanaSAP.Show()
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles btn_prodEMSM.Click
        Formulario_Produccion.Show()
    End Sub

    Private Sub bunibtn_Seguimiento_Click(sender As Object, e As EventArgs) Handles bunibtn_Seguimiento.Click
        hideSubmenu()
        SeguimientoSAP.Show()
    End Sub
End Class