<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SeguimientoSAP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SeguimientoSAP))
        Me.Panel_topProd = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btn_Salir = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_Minimizar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ProgressBar_busqueda = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_OK = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_SalirS = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.timePicker_fechaCreacion = New System.Windows.Forms.DateTimePicker()
        Me.txtbox_Solicitante = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btnBuscar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSolPedido = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.mov_cabecera = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtOferta = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.groubox_OF = New System.Windows.Forms.GroupBox()
        Me.lblOferta = New System.Windows.Forms.Label()
        Me.BunifuSeparator5 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.GroupBox_pedido = New System.Windows.Forms.GroupBox()
        Me.lblPedido = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuSeparator3 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator4 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPedido = New System.Windows.Forms.Label()
        Me.GroupBox_recepcion = New System.Windows.Forms.GroupBox()
        Me.lblRecepcion = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BunifuSeparator6 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRecepcion = New System.Windows.Forms.Label()
        Me.panel_groupbox = New System.Windows.Forms.Panel()
        Me.imgRecepCancel = New System.Windows.Forms.PictureBox()
        Me.imgPedidoCancel = New System.Windows.Forms.PictureBox()
        Me.imgOfertaCancel = New System.Windows.Forms.PictureBox()
        Me.imgRecepcionOk = New System.Windows.Forms.PictureBox()
        Me.imgPedidoOk = New System.Windows.Forms.PictureBox()
        Me.imgOfertaOk = New System.Windows.Forms.PictureBox()
        Me.progressbar_oferta = New Bunifu.Framework.UI.BunifuProgressBar()
        Me.Panel_topProd.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Salir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.btnBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.groubox_OF.SuspendLayout()
        Me.GroupBox_pedido.SuspendLayout()
        Me.GroupBox_recepcion.SuspendLayout()
        Me.panel_groupbox.SuspendLayout()
        CType(Me.imgRecepCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPedidoCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgOfertaCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgRecepcionOk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPedidoOk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgOfertaOk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_topProd
        '
        Me.Panel_topProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Panel_topProd.Controls.Add(Me.PictureBox1)
        Me.Panel_topProd.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel_topProd.Controls.Add(Me.btn_Salir)
        Me.Panel_topProd.Controls.Add(Me.btn_Minimizar)
        Me.Panel_topProd.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_topProd.Location = New System.Drawing.Point(0, 0)
        Me.Panel_topProd.Name = "Panel_topProd"
        Me.Panel_topProd.Size = New System.Drawing.Size(752, 33)
        Me.Panel_topProd.TabIndex = 71
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(47, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 72
        Me.PictureBox1.TabStop = False
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(52, 4)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(295, 24)
        Me.BunifuCustomLabel1.TabIndex = 71
        Me.BunifuCustomLabel1.Text = "Seguimiento de documentos SAP"
        '
        'btn_Salir
        '
        Me.btn_Salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Salir.BackColor = System.Drawing.Color.Transparent
        Me.btn_Salir.Image = CType(resources.GetObject("btn_Salir.Image"), System.Drawing.Image)
        Me.btn_Salir.ImageActive = Nothing
        Me.btn_Salir.Location = New System.Drawing.Point(713, 3)
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
        Me.btn_Minimizar.Location = New System.Drawing.Point(671, 3)
        Me.btn_Minimizar.Name = "btn_Minimizar"
        Me.btn_Minimizar.Size = New System.Drawing.Size(36, 30)
        Me.btn_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_Minimizar.TabIndex = 6
        Me.btn_Minimizar.TabStop = False
        Me.btn_Minimizar.Zoom = 10
        '
        'ProgressBar_busqueda
        '
        Me.ProgressBar_busqueda.animated = True
        Me.ProgressBar_busqueda.animationIterval = 5
        Me.ProgressBar_busqueda.animationSpeed = 20
        Me.ProgressBar_busqueda.BackColor = System.Drawing.Color.Transparent
        Me.ProgressBar_busqueda.BackgroundImage = CType(resources.GetObject("ProgressBar_busqueda.BackgroundImage"), System.Drawing.Image)
        Me.ProgressBar_busqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!)
        Me.ProgressBar_busqueda.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.ProgressBar_busqueda.LabelVisible = True
        Me.ProgressBar_busqueda.LineProgressThickness = 8
        Me.ProgressBar_busqueda.LineThickness = 7
        Me.ProgressBar_busqueda.Location = New System.Drawing.Point(6, 112)
        Me.ProgressBar_busqueda.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.ProgressBar_busqueda.MaxValue = 100
        Me.ProgressBar_busqueda.Name = "ProgressBar_busqueda"
        Me.ProgressBar_busqueda.ProgressBackColor = System.Drawing.Color.DarkGray
        Me.ProgressBar_busqueda.ProgressColor = System.Drawing.Color.LightSeaGreen
        Me.ProgressBar_busqueda.Size = New System.Drawing.Size(138, 138)
        Me.ProgressBar_busqueda.TabIndex = 85
        Me.ProgressBar_busqueda.Value = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 19)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Número Solicitud de Pedido:"
        '
        'btn_OK
        '
        Me.btn_OK.ActiveBorderThickness = 1
        Me.btn_OK.ActiveCornerRadius = 20
        Me.btn_OK.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btn_OK.ActiveForecolor = System.Drawing.Color.White
        Me.btn_OK.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btn_OK.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_OK.BackgroundImage = CType(resources.GetObject("btn_OK.BackgroundImage"), System.Drawing.Image)
        Me.btn_OK.ButtonText = "Nuevo"
        Me.btn_OK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_OK.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_OK.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_OK.IdleBorderThickness = 1
        Me.btn_OK.IdleCornerRadius = 20
        Me.btn_OK.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_OK.IdleForecolor = System.Drawing.Color.White
        Me.btn_OK.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_OK.Location = New System.Drawing.Point(484, 422)
        Me.btn_OK.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(91, 48)
        Me.btn_OK.TabIndex = 89
        Me.btn_OK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_SalirS
        '
        Me.btn_SalirS.ActiveBorderThickness = 1
        Me.btn_SalirS.ActiveCornerRadius = 20
        Me.btn_SalirS.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btn_SalirS.ActiveForecolor = System.Drawing.Color.White
        Me.btn_SalirS.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btn_SalirS.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_SalirS.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_SalirS.BackgroundImage = CType(resources.GetObject("btn_SalirS.BackgroundImage"), System.Drawing.Image)
        Me.btn_SalirS.ButtonText = "Salir"
        Me.btn_SalirS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_SalirS.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SalirS.ForeColor = System.Drawing.Color.White
        Me.btn_SalirS.IdleBorderThickness = 1
        Me.btn_SalirS.IdleCornerRadius = 20
        Me.btn_SalirS.IdleFillColor = System.Drawing.Color.DarkGray
        Me.btn_SalirS.IdleForecolor = System.Drawing.Color.White
        Me.btn_SalirS.IdleLineColor = System.Drawing.Color.DarkGray
        Me.btn_SalirS.Location = New System.Drawing.Point(32, 422)
        Me.btn_SalirS.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_SalirS.Name = "btn_SalirS"
        Me.btn_SalirS.Size = New System.Drawing.Size(76, 36)
        Me.btn_SalirS.TabIndex = 88
        Me.btn_SalirS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.lblMensaje)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label7)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label5)
        Me.BunifuGradientPanel1.Controls.Add(Me.ProgressBar_busqueda)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Teal
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(593, 33)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(159, 439)
        Me.BunifuGradientPanel1.TabIndex = 89
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.BackColor = System.Drawing.Color.Transparent
        Me.lblMensaje.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblMensaje.Location = New System.Drawing.Point(9, 292)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(0, 19)
        Me.lblMensaje.TabIndex = 102
        Me.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(6, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 19)
        Me.Label7.TabIndex = 99
        Me.Label7.Text = "de la búsqueda:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Location = New System.Drawing.Point(32, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 19)
        Me.Label5.TabIndex = 98
        Me.Label5.Text = "Progreso"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 19)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "Código solicitante"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 19)
        Me.Label6.TabIndex = 94
        Me.Label6.Text = "Fecha creación"
        '
        'timePicker_fechaCreacion
        '
        Me.timePicker_fechaCreacion.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timePicker_fechaCreacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.timePicker_fechaCreacion.Location = New System.Drawing.Point(243, 106)
        Me.timePicker_fechaCreacion.Name = "timePicker_fechaCreacion"
        Me.timePicker_fechaCreacion.Size = New System.Drawing.Size(144, 27)
        Me.timePicker_fechaCreacion.TabIndex = 3
        Me.timePicker_fechaCreacion.Value = New Date(2020, 1, 31, 0, 0, 0, 0)
        '
        'txtbox_Solicitante
        '
        Me.txtbox_Solicitante.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtbox_Solicitante.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbox_Solicitante.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.txtbox_Solicitante.ForeColor = System.Drawing.Color.Black
        Me.txtbox_Solicitante.HintForeColor = System.Drawing.Color.Gray
        Me.txtbox_Solicitante.HintText = "Código solicitante"
        Me.txtbox_Solicitante.isPassword = False
        Me.txtbox_Solicitante.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.txtbox_Solicitante.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.txtbox_Solicitante.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.txtbox_Solicitante.LineThickness = 3
        Me.txtbox_Solicitante.Location = New System.Drawing.Point(243, 65)
        Me.txtbox_Solicitante.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbox_Solicitante.Name = "txtbox_Solicitante"
        Me.txtbox_Solicitante.Size = New System.Drawing.Size(144, 31)
        Me.txtbox_Solicitante.TabIndex = 1
        Me.txtbox_Solicitante.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageActive = Nothing
        Me.btnBuscar.Location = New System.Drawing.Point(476, 81)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Padding = New System.Windows.Forms.Padding(1)
        Me.btnBuscar.Size = New System.Drawing.Size(62, 130)
        Me.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnBuscar.TabIndex = 96
        Me.btnBuscar.TabStop = False
        Me.btnBuscar.Zoom = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSolPedido)
        Me.GroupBox1.Controls.Add(Me.timePicker_fechaCreacion)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtbox_Solicitante)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(66, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(394, 152)
        Me.GroupBox1.TabIndex = 97
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información"
        '
        'txtSolPedido
        '
        Me.txtSolPedido.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSolPedido.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSolPedido.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.txtSolPedido.ForeColor = System.Drawing.Color.Black
        Me.txtSolPedido.HintForeColor = System.Drawing.Color.Gray
        Me.txtSolPedido.HintText = "Ingrese número"
        Me.txtSolPedido.isPassword = False
        Me.txtSolPedido.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.txtSolPedido.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.txtSolPedido.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.txtSolPedido.LineThickness = 3
        Me.txtSolPedido.Location = New System.Drawing.Point(243, 27)
        Me.txtSolPedido.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSolPedido.Name = "txtSolPedido"
        Me.txtSolPedido.Size = New System.Drawing.Size(144, 31)
        Me.txtSolPedido.TabIndex = 2
        Me.txtSolPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'mov_cabecera
        '
        Me.mov_cabecera.Fixed = True
        Me.mov_cabecera.Horizontal = True
        Me.mov_cabecera.TargetControl = Me.Panel_topProd
        Me.mov_cabecera.Vertical = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 19)
        Me.Label8.TabIndex = 99
        Me.Label8.Text = "N°     :"
        '
        'txtOferta
        '
        Me.txtOferta.AutoSize = True
        Me.txtOferta.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOferta.ForeColor = System.Drawing.Color.Black
        Me.txtOferta.Location = New System.Drawing.Point(79, 37)
        Me.txtOferta.Name = "txtOferta"
        Me.txtOferta.Size = New System.Drawing.Size(0, 22)
        Me.txtOferta.TabIndex = 109
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(11, 73)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 19)
        Me.Label11.TabIndex = 110
        Me.Label11.Text = "Estado:"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 189
        Me.BunifuSeparator1.Location = New System.Drawing.Point(6, 18)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(159, 10)
        Me.BunifuSeparator1.TabIndex = 111
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'groubox_OF
        '
        Me.groubox_OF.Controls.Add(Me.lblOferta)
        Me.groubox_OF.Controls.Add(Me.BunifuSeparator5)
        Me.groubox_OF.Controls.Add(Me.BunifuSeparator1)
        Me.groubox_OF.Controls.Add(Me.Label11)
        Me.groubox_OF.Controls.Add(Me.txtOferta)
        Me.groubox_OF.Controls.Add(Me.Label8)
        Me.groubox_OF.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groubox_OF.Location = New System.Drawing.Point(16, 3)
        Me.groubox_OF.Name = "groubox_OF"
        Me.groubox_OF.Size = New System.Drawing.Size(176, 98)
        Me.groubox_OF.TabIndex = 119
        Me.groubox_OF.TabStop = False
        Me.groubox_OF.Text = "Oferta de compra"
        '
        'lblOferta
        '
        Me.lblOferta.AutoSize = True
        Me.lblOferta.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOferta.Location = New System.Drawing.Point(72, 73)
        Me.lblOferta.Name = "lblOferta"
        Me.lblOferta.Size = New System.Drawing.Size(0, 19)
        Me.lblOferta.TabIndex = 114
        '
        'BunifuSeparator5
        '
        Me.BunifuSeparator5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.BunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuSeparator5.LineThickness = 88
        Me.BunifuSeparator5.Location = New System.Drawing.Point(12, 60)
        Me.BunifuSeparator5.Margin = New System.Windows.Forms.Padding(9)
        Me.BunifuSeparator5.Name = "BunifuSeparator5"
        Me.BunifuSeparator5.Size = New System.Drawing.Size(153, 10)
        Me.BunifuSeparator5.TabIndex = 113
        Me.BunifuSeparator5.Transparency = 255
        Me.BunifuSeparator5.Vertical = False
        '
        'GroupBox_pedido
        '
        Me.GroupBox_pedido.Controls.Add(Me.lblPedido)
        Me.GroupBox_pedido.Controls.Add(Me.Label3)
        Me.GroupBox_pedido.Controls.Add(Me.BunifuSeparator3)
        Me.GroupBox_pedido.Controls.Add(Me.BunifuSeparator4)
        Me.GroupBox_pedido.Controls.Add(Me.Label15)
        Me.GroupBox_pedido.Controls.Add(Me.txtPedido)
        Me.GroupBox_pedido.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_pedido.Location = New System.Drawing.Point(203, 3)
        Me.GroupBox_pedido.Name = "GroupBox_pedido"
        Me.GroupBox_pedido.Size = New System.Drawing.Size(176, 98)
        Me.GroupBox_pedido.TabIndex = 120
        Me.GroupBox_pedido.TabStop = False
        Me.GroupBox_pedido.Text = "Pedido"
        '
        'lblPedido
        '
        Me.lblPedido.AutoSize = True
        Me.lblPedido.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPedido.Location = New System.Drawing.Point(74, 73)
        Me.lblPedido.Name = "lblPedido"
        Me.lblPedido.Size = New System.Drawing.Size(0, 19)
        Me.lblPedido.TabIndex = 115
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 19)
        Me.Label3.TabIndex = 114
        Me.Label3.Text = "N°     :"
        '
        'BunifuSeparator3
        '
        Me.BunifuSeparator3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.BunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuSeparator3.LineThickness = 88
        Me.BunifuSeparator3.Location = New System.Drawing.Point(11, 60)
        Me.BunifuSeparator3.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuSeparator3.Name = "BunifuSeparator3"
        Me.BunifuSeparator3.Size = New System.Drawing.Size(153, 10)
        Me.BunifuSeparator3.TabIndex = 112
        Me.BunifuSeparator3.Transparency = 255
        Me.BunifuSeparator3.Vertical = False
        '
        'BunifuSeparator4
        '
        Me.BunifuSeparator4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.BunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuSeparator4.LineThickness = 189
        Me.BunifuSeparator4.Location = New System.Drawing.Point(7, 18)
        Me.BunifuSeparator4.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuSeparator4.Name = "BunifuSeparator4"
        Me.BunifuSeparator4.Size = New System.Drawing.Size(159, 10)
        Me.BunifuSeparator4.TabIndex = 111
        Me.BunifuSeparator4.Transparency = 255
        Me.BunifuSeparator4.Vertical = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(11, 73)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 19)
        Me.Label15.TabIndex = 110
        Me.Label15.Text = "Estado:"
        '
        'txtPedido
        '
        Me.txtPedido.AutoSize = True
        Me.txtPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPedido.ForeColor = System.Drawing.Color.Black
        Me.txtPedido.Location = New System.Drawing.Point(79, 37)
        Me.txtPedido.Name = "txtPedido"
        Me.txtPedido.Size = New System.Drawing.Size(0, 22)
        Me.txtPedido.TabIndex = 109
        '
        'GroupBox_recepcion
        '
        Me.GroupBox_recepcion.Controls.Add(Me.lblRecepcion)
        Me.GroupBox_recepcion.Controls.Add(Me.Label9)
        Me.GroupBox_recepcion.Controls.Add(Me.BunifuSeparator6)
        Me.GroupBox_recepcion.Controls.Add(Me.BunifuSeparator2)
        Me.GroupBox_recepcion.Controls.Add(Me.Label2)
        Me.GroupBox_recepcion.Controls.Add(Me.txtRecepcion)
        Me.GroupBox_recepcion.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_recepcion.Location = New System.Drawing.Point(385, 3)
        Me.GroupBox_recepcion.Name = "GroupBox_recepcion"
        Me.GroupBox_recepcion.Size = New System.Drawing.Size(176, 98)
        Me.GroupBox_recepcion.TabIndex = 121
        Me.GroupBox_recepcion.TabStop = False
        Me.GroupBox_recepcion.Text = "Recepción"
        '
        'lblRecepcion
        '
        Me.lblRecepcion.AutoSize = True
        Me.lblRecepcion.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecepcion.Location = New System.Drawing.Point(73, 73)
        Me.lblRecepcion.Name = "lblRecepcion"
        Me.lblRecepcion.Size = New System.Drawing.Size(0, 19)
        Me.lblRecepcion.TabIndex = 122
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 19)
        Me.Label9.TabIndex = 115
        Me.Label9.Text = "N°     :"
        '
        'BunifuSeparator6
        '
        Me.BunifuSeparator6.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.BunifuSeparator6.LineColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuSeparator6.LineThickness = 88
        Me.BunifuSeparator6.Location = New System.Drawing.Point(12, 60)
        Me.BunifuSeparator6.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.BunifuSeparator6.Name = "BunifuSeparator6"
        Me.BunifuSeparator6.Size = New System.Drawing.Size(153, 10)
        Me.BunifuSeparator6.TabIndex = 113
        Me.BunifuSeparator6.Transparency = 255
        Me.BunifuSeparator6.Vertical = False
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 189
        Me.BunifuSeparator2.Location = New System.Drawing.Point(8, 18)
        Me.BunifuSeparator2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(159, 10)
        Me.BunifuSeparator2.TabIndex = 111
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 19)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "Estado:"
        '
        'txtRecepcion
        '
        Me.txtRecepcion.AutoSize = True
        Me.txtRecepcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecepcion.ForeColor = System.Drawing.Color.Black
        Me.txtRecepcion.Location = New System.Drawing.Point(78, 37)
        Me.txtRecepcion.Name = "txtRecepcion"
        Me.txtRecepcion.Size = New System.Drawing.Size(0, 22)
        Me.txtRecepcion.TabIndex = 109
        '
        'panel_groupbox
        '
        Me.panel_groupbox.BackColor = System.Drawing.Color.Transparent
        Me.panel_groupbox.Controls.Add(Me.groubox_OF)
        Me.panel_groupbox.Controls.Add(Me.GroupBox_recepcion)
        Me.panel_groupbox.Controls.Add(Me.GroupBox_pedido)
        Me.panel_groupbox.Location = New System.Drawing.Point(21, 303)
        Me.panel_groupbox.Name = "panel_groupbox"
        Me.panel_groupbox.Size = New System.Drawing.Size(566, 111)
        Me.panel_groupbox.TabIndex = 122
        '
        'imgRecepCancel
        '
        Me.imgRecepCancel.BackColor = System.Drawing.Color.Transparent
        Me.imgRecepCancel.Image = CType(resources.GetObject("imgRecepCancel.Image"), System.Drawing.Image)
        Me.imgRecepCancel.Location = New System.Drawing.Point(482, 249)
        Me.imgRecepCancel.Name = "imgRecepCancel"
        Me.imgRecepCancel.Size = New System.Drawing.Size(33, 30)
        Me.imgRecepCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgRecepCancel.TabIndex = 130
        Me.imgRecepCancel.TabStop = False
        Me.imgRecepCancel.Visible = False
        '
        'imgPedidoCancel
        '
        Me.imgPedidoCancel.BackColor = System.Drawing.Color.Transparent
        Me.imgPedidoCancel.Image = CType(resources.GetObject("imgPedidoCancel.Image"), System.Drawing.Image)
        Me.imgPedidoCancel.Location = New System.Drawing.Point(296, 249)
        Me.imgPedidoCancel.Name = "imgPedidoCancel"
        Me.imgPedidoCancel.Size = New System.Drawing.Size(33, 30)
        Me.imgPedidoCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgPedidoCancel.TabIndex = 131
        Me.imgPedidoCancel.TabStop = False
        Me.imgPedidoCancel.Visible = False
        '
        'imgOfertaCancel
        '
        Me.imgOfertaCancel.BackColor = System.Drawing.Color.Transparent
        Me.imgOfertaCancel.Image = CType(resources.GetObject("imgOfertaCancel.Image"), System.Drawing.Image)
        Me.imgOfertaCancel.Location = New System.Drawing.Point(116, 249)
        Me.imgOfertaCancel.Name = "imgOfertaCancel"
        Me.imgOfertaCancel.Size = New System.Drawing.Size(33, 30)
        Me.imgOfertaCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgOfertaCancel.TabIndex = 132
        Me.imgOfertaCancel.TabStop = False
        Me.imgOfertaCancel.Visible = False
        '
        'imgRecepcionOk
        '
        Me.imgRecepcionOk.BackColor = System.Drawing.Color.Transparent
        Me.imgRecepcionOk.Image = CType(resources.GetObject("imgRecepcionOk.Image"), System.Drawing.Image)
        Me.imgRecepcionOk.Location = New System.Drawing.Point(482, 249)
        Me.imgRecepcionOk.Name = "imgRecepcionOk"
        Me.imgRecepcionOk.Size = New System.Drawing.Size(33, 30)
        Me.imgRecepcionOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgRecepcionOk.TabIndex = 129
        Me.imgRecepcionOk.TabStop = False
        '
        'imgPedidoOk
        '
        Me.imgPedidoOk.BackColor = System.Drawing.Color.Transparent
        Me.imgPedidoOk.Image = CType(resources.GetObject("imgPedidoOk.Image"), System.Drawing.Image)
        Me.imgPedidoOk.Location = New System.Drawing.Point(296, 249)
        Me.imgPedidoOk.Name = "imgPedidoOk"
        Me.imgPedidoOk.Size = New System.Drawing.Size(33, 30)
        Me.imgPedidoOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgPedidoOk.TabIndex = 128
        Me.imgPedidoOk.TabStop = False
        '
        'imgOfertaOk
        '
        Me.imgOfertaOk.BackColor = System.Drawing.Color.Transparent
        Me.imgOfertaOk.Image = CType(resources.GetObject("imgOfertaOk.Image"), System.Drawing.Image)
        Me.imgOfertaOk.Location = New System.Drawing.Point(117, 249)
        Me.imgOfertaOk.Name = "imgOfertaOk"
        Me.imgOfertaOk.Size = New System.Drawing.Size(33, 30)
        Me.imgOfertaOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgOfertaOk.TabIndex = 127
        Me.imgOfertaOk.TabStop = False
        '
        'progressbar_oferta
        '
        Me.progressbar_oferta.BackColor = System.Drawing.Color.Silver
        Me.progressbar_oferta.BorderRadius = 5
        Me.progressbar_oferta.Location = New System.Drawing.Point(37, 260)
        Me.progressbar_oferta.MaximumValue = 100
        Me.progressbar_oferta.Name = "progressbar_oferta"
        Me.progressbar_oferta.ProgressColor = System.Drawing.Color.SeaGreen
        Me.progressbar_oferta.Size = New System.Drawing.Size(531, 10)
        Me.progressbar_oferta.TabIndex = 126
        Me.progressbar_oferta.Value = 0
        '
        'SeguimientoSAP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(752, 472)
        Me.Controls.Add(Me.imgRecepCancel)
        Me.Controls.Add(Me.imgPedidoCancel)
        Me.Controls.Add(Me.imgOfertaCancel)
        Me.Controls.Add(Me.btn_OK)
        Me.Controls.Add(Me.imgRecepcionOk)
        Me.Controls.Add(Me.imgPedidoOk)
        Me.Controls.Add(Me.imgOfertaOk)
        Me.Controls.Add(Me.progressbar_oferta)
        Me.Controls.Add(Me.panel_groupbox)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Controls.Add(Me.btn_SalirS)
        Me.Controls.Add(Me.Panel_topProd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SeguimientoSAP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seguimiento solicitud"
        Me.Panel_topProd.ResumeLayout(False)
        Me.Panel_topProd.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Salir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.btnBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.groubox_OF.ResumeLayout(False)
        Me.groubox_OF.PerformLayout()
        Me.GroupBox_pedido.ResumeLayout(False)
        Me.GroupBox_pedido.PerformLayout()
        Me.GroupBox_recepcion.ResumeLayout(False)
        Me.GroupBox_recepcion.PerformLayout()
        Me.panel_groupbox.ResumeLayout(False)
        CType(Me.imgRecepCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPedidoCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgOfertaCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgRecepcionOk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPedidoOk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgOfertaOk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_topProd As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btn_Salir As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_Minimizar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_OK As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_SalirS As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents timePicker_fechaCreacion As DateTimePicker
    Friend WithEvents txtbox_Solicitante As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btnBuscar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtSolPedido As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents ProgressBar_busqueda As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents mov_cabecera As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Label8 As Label
    Friend WithEvents txtOferta As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents groubox_OF As GroupBox
    Friend WithEvents GroupBox_pedido As GroupBox
    Friend WithEvents BunifuSeparator4 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label15 As Label
    Friend WithEvents txtPedido As Label
    Friend WithEvents GroupBox_recepcion As GroupBox
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRecepcion As Label
    Friend WithEvents BunifuSeparator5 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator3 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator6 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents panel_groupbox As Panel
    Friend WithEvents lblOferta As Label
    Friend WithEvents lblPedido As Label
    Friend WithEvents lblRecepcion As Label
    Friend WithEvents lblMensaje As Label
    Friend WithEvents imgRecepCancel As PictureBox
    Friend WithEvents imgPedidoCancel As PictureBox
    Friend WithEvents imgOfertaCancel As PictureBox
    Friend WithEvents imgRecepcionOk As PictureBox
    Friend WithEvents imgPedidoOk As PictureBox
    Friend WithEvents imgOfertaOk As PictureBox
    Friend WithEvents progressbar_oferta As Bunifu.Framework.UI.BunifuProgressBar
End Class
