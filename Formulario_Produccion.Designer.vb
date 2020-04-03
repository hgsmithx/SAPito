<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formulario_Produccion
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
        Dim Movimiento_cabecera As Bunifu.Framework.UI.BunifuDragControl
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formulario_Produccion))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel_topProd = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btn_Maximizar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_Restaurar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_Salir = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_Minimizar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.tabControl_EMSM = New System.Windows.Forms.TabControl()
        Me.panel_SM = New System.Windows.Forms.TabPage()
        Me.progressbar_SM = New Bunifu.Framework.UI.BunifuProgressBar()
        Me.btn_Siguiente = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbox_comentariosSM = New System.Windows.Forms.TextBox()
        Me.dgvDatos_SM = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_solicitanteSM = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_numFolioSM = New System.Windows.Forms.TextBox()
        Me.txt_prefijoFolioSM = New System.Windows.Forms.TextBox()
        Me.txtNumDocSM = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_eliminarSM = New Bunifu.Framework.UI.BunifuImageButton()
        Me.panel_EM = New System.Windows.Forms.TabPage()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.ProgressBar_EM = New Bunifu.Framework.UI.BunifuProgressBar()
        Me.btn_crearEM = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_salirEM = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtbox_comentariosEM = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_SolicitanteEM = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_numFolioEM = New System.Windows.Forms.TextBox()
        Me.txt_prefijoFolioEM = New System.Windows.Forms.TextBox()
        Me.txtNumDocEM = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btn_eliminarEM = New Bunifu.Framework.UI.BunifuImageButton()
        Me.dgvDatos_EM = New System.Windows.Forms.DataGridView()
        Movimiento_cabecera = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel_topProd.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Maximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Restaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Salir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControl_EMSM.SuspendLayout()
        Me.panel_SM.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvDatos_SM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.btn_eliminarSM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_EM.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.btn_eliminarEM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDatos_EM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Movimiento_cabecera
        '
        Movimiento_cabecera.Fixed = True
        Movimiento_cabecera.Horizontal = True
        Movimiento_cabecera.TargetControl = Me.Panel_topProd
        Movimiento_cabecera.Vertical = True
        '
        'Panel_topProd
        '
        Me.Panel_topProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Panel_topProd.Controls.Add(Me.PictureBox1)
        Me.Panel_topProd.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel_topProd.Controls.Add(Me.btn_Maximizar)
        Me.Panel_topProd.Controls.Add(Me.btn_Restaurar)
        Me.Panel_topProd.Controls.Add(Me.btn_Salir)
        Me.Panel_topProd.Controls.Add(Me.btn_Minimizar)
        Me.Panel_topProd.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_topProd.Location = New System.Drawing.Point(0, 0)
        Me.Panel_topProd.Name = "Panel_topProd"
        Me.Panel_topProd.Size = New System.Drawing.Size(776, 33)
        Me.Panel_topProd.TabIndex = 70
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
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(107, 24)
        Me.BunifuCustomLabel1.TabIndex = 71
        Me.BunifuCustomLabel1.Text = "Producción"
        '
        'btn_Maximizar
        '
        Me.btn_Maximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Maximizar.BackColor = System.Drawing.Color.Transparent
        Me.btn_Maximizar.Image = CType(resources.GetObject("btn_Maximizar.Image"), System.Drawing.Image)
        Me.btn_Maximizar.ImageActive = Nothing
        Me.btn_Maximizar.Location = New System.Drawing.Point(678, 2)
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
        Me.btn_Restaurar.Location = New System.Drawing.Point(678, 2)
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
        Me.btn_Salir.Location = New System.Drawing.Point(720, 2)
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
        Me.btn_Minimizar.Location = New System.Drawing.Point(636, 2)
        Me.btn_Minimizar.Name = "btn_Minimizar"
        Me.btn_Minimizar.Size = New System.Drawing.Size(36, 30)
        Me.btn_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_Minimizar.TabIndex = 6
        Me.btn_Minimizar.TabStop = False
        Me.btn_Minimizar.Zoom = 10
        '
        'tabControl_EMSM
        '
        Me.tabControl_EMSM.Controls.Add(Me.panel_SM)
        Me.tabControl_EMSM.Controls.Add(Me.panel_EM)
        Me.tabControl_EMSM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl_EMSM.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabControl_EMSM.Location = New System.Drawing.Point(0, 33)
        Me.tabControl_EMSM.Name = "tabControl_EMSM"
        Me.tabControl_EMSM.SelectedIndex = 0
        Me.tabControl_EMSM.Size = New System.Drawing.Size(776, 469)
        Me.tabControl_EMSM.TabIndex = 0
        '
        'panel_SM
        '
        Me.panel_SM.BackColor = System.Drawing.Color.White
        Me.panel_SM.CausesValidation = False
        Me.panel_SM.Controls.Add(Me.progressbar_SM)
        Me.panel_SM.Controls.Add(Me.btn_Siguiente)
        Me.panel_SM.Controls.Add(Me.GroupBox3)
        Me.panel_SM.Controls.Add(Me.dgvDatos_SM)
        Me.panel_SM.Controls.Add(Me.GroupBox4)
        Me.panel_SM.Controls.Add(Me.btn_eliminarSM)
        Me.panel_SM.Location = New System.Drawing.Point(4, 27)
        Me.panel_SM.Name = "panel_SM"
        Me.panel_SM.Padding = New System.Windows.Forms.Padding(3)
        Me.panel_SM.Size = New System.Drawing.Size(768, 438)
        Me.panel_SM.TabIndex = 1
        Me.panel_SM.Text = "Salida de mercancía"
        '
        'progressbar_SM
        '
        Me.progressbar_SM.BackColor = System.Drawing.SystemColors.ControlLight
        Me.progressbar_SM.BorderRadius = 6
        Me.progressbar_SM.Location = New System.Drawing.Point(268, 336)
        Me.progressbar_SM.Margin = New System.Windows.Forms.Padding(14, 11, 14, 11)
        Me.progressbar_SM.MaximumValue = 100
        Me.progressbar_SM.Name = "progressbar_SM"
        Me.progressbar_SM.ProgressColor = System.Drawing.Color.SeaGreen
        Me.progressbar_SM.Size = New System.Drawing.Size(477, 19)
        Me.progressbar_SM.TabIndex = 97
        Me.progressbar_SM.Value = 0
        '
        'btn_Siguiente
        '
        Me.btn_Siguiente.ActiveBorderThickness = 1
        Me.btn_Siguiente.ActiveCornerRadius = 20
        Me.btn_Siguiente.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btn_Siguiente.ActiveForecolor = System.Drawing.Color.White
        Me.btn_Siguiente.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btn_Siguiente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Siguiente.BackColor = System.Drawing.Color.White
        Me.btn_Siguiente.BackgroundImage = CType(resources.GetObject("btn_Siguiente.BackgroundImage"), System.Drawing.Image)
        Me.btn_Siguiente.ButtonText = "Siguiente"
        Me.btn_Siguiente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Siguiente.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Siguiente.ForeColor = System.Drawing.Color.White
        Me.btn_Siguiente.IdleBorderThickness = 1
        Me.btn_Siguiente.IdleCornerRadius = 20
        Me.btn_Siguiente.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_Siguiente.IdleForecolor = System.Drawing.Color.WhiteSmoke
        Me.btn_Siguiente.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_Siguiente.Location = New System.Drawing.Point(652, 379)
        Me.btn_Siguiente.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_Siguiente.Name = "btn_Siguiente"
        Me.btn_Siguiente.Size = New System.Drawing.Size(93, 49)
        Me.btn_Siguiente.TabIndex = 95
        Me.btn_Siguiente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtbox_comentariosSM)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(398, 17)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(347, 122)
        Me.GroupBox3.TabIndex = 94
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Comentarios:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 20)
        Me.Label2.TabIndex = 71
        '
        'txtbox_comentariosSM
        '
        Me.txtbox_comentariosSM.Location = New System.Drawing.Point(50, 26)
        Me.txtbox_comentariosSM.Multiline = True
        Me.txtbox_comentariosSM.Name = "txtbox_comentariosSM"
        Me.txtbox_comentariosSM.Size = New System.Drawing.Size(275, 76)
        Me.txtbox_comentariosSM.TabIndex = 87
        '
        'dgvDatos_SM
        '
        Me.dgvDatos_SM.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDatos_SM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDatos_SM.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvDatos_SM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos_SM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.dgvDatos_SM.Location = New System.Drawing.Point(28, 156)
        Me.dgvDatos_SM.Name = "dgvDatos_SM"
        Me.dgvDatos_SM.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDatos_SM.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDatos_SM.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDatos_SM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDatos_SM.Size = New System.Drawing.Size(717, 146)
        Me.dgvDatos_SM.TabIndex = 81
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txt_solicitanteSM)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.txt_numFolioSM)
        Me.GroupBox4.Controls.Add(Me.txt_prefijoFolioSM)
        Me.GroupBox4.Controls.Add(Me.txtNumDocSM)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(28, 17)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(347, 122)
        Me.GroupBox4.TabIndex = 79
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Información del documento:"
        '
        'txt_solicitanteSM
        '
        Me.txt_solicitanteSM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_solicitanteSM.BackColor = System.Drawing.Color.White
        Me.txt_solicitanteSM.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_solicitanteSM.Location = New System.Drawing.Point(194, 24)
        Me.txt_solicitanteSM.Name = "txt_solicitanteSM"
        Me.txt_solicitanteSM.Size = New System.Drawing.Size(147, 25)
        Me.txt_solicitanteSM.TabIndex = 1
        Me.txt_solicitanteSM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(31, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 19)
        Me.Label9.TabIndex = 84
        Me.Label9.Text = "Solicitante"
        '
        'txt_numFolioSM
        '
        Me.txt_numFolioSM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_numFolioSM.BackColor = System.Drawing.Color.White
        Me.txt_numFolioSM.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numFolioSM.Location = New System.Drawing.Point(243, 56)
        Me.txt_numFolioSM.Name = "txt_numFolioSM"
        Me.txt_numFolioSM.Size = New System.Drawing.Size(98, 25)
        Me.txt_numFolioSM.TabIndex = 3
        Me.txt_numFolioSM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_prefijoFolioSM
        '
        Me.txt_prefijoFolioSM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_prefijoFolioSM.BackColor = System.Drawing.Color.White
        Me.txt_prefijoFolioSM.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_prefijoFolioSM.Location = New System.Drawing.Point(194, 56)
        Me.txt_prefijoFolioSM.Name = "txt_prefijoFolioSM"
        Me.txt_prefijoFolioSM.Size = New System.Drawing.Size(43, 25)
        Me.txt_prefijoFolioSM.TabIndex = 2
        Me.txt_prefijoFolioSM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNumDocSM
        '
        Me.txtNumDocSM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumDocSM.BackColor = System.Drawing.Color.White
        Me.txtNumDocSM.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumDocSM.Location = New System.Drawing.Point(194, 90)
        Me.txtNumDocSM.Name = "txtNumDocSM"
        Me.txtNumDocSM.ReadOnly = True
        Me.txtNumDocSM.Size = New System.Drawing.Size(147, 25)
        Me.txtNumDocSM.TabIndex = 4
        Me.txtNumDocSM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 19)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Número documento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 20)
        Me.Label5.TabIndex = 71
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 19)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Número folio"
        '
        'btn_eliminarSM
        '
        Me.btn_eliminarSM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_eliminarSM.BackColor = System.Drawing.Color.Transparent
        Me.btn_eliminarSM.Image = CType(resources.GetObject("btn_eliminarSM.Image"), System.Drawing.Image)
        Me.btn_eliminarSM.ImageActive = Nothing
        Me.btn_eliminarSM.Location = New System.Drawing.Point(28, 308)
        Me.btn_eliminarSM.Name = "btn_eliminarSM"
        Me.btn_eliminarSM.Size = New System.Drawing.Size(58, 32)
        Me.btn_eliminarSM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_eliminarSM.TabIndex = 83
        Me.btn_eliminarSM.TabStop = False
        Me.btn_eliminarSM.Zoom = 10
        '
        'panel_EM
        '
        Me.panel_EM.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.panel_EM.Controls.Add(Me.BunifuThinButton21)
        Me.panel_EM.Controls.Add(Me.ProgressBar_EM)
        Me.panel_EM.Controls.Add(Me.btn_crearEM)
        Me.panel_EM.Controls.Add(Me.btn_salirEM)
        Me.panel_EM.Controls.Add(Me.GroupBox2)
        Me.panel_EM.Controls.Add(Me.GroupBox1)
        Me.panel_EM.Controls.Add(Me.btn_eliminarEM)
        Me.panel_EM.Controls.Add(Me.dgvDatos_EM)
        Me.panel_EM.Location = New System.Drawing.Point(4, 27)
        Me.panel_EM.Name = "panel_EM"
        Me.panel_EM.Padding = New System.Windows.Forms.Padding(3)
        Me.panel_EM.Size = New System.Drawing.Size(768, 438)
        Me.panel_EM.TabIndex = 0
        Me.panel_EM.Text = "Entrada de mercancía"
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "Nuevo"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.BunifuThinButton21.Location = New System.Drawing.Point(551, 379)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(93, 49)
        Me.BunifuThinButton21.TabIndex = 97
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuThinButton21.Visible = False
        '
        'ProgressBar_EM
        '
        Me.ProgressBar_EM.BackColor = System.Drawing.Color.Silver
        Me.ProgressBar_EM.BorderRadius = 6
        Me.ProgressBar_EM.Location = New System.Drawing.Point(268, 336)
        Me.ProgressBar_EM.Margin = New System.Windows.Forms.Padding(9, 8, 9, 8)
        Me.ProgressBar_EM.MaximumValue = 100
        Me.ProgressBar_EM.Name = "ProgressBar_EM"
        Me.ProgressBar_EM.ProgressColor = System.Drawing.Color.SeaGreen
        Me.ProgressBar_EM.Size = New System.Drawing.Size(477, 19)
        Me.ProgressBar_EM.TabIndex = 96
        Me.ProgressBar_EM.Value = 0
        '
        'btn_crearEM
        '
        Me.btn_crearEM.ActiveBorderThickness = 1
        Me.btn_crearEM.ActiveCornerRadius = 20
        Me.btn_crearEM.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btn_crearEM.ActiveForecolor = System.Drawing.Color.White
        Me.btn_crearEM.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btn_crearEM.BackColor = System.Drawing.Color.Transparent
        Me.btn_crearEM.BackgroundImage = CType(resources.GetObject("btn_crearEM.BackgroundImage"), System.Drawing.Image)
        Me.btn_crearEM.ButtonText = "Crear"
        Me.btn_crearEM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_crearEM.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_crearEM.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_crearEM.IdleBorderThickness = 1
        Me.btn_crearEM.IdleCornerRadius = 20
        Me.btn_crearEM.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_crearEM.IdleForecolor = System.Drawing.Color.White
        Me.btn_crearEM.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_crearEM.Location = New System.Drawing.Point(652, 379)
        Me.btn_crearEM.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_crearEM.Name = "btn_crearEM"
        Me.btn_crearEM.Size = New System.Drawing.Size(93, 49)
        Me.btn_crearEM.TabIndex = 95
        Me.btn_crearEM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_salirEM
        '
        Me.btn_salirEM.ActiveBorderThickness = 1
        Me.btn_salirEM.ActiveCornerRadius = 20
        Me.btn_salirEM.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btn_salirEM.ActiveForecolor = System.Drawing.Color.White
        Me.btn_salirEM.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btn_salirEM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_salirEM.BackColor = System.Drawing.Color.Transparent
        Me.btn_salirEM.BackgroundImage = CType(resources.GetObject("btn_salirEM.BackgroundImage"), System.Drawing.Image)
        Me.btn_salirEM.ButtonText = "Salir"
        Me.btn_salirEM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_salirEM.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salirEM.ForeColor = System.Drawing.Color.White
        Me.btn_salirEM.IdleBorderThickness = 1
        Me.btn_salirEM.IdleCornerRadius = 20
        Me.btn_salirEM.IdleFillColor = System.Drawing.Color.DarkGray
        Me.btn_salirEM.IdleForecolor = System.Drawing.Color.White
        Me.btn_salirEM.IdleLineColor = System.Drawing.Color.DarkGray
        Me.btn_salirEM.Location = New System.Drawing.Point(28, 382)
        Me.btn_salirEM.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_salirEM.Name = "btn_salirEM"
        Me.btn_salirEM.Size = New System.Drawing.Size(93, 46)
        Me.btn_salirEM.TabIndex = 94
        Me.btn_salirEM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtbox_comentariosEM)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(398, 17)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(347, 122)
        Me.GroupBox2.TabIndex = 90
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Comentarios:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 20)
        Me.Label7.TabIndex = 71
        '
        'txtbox_comentariosEM
        '
        Me.txtbox_comentariosEM.Location = New System.Drawing.Point(50, 26)
        Me.txtbox_comentariosEM.Multiline = True
        Me.txtbox_comentariosEM.Name = "txtbox_comentariosEM"
        Me.txtbox_comentariosEM.Size = New System.Drawing.Size(275, 76)
        Me.txtbox_comentariosEM.TabIndex = 89
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_SolicitanteEM)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_numFolioEM)
        Me.GroupBox1.Controls.Add(Me.txt_prefijoFolioEM)
        Me.GroupBox1.Controls.Add(Me.txtNumDocEM)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(28, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(347, 122)
        Me.GroupBox1.TabIndex = 80
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información del documento:"
        '
        'txt_SolicitanteEM
        '
        Me.txt_SolicitanteEM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_SolicitanteEM.BackColor = System.Drawing.SystemColors.Window
        Me.txt_SolicitanteEM.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SolicitanteEM.Location = New System.Drawing.Point(194, 24)
        Me.txt_SolicitanteEM.Name = "txt_SolicitanteEM"
        Me.txt_SolicitanteEM.Size = New System.Drawing.Size(147, 25)
        Me.txt_SolicitanteEM.TabIndex = 1
        Me.txt_SolicitanteEM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 19)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Solicitante"
        '
        'txt_numFolioEM
        '
        Me.txt_numFolioEM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_numFolioEM.BackColor = System.Drawing.SystemColors.Window
        Me.txt_numFolioEM.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numFolioEM.Location = New System.Drawing.Point(243, 56)
        Me.txt_numFolioEM.Name = "txt_numFolioEM"
        Me.txt_numFolioEM.Size = New System.Drawing.Size(98, 25)
        Me.txt_numFolioEM.TabIndex = 3
        Me.txt_numFolioEM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_prefijoFolioEM
        '
        Me.txt_prefijoFolioEM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_prefijoFolioEM.BackColor = System.Drawing.SystemColors.Window
        Me.txt_prefijoFolioEM.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_prefijoFolioEM.Location = New System.Drawing.Point(194, 56)
        Me.txt_prefijoFolioEM.Name = "txt_prefijoFolioEM"
        Me.txt_prefijoFolioEM.Size = New System.Drawing.Size(43, 25)
        Me.txt_prefijoFolioEM.TabIndex = 2
        Me.txt_prefijoFolioEM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNumDocEM
        '
        Me.txtNumDocEM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumDocEM.BackColor = System.Drawing.SystemColors.Window
        Me.txtNumDocEM.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumDocEM.Location = New System.Drawing.Point(194, 90)
        Me.txtNumDocEM.Name = "txtNumDocEM"
        Me.txtNumDocEM.ReadOnly = True
        Me.txtNumDocEM.Size = New System.Drawing.Size(147, 25)
        Me.txtNumDocEM.TabIndex = 4
        Me.txtNumDocEM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(31, 92)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(150, 19)
        Me.Label14.TabIndex = 81
        Me.Label14.Text = "Número documento"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(9, 146)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(0, 20)
        Me.Label15.TabIndex = 71
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(31, 56)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(102, 19)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Número folio"
        '
        'btn_eliminarEM
        '
        Me.btn_eliminarEM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_eliminarEM.BackColor = System.Drawing.Color.Transparent
        Me.btn_eliminarEM.Image = CType(resources.GetObject("btn_eliminarEM.Image"), System.Drawing.Image)
        Me.btn_eliminarEM.ImageActive = Nothing
        Me.btn_eliminarEM.Location = New System.Drawing.Point(28, 308)
        Me.btn_eliminarEM.Name = "btn_eliminarEM"
        Me.btn_eliminarEM.Size = New System.Drawing.Size(58, 32)
        Me.btn_eliminarEM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_eliminarEM.TabIndex = 77
        Me.btn_eliminarEM.TabStop = False
        Me.btn_eliminarEM.Zoom = 10
        '
        'dgvDatos_EM
        '
        Me.dgvDatos_EM.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDatos_EM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDatos_EM.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvDatos_EM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos_EM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.dgvDatos_EM.Location = New System.Drawing.Point(28, 156)
        Me.dgvDatos_EM.Name = "dgvDatos_EM"
        Me.dgvDatos_EM.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDatos_EM.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDatos_EM.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDatos_EM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDatos_EM.Size = New System.Drawing.Size(717, 146)
        Me.dgvDatos_EM.TabIndex = 49
        '
        'Formulario_Produccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 502)
        Me.Controls.Add(Me.tabControl_EMSM)
        Me.Controls.Add(Me.Panel_topProd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Formulario_Produccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario_Produccion"
        Me.Panel_topProd.ResumeLayout(False)
        Me.Panel_topProd.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Maximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Restaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Salir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControl_EMSM.ResumeLayout(False)
        Me.panel_SM.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvDatos_SM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.btn_eliminarSM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_EM.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.btn_eliminarEM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDatos_EM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabControl_EMSM As TabControl
    Friend WithEvents panel_EM As TabPage
    Friend WithEvents panel_SM As TabPage
    Friend WithEvents Panel_topProd As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btn_Maximizar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_Restaurar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_Salir As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_Minimizar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents dgvDatos_EM As DataGridView
    Friend WithEvents btn_eliminarEM As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txtbox_comentariosSM As TextBox
    Friend WithEvents btn_eliminarSM As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents dgvDatos_SM As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txt_solicitanteSM As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_numFolioSM As TextBox
    Friend WithEvents txt_prefijoFolioSM As TextBox
    Friend WithEvents txtNumDocSM As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtbox_comentariosEM As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_numFolioEM As TextBox
    Friend WithEvents txtNumDocEM As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_prefijoFolioEM As TextBox
    Friend WithEvents txt_SolicitanteEM As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_Siguiente As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents ProgressBar_EM As Bunifu.Framework.UI.BunifuProgressBar
    Friend WithEvents btn_crearEM As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_salirEM As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents progressbar_SM As Bunifu.Framework.UI.BunifuProgressBar
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
End Class
