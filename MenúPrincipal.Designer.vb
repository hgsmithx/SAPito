<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenúPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenúPrincipal))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.bunibtn_Seguimiento = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.buniPanel_config = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btn_buniParamSAP = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_buniParamSQL = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_buniUsuarios = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bunibtn_Config = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bunibtn_Rendiciones = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.buniPanel_produccion = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton3 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_prodEMSM = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bunifbtn_Produccion = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bunifPanel_SolCompras = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btn_pedido = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_ofertaCompra = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_solCompra = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bunibtn_Compras = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bunPanel_izqTop = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Panel_top = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNomUsuario = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btn_Maximizar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_Restaurar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_Salir = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_Minimizar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panelcentrofondo = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panelcentro_encima = New System.Windows.Forms.Panel()
        Me.btn_hideMenu = New Bunifu.Framework.UI.BunifuImageButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Movimiento_cabecera = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.PanelMenu.SuspendLayout()
        Me.buniPanel_config.SuspendLayout()
        Me.buniPanel_produccion.SuspendLayout()
        Me.bunifPanel_SolCompras.SuspendLayout()
        Me.Panel_top.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Maximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Restaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Salir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelcentrofondo.SuspendLayout()
        Me.Panelcentro_encima.SuspendLayout()
        CType(Me.btn_hideMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.AutoScroll = True
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.bunibtn_Seguimiento)
        Me.PanelMenu.Controls.Add(Me.buniPanel_config)
        Me.PanelMenu.Controls.Add(Me.bunibtn_Config)
        Me.PanelMenu.Controls.Add(Me.bunibtn_Rendiciones)
        Me.PanelMenu.Controls.Add(Me.buniPanel_produccion)
        Me.PanelMenu.Controls.Add(Me.bunifbtn_Produccion)
        Me.PanelMenu.Controls.Add(Me.bunifPanel_SolCompras)
        Me.PanelMenu.Controls.Add(Me.bunibtn_Compras)
        Me.PanelMenu.Controls.Add(Me.bunPanel_izqTop)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 33)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(214, 474)
        Me.PanelMenu.TabIndex = 2
        '
        'bunibtn_Seguimiento
        '
        Me.bunibtn_Seguimiento.Activecolor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.bunibtn_Seguimiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.bunibtn_Seguimiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bunibtn_Seguimiento.BorderRadius = 0
        Me.bunibtn_Seguimiento.ButtonText = "Seguimiento"
        Me.bunibtn_Seguimiento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bunibtn_Seguimiento.DisabledColor = System.Drawing.Color.Gray
        Me.bunibtn_Seguimiento.Dock = System.Windows.Forms.DockStyle.Top
        Me.bunibtn_Seguimiento.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.bunibtn_Seguimiento.Iconcolor = System.Drawing.Color.Transparent
        Me.bunibtn_Seguimiento.Iconimage = CType(resources.GetObject("bunibtn_Seguimiento.Iconimage"), System.Drawing.Image)
        Me.bunibtn_Seguimiento.Iconimage_right = Nothing
        Me.bunibtn_Seguimiento.Iconimage_right_Selected = Nothing
        Me.bunibtn_Seguimiento.Iconimage_Selected = Nothing
        Me.bunibtn_Seguimiento.IconMarginLeft = 0
        Me.bunibtn_Seguimiento.IconMarginRight = 0
        Me.bunibtn_Seguimiento.IconRightVisible = True
        Me.bunibtn_Seguimiento.IconRightZoom = 0R
        Me.bunibtn_Seguimiento.IconVisible = True
        Me.bunibtn_Seguimiento.IconZoom = 60.0R
        Me.bunibtn_Seguimiento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bunibtn_Seguimiento.IsTab = False
        Me.bunibtn_Seguimiento.Location = New System.Drawing.Point(0, 737)
        Me.bunibtn_Seguimiento.Name = "bunibtn_Seguimiento"
        Me.bunibtn_Seguimiento.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.bunibtn_Seguimiento.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.bunibtn_Seguimiento.OnHoverTextColor = System.Drawing.Color.LightGoldenrodYellow
        Me.bunibtn_Seguimiento.selected = False
        Me.bunibtn_Seguimiento.Size = New System.Drawing.Size(197, 60)
        Me.bunibtn_Seguimiento.TabIndex = 19
        Me.bunibtn_Seguimiento.Text = "Seguimiento"
        Me.bunibtn_Seguimiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bunibtn_Seguimiento.Textcolor = System.Drawing.Color.Snow
        Me.bunibtn_Seguimiento.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'buniPanel_config
        '
        Me.buniPanel_config.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.buniPanel_config.BackgroundImage = CType(resources.GetObject("buniPanel_config.BackgroundImage"), System.Drawing.Image)
        Me.buniPanel_config.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.buniPanel_config.Controls.Add(Me.btn_buniParamSAP)
        Me.buniPanel_config.Controls.Add(Me.btn_buniParamSQL)
        Me.buniPanel_config.Controls.Add(Me.btn_buniUsuarios)
        Me.buniPanel_config.Dock = System.Windows.Forms.DockStyle.Top
        Me.buniPanel_config.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.buniPanel_config.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.buniPanel_config.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.buniPanel_config.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.buniPanel_config.Location = New System.Drawing.Point(0, 581)
        Me.buniPanel_config.Name = "buniPanel_config"
        Me.buniPanel_config.Quality = 10
        Me.buniPanel_config.Size = New System.Drawing.Size(197, 156)
        Me.buniPanel_config.TabIndex = 17
        '
        'btn_buniParamSAP
        '
        Me.btn_buniParamSAP.Activecolor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btn_buniParamSAP.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btn_buniParamSAP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_buniParamSAP.BorderRadius = 0
        Me.btn_buniParamSAP.ButtonText = "Parámetros SAP"
        Me.btn_buniParamSAP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_buniParamSAP.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_buniParamSAP.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_buniParamSAP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btn_buniParamSAP.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_buniParamSAP.Iconimage = CType(resources.GetObject("btn_buniParamSAP.Iconimage"), System.Drawing.Image)
        Me.btn_buniParamSAP.Iconimage_right = Nothing
        Me.btn_buniParamSAP.Iconimage_right_Selected = Nothing
        Me.btn_buniParamSAP.Iconimage_Selected = Nothing
        Me.btn_buniParamSAP.IconMarginLeft = 0
        Me.btn_buniParamSAP.IconMarginRight = 0
        Me.btn_buniParamSAP.IconRightVisible = True
        Me.btn_buniParamSAP.IconRightZoom = 0R
        Me.btn_buniParamSAP.IconVisible = True
        Me.btn_buniParamSAP.IconZoom = 30.0R
        Me.btn_buniParamSAP.IsTab = False
        Me.btn_buniParamSAP.Location = New System.Drawing.Point(0, 96)
        Me.btn_buniParamSAP.Name = "btn_buniParamSAP"
        Me.btn_buniParamSAP.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btn_buniParamSAP.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btn_buniParamSAP.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_buniParamSAP.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btn_buniParamSAP.selected = False
        Me.btn_buniParamSAP.Size = New System.Drawing.Size(197, 48)
        Me.btn_buniParamSAP.TabIndex = 7
        Me.btn_buniParamSAP.Text = "Parámetros SAP"
        Me.btn_buniParamSAP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_buniParamSAP.Textcolor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_buniParamSAP.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_buniParamSQL
        '
        Me.btn_buniParamSQL.Activecolor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btn_buniParamSQL.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btn_buniParamSQL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_buniParamSQL.BorderRadius = 0
        Me.btn_buniParamSQL.ButtonText = "Parámetros SQL"
        Me.btn_buniParamSQL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_buniParamSQL.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_buniParamSQL.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_buniParamSQL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btn_buniParamSQL.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_buniParamSQL.Iconimage = CType(resources.GetObject("btn_buniParamSQL.Iconimage"), System.Drawing.Image)
        Me.btn_buniParamSQL.Iconimage_right = Nothing
        Me.btn_buniParamSQL.Iconimage_right_Selected = Nothing
        Me.btn_buniParamSQL.Iconimage_Selected = Nothing
        Me.btn_buniParamSQL.IconMarginLeft = 0
        Me.btn_buniParamSQL.IconMarginRight = 0
        Me.btn_buniParamSQL.IconRightVisible = True
        Me.btn_buniParamSQL.IconRightZoom = 0R
        Me.btn_buniParamSQL.IconVisible = True
        Me.btn_buniParamSQL.IconZoom = 30.0R
        Me.btn_buniParamSQL.IsTab = False
        Me.btn_buniParamSQL.Location = New System.Drawing.Point(0, 48)
        Me.btn_buniParamSQL.Name = "btn_buniParamSQL"
        Me.btn_buniParamSQL.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btn_buniParamSQL.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btn_buniParamSQL.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_buniParamSQL.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btn_buniParamSQL.selected = False
        Me.btn_buniParamSQL.Size = New System.Drawing.Size(197, 48)
        Me.btn_buniParamSQL.TabIndex = 6
        Me.btn_buniParamSQL.Text = "Parámetros SQL"
        Me.btn_buniParamSQL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_buniParamSQL.Textcolor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_buniParamSQL.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_buniUsuarios
        '
        Me.btn_buniUsuarios.Activecolor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btn_buniUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btn_buniUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_buniUsuarios.BorderRadius = 0
        Me.btn_buniUsuarios.ButtonText = "Mantenedor usuarios"
        Me.btn_buniUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_buniUsuarios.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_buniUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_buniUsuarios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btn_buniUsuarios.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_buniUsuarios.Iconimage = CType(resources.GetObject("btn_buniUsuarios.Iconimage"), System.Drawing.Image)
        Me.btn_buniUsuarios.Iconimage_right = Nothing
        Me.btn_buniUsuarios.Iconimage_right_Selected = Nothing
        Me.btn_buniUsuarios.Iconimage_Selected = Nothing
        Me.btn_buniUsuarios.IconMarginLeft = 0
        Me.btn_buniUsuarios.IconMarginRight = 0
        Me.btn_buniUsuarios.IconRightVisible = True
        Me.btn_buniUsuarios.IconRightZoom = 0R
        Me.btn_buniUsuarios.IconVisible = True
        Me.btn_buniUsuarios.IconZoom = 30.0R
        Me.btn_buniUsuarios.IsTab = False
        Me.btn_buniUsuarios.Location = New System.Drawing.Point(0, 0)
        Me.btn_buniUsuarios.Name = "btn_buniUsuarios"
        Me.btn_buniUsuarios.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btn_buniUsuarios.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btn_buniUsuarios.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_buniUsuarios.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btn_buniUsuarios.selected = False
        Me.btn_buniUsuarios.Size = New System.Drawing.Size(197, 48)
        Me.btn_buniUsuarios.TabIndex = 4
        Me.btn_buniUsuarios.Text = "Mantenedor usuarios"
        Me.btn_buniUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_buniUsuarios.Textcolor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_buniUsuarios.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bunibtn_Config
        '
        Me.bunibtn_Config.Activecolor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.bunibtn_Config.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.bunibtn_Config.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bunibtn_Config.BorderRadius = 0
        Me.bunibtn_Config.ButtonText = "Configuración"
        Me.bunibtn_Config.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bunibtn_Config.DisabledColor = System.Drawing.Color.Gray
        Me.bunibtn_Config.Dock = System.Windows.Forms.DockStyle.Top
        Me.bunibtn_Config.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.bunibtn_Config.Iconcolor = System.Drawing.Color.Transparent
        Me.bunibtn_Config.Iconimage = CType(resources.GetObject("bunibtn_Config.Iconimage"), System.Drawing.Image)
        Me.bunibtn_Config.Iconimage_right = Nothing
        Me.bunibtn_Config.Iconimage_right_Selected = Nothing
        Me.bunibtn_Config.Iconimage_Selected = Nothing
        Me.bunibtn_Config.IconMarginLeft = 0
        Me.bunibtn_Config.IconMarginRight = 0
        Me.bunibtn_Config.IconRightVisible = True
        Me.bunibtn_Config.IconRightZoom = 0R
        Me.bunibtn_Config.IconVisible = True
        Me.bunibtn_Config.IconZoom = 50.0R
        Me.bunibtn_Config.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bunibtn_Config.IsTab = False
        Me.bunibtn_Config.Location = New System.Drawing.Point(0, 521)
        Me.bunibtn_Config.Name = "bunibtn_Config"
        Me.bunibtn_Config.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.bunibtn_Config.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.bunibtn_Config.OnHoverTextColor = System.Drawing.Color.LightGoldenrodYellow
        Me.bunibtn_Config.selected = False
        Me.bunibtn_Config.Size = New System.Drawing.Size(197, 60)
        Me.bunibtn_Config.TabIndex = 18
        Me.bunibtn_Config.Text = "Configuración"
        Me.bunibtn_Config.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bunibtn_Config.Textcolor = System.Drawing.Color.Snow
        Me.bunibtn_Config.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bunibtn_Rendiciones
        '
        Me.bunibtn_Rendiciones.Activecolor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.bunibtn_Rendiciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.bunibtn_Rendiciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bunibtn_Rendiciones.BorderRadius = 0
        Me.bunibtn_Rendiciones.ButtonText = "Rendiciones"
        Me.bunibtn_Rendiciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bunibtn_Rendiciones.DisabledColor = System.Drawing.Color.Gray
        Me.bunibtn_Rendiciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.bunibtn_Rendiciones.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.bunibtn_Rendiciones.Iconcolor = System.Drawing.Color.Transparent
        Me.bunibtn_Rendiciones.Iconimage = CType(resources.GetObject("bunibtn_Rendiciones.Iconimage"), System.Drawing.Image)
        Me.bunibtn_Rendiciones.Iconimage_right = Nothing
        Me.bunibtn_Rendiciones.Iconimage_right_Selected = Nothing
        Me.bunibtn_Rendiciones.Iconimage_Selected = Nothing
        Me.bunibtn_Rendiciones.IconMarginLeft = 0
        Me.bunibtn_Rendiciones.IconMarginRight = 0
        Me.bunibtn_Rendiciones.IconRightVisible = True
        Me.bunibtn_Rendiciones.IconRightZoom = 0R
        Me.bunibtn_Rendiciones.IconVisible = True
        Me.bunibtn_Rendiciones.IconZoom = 50.0R
        Me.bunibtn_Rendiciones.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bunibtn_Rendiciones.IsTab = False
        Me.bunibtn_Rendiciones.Location = New System.Drawing.Point(0, 461)
        Me.bunibtn_Rendiciones.Name = "bunibtn_Rendiciones"
        Me.bunibtn_Rendiciones.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.bunibtn_Rendiciones.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.bunibtn_Rendiciones.OnHoverTextColor = System.Drawing.Color.LightGoldenrodYellow
        Me.bunibtn_Rendiciones.selected = False
        Me.bunibtn_Rendiciones.Size = New System.Drawing.Size(197, 60)
        Me.bunibtn_Rendiciones.TabIndex = 17
        Me.bunibtn_Rendiciones.Text = "Rendiciones"
        Me.bunibtn_Rendiciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bunibtn_Rendiciones.Textcolor = System.Drawing.Color.Snow
        Me.bunibtn_Rendiciones.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'buniPanel_produccion
        '
        Me.buniPanel_produccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.buniPanel_produccion.BackgroundImage = CType(resources.GetObject("buniPanel_produccion.BackgroundImage"), System.Drawing.Image)
        Me.buniPanel_produccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.buniPanel_produccion.Controls.Add(Me.BunifuFlatButton2)
        Me.buniPanel_produccion.Controls.Add(Me.BunifuFlatButton3)
        Me.buniPanel_produccion.Controls.Add(Me.btn_prodEMSM)
        Me.buniPanel_produccion.Dock = System.Windows.Forms.DockStyle.Top
        Me.buniPanel_produccion.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.buniPanel_produccion.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.buniPanel_produccion.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.buniPanel_produccion.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.buniPanel_produccion.Location = New System.Drawing.Point(0, 309)
        Me.buniPanel_produccion.Name = "buniPanel_produccion"
        Me.buniPanel_produccion.Quality = 10
        Me.buniPanel_produccion.Size = New System.Drawing.Size(197, 152)
        Me.buniPanel_produccion.TabIndex = 16
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.ButtonText = "Produccion3"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BunifuFlatButton2.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuFlatButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = CType(resources.GetObject("BunifuFlatButton2.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0R
        Me.BunifuFlatButton2.IconVisible = True
        Me.BunifuFlatButton2.IconZoom = 30.0R
        Me.BunifuFlatButton2.IsTab = False
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(0, 96)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BunifuFlatButton2.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(197, 48)
        Me.BunifuFlatButton2.TabIndex = 5
        Me.BunifuFlatButton2.Text = "Produccion3"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton3
        '
        Me.BunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.BunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.BunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton3.BorderRadius = 0
        Me.BunifuFlatButton3.ButtonText = "Produccion 2"
        Me.BunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton3.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BunifuFlatButton3.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuFlatButton3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.BunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.Iconimage = CType(resources.GetObject("BunifuFlatButton3.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton3.Iconimage_right = Nothing
        Me.BunifuFlatButton3.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton3.Iconimage_Selected = Nothing
        Me.BunifuFlatButton3.IconMarginLeft = 0
        Me.BunifuFlatButton3.IconMarginRight = 0
        Me.BunifuFlatButton3.IconRightVisible = True
        Me.BunifuFlatButton3.IconRightZoom = 0R
        Me.BunifuFlatButton3.IconVisible = True
        Me.BunifuFlatButton3.IconZoom = 30.0R
        Me.BunifuFlatButton3.IsTab = False
        Me.BunifuFlatButton3.Location = New System.Drawing.Point(0, 48)
        Me.BunifuFlatButton3.Name = "BunifuFlatButton3"
        Me.BunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.BunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.BunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BunifuFlatButton3.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BunifuFlatButton3.selected = False
        Me.BunifuFlatButton3.Size = New System.Drawing.Size(197, 48)
        Me.BunifuFlatButton3.TabIndex = 6
        Me.BunifuFlatButton3.Text = "Produccion 2"
        Me.BunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton3.Textcolor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BunifuFlatButton3.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_prodEMSM
        '
        Me.btn_prodEMSM.Activecolor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btn_prodEMSM.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btn_prodEMSM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_prodEMSM.BorderRadius = 0
        Me.btn_prodEMSM.ButtonText = "Entrada y salida de mercancia"
        Me.btn_prodEMSM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_prodEMSM.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_prodEMSM.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_prodEMSM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btn_prodEMSM.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_prodEMSM.Iconimage = CType(resources.GetObject("btn_prodEMSM.Iconimage"), System.Drawing.Image)
        Me.btn_prodEMSM.Iconimage_right = Nothing
        Me.btn_prodEMSM.Iconimage_right_Selected = Nothing
        Me.btn_prodEMSM.Iconimage_Selected = Nothing
        Me.btn_prodEMSM.IconMarginLeft = 0
        Me.btn_prodEMSM.IconMarginRight = 0
        Me.btn_prodEMSM.IconRightVisible = True
        Me.btn_prodEMSM.IconRightZoom = 0R
        Me.btn_prodEMSM.IconVisible = True
        Me.btn_prodEMSM.IconZoom = 30.0R
        Me.btn_prodEMSM.IsTab = False
        Me.btn_prodEMSM.Location = New System.Drawing.Point(0, 0)
        Me.btn_prodEMSM.Name = "btn_prodEMSM"
        Me.btn_prodEMSM.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btn_prodEMSM.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btn_prodEMSM.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_prodEMSM.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btn_prodEMSM.selected = False
        Me.btn_prodEMSM.Size = New System.Drawing.Size(197, 48)
        Me.btn_prodEMSM.TabIndex = 4
        Me.btn_prodEMSM.Text = "Entrada y salida de mercancia"
        Me.btn_prodEMSM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_prodEMSM.Textcolor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_prodEMSM.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bunifbtn_Produccion
        '
        Me.bunifbtn_Produccion.Activecolor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.bunifbtn_Produccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.bunifbtn_Produccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bunifbtn_Produccion.BorderRadius = 0
        Me.bunifbtn_Produccion.ButtonText = "Producción"
        Me.bunifbtn_Produccion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bunifbtn_Produccion.DisabledColor = System.Drawing.Color.Gray
        Me.bunifbtn_Produccion.Dock = System.Windows.Forms.DockStyle.Top
        Me.bunifbtn_Produccion.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.bunifbtn_Produccion.Iconcolor = System.Drawing.Color.Transparent
        Me.bunifbtn_Produccion.Iconimage = CType(resources.GetObject("bunifbtn_Produccion.Iconimage"), System.Drawing.Image)
        Me.bunifbtn_Produccion.Iconimage_right = Nothing
        Me.bunifbtn_Produccion.Iconimage_right_Selected = Nothing
        Me.bunifbtn_Produccion.Iconimage_Selected = Nothing
        Me.bunifbtn_Produccion.IconMarginLeft = 0
        Me.bunifbtn_Produccion.IconMarginRight = 0
        Me.bunifbtn_Produccion.IconRightVisible = True
        Me.bunifbtn_Produccion.IconRightZoom = 0R
        Me.bunifbtn_Produccion.IconVisible = True
        Me.bunifbtn_Produccion.IconZoom = 50.0R
        Me.bunifbtn_Produccion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bunifbtn_Produccion.IsTab = False
        Me.bunifbtn_Produccion.Location = New System.Drawing.Point(0, 249)
        Me.bunifbtn_Produccion.Name = "bunifbtn_Produccion"
        Me.bunifbtn_Produccion.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.bunifbtn_Produccion.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.bunifbtn_Produccion.OnHoverTextColor = System.Drawing.Color.LightGoldenrodYellow
        Me.bunifbtn_Produccion.selected = False
        Me.bunifbtn_Produccion.Size = New System.Drawing.Size(197, 60)
        Me.bunifbtn_Produccion.TabIndex = 15
        Me.bunifbtn_Produccion.Text = "Producción"
        Me.bunifbtn_Produccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bunifbtn_Produccion.Textcolor = System.Drawing.Color.Snow
        Me.bunifbtn_Produccion.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bunifPanel_SolCompras
        '
        Me.bunifPanel_SolCompras.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.bunifPanel_SolCompras.BackgroundImage = CType(resources.GetObject("bunifPanel_SolCompras.BackgroundImage"), System.Drawing.Image)
        Me.bunifPanel_SolCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bunifPanel_SolCompras.Controls.Add(Me.btn_pedido)
        Me.bunifPanel_SolCompras.Controls.Add(Me.btn_ofertaCompra)
        Me.bunifPanel_SolCompras.Controls.Add(Me.btn_solCompra)
        Me.bunifPanel_SolCompras.Dock = System.Windows.Forms.DockStyle.Top
        Me.bunifPanel_SolCompras.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.bunifPanel_SolCompras.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.bunifPanel_SolCompras.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.bunifPanel_SolCompras.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.bunifPanel_SolCompras.Location = New System.Drawing.Point(0, 97)
        Me.bunifPanel_SolCompras.Name = "bunifPanel_SolCompras"
        Me.bunifPanel_SolCompras.Quality = 10
        Me.bunifPanel_SolCompras.Size = New System.Drawing.Size(197, 152)
        Me.bunifPanel_SolCompras.TabIndex = 14
        '
        'btn_pedido
        '
        Me.btn_pedido.Activecolor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btn_pedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btn_pedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_pedido.BorderRadius = 0
        Me.btn_pedido.ButtonText = "Pedido"
        Me.btn_pedido.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_pedido.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_pedido.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_pedido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btn_pedido.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_pedido.Iconimage = CType(resources.GetObject("btn_pedido.Iconimage"), System.Drawing.Image)
        Me.btn_pedido.Iconimage_right = Nothing
        Me.btn_pedido.Iconimage_right_Selected = Nothing
        Me.btn_pedido.Iconimage_Selected = Nothing
        Me.btn_pedido.IconMarginLeft = 0
        Me.btn_pedido.IconMarginRight = 0
        Me.btn_pedido.IconRightVisible = True
        Me.btn_pedido.IconRightZoom = 0R
        Me.btn_pedido.IconVisible = True
        Me.btn_pedido.IconZoom = 30.0R
        Me.btn_pedido.IsTab = False
        Me.btn_pedido.Location = New System.Drawing.Point(0, 96)
        Me.btn_pedido.Name = "btn_pedido"
        Me.btn_pedido.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btn_pedido.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btn_pedido.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_pedido.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btn_pedido.selected = False
        Me.btn_pedido.Size = New System.Drawing.Size(197, 48)
        Me.btn_pedido.TabIndex = 5
        Me.btn_pedido.Text = "Pedido"
        Me.btn_pedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_pedido.Textcolor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_pedido.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_ofertaCompra
        '
        Me.btn_ofertaCompra.Activecolor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btn_ofertaCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btn_ofertaCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_ofertaCompra.BorderRadius = 0
        Me.btn_ofertaCompra.ButtonText = "Oferta de compra"
        Me.btn_ofertaCompra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ofertaCompra.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_ofertaCompra.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_ofertaCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btn_ofertaCompra.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_ofertaCompra.Iconimage = CType(resources.GetObject("btn_ofertaCompra.Iconimage"), System.Drawing.Image)
        Me.btn_ofertaCompra.Iconimage_right = Nothing
        Me.btn_ofertaCompra.Iconimage_right_Selected = Nothing
        Me.btn_ofertaCompra.Iconimage_Selected = Nothing
        Me.btn_ofertaCompra.IconMarginLeft = 0
        Me.btn_ofertaCompra.IconMarginRight = 0
        Me.btn_ofertaCompra.IconRightVisible = True
        Me.btn_ofertaCompra.IconRightZoom = 0R
        Me.btn_ofertaCompra.IconVisible = True
        Me.btn_ofertaCompra.IconZoom = 30.0R
        Me.btn_ofertaCompra.IsTab = False
        Me.btn_ofertaCompra.Location = New System.Drawing.Point(0, 48)
        Me.btn_ofertaCompra.Name = "btn_ofertaCompra"
        Me.btn_ofertaCompra.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btn_ofertaCompra.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btn_ofertaCompra.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_ofertaCompra.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btn_ofertaCompra.selected = False
        Me.btn_ofertaCompra.Size = New System.Drawing.Size(197, 48)
        Me.btn_ofertaCompra.TabIndex = 6
        Me.btn_ofertaCompra.Text = "Oferta de compra"
        Me.btn_ofertaCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ofertaCompra.Textcolor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_ofertaCompra.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_solCompra
        '
        Me.btn_solCompra.Activecolor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btn_solCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btn_solCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_solCompra.BorderRadius = 0
        Me.btn_solCompra.ButtonText = "Solicitud de compra"
        Me.btn_solCompra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_solCompra.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_solCompra.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_solCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btn_solCompra.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_solCompra.Iconimage = CType(resources.GetObject("btn_solCompra.Iconimage"), System.Drawing.Image)
        Me.btn_solCompra.Iconimage_right = Nothing
        Me.btn_solCompra.Iconimage_right_Selected = Nothing
        Me.btn_solCompra.Iconimage_Selected = Nothing
        Me.btn_solCompra.IconMarginLeft = 0
        Me.btn_solCompra.IconMarginRight = 0
        Me.btn_solCompra.IconRightVisible = True
        Me.btn_solCompra.IconRightZoom = 0R
        Me.btn_solCompra.IconVisible = True
        Me.btn_solCompra.IconZoom = 30.0R
        Me.btn_solCompra.IsTab = False
        Me.btn_solCompra.Location = New System.Drawing.Point(0, 0)
        Me.btn_solCompra.Name = "btn_solCompra"
        Me.btn_solCompra.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btn_solCompra.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btn_solCompra.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_solCompra.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btn_solCompra.selected = False
        Me.btn_solCompra.Size = New System.Drawing.Size(197, 48)
        Me.btn_solCompra.TabIndex = 4
        Me.btn_solCompra.Text = "Solicitud de compra"
        Me.btn_solCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_solCompra.Textcolor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_solCompra.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bunibtn_Compras
        '
        Me.bunibtn_Compras.Activecolor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.bunibtn_Compras.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.bunibtn_Compras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bunibtn_Compras.BorderRadius = 0
        Me.bunibtn_Compras.ButtonText = "Compras"
        Me.bunibtn_Compras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bunibtn_Compras.DisabledColor = System.Drawing.Color.Gray
        Me.bunibtn_Compras.Dock = System.Windows.Forms.DockStyle.Top
        Me.bunibtn_Compras.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.bunibtn_Compras.Iconcolor = System.Drawing.Color.Transparent
        Me.bunibtn_Compras.Iconimage = CType(resources.GetObject("bunibtn_Compras.Iconimage"), System.Drawing.Image)
        Me.bunibtn_Compras.Iconimage_right = Nothing
        Me.bunibtn_Compras.Iconimage_right_Selected = Nothing
        Me.bunibtn_Compras.Iconimage_Selected = Nothing
        Me.bunibtn_Compras.IconMarginLeft = 0
        Me.bunibtn_Compras.IconMarginRight = 0
        Me.bunibtn_Compras.IconRightVisible = True
        Me.bunibtn_Compras.IconRightZoom = 0R
        Me.bunibtn_Compras.IconVisible = True
        Me.bunibtn_Compras.IconZoom = 60.0R
        Me.bunibtn_Compras.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bunibtn_Compras.IsTab = False
        Me.bunibtn_Compras.Location = New System.Drawing.Point(0, 37)
        Me.bunibtn_Compras.Name = "bunibtn_Compras"
        Me.bunibtn_Compras.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.bunibtn_Compras.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.bunibtn_Compras.OnHoverTextColor = System.Drawing.Color.LightGoldenrodYellow
        Me.bunibtn_Compras.selected = False
        Me.bunibtn_Compras.Size = New System.Drawing.Size(197, 60)
        Me.bunibtn_Compras.TabIndex = 13
        Me.bunibtn_Compras.Text = "Compras"
        Me.bunibtn_Compras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bunibtn_Compras.Textcolor = System.Drawing.Color.Snow
        Me.bunibtn_Compras.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bunPanel_izqTop
        '
        Me.bunPanel_izqTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.bunPanel_izqTop.BackgroundImage = CType(resources.GetObject("bunPanel_izqTop.BackgroundImage"), System.Drawing.Image)
        Me.bunPanel_izqTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bunPanel_izqTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.bunPanel_izqTop.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.bunPanel_izqTop.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.bunPanel_izqTop.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.bunPanel_izqTop.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.bunPanel_izqTop.Location = New System.Drawing.Point(0, 0)
        Me.bunPanel_izqTop.Name = "bunPanel_izqTop"
        Me.bunPanel_izqTop.Quality = 10
        Me.bunPanel_izqTop.Size = New System.Drawing.Size(197, 37)
        Me.bunPanel_izqTop.TabIndex = 12
        '
        'Panel_top
        '
        Me.Panel_top.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Panel_top.Controls.Add(Me.Label3)
        Me.Panel_top.Controls.Add(Me.lblNomUsuario)
        Me.Panel_top.Controls.Add(Me.Label2)
        Me.Panel_top.Controls.Add(Me.PictureBox2)
        Me.Panel_top.Controls.Add(Me.btn_Maximizar)
        Me.Panel_top.Controls.Add(Me.btn_Restaurar)
        Me.Panel_top.Controls.Add(Me.btn_Salir)
        Me.Panel_top.Controls.Add(Me.btn_Minimizar)
        Me.Panel_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_top.Location = New System.Drawing.Point(0, 0)
        Me.Panel_top.Name = "Panel_top"
        Me.Panel_top.Size = New System.Drawing.Size(939, 33)
        Me.Panel_top.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(583, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 19)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "al menú principal"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNomUsuario
        '
        Me.lblNomUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNomUsuario.AutoSize = True
        Me.lblNomUsuario.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomUsuario.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblNomUsuario.Location = New System.Drawing.Point(516, 9)
        Me.lblNomUsuario.Name = "lblNomUsuario"
        Me.lblNomUsuario.Size = New System.Drawing.Size(63, 19)
        Me.lblNomUsuario.TabIndex = 74
        Me.lblNomUsuario.Text = "Label2"
        Me.lblNomUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(395, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 19)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Bienvenido/a"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(47, 33)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 73
        Me.PictureBox2.TabStop = False
        '
        'btn_Maximizar
        '
        Me.btn_Maximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Maximizar.BackColor = System.Drawing.Color.Transparent
        Me.btn_Maximizar.Image = CType(resources.GetObject("btn_Maximizar.Image"), System.Drawing.Image)
        Me.btn_Maximizar.ImageActive = Nothing
        Me.btn_Maximizar.Location = New System.Drawing.Point(841, 2)
        Me.btn_Maximizar.Name = "btn_Maximizar"
        Me.btn_Maximizar.Size = New System.Drawing.Size(36, 30)
        Me.btn_Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_Maximizar.TabIndex = 7
        Me.btn_Maximizar.TabStop = False
        Me.btn_Maximizar.Zoom = 10
        '
        'btn_Restaurar
        '
        Me.btn_Restaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Restaurar.BackColor = System.Drawing.Color.Transparent
        Me.btn_Restaurar.Image = CType(resources.GetObject("btn_Restaurar.Image"), System.Drawing.Image)
        Me.btn_Restaurar.ImageActive = Nothing
        Me.btn_Restaurar.Location = New System.Drawing.Point(841, 2)
        Me.btn_Restaurar.Name = "btn_Restaurar"
        Me.btn_Restaurar.Size = New System.Drawing.Size(36, 30)
        Me.btn_Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_Restaurar.TabIndex = 8
        Me.btn_Restaurar.TabStop = False
        Me.btn_Restaurar.Visible = False
        Me.btn_Restaurar.Zoom = 10
        '
        'btn_Salir
        '
        Me.btn_Salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Salir.BackColor = System.Drawing.Color.Transparent
        Me.btn_Salir.Image = CType(resources.GetObject("btn_Salir.Image"), System.Drawing.Image)
        Me.btn_Salir.ImageActive = Nothing
        Me.btn_Salir.Location = New System.Drawing.Point(883, 2)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(36, 30)
        Me.btn_Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_Salir.TabIndex = 5
        Me.btn_Salir.TabStop = False
        Me.btn_Salir.Zoom = 10
        '
        'btn_Minimizar
        '
        Me.btn_Minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Minimizar.BackColor = System.Drawing.Color.Transparent
        Me.btn_Minimizar.Image = CType(resources.GetObject("btn_Minimizar.Image"), System.Drawing.Image)
        Me.btn_Minimizar.ImageActive = Nothing
        Me.btn_Minimizar.Location = New System.Drawing.Point(799, 2)
        Me.btn_Minimizar.Name = "btn_Minimizar"
        Me.btn_Minimizar.Size = New System.Drawing.Size(36, 30)
        Me.btn_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_Minimizar.TabIndex = 6
        Me.btn_Minimizar.TabStop = False
        Me.btn_Minimizar.Zoom = 10
        '
        'Panelcentrofondo
        '
        Me.Panelcentrofondo.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Panelcentrofondo.Controls.Add(Me.Label1)
        Me.Panelcentrofondo.Controls.Add(Me.Panelcentro_encima)
        Me.Panelcentrofondo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panelcentrofondo.Location = New System.Drawing.Point(214, 70)
        Me.Panelcentrofondo.Name = "Panelcentrofondo"
        Me.Panelcentrofondo.Padding = New System.Windows.Forms.Padding(20)
        Me.Panelcentrofondo.Size = New System.Drawing.Size(725, 437)
        Me.Panelcentrofondo.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(203, 421)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 12)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Desarrollado por Hugo Smith | Wendolaine Castillo | Claudio Somorrostro"
        '
        'Panelcentro_encima
        '
        Me.Panelcentro_encima.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Panelcentro_encima.Controls.Add(Me.btn_hideMenu)
        Me.Panelcentro_encima.Controls.Add(Me.PictureBox1)
        Me.Panelcentro_encima.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panelcentro_encima.Location = New System.Drawing.Point(20, 20)
        Me.Panelcentro_encima.Name = "Panelcentro_encima"
        Me.Panelcentro_encima.Size = New System.Drawing.Size(685, 397)
        Me.Panelcentro_encima.TabIndex = 4
        '
        'btn_hideMenu
        '
        Me.btn_hideMenu.BackColor = System.Drawing.Color.Transparent
        Me.btn_hideMenu.Image = CType(resources.GetObject("btn_hideMenu.Image"), System.Drawing.Image)
        Me.btn_hideMenu.ImageActive = Nothing
        Me.btn_hideMenu.Location = New System.Drawing.Point(3, 3)
        Me.btn_hideMenu.Name = "btn_hideMenu"
        Me.btn_hideMenu.Size = New System.Drawing.Size(36, 29)
        Me.btn_hideMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_hideMenu.TabIndex = 10
        Me.btn_hideMenu.TabStop = False
        Me.btn_hideMenu.Zoom = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(232, 117)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(261, 145)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Movimiento_cabecera
        '
        Me.Movimiento_cabecera.Fixed = True
        Me.Movimiento_cabecera.Horizontal = True
        Me.Movimiento_cabecera.TargetControl = Me.Panel_top
        Me.Movimiento_cabecera.Vertical = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BunifuGradientPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(214, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(725, 37)
        Me.Panel1.TabIndex = 5
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(725, 37)
        Me.BunifuGradientPanel1.TabIndex = 13
        '
        'MenúPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 507)
        Me.Controls.Add(Me.Panelcentrofondo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.Panel_top)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MenúPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenúPrincipal"
        Me.PanelMenu.ResumeLayout(False)
        Me.buniPanel_config.ResumeLayout(False)
        Me.buniPanel_produccion.ResumeLayout(False)
        Me.bunifPanel_SolCompras.ResumeLayout(False)
        Me.Panel_top.ResumeLayout(False)
        Me.Panel_top.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Maximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Restaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Salir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelcentrofondo.ResumeLayout(False)
        Me.Panelcentrofondo.PerformLayout()
        Me.Panelcentro_encima.ResumeLayout(False)
        CType(Me.btn_hideMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents Panel_top As Panel
    Friend WithEvents btn_Salir As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_Maximizar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_Restaurar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_Minimizar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents bunibtn_Compras As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bunPanel_izqTop As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Panelcentrofondo As Panel
    Friend WithEvents Panelcentro_encima As Panel
    Friend WithEvents btn_ofertaCompra As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_hideMenu As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_pedido As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_solCompra As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents bunifbtn_Produccion As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bunifPanel_SolCompras As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents buniPanel_produccion As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton3 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_prodEMSM As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bunibtn_Config As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bunibtn_Rendiciones As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Movimiento_cabecera As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents buniPanel_config As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents btn_buniParamSQL As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_buniUsuarios As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_buniParamSAP As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNomUsuario As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents bunibtn_Seguimiento As Bunifu.Framework.UI.BunifuFlatButton
End Class
