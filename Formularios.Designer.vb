<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formularios
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formularios))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblNumDocumento = New System.Windows.Forms.Label()
        Me.txtCorreo = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Correo = New System.Windows.Forms.Label()
        Me.txtSolicitante = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtNombre = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.label_solicitante = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.FechaContable = New System.Windows.Forms.DateTimePicker()
        Me.FechaValidez = New System.Windows.Forms.DateTimePicker()
        Me.FechaDocumento = New System.Windows.Forms.DateTimePicker()
        Me.FechaNecesaria = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_fechanec = New System.Windows.Forms.Label()
        Me.lbl_fechadoc = New System.Windows.Forms.Label()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.Panel_top = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btn_Maximizar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_Restaurar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_Salir = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_Minimizar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Movimiento_cabecera = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_cerrar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_Crear = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lbl_nomdoc = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelFondo = New System.Windows.Forms.Panel()
        Me.PanelCarga = New System.Windows.Forms.Panel()
        Me.Panel99 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_top.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Maximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Restaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Salir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFondo.SuspendLayout()
        Me.Panel99.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblNumDocumento)
        Me.GroupBox1.Controls.Add(Me.txtCorreo)
        Me.GroupBox1.Controls.Add(Me.Correo)
        Me.GroupBox1.Controls.Add(Me.txtSolicitante)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.label_solicitante)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(47, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(318, 152)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información Solicitante"
        '
        'lblNumDocumento
        '
        Me.lblNumDocumento.AutoSize = True
        Me.lblNumDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumDocumento.Location = New System.Drawing.Point(9, 146)
        Me.lblNumDocumento.Name = "lblNumDocumento"
        Me.lblNumDocumento.Size = New System.Drawing.Size(0, 20)
        Me.lblNumDocumento.TabIndex = 71
        '
        'txtCorreo
        '
        Me.txtCorreo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCorreo.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCorreo.ForeColor = System.Drawing.Color.Black
        Me.txtCorreo.HintForeColor = System.Drawing.Color.Gray
        Me.txtCorreo.HintText = "Correo SN"
        Me.txtCorreo.isPassword = False
        Me.txtCorreo.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.txtCorreo.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.txtCorreo.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.txtCorreo.LineThickness = 3
        Me.txtCorreo.Location = New System.Drawing.Point(142, 106)
        Me.txtCorreo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(149, 33)
        Me.txtCorreo.TabIndex = 3
        Me.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Correo
        '
        Me.Correo.AutoSize = True
        Me.Correo.Location = New System.Drawing.Point(9, 118)
        Me.Correo.Name = "Correo"
        Me.Correo.Size = New System.Drawing.Size(57, 19)
        Me.Correo.TabIndex = 56
        Me.Correo.Text = "Correo"
        '
        'txtSolicitante
        '
        Me.txtSolicitante.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSolicitante.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSolicitante.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtSolicitante.ForeColor = System.Drawing.Color.Black
        Me.txtSolicitante.HintForeColor = System.Drawing.Color.Gray
        Me.txtSolicitante.HintText = "Código solicitante"
        Me.txtSolicitante.isPassword = False
        Me.txtSolicitante.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.txtSolicitante.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.txtSolicitante.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.txtSolicitante.LineThickness = 3
        Me.txtSolicitante.Location = New System.Drawing.Point(142, 22)
        Me.txtSolicitante.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSolicitante.Name = "txtSolicitante"
        Me.txtSolicitante.Size = New System.Drawing.Size(149, 33)
        Me.txtSolicitante.TabIndex = 1
        Me.txtSolicitante.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombre.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtNombre.ForeColor = System.Drawing.Color.Black
        Me.txtNombre.HintForeColor = System.Drawing.Color.Gray
        Me.txtNombre.HintText = "Nombre solicitante"
        Me.txtNombre.isPassword = False
        Me.txtNombre.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.txtNombre.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.txtNombre.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.txtNombre.LineThickness = 3
        Me.txtNombre.Location = New System.Drawing.Point(142, 68)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(149, 28)
        Me.txtNombre.TabIndex = 2
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 19)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Nombre"
        '
        'label_solicitante
        '
        Me.label_solicitante.AutoSize = True
        Me.label_solicitante.Location = New System.Drawing.Point(9, 36)
        Me.label_solicitante.Name = "label_solicitante"
        Me.label_solicitante.Size = New System.Drawing.Size(81, 19)
        Me.label_solicitante.TabIndex = 8
        Me.label_solicitante.Text = "Solicitante"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.FechaContable)
        Me.GroupBox3.Controls.Add(Me.FechaValidez)
        Me.GroupBox3.Controls.Add(Me.FechaDocumento)
        Me.GroupBox3.Controls.Add(Me.FechaNecesaria)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.lbl_fechanec)
        Me.GroupBox3.Controls.Add(Me.lbl_fechadoc)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(440, 52)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(313, 152)
        Me.GroupBox3.TabIndex = 45
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Fechas"
        '
        'FechaContable
        '
        Me.FechaContable.CalendarFont = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaContable.CustomFormat = "dd/mm/yyyy"
        Me.FechaContable.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaContable.Location = New System.Drawing.Point(141, 22)
        Me.FechaContable.Name = "FechaContable"
        Me.FechaContable.Size = New System.Drawing.Size(159, 27)
        Me.FechaContable.TabIndex = 79
        Me.FechaContable.Value = New Date(2020, 1, 20, 0, 0, 0, 0)
        '
        'FechaValidez
        '
        Me.FechaValidez.CustomFormat = "dd/mm/yyyy"
        Me.FechaValidez.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaValidez.Location = New System.Drawing.Point(141, 54)
        Me.FechaValidez.Name = "FechaValidez"
        Me.FechaValidez.Size = New System.Drawing.Size(159, 27)
        Me.FechaValidez.TabIndex = 78
        Me.FechaValidez.Value = New Date(2020, 1, 20, 0, 0, 0, 0)
        '
        'FechaDocumento
        '
        Me.FechaDocumento.CustomFormat = "dd/mm/yyyy"
        Me.FechaDocumento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDocumento.Location = New System.Drawing.Point(141, 86)
        Me.FechaDocumento.Name = "FechaDocumento"
        Me.FechaDocumento.Size = New System.Drawing.Size(159, 27)
        Me.FechaDocumento.TabIndex = 77
        Me.FechaDocumento.Value = New Date(2020, 1, 20, 0, 0, 0, 0)
        '
        'FechaNecesaria
        '
        Me.FechaNecesaria.CustomFormat = "dd/mm/yyyy"
        Me.FechaNecesaria.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaNecesaria.Location = New System.Drawing.Point(141, 118)
        Me.FechaNecesaria.Name = "FechaNecesaria"
        Me.FechaNecesaria.Size = New System.Drawing.Size(159, 27)
        Me.FechaNecesaria.TabIndex = 76
        Me.FechaNecesaria.Value = New Date(2020, 1, 20, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 18)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Fecha contable"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 18)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Fecha válida"
        '
        'lbl_fechanec
        '
        Me.lbl_fechanec.AutoSize = True
        Me.lbl_fechanec.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fechanec.Location = New System.Drawing.Point(6, 123)
        Me.lbl_fechanec.Name = "lbl_fechanec"
        Me.lbl_fechanec.Size = New System.Drawing.Size(113, 18)
        Me.lbl_fechanec.TabIndex = 10
        Me.lbl_fechanec.Text = "Fecha necesaria"
        '
        'lbl_fechadoc
        '
        Me.lbl_fechadoc.AutoSize = True
        Me.lbl_fechadoc.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fechadoc.Location = New System.Drawing.Point(6, 91)
        Me.lbl_fechadoc.Name = "lbl_fechadoc"
        Me.lbl_fechadoc.Size = New System.Drawing.Size(125, 18)
        Me.lbl_fechadoc.TabIndex = 8
        Me.lbl_fechadoc.Text = "Fecha documento"
        '
        'dgvDatos
        '
        Me.dgvDatos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDatos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.dgvDatos.Location = New System.Drawing.Point(47, 247)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDatos.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDatos.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDatos.Size = New System.Drawing.Size(706, 188)
        Me.dgvDatos.TabIndex = 46
        '
        'Panel_top
        '
        Me.Panel_top.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Panel_top.Controls.Add(Me.PictureBox1)
        Me.Panel_top.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel_top.Controls.Add(Me.btn_Maximizar)
        Me.Panel_top.Controls.Add(Me.btn_Restaurar)
        Me.Panel_top.Controls.Add(Me.btn_Salir)
        Me.Panel_top.Controls.Add(Me.btn_Minimizar)
        Me.Panel_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_top.Location = New System.Drawing.Point(0, 0)
        Me.Panel_top.Name = "Panel_top"
        Me.Panel_top.Size = New System.Drawing.Size(792, 33)
        Me.Panel_top.TabIndex = 69
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
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(52, 5)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(189, 24)
        Me.BunifuCustomLabel1.TabIndex = 71
        Me.BunifuCustomLabel1.Text = "Solicitud de compra"
        '
        'btn_Maximizar
        '
        Me.btn_Maximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Maximizar.BackColor = System.Drawing.Color.Transparent
        Me.btn_Maximizar.Image = CType(resources.GetObject("btn_Maximizar.Image"), System.Drawing.Image)
        Me.btn_Maximizar.ImageActive = Nothing
        Me.btn_Maximizar.Location = New System.Drawing.Point(694, 2)
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
        Me.btn_Restaurar.Location = New System.Drawing.Point(694, 2)
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
        Me.btn_Salir.Location = New System.Drawing.Point(736, 2)
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
        Me.btn_Minimizar.Location = New System.Drawing.Point(652, 2)
        Me.btn_Minimizar.Name = "btn_Minimizar"
        Me.btn_Minimizar.Size = New System.Drawing.Size(36, 30)
        Me.btn_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_Minimizar.TabIndex = 6
        Me.btn_Minimizar.TabStop = False
        Me.btn_Minimizar.Zoom = 10
        '
        'Movimiento_cabecera
        '
        Me.Movimiento_cabecera.Fixed = True
        Me.Movimiento_cabecera.Horizontal = True
        Me.Movimiento_cabecera.TargetControl = Me.Panel_top
        Me.Movimiento_cabecera.Vertical = True
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(694, 441)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(59, 20)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 65
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'btn_cerrar
        '
        Me.btn_cerrar.ActiveBorderThickness = 1
        Me.btn_cerrar.ActiveCornerRadius = 20
        Me.btn_cerrar.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btn_cerrar.ActiveForecolor = System.Drawing.Color.White
        Me.btn_cerrar.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btn_cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cerrar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_cerrar.BackgroundImage = CType(resources.GetObject("btn_cerrar.BackgroundImage"), System.Drawing.Image)
        Me.btn_cerrar.ButtonText = "Salir"
        Me.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cerrar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cerrar.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_cerrar.IdleBorderThickness = 1
        Me.btn_cerrar.IdleCornerRadius = 20
        Me.btn_cerrar.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_cerrar.IdleForecolor = System.Drawing.Color.WhiteSmoke
        Me.btn_cerrar.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btn_cerrar.Location = New System.Drawing.Point(660, 469)
        Me.btn_cerrar.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(93, 49)
        Me.btn_cerrar.TabIndex = 48
        Me.btn_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_Crear
        '
        Me.btn_Crear.ActiveBorderThickness = 1
        Me.btn_Crear.ActiveCornerRadius = 20
        Me.btn_Crear.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btn_Crear.ActiveForecolor = System.Drawing.Color.White
        Me.btn_Crear.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btn_Crear.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Crear.BackgroundImage = CType(resources.GetObject("btn_Crear.BackgroundImage"), System.Drawing.Image)
        Me.btn_Crear.ButtonText = "Crear"
        Me.btn_Crear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Crear.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Crear.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_Crear.IdleBorderThickness = 1
        Me.btn_Crear.IdleCornerRadius = 20
        Me.btn_Crear.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_Crear.IdleForecolor = System.Drawing.SystemColors.Window
        Me.btn_Crear.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_Crear.Location = New System.Drawing.Point(47, 469)
        Me.btn_Crear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_Crear.Name = "btn_Crear"
        Me.btn_Crear.Size = New System.Drawing.Size(93, 49)
        Me.btn_Crear.TabIndex = 70
        Me.btn_Crear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(674, 221)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(79, 20)
        Me.TextBox1.TabIndex = 72
        '
        'lbl_nomdoc
        '
        Me.lbl_nomdoc.AutoSize = True
        Me.lbl_nomdoc.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.lbl_nomdoc.Location = New System.Drawing.Point(680, 225)
        Me.lbl_nomdoc.Name = "lbl_nomdoc"
        Me.lbl_nomdoc.Size = New System.Drawing.Size(0, 13)
        Me.lbl_nomdoc.TabIndex = 73
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(524, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 19)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Número documento"
        '
        'PanelFondo
        '
        Me.PanelFondo.BackColor = System.Drawing.Color.LightGray
        Me.PanelFondo.Controls.Add(Me.Panel99)
        Me.PanelFondo.Controls.Add(Me.PanelCarga)
        Me.PanelFondo.Location = New System.Drawing.Point(171, 488)
        Me.PanelFondo.Name = "PanelFondo"
        Me.PanelFondo.Size = New System.Drawing.Size(400, 8)
        Me.PanelFondo.TabIndex = 75
        '
        'PanelCarga
        '
        Me.PanelCarga.Location = New System.Drawing.Point(0, 1)
        Me.PanelCarga.Name = "PanelCarga"
        Me.PanelCarga.Size = New System.Drawing.Size(0, 7)
        Me.PanelCarga.TabIndex = 76
        '
        'Panel99
        '
        Me.Panel99.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel99.Controls.Add(Me.Panel2)
        Me.Panel99.Location = New System.Drawing.Point(0, 1)
        Me.Panel99.Name = "Panel99"
        Me.Panel99.Size = New System.Drawing.Size(1, 7)
        Me.Panel99.TabIndex = 76
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(0, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(0, 7)
        Me.Panel2.TabIndex = 76
        '
        'Formularios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 524)
        Me.Controls.Add(Me.PanelFondo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_nomdoc)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btn_Crear)
        Me.Controls.Add(Me.Panel_top)
        Me.Controls.Add(Me.BunifuImageButton2)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.dgvDatos)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Formularios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formularios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_top.ResumeLayout(False)
        Me.Panel_top.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Maximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Restaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Salir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFondo.ResumeLayout(False)
        Me.Panel99.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCorreo As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Correo As Label
    Friend WithEvents txtSolicitante As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtNombre As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents label_solicitante As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_fechanec As Label
    Friend WithEvents lbl_fechadoc As Label
    Friend WithEvents dgvDatos As DataGridView
    Friend WithEvents btn_cerrar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Panel_top As Panel
    Friend WithEvents btn_Maximizar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_Restaurar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_Salir As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_Minimizar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Movimiento_cabecera As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents btn_Crear As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblNumDocumento As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lbl_nomdoc As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents FechaNecesaria As DateTimePicker
    Friend WithEvents FechaContable As DateTimePicker
    Friend WithEvents FechaValidez As DateTimePicker
    Friend WithEvents FechaDocumento As DateTimePicker
    Friend WithEvents PanelFondo As Panel
    Friend WithEvents PanelCarga As Panel
    Friend WithEvents Panel99 As Panel
    Friend WithEvents Panel2 As Panel
End Class
