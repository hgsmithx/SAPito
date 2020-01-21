<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.txtUsuario = New Bunifu.Framework.UI.BunifuTextbox()
        Me.btn_ingresar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_salir = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtPass = New Bunifu.Framework.UI.BunifuTextbox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_sesion = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtUsuario.BackgroundImage = CType(resources.GetObject("txtUsuario.BackgroundImage"), System.Drawing.Image)
        Me.txtUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtUsuario.ForeColor = System.Drawing.Color.White
        Me.txtUsuario.Icon = CType(resources.GetObject("txtUsuario.Icon"), System.Drawing.Image)
        Me.txtUsuario.Location = New System.Drawing.Point(0, 0)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(254, 32)
        Me.txtUsuario.TabIndex = 2
        Me.txtUsuario.text = "Usuario"
        '
        'btn_ingresar
        '
        Me.btn_ingresar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_ingresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btn_ingresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_ingresar.BorderRadius = 7
        Me.btn_ingresar.ButtonText = "Ingresar"
        Me.btn_ingresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ingresar.DisabledColor = System.Drawing.Color.Gray
        Me.btn_ingresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_ingresar.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_ingresar.Iconimage = CType(resources.GetObject("btn_ingresar.Iconimage"), System.Drawing.Image)
        Me.btn_ingresar.Iconimage_right = Nothing
        Me.btn_ingresar.Iconimage_right_Selected = Nothing
        Me.btn_ingresar.Iconimage_Selected = Nothing
        Me.btn_ingresar.IconMarginLeft = 0
        Me.btn_ingresar.IconMarginRight = 0
        Me.btn_ingresar.IconRightVisible = True
        Me.btn_ingresar.IconRightZoom = 0R
        Me.btn_ingresar.IconVisible = True
        Me.btn_ingresar.IconZoom = 40.0R
        Me.btn_ingresar.IsTab = False
        Me.btn_ingresar.Location = New System.Drawing.Point(123, 335)
        Me.btn_ingresar.Name = "btn_ingresar"
        Me.btn_ingresar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btn_ingresar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btn_ingresar.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_ingresar.selected = False
        Me.btn_ingresar.Size = New System.Drawing.Size(131, 41)
        Me.btn_ingresar.TabIndex = 5
        Me.btn_ingresar.Text = "Ingresar"
        Me.btn_ingresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ingresar.Textcolor = System.Drawing.Color.WhiteSmoke
        Me.btn_ingresar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_salir
        '
        Me.btn_salir.Activecolor = System.Drawing.Color.Tomato
        Me.btn_salir.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_salir.BorderRadius = 7
        Me.btn_salir.ButtonText = ""
        Me.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_salir.DisabledColor = System.Drawing.Color.Gray
        Me.btn_salir.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_salir.Iconimage = CType(resources.GetObject("btn_salir.Iconimage"), System.Drawing.Image)
        Me.btn_salir.Iconimage_right = Nothing
        Me.btn_salir.Iconimage_right_Selected = Nothing
        Me.btn_salir.Iconimage_Selected = Nothing
        Me.btn_salir.IconMarginLeft = 0
        Me.btn_salir.IconMarginRight = 0
        Me.btn_salir.IconRightVisible = True
        Me.btn_salir.IconRightZoom = 0R
        Me.btn_salir.IconVisible = True
        Me.btn_salir.IconZoom = 45.0R
        Me.btn_salir.IsTab = False
        Me.btn_salir.Location = New System.Drawing.Point(579, 487)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btn_salir.OnHovercolor = System.Drawing.Color.Firebrick
        Me.btn_salir.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_salir.selected = False
        Me.btn_salir.Size = New System.Drawing.Size(35, 37)
        Me.btn_salir.TabIndex = 6
        Me.btn_salir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_salir.Textcolor = System.Drawing.Color.Black
        Me.btn_salir.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.ForeColor = System.Drawing.Color.SandyBrown
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 2
        Me.BunifuSeparator1.Location = New System.Drawing.Point(16, 178)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(324, 35)
        Me.BunifuSeparator1.TabIndex = 4
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtPass)
        Me.Panel2.Location = New System.Drawing.Point(52, 266)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(254, 32)
        Me.Panel2.TabIndex = 3
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtPass.BackgroundImage = CType(resources.GetObject("txtPass.BackgroundImage"), System.Drawing.Image)
        Me.txtPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtPass.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtPass.Icon = CType(resources.GetObject("txtPass.Icon"), System.Drawing.Image)
        Me.txtPass.Location = New System.Drawing.Point(0, 0)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(254, 32)
        Me.txtPass.TabIndex = 3
        Me.txtPass.text = "Contraseña"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(92, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(187, 147)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'lbl_sesion
        '
        Me.lbl_sesion.AutoSize = True
        Me.lbl_sesion.BackColor = System.Drawing.Color.Transparent
        Me.lbl_sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_sesion.Font = New System.Drawing.Font("Britannic Bold", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sesion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.lbl_sesion.Location = New System.Drawing.Point(74, 150)
        Me.lbl_sesion.Name = "lbl_sesion"
        Me.lbl_sesion.Size = New System.Drawing.Size(215, 37)
        Me.lbl_sesion.TabIndex = 8
        Me.lbl_sesion.Text = "Inicio sesión"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.lbl_sesion)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Controls.Add(Me.BunifuSeparator1)
        Me.Panel3.Controls.Add(Me.btn_ingresar)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Location = New System.Drawing.Point(160, 43)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(354, 416)
        Me.Panel3.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtUsuario)
        Me.Panel1.Location = New System.Drawing.Point(52, 219)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(254, 32)
        Me.Panel1.TabIndex = 2
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(680, 557)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btn_salir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtPass As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents txtUsuario As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents btn_ingresar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_salir As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_sesion As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
End Class
