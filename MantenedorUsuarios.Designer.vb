<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MantenedorUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MantenedorUsuarios))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel_header = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_buniMinimizar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_buniExit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Movimiento_cabecera = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtbuni_Contraseña = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtbuni_ID = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtbuni_Nombre = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btn_Actualizar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_Eliminar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_Agregar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_buniBuscar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txtBuscar = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.grilla = New System.Windows.Forms.DataGridView()
        Me.Panel_header.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_buniMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_buniExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.btn_buniBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel_header.Size = New System.Drawing.Size(815, 39)
        Me.Panel_header.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 3)
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
        Me.btn_buniMinimizar.Location = New System.Drawing.Point(739, 6)
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
        Me.btn_buniExit.Location = New System.Drawing.Point(773, 6)
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
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(53, 9)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(223, 25)
        Me.BunifuCustomLabel1.TabIndex = 3
        Me.BunifuCustomLabel1.Text = "Mantenedor de usuarios"
        '
        'Movimiento_cabecera
        '
        Me.Movimiento_cabecera.Fixed = True
        Me.Movimiento_cabecera.Horizontal = True
        Me.Movimiento_cabecera.TargetControl = Me.Panel_header
        Me.Movimiento_cabecera.Vertical = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtbuni_Contraseña)
        Me.GroupBox1.Controls.Add(Me.txtbuni_ID)
        Me.GroupBox1.Controls.Add(Me.txtbuni_Nombre)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(38, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(262, 168)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion personal"
        '
        'txtbuni_Contraseña
        '
        Me.txtbuni_Contraseña.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtbuni_Contraseña.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbuni_Contraseña.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtbuni_Contraseña.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbuni_Contraseña.HintForeColor = System.Drawing.Color.DarkGray
        Me.txtbuni_Contraseña.HintText = "Contraseña"
        Me.txtbuni_Contraseña.isPassword = False
        Me.txtbuni_Contraseña.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.txtbuni_Contraseña.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.txtbuni_Contraseña.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtbuni_Contraseña.LineThickness = 3
        Me.txtbuni_Contraseña.Location = New System.Drawing.Point(12, 117)
        Me.txtbuni_Contraseña.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbuni_Contraseña.Name = "txtbuni_Contraseña"
        Me.txtbuni_Contraseña.Size = New System.Drawing.Size(224, 34)
        Me.txtbuni_Contraseña.TabIndex = 3
        Me.txtbuni_Contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtbuni_ID
        '
        Me.txtbuni_ID.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtbuni_ID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbuni_ID.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtbuni_ID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbuni_ID.HintForeColor = System.Drawing.Color.DarkGray
        Me.txtbuni_ID.HintText = "ID"
        Me.txtbuni_ID.isPassword = False
        Me.txtbuni_ID.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.txtbuni_ID.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.txtbuni_ID.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtbuni_ID.LineThickness = 3
        Me.txtbuni_ID.Location = New System.Drawing.Point(12, 33)
        Me.txtbuni_ID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbuni_ID.Name = "txtbuni_ID"
        Me.txtbuni_ID.Size = New System.Drawing.Size(224, 34)
        Me.txtbuni_ID.TabIndex = 1
        Me.txtbuni_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtbuni_Nombre
        '
        Me.txtbuni_Nombre.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtbuni_Nombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbuni_Nombre.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtbuni_Nombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbuni_Nombre.HintForeColor = System.Drawing.Color.DarkGray
        Me.txtbuni_Nombre.HintText = "Nombre"
        Me.txtbuni_Nombre.isPassword = False
        Me.txtbuni_Nombre.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.txtbuni_Nombre.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.txtbuni_Nombre.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtbuni_Nombre.LineThickness = 3
        Me.txtbuni_Nombre.Location = New System.Drawing.Point(12, 75)
        Me.txtbuni_Nombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbuni_Nombre.Name = "txtbuni_Nombre"
        Me.txtbuni_Nombre.Size = New System.Drawing.Size(224, 34)
        Me.txtbuni_Nombre.TabIndex = 2
        Me.txtbuni_Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btn_Actualizar
        '
        Me.btn_Actualizar.ActiveBorderThickness = 1
        Me.btn_Actualizar.ActiveCornerRadius = 20
        Me.btn_Actualizar.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btn_Actualizar.ActiveForecolor = System.Drawing.Color.White
        Me.btn_Actualizar.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btn_Actualizar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Actualizar.BackgroundImage = CType(resources.GetObject("btn_Actualizar.BackgroundImage"), System.Drawing.Image)
        Me.btn_Actualizar.ButtonText = "Actualizar"
        Me.btn_Actualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Actualizar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Actualizar.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_Actualizar.IdleBorderThickness = 1
        Me.btn_Actualizar.IdleCornerRadius = 20
        Me.btn_Actualizar.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btn_Actualizar.IdleForecolor = System.Drawing.SystemColors.Window
        Me.btn_Actualizar.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btn_Actualizar.Location = New System.Drawing.Point(605, 304)
        Me.btn_Actualizar.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_Actualizar.Name = "btn_Actualizar"
        Me.btn_Actualizar.Size = New System.Drawing.Size(95, 41)
        Me.btn_Actualizar.TabIndex = 5
        Me.btn_Actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.ActiveBorderThickness = 1
        Me.btn_Eliminar.ActiveCornerRadius = 20
        Me.btn_Eliminar.ActiveFillColor = System.Drawing.Color.IndianRed
        Me.btn_Eliminar.ActiveForecolor = System.Drawing.Color.White
        Me.btn_Eliminar.ActiveLineColor = System.Drawing.Color.IndianRed
        Me.btn_Eliminar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Eliminar.BackgroundImage = CType(resources.GetObject("btn_Eliminar.BackgroundImage"), System.Drawing.Image)
        Me.btn_Eliminar.ButtonText = "Eliminar"
        Me.btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Eliminar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Eliminar.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_Eliminar.IdleBorderThickness = 1
        Me.btn_Eliminar.IdleCornerRadius = 20
        Me.btn_Eliminar.IdleFillColor = System.Drawing.Color.Firebrick
        Me.btn_Eliminar.IdleForecolor = System.Drawing.SystemColors.Window
        Me.btn_Eliminar.IdleLineColor = System.Drawing.Color.Firebrick
        Me.btn_Eliminar.Location = New System.Drawing.Point(710, 304)
        Me.btn_Eliminar.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(86, 41)
        Me.btn_Eliminar.TabIndex = 6
        Me.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_Agregar
        '
        Me.btn_Agregar.ActiveBorderThickness = 1
        Me.btn_Agregar.ActiveCornerRadius = 20
        Me.btn_Agregar.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btn_Agregar.ActiveForecolor = System.Drawing.Color.White
        Me.btn_Agregar.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btn_Agregar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Agregar.BackgroundImage = CType(resources.GetObject("btn_Agregar.BackgroundImage"), System.Drawing.Image)
        Me.btn_Agregar.ButtonText = "Agregar"
        Me.btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Agregar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Agregar.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_Agregar.IdleBorderThickness = 1
        Me.btn_Agregar.IdleCornerRadius = 20
        Me.btn_Agregar.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_Agregar.IdleForecolor = System.Drawing.Color.White
        Me.btn_Agregar.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_Agregar.Location = New System.Drawing.Point(38, 253)
        Me.btn_Agregar.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(109, 43)
        Me.btn_Agregar.TabIndex = 4
        Me.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_buniBuscar
        '
        Me.btn_buniBuscar.BackColor = System.Drawing.Color.Transparent
        Me.btn_buniBuscar.Image = CType(resources.GetObject("btn_buniBuscar.Image"), System.Drawing.Image)
        Me.btn_buniBuscar.ImageActive = Nothing
        Me.btn_buniBuscar.Location = New System.Drawing.Point(756, 65)
        Me.btn_buniBuscar.Name = "btn_buniBuscar"
        Me.btn_buniBuscar.Size = New System.Drawing.Size(40, 19)
        Me.btn_buniBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_buniBuscar.TabIndex = 52
        Me.btn_buniBuscar.TabStop = False
        Me.btn_buniBuscar.Zoom = 10
        '
        'txtBuscar
        '
        Me.txtBuscar.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtBuscar.Location = New System.Drawing.Point(622, 65)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(174, 20)
        Me.txtBuscar.TabIndex = 53
        Me.txtBuscar.Text = "Buscar"
        '
        'grilla
        '
        Me.grilla.AllowUserToAddRows = False
        Me.grilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grilla.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.grilla.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla.Location = New System.Drawing.Point(323, 90)
        Me.grilla.Name = "grilla"
        Me.grilla.RowHeadersVisible = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray
        Me.grilla.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grilla.Size = New System.Drawing.Size(473, 206)
        Me.grilla.TabIndex = 55
        '
        'MantenedorUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(815, 455)
        Me.Controls.Add(Me.grilla)
        Me.Controls.Add(Me.btn_buniBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_Actualizar)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Agregar)
        Me.Controls.Add(Me.Panel_header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MantenedorUsuarios"
        Me.Text = "MantenedorUsuarios"
        Me.Panel_header.ResumeLayout(False)
        Me.Panel_header.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_buniMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_buniExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.btn_buniBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel_header As Panel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btn_buniExit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_buniMinimizar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_Agregar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_Eliminar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_Actualizar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Movimiento_cabecera As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtbuni_Contraseña As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtbuni_ID As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtbuni_Nombre As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btn_buniBuscar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txtBuscar As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents grilla As DataGridView
End Class
