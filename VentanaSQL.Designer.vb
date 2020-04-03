<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaSQL
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaSQL))
        Me.Panel_header = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_buniMinimizar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_buniExit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Movimiento_cabecera = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuCustomLabel12 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnSalir = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnConectar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtDataSource = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtContraseña = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtPuerto = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtIdUsuario = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtNombreDB = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel11 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel_header.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_buniMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_buniExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_header
        '
        Me.Panel_header.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Panel_header.Controls.Add(Me.PictureBox1)
        Me.Panel_header.Controls.Add(Me.btn_buniMinimizar)
        Me.Panel_header.Controls.Add(Me.btn_buniExit)
        Me.Panel_header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_header.Location = New System.Drawing.Point(0, 0)
        Me.Panel_header.Name = "Panel_header"
        Me.Panel_header.Size = New System.Drawing.Size(502, 32)
        Me.Panel_header.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(47, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 73
        Me.PictureBox1.TabStop = False
        '
        'btn_buniMinimizar
        '
        Me.btn_buniMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.btn_buniMinimizar.Image = Global.Diseño2._1.My.Resources.Resources.Minimize_Window_2_48px
        Me.btn_buniMinimizar.ImageActive = Nothing
        Me.btn_buniMinimizar.Location = New System.Drawing.Point(430, 2)
        Me.btn_buniMinimizar.Name = "btn_buniMinimizar"
        Me.btn_buniMinimizar.Size = New System.Drawing.Size(28, 26)
        Me.btn_buniMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_buniMinimizar.TabIndex = 5
        Me.btn_buniMinimizar.TabStop = False
        Me.btn_buniMinimizar.Zoom = 10
        '
        'btn_buniExit
        '
        Me.btn_buniExit.BackColor = System.Drawing.Color.Transparent
        Me.btn_buniExit.Image = Global.Diseño2._1.My.Resources.Resources.Close_Window__2_48px
        Me.btn_buniExit.ImageActive = Nothing
        Me.btn_buniExit.Location = New System.Drawing.Point(464, 2)
        Me.btn_buniExit.Name = "btn_buniExit"
        Me.btn_buniExit.Size = New System.Drawing.Size(28, 27)
        Me.btn_buniExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_buniExit.TabIndex = 4
        Me.btn_buniExit.TabStop = False
        Me.btn_buniExit.Zoom = 10
        '
        'Movimiento_cabecera
        '
        Me.Movimiento_cabecera.Fixed = True
        Me.Movimiento_cabecera.Horizontal = True
        Me.Movimiento_cabecera.TargetControl = Me.Panel_header
        Me.Movimiento_cabecera.Vertical = True
        '
        'BunifuCustomLabel12
        '
        Me.BunifuCustomLabel12.AutoSize = True
        Me.BunifuCustomLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.BunifuCustomLabel12.Location = New System.Drawing.Point(171, 37)
        Me.BunifuCustomLabel12.Name = "BunifuCustomLabel12"
        Me.BunifuCustomLabel12.Size = New System.Drawing.Size(181, 29)
        Me.BunifuCustomLabel12.TabIndex = 9
        Me.BunifuCustomLabel12.Text = "Conexión SQL"
        '
        'btnSalir
        '
        Me.btnSalir.ActiveBorderThickness = 1
        Me.btnSalir.ActiveCornerRadius = 20
        Me.btnSalir.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnSalir.ActiveForecolor = System.Drawing.Color.White
        Me.btnSalir.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
        Me.btnSalir.BackgroundImage = CType(resources.GetObject("btnSalir.BackgroundImage"), System.Drawing.Image)
        Me.btnSalir.ButtonText = "Salir"
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnSalir.IdleBorderThickness = 1
        Me.btnSalir.IdleCornerRadius = 20
        Me.btnSalir.IdleFillColor = System.Drawing.Color.DarkGray
        Me.btnSalir.IdleForecolor = System.Drawing.SystemColors.Window
        Me.btnSalir.IdleLineColor = System.Drawing.Color.DarkGray
        Me.btnSalir.Location = New System.Drawing.Point(263, 325)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(87, 40)
        Me.btnSalir.TabIndex = 15
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnConectar
        '
        Me.btnConectar.ActiveBorderThickness = 1
        Me.btnConectar.ActiveCornerRadius = 20
        Me.btnConectar.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btnConectar.ActiveForecolor = System.Drawing.Color.White
        Me.btnConectar.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnConectar.BackColor = System.Drawing.SystemColors.Control
        Me.btnConectar.BackgroundImage = CType(resources.GetObject("btnConectar.BackgroundImage"), System.Drawing.Image)
        Me.btnConectar.ButtonText = "Conectar"
        Me.btnConectar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConectar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConectar.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnConectar.IdleBorderThickness = 1
        Me.btnConectar.IdleCornerRadius = 20
        Me.btnConectar.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnConectar.IdleForecolor = System.Drawing.SystemColors.Window
        Me.btnConectar.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnConectar.Location = New System.Drawing.Point(162, 325)
        Me.btnConectar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(93, 40)
        Me.btnConectar.TabIndex = 14
        Me.btnConectar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuCustomLabel6)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuCustomLabel5)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuCustomLabel4)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuCustomLabel3)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuCustomLabel2)
        Me.BunifuGradientPanel1.Controls.Add(Me.txtDataSource)
        Me.BunifuGradientPanel1.Controls.Add(Me.txtContraseña)
        Me.BunifuGradientPanel1.Controls.Add(Me.txtPuerto)
        Me.BunifuGradientPanel1.Controls.Add(Me.txtIdUsuario)
        Me.BunifuGradientPanel1.Controls.Add(Me.txtNombreDB)
        Me.BunifuGradientPanel1.Controls.Add(Me.Panel1)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.MediumAquamarine
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(28, 73)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(449, 250)
        Me.BunifuGradientPanel1.TabIndex = 13
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(18, 201)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(98, 19)
        Me.BunifuCustomLabel6.TabIndex = 17
        Me.BunifuCustomLabel6.Text = "Contraseña"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(18, 157)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(84, 19)
        Me.BunifuCustomLabel5.TabIndex = 16
        Me.BunifuCustomLabel5.Text = "Id Usuario"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(18, 113)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(97, 19)
        Me.BunifuCustomLabel4.TabIndex = 15
        Me.BunifuCustomLabel4.Text = "Nombre DB"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(18, 69)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(101, 19)
        Me.BunifuCustomLabel3.TabIndex = 14
        Me.BunifuCustomLabel3.Text = "Puerto           "
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(18, 25)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(103, 19)
        Me.BunifuCustomLabel2.TabIndex = 13
        Me.BunifuCustomLabel2.Text = "DataSource "
        '
        'txtDataSource
        '
        Me.txtDataSource.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDataSource.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDataSource.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtDataSource.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDataSource.HintForeColor = System.Drawing.Color.DarkGray
        Me.txtDataSource.HintText = "DataSource"
        Me.txtDataSource.isPassword = False
        Me.txtDataSource.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.txtDataSource.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.txtDataSource.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtDataSource.LineThickness = 3
        Me.txtDataSource.Location = New System.Drawing.Point(154, 18)
        Me.txtDataSource.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDataSource.Name = "txtDataSource"
        Me.txtDataSource.Size = New System.Drawing.Size(279, 34)
        Me.txtDataSource.TabIndex = 1
        Me.txtDataSource.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtContraseña
        '
        Me.txtContraseña.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtContraseña.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContraseña.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtContraseña.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtContraseña.HintForeColor = System.Drawing.Color.DarkGray
        Me.txtContraseña.HintText = "Contraseña"
        Me.txtContraseña.isPassword = False
        Me.txtContraseña.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.txtContraseña.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.txtContraseña.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtContraseña.LineThickness = 3
        Me.txtContraseña.Location = New System.Drawing.Point(154, 194)
        Me.txtContraseña.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(279, 34)
        Me.txtContraseña.TabIndex = 5
        Me.txtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtPuerto
        '
        Me.txtPuerto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPuerto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPuerto.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtPuerto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPuerto.HintForeColor = System.Drawing.Color.DarkGray
        Me.txtPuerto.HintText = "Puerto"
        Me.txtPuerto.isPassword = False
        Me.txtPuerto.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.txtPuerto.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.txtPuerto.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtPuerto.LineThickness = 3
        Me.txtPuerto.Location = New System.Drawing.Point(154, 62)
        Me.txtPuerto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPuerto.Name = "txtPuerto"
        Me.txtPuerto.Size = New System.Drawing.Size(279, 34)
        Me.txtPuerto.TabIndex = 2
        Me.txtPuerto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtIdUsuario
        '
        Me.txtIdUsuario.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtIdUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIdUsuario.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtIdUsuario.ForeColor = System.Drawing.Color.Black
        Me.txtIdUsuario.HintForeColor = System.Drawing.Color.DarkGray
        Me.txtIdUsuario.HintText = "Id Usuario"
        Me.txtIdUsuario.isPassword = False
        Me.txtIdUsuario.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.txtIdUsuario.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.txtIdUsuario.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtIdUsuario.LineThickness = 3
        Me.txtIdUsuario.Location = New System.Drawing.Point(154, 150)
        Me.txtIdUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdUsuario.Name = "txtIdUsuario"
        Me.txtIdUsuario.Size = New System.Drawing.Size(279, 34)
        Me.txtIdUsuario.TabIndex = 4
        Me.txtIdUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtNombreDB
        '
        Me.txtNombreDB.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNombreDB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombreDB.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtNombreDB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNombreDB.HintForeColor = System.Drawing.Color.DarkGray
        Me.txtNombreDB.HintText = "NombreDB"
        Me.txtNombreDB.isPassword = False
        Me.txtNombreDB.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.txtNombreDB.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.txtNombreDB.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtNombreDB.LineThickness = 3
        Me.txtNombreDB.Location = New System.Drawing.Point(154, 106)
        Me.txtNombreDB.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreDB.Name = "txtNombreDB"
        Me.txtNombreDB.Size = New System.Drawing.Size(279, 34)
        Me.txtNombreDB.TabIndex = 3
        Me.txtNombreDB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel11)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel10)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel9)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel8)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel7)
        Me.Panel1.Location = New System.Drawing.Point(114, 18)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(26, 210)
        Me.Panel1.TabIndex = 18
        '
        'BunifuCustomLabel11
        '
        Me.BunifuCustomLabel11.AutoSize = True
        Me.BunifuCustomLabel11.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel11.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel11.Location = New System.Drawing.Point(3, 178)
        Me.BunifuCustomLabel11.Name = "BunifuCustomLabel11"
        Me.BunifuCustomLabel11.Size = New System.Drawing.Size(19, 28)
        Me.BunifuCustomLabel11.TabIndex = 23
        Me.BunifuCustomLabel11.Text = ":"
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuCustomLabel10.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel10.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(3, 134)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(19, 28)
        Me.BunifuCustomLabel10.TabIndex = 22
        Me.BunifuCustomLabel10.Text = ":"
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.AutoSize = True
        Me.BunifuCustomLabel9.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel9.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(3, 90)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(19, 28)
        Me.BunifuCustomLabel9.TabIndex = 21
        Me.BunifuCustomLabel9.Text = ":"
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(3, 46)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(19, 28)
        Me.BunifuCustomLabel8.TabIndex = 20
        Me.BunifuCustomLabel8.Text = ":"
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(3, 2)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(19, 28)
        Me.BunifuCustomLabel7.TabIndex = 19
        Me.BunifuCustomLabel7.Text = ":"
        '
        'VentanaSQL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 371)
        Me.Controls.Add(Me.BunifuCustomLabel12)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnConectar)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Controls.Add(Me.Panel_header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VentanaSQL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VentanaSQL"
        Me.Panel_header.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_buniMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_buniExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel_header As Panel
    Friend WithEvents btn_buniMinimizar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_buniExit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txtDataSource As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtPuerto As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtNombreDB As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtIdUsuario As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtContraseña As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents btnConectar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnSalir As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Movimiento_cabecera As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuCustomLabel11 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel12 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PictureBox1 As PictureBox
End Class
