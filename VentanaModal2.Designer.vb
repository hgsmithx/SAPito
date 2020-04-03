<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaModal2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaModal2))
        Me.GrillaModal2 = New System.Windows.Forms.DataGridView()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.btn_EM = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_cerrarSM = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel_top = New System.Windows.Forms.Panel()
        Me.btn_Minimizar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_Salir = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        CType(Me.GrillaModal2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_top.SuspendLayout()
        CType(Me.btn_Minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Salir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrillaModal2
        '
        Me.GrillaModal2.AllowUserToAddRows = False
        Me.GrillaModal2.AllowUserToDeleteRows = False
        Me.GrillaModal2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GrillaModal2.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.GrillaModal2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GrillaModal2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaModal2.Location = New System.Drawing.Point(26, 68)
        Me.GrillaModal2.Name = "GrillaModal2"
        Me.GrillaModal2.ReadOnly = True
        Me.GrillaModal2.RowHeadersVisible = False
        Me.GrillaModal2.Size = New System.Drawing.Size(488, 196)
        Me.GrillaModal2.TabIndex = 0
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Century Schoolbook", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(384, 42)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(130, 21)
        Me.txtBuscar.TabIndex = 1
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.Location = New System.Drawing.Point(336, 44)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(42, 14)
        Me.lblBuscar.TabIndex = 2
        Me.lblBuscar.Text = "Buscar"
        '
        'btn_EM
        '
        Me.btn_EM.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_EM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_EM.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_EM.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_EM.Location = New System.Drawing.Point(26, 270)
        Me.btn_EM.Name = "btn_EM"
        Me.btn_EM.Size = New System.Drawing.Size(140, 31)
        Me.btn_EM.TabIndex = 3
        Me.btn_EM.Text = "Seleccionar artículo"
        Me.btn_EM.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(26, 270)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 31)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Seleccionar artículo"
        Me.Button2.UseVisualStyleBackColor = False
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
        Me.btn_cerrarSM.Font = New System.Drawing.Font("Century Schoolbook", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cerrarSM.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_cerrarSM.IdleBorderThickness = 1
        Me.btn_cerrarSM.IdleCornerRadius = 20
        Me.btn_cerrarSM.IdleFillColor = System.Drawing.SystemColors.ActiveBorder
        Me.btn_cerrarSM.IdleForecolor = System.Drawing.Color.WhiteSmoke
        Me.btn_cerrarSM.IdleLineColor = System.Drawing.SystemColors.ActiveBorder
        Me.btn_cerrarSM.Location = New System.Drawing.Point(431, 270)
        Me.btn_cerrarSM.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_cerrarSM.Name = "btn_cerrarSM"
        Me.btn_cerrarSM.Size = New System.Drawing.Size(83, 41)
        Me.btn_cerrarSM.TabIndex = 81
        Me.btn_cerrarSM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_top
        '
        Me.Panel_top.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Panel_top.Controls.Add(Me.btn_Minimizar)
        Me.Panel_top.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel_top.Controls.Add(Me.btn_Salir)
        Me.Panel_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_top.Location = New System.Drawing.Point(0, 0)
        Me.Panel_top.Name = "Panel_top"
        Me.Panel_top.Size = New System.Drawing.Size(540, 30)
        Me.Panel_top.TabIndex = 82
        '
        'btn_Minimizar
        '
        Me.btn_Minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Minimizar.BackColor = System.Drawing.Color.Transparent
        Me.btn_Minimizar.Image = CType(resources.GetObject("btn_Minimizar.Image"), System.Drawing.Image)
        Me.btn_Minimizar.ImageActive = Nothing
        Me.btn_Minimizar.Location = New System.Drawing.Point(470, 3)
        Me.btn_Minimizar.Name = "btn_Minimizar"
        Me.btn_Minimizar.Size = New System.Drawing.Size(26, 27)
        Me.btn_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_Minimizar.TabIndex = 73
        Me.btn_Minimizar.TabStop = False
        Me.btn_Minimizar.Zoom = 10
        '
        'btn_Salir
        '
        Me.btn_Salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Salir.BackColor = System.Drawing.Color.Transparent
        Me.btn_Salir.Image = CType(resources.GetObject("btn_Salir.Image"), System.Drawing.Image)
        Me.btn_Salir.ImageActive = Nothing
        Me.btn_Salir.Location = New System.Drawing.Point(502, 1)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(26, 27)
        Me.btn_Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_Salir.TabIndex = 5
        Me.btn_Salir.TabStop = False
        Me.btn_Salir.Zoom = 10
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(21, 6)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(145, 19)
        Me.BunifuCustomLabel1.TabIndex = 71
        Me.BunifuCustomLabel1.Text = "Listado de artículos"
        '
        'VentanaModal2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 318)
        Me.Controls.Add(Me.Panel_top)
        Me.Controls.Add(Me.btn_cerrarSM)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_EM)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.GrillaModal2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VentanaModal2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "VentanaModal2"
        CType(Me.GrillaModal2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_top.ResumeLayout(False)
        Me.Panel_top.PerformLayout()
        CType(Me.btn_Minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Salir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GrillaModal2 As DataGridView
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents lblBuscar As Label
    Friend WithEvents btn_EM As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_cerrarSM As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panel_top As Panel
    Friend WithEvents btn_Minimizar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_Salir As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
