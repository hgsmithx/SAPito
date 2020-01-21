<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaSAP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaSAP))
        Me.Panel_header = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_buniMinimizar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_buniExit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnConectar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtCompanyDB = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel17 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtDBServerType = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtDbUserName = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtDbPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuGradientPanel2 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtUserName = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel22 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel23 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel25 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel26 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtLicenseServer = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtServer = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel30 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel31 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel32 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel29 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Movimiento_cabecera = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel_header.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_buniMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_buniExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.BunifuGradientPanel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_header
        '
        Me.Panel_header.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Panel_header.Controls.Add(Me.PictureBox1)
        Me.Panel_header.Controls.Add(Me.btn_buniMinimizar)
        Me.Panel_header.Controls.Add(Me.btn_buniExit)
        Me.Panel_header.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel_header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_header.Location = New System.Drawing.Point(0, 0)
        Me.Panel_header.Name = "Panel_header"
        Me.Panel_header.Size = New System.Drawing.Size(501, 39)
        Me.Panel_header.TabIndex = 16
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 3)
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
        Me.btn_buniMinimizar.Location = New System.Drawing.Point(430, 6)
        Me.btn_buniMinimizar.Name = "btn_buniMinimizar"
        Me.btn_buniMinimizar.Size = New System.Drawing.Size(28, 27)
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
        Me.btn_buniExit.Location = New System.Drawing.Point(464, 6)
        Me.btn_buniExit.Name = "btn_buniExit"
        Me.btn_buniExit.Size = New System.Drawing.Size(28, 27)
        Me.btn_buniExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_buniExit.TabIndex = 4
        Me.btn_buniExit.TabStop = False
        Me.btn_buniExit.Zoom = 10
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(48, 12)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(123, 20)
        Me.BunifuCustomLabel1.TabIndex = 3
        Me.BunifuCustomLabel1.Text = "Conexión SAP"
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
        Me.btnConectar.Location = New System.Drawing.Point(383, 529)
        Me.btnConectar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(93, 40)
        Me.btnConectar.TabIndex = 18
        Me.btnConectar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.GroupBox1)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.MediumAquamarine
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(27, 62)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(449, 227)
        Me.BunifuGradientPanel1.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel4)
        Me.GroupBox1.Controls.Add(Me.txtCompanyDB)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel17)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel2)
        Me.GroupBox1.Controls.Add(Me.txtDBServerType)
        Me.GroupBox1.Controls.Add(Me.txtDbUserName)
        Me.GroupBox1.Controls.Add(Me.txtDbPassword)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(427, 208)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Base de Datos"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(6, 124)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(122, 19)
        Me.BunifuCustomLabel4.TabIndex = 15
        Me.BunifuCustomLabel4.Text = "BD Contraseña"
        '
        'txtCompanyDB
        '
        Me.txtCompanyDB.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCompanyDB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCompanyDB.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCompanyDB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCompanyDB.HintForeColor = System.Drawing.Color.DarkGray
        Me.txtCompanyDB.HintText = "CompanyDB"
        Me.txtCompanyDB.isPassword = False
        Me.txtCompanyDB.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.txtCompanyDB.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.txtCompanyDB.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtCompanyDB.LineThickness = 3
        Me.txtCompanyDB.Location = New System.Drawing.Point(143, 167)
        Me.txtCompanyDB.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCompanyDB.Name = "txtCompanyDB"
        Me.txtCompanyDB.Size = New System.Drawing.Size(279, 34)
        Me.txtCompanyDB.TabIndex = 4
        Me.txtCompanyDB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel17
        '
        Me.BunifuCustomLabel17.AutoSize = True
        Me.BunifuCustomLabel17.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel17.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel17.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel17.Location = New System.Drawing.Point(8, 174)
        Me.BunifuCustomLabel17.Name = "BunifuCustomLabel17"
        Me.BunifuCustomLabel17.Size = New System.Drawing.Size(108, 19)
        Me.BunifuCustomLabel17.TabIndex = 25
        Me.BunifuCustomLabel17.Text = "CompanyDB"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(8, 30)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(105, 19)
        Me.BunifuCustomLabel2.TabIndex = 13
        Me.BunifuCustomLabel2.Text = "Tipo servidor"
        '
        'txtDBServerType
        '
        Me.txtDBServerType.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDBServerType.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDBServerType.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtDBServerType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDBServerType.HintForeColor = System.Drawing.Color.DarkGray
        Me.txtDBServerType.HintText = "DbServerType"
        Me.txtDBServerType.isPassword = False
        Me.txtDBServerType.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.txtDBServerType.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.txtDBServerType.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtDBServerType.LineThickness = 3
        Me.txtDBServerType.Location = New System.Drawing.Point(143, 23)
        Me.txtDBServerType.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDBServerType.Name = "txtDBServerType"
        Me.txtDBServerType.Size = New System.Drawing.Size(279, 34)
        Me.txtDBServerType.TabIndex = 1
        Me.txtDBServerType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtDbUserName
        '
        Me.txtDbUserName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDbUserName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDbUserName.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtDbUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDbUserName.HintForeColor = System.Drawing.Color.DarkGray
        Me.txtDbUserName.HintText = "DbUserName   "
        Me.txtDbUserName.isPassword = False
        Me.txtDbUserName.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.txtDbUserName.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.txtDbUserName.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtDbUserName.LineThickness = 3
        Me.txtDbUserName.Location = New System.Drawing.Point(143, 71)
        Me.txtDbUserName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDbUserName.Name = "txtDbUserName"
        Me.txtDbUserName.Size = New System.Drawing.Size(279, 34)
        Me.txtDbUserName.TabIndex = 2
        Me.txtDbUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtDbPassword
        '
        Me.txtDbPassword.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDbPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDbPassword.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtDbPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDbPassword.HintForeColor = System.Drawing.Color.DarkGray
        Me.txtDbPassword.HintText = "DbPassword"
        Me.txtDbPassword.isPassword = False
        Me.txtDbPassword.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.txtDbPassword.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.txtDbPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtDbPassword.LineThickness = 3
        Me.txtDbPassword.Location = New System.Drawing.Point(143, 119)
        Me.txtDbPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDbPassword.Name = "txtDbPassword"
        Me.txtDbPassword.Size = New System.Drawing.Size(279, 34)
        Me.txtDbPassword.TabIndex = 3
        Me.txtDbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel9)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel8)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel10)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel7)
        Me.Panel1.Location = New System.Drawing.Point(122, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(26, 178)
        Me.Panel1.TabIndex = 18
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.AutoSize = True
        Me.BunifuCustomLabel9.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel9.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(4, 94)
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
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(3, 47)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(19, 28)
        Me.BunifuCustomLabel8.TabIndex = 20
        Me.BunifuCustomLabel8.Text = ":"
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuCustomLabel10.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel10.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(4, 144)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(19, 28)
        Me.BunifuCustomLabel10.TabIndex = 22
        Me.BunifuCustomLabel10.Text = ":"
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(4, 0)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(19, 28)
        Me.BunifuCustomLabel7.TabIndex = 19
        Me.BunifuCustomLabel7.Text = ":"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(8, 77)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(89, 19)
        Me.BunifuCustomLabel3.TabIndex = 14
        Me.BunifuCustomLabel3.Text = "BD Usuario"
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.Controls.Add(Me.GroupBox2)
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.MediumAquamarine
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(27, 303)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Quality = 10
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(449, 227)
        Me.BunifuGradientPanel2.TabIndex = 32
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.txtPassword)
        Me.GroupBox2.Controls.Add(Me.txtUserName)
        Me.GroupBox2.Controls.Add(Me.BunifuCustomLabel22)
        Me.GroupBox2.Controls.Add(Me.BunifuCustomLabel23)
        Me.GroupBox2.Controls.Add(Me.BunifuCustomLabel25)
        Me.GroupBox2.Controls.Add(Me.BunifuCustomLabel26)
        Me.GroupBox2.Controls.Add(Me.txtLicenseServer)
        Me.GroupBox2.Controls.Add(Me.txtServer)
        Me.GroupBox2.Controls.Add(Me.Panel4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(11, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox2.Size = New System.Drawing.Size(427, 208)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Servidor"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPassword.HintForeColor = System.Drawing.Color.DarkGray
        Me.txtPassword.HintText = "Password"
        Me.txtPassword.isPassword = False
        Me.txtPassword.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.txtPassword.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.txtPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtPassword.LineThickness = 3
        Me.txtPassword.Location = New System.Drawing.Point(141, 166)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(279, 34)
        Me.txtPassword.TabIndex = 8
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtUserName
        '
        Me.txtUserName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUserName.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUserName.HintForeColor = System.Drawing.Color.DarkGray
        Me.txtUserName.HintText = "UserName"
        Me.txtUserName.isPassword = False
        Me.txtUserName.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.txtUserName.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.txtUserName.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtUserName.LineThickness = 3
        Me.txtUserName.Location = New System.Drawing.Point(141, 118)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(279, 34)
        Me.txtUserName.TabIndex = 7
        Me.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel22
        '
        Me.BunifuCustomLabel22.AutoSize = True
        Me.BunifuCustomLabel22.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel22.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel22.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel22.Location = New System.Drawing.Point(8, 172)
        Me.BunifuCustomLabel22.Name = "BunifuCustomLabel22"
        Me.BunifuCustomLabel22.Size = New System.Drawing.Size(121, 19)
        Me.BunifuCustomLabel22.TabIndex = 27
        Me.BunifuCustomLabel22.Text = "SV Contraseña"
        '
        'BunifuCustomLabel23
        '
        Me.BunifuCustomLabel23.AutoSize = True
        Me.BunifuCustomLabel23.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel23.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel23.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel23.Location = New System.Drawing.Point(8, 123)
        Me.BunifuCustomLabel23.Name = "BunifuCustomLabel23"
        Me.BunifuCustomLabel23.Size = New System.Drawing.Size(88, 19)
        Me.BunifuCustomLabel23.TabIndex = 26
        Me.BunifuCustomLabel23.Text = "SV Usuario"
        '
        'BunifuCustomLabel25
        '
        Me.BunifuCustomLabel25.AutoSize = True
        Me.BunifuCustomLabel25.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel25.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel25.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel25.Location = New System.Drawing.Point(8, 75)
        Me.BunifuCustomLabel25.Name = "BunifuCustomLabel25"
        Me.BunifuCustomLabel25.Size = New System.Drawing.Size(75, 19)
        Me.BunifuCustomLabel25.TabIndex = 17
        Me.BunifuCustomLabel25.Text = "Licencia"
        '
        'BunifuCustomLabel26
        '
        Me.BunifuCustomLabel26.AutoSize = True
        Me.BunifuCustomLabel26.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel26.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel26.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel26.Location = New System.Drawing.Point(8, 31)
        Me.BunifuCustomLabel26.Name = "BunifuCustomLabel26"
        Me.BunifuCustomLabel26.Size = New System.Drawing.Size(71, 19)
        Me.BunifuCustomLabel26.TabIndex = 16
        Me.BunifuCustomLabel26.Text = "Servidor"
        '
        'txtLicenseServer
        '
        Me.txtLicenseServer.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtLicenseServer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLicenseServer.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtLicenseServer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtLicenseServer.HintForeColor = System.Drawing.Color.DarkGray
        Me.txtLicenseServer.HintText = "LicenseServer"
        Me.txtLicenseServer.isPassword = False
        Me.txtLicenseServer.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.txtLicenseServer.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.txtLicenseServer.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtLicenseServer.LineThickness = 3
        Me.txtLicenseServer.Location = New System.Drawing.Point(141, 70)
        Me.txtLicenseServer.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLicenseServer.Name = "txtLicenseServer"
        Me.txtLicenseServer.Size = New System.Drawing.Size(279, 34)
        Me.txtLicenseServer.TabIndex = 6
        Me.txtLicenseServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtServer
        '
        Me.txtServer.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtServer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtServer.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtServer.ForeColor = System.Drawing.Color.Black
        Me.txtServer.HintForeColor = System.Drawing.Color.DarkGray
        Me.txtServer.HintText = "Server"
        Me.txtServer.isPassword = False
        Me.txtServer.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.txtServer.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.txtServer.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtServer.LineThickness = 3
        Me.txtServer.Location = New System.Drawing.Point(141, 22)
        Me.txtServer.Margin = New System.Windows.Forms.Padding(4)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(279, 34)
        Me.txtServer.TabIndex = 5
        Me.txtServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.BunifuCustomLabel30)
        Me.Panel4.Controls.Add(Me.BunifuCustomLabel31)
        Me.Panel4.Controls.Add(Me.BunifuCustomLabel32)
        Me.Panel4.Controls.Add(Me.BunifuCustomLabel29)
        Me.Panel4.Location = New System.Drawing.Point(122, 24)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(26, 178)
        Me.Panel4.TabIndex = 18
        '
        'BunifuCustomLabel30
        '
        Me.BunifuCustomLabel30.AutoSize = True
        Me.BunifuCustomLabel30.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel30.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel30.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel30.Location = New System.Drawing.Point(4, 141)
        Me.BunifuCustomLabel30.Name = "BunifuCustomLabel30"
        Me.BunifuCustomLabel30.Size = New System.Drawing.Size(19, 28)
        Me.BunifuCustomLabel30.TabIndex = 22
        Me.BunifuCustomLabel30.Text = ":"
        '
        'BunifuCustomLabel31
        '
        Me.BunifuCustomLabel31.AutoSize = True
        Me.BunifuCustomLabel31.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel31.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel31.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel31.Location = New System.Drawing.Point(4, 92)
        Me.BunifuCustomLabel31.Name = "BunifuCustomLabel31"
        Me.BunifuCustomLabel31.Size = New System.Drawing.Size(19, 28)
        Me.BunifuCustomLabel31.TabIndex = 21
        Me.BunifuCustomLabel31.Text = ":"
        '
        'BunifuCustomLabel32
        '
        Me.BunifuCustomLabel32.AutoSize = True
        Me.BunifuCustomLabel32.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel32.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel32.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel32.Location = New System.Drawing.Point(4, 0)
        Me.BunifuCustomLabel32.Name = "BunifuCustomLabel32"
        Me.BunifuCustomLabel32.Size = New System.Drawing.Size(19, 28)
        Me.BunifuCustomLabel32.TabIndex = 19
        Me.BunifuCustomLabel32.Text = ":"
        '
        'BunifuCustomLabel29
        '
        Me.BunifuCustomLabel29.AutoSize = True
        Me.BunifuCustomLabel29.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel29.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel29.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel29.Location = New System.Drawing.Point(4, 44)
        Me.BunifuCustomLabel29.Name = "BunifuCustomLabel29"
        Me.BunifuCustomLabel29.Size = New System.Drawing.Size(19, 28)
        Me.BunifuCustomLabel29.TabIndex = 20
        Me.BunifuCustomLabel29.Text = ":"
        '
        'Movimiento_cabecera
        '
        Me.Movimiento_cabecera.Fixed = True
        Me.Movimiento_cabecera.Horizontal = True
        Me.Movimiento_cabecera.TargetControl = Me.Panel_header
        Me.Movimiento_cabecera.Vertical = True
        '
        'VentanaSAP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 575)
        Me.Controls.Add(Me.BunifuGradientPanel2)
        Me.Controls.Add(Me.btnConectar)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Controls.Add(Me.Panel_header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VentanaSAP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VentanaSAP"
        Me.Panel_header.ResumeLayout(False)
        Me.Panel_header.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_buniMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_buniExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.BunifuGradientPanel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnConectar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtDBServerType As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtDbUserName As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtDbPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuCustomLabel10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel_header As Panel
    Friend WithEvents btn_buniMinimizar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_buniExit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtCompanyDB As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel17 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuGradientPanel2 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents txtPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtUserName As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel22 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel23 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel25 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel26 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtLicenseServer As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtServer As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BunifuCustomLabel29 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel30 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel31 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel32 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Movimiento_cabecera As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents PictureBox1 As PictureBox
End Class
