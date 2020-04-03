<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VentanaModal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaModal))
        Me.GrillaModal = New System.Windows.Forms.DataGridView()
        Me.Panel_top = New System.Windows.Forms.Panel()
        Me.btn_Minimizar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btn_Salir = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_SelectArt = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_cerrarSM = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txtBusqueda = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        CType(Me.GrillaModal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_top.SuspendLayout()
        CType(Me.btn_Minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Salir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrillaModal
        '
        Me.GrillaModal.AllowUserToAddRows = False
        Me.GrillaModal.AllowUserToDeleteRows = False
        Me.GrillaModal.AllowUserToResizeRows = False
        Me.GrillaModal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GrillaModal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaModal.Location = New System.Drawing.Point(21, 76)
        Me.GrillaModal.Name = "GrillaModal"
        Me.GrillaModal.ReadOnly = True
        Me.GrillaModal.RowHeadersVisible = False
        Me.GrillaModal.Size = New System.Drawing.Size(500, 213)
        Me.GrillaModal.TabIndex = 0
        '
        'Panel_top
        '
        Me.Panel_top.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Panel_top.Controls.Add(Me.btn_Minimizar)
        Me.Panel_top.Controls.Add(Me.PictureBox1)
        Me.Panel_top.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel_top.Controls.Add(Me.btn_Salir)
        Me.Panel_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_top.Location = New System.Drawing.Point(0, 0)
        Me.Panel_top.Name = "Panel_top"
        Me.Panel_top.Size = New System.Drawing.Size(546, 30)
        Me.Panel_top.TabIndex = 72
        '
        'btn_Minimizar
        '
        Me.btn_Minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Minimizar.BackColor = System.Drawing.Color.Transparent
        Me.btn_Minimizar.Image = CType(resources.GetObject("btn_Minimizar.Image"), System.Drawing.Image)
        Me.btn_Minimizar.ImageActive = Nothing
        Me.btn_Minimizar.Location = New System.Drawing.Point(476, 3)
        Me.btn_Minimizar.Name = "btn_Minimizar"
        Me.btn_Minimizar.Size = New System.Drawing.Size(26, 27)
        Me.btn_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_Minimizar.TabIndex = 73
        Me.btn_Minimizar.TabStop = False
        Me.btn_Minimizar.Zoom = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 72
        Me.PictureBox1.TabStop = False
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(51, 4)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(145, 19)
        Me.BunifuCustomLabel1.TabIndex = 71
        Me.BunifuCustomLabel1.Text = "Listado de artículos"
        '
        'btn_Salir
        '
        Me.btn_Salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Salir.BackColor = System.Drawing.Color.Transparent
        Me.btn_Salir.Image = CType(resources.GetObject("btn_Salir.Image"), System.Drawing.Image)
        Me.btn_Salir.ImageActive = Nothing
        Me.btn_Salir.Location = New System.Drawing.Point(508, 1)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(26, 27)
        Me.btn_Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_Salir.TabIndex = 5
        Me.btn_Salir.TabStop = False
        Me.btn_Salir.Zoom = 10
        '
        'btn_SelectArt
        '
        Me.btn_SelectArt.ActiveBorderThickness = 1
        Me.btn_SelectArt.ActiveCornerRadius = 20
        Me.btn_SelectArt.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btn_SelectArt.ActiveForecolor = System.Drawing.Color.White
        Me.btn_SelectArt.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btn_SelectArt.BackColor = System.Drawing.SystemColors.Control
        Me.btn_SelectArt.BackgroundImage = CType(resources.GetObject("btn_SelectArt.BackgroundImage"), System.Drawing.Image)
        Me.btn_SelectArt.ButtonText = "Seleccionar"
        Me.btn_SelectArt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_SelectArt.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SelectArt.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_SelectArt.IdleBorderThickness = 1
        Me.btn_SelectArt.IdleCornerRadius = 20
        Me.btn_SelectArt.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_SelectArt.IdleForecolor = System.Drawing.SystemColors.Window
        Me.btn_SelectArt.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_SelectArt.Location = New System.Drawing.Point(21, 294)
        Me.btn_SelectArt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_SelectArt.Name = "btn_SelectArt"
        Me.btn_SelectArt.Size = New System.Drawing.Size(93, 44)
        Me.btn_SelectArt.TabIndex = 81
        Me.btn_SelectArt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_cerrarSM
        '
        Me.btn_cerrarSM.ActiveBorderThickness = 1
        Me.btn_cerrarSM.ActiveCornerRadius = 20
        Me.btn_cerrarSM.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btn_cerrarSM.ActiveForecolor = System.Drawing.Color.White
        Me.btn_cerrarSM.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btn_cerrarSM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cerrarSM.BackColor = System.Drawing.SystemColors.Control
        Me.btn_cerrarSM.BackgroundImage = CType(resources.GetObject("btn_cerrarSM.BackgroundImage"), System.Drawing.Image)
        Me.btn_cerrarSM.ButtonText = "Cancelar"
        Me.btn_cerrarSM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cerrarSM.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cerrarSM.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_cerrarSM.IdleBorderThickness = 1
        Me.btn_cerrarSM.IdleCornerRadius = 20
        Me.btn_cerrarSM.IdleFillColor = System.Drawing.SystemColors.ActiveBorder
        Me.btn_cerrarSM.IdleForecolor = System.Drawing.Color.WhiteSmoke
        Me.btn_cerrarSM.IdleLineColor = System.Drawing.SystemColors.ActiveBorder
        Me.btn_cerrarSM.Location = New System.Drawing.Point(438, 294)
        Me.btn_cerrarSM.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_cerrarSM.Name = "btn_cerrarSM"
        Me.btn_cerrarSM.Size = New System.Drawing.Size(83, 44)
        Me.btn_cerrarSM.TabIndex = 80
        Me.btn_cerrarSM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBusqueda
        '
        Me.txtBusqueda.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtBusqueda.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBusqueda.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.ForeColor = System.Drawing.Color.Black
        Me.txtBusqueda.HintForeColor = System.Drawing.Color.Gray
        Me.txtBusqueda.HintText = "Buscar"
        Me.txtBusqueda.isPassword = False
        Me.txtBusqueda.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.txtBusqueda.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.txtBusqueda.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.txtBusqueda.LineThickness = 3
        Me.txtBusqueda.Location = New System.Drawing.Point(142, 37)
        Me.txtBusqueda.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(161, 34)
        Me.txtBusqueda.TabIndex = 82
        Me.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(360, 50)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(100, 20)
        Me.txtBuscar.TabIndex = 83
        Me.txtBuscar.Text = "Buscar"
        '
        'VentanaModal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 340)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.btn_SelectArt)
        Me.Controls.Add(Me.btn_cerrarSM)
        Me.Controls.Add(Me.Panel_top)
        Me.Controls.Add(Me.GrillaModal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VentanaModal"
        Me.Text = "VentanaModal"
        CType(Me.GrillaModal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_top.ResumeLayout(False)
        Me.Panel_top.PerformLayout()
        CType(Me.btn_Minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Salir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GrillaModal As DataGridView
    Friend WithEvents Panel_top As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btn_Salir As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_SelectArt As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_cerrarSM As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_Minimizar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txtBusqueda As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtBuscar As TextBox
End Class
