<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_Connexion
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_Connexion))
        Me.ElegantThemeContainer1 = New GSB_Admin.ElegantThemeContainer()
        Me.lbl_Error = New GSB_Admin.ElegantThemeLabel()
        Me.btn_Quitte = New GSB_Admin.ElegantThemeButton()
        Me.btn_Submit = New GSB_Admin.ElegantThemeButton()
        Me.txtB_MDP = New GSB_Admin.ElegantThemeTextBox()
        Me.txtB_Login = New GSB_Admin.ElegantThemeTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ElegantThemeContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ElegantThemeContainer1
        '
        Me.ElegantThemeContainer1.AllowClose = True
        Me.ElegantThemeContainer1.AllowMaximize = True
        Me.ElegantThemeContainer1.AllowMinimize = True
        Me.ElegantThemeContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ElegantThemeContainer1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ElegantThemeContainer1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.ElegantThemeContainer1.ControlBaseColour = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ElegantThemeContainer1.ControlBoxButtonSplitColour = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.ElegantThemeContainer1.ControlBoxColour = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.ElegantThemeContainer1.Controls.Add(Me.lbl_Error)
        Me.ElegantThemeContainer1.Controls.Add(Me.btn_Quitte)
        Me.ElegantThemeContainer1.Controls.Add(Me.btn_Submit)
        Me.ElegantThemeContainer1.Controls.Add(Me.txtB_MDP)
        Me.ElegantThemeContainer1.Controls.Add(Me.txtB_Login)
        Me.ElegantThemeContainer1.Controls.Add(Me.PictureBox1)
        Me.ElegantThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ElegantThemeContainer1.IconColour = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ElegantThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ElegantThemeContainer1.Name = "ElegantThemeContainer1"
        Me.ElegantThemeContainer1.Size = New System.Drawing.Size(618, 262)
        Me.ElegantThemeContainer1.TabIndex = 0
        Me.ElegantThemeContainer1.Text = "Connexion à l'application GSB-Admin"
        Me.ElegantThemeContainer1.TopStripBorderColour = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.ElegantThemeContainer1.TopStripColour = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(241, Byte), Integer))
        '
        'lbl_Error
        '
        Me.lbl_Error.AutoSize = True
        Me.lbl_Error.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Error.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Error.FontColour = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.lbl_Error.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.lbl_Error.Location = New System.Drawing.Point(268, 171)
        Me.lbl_Error.Name = "lbl_Error"
        Me.lbl_Error.Size = New System.Drawing.Size(0, 15)
        Me.lbl_Error.TabIndex = 8
        '
        'btn_Quitte
        '
        Me.btn_Quitte.BackColor = System.Drawing.Color.Transparent
        Me.btn_Quitte.BaseColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Quitte.BorderColour = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.btn_Quitte.Location = New System.Drawing.Point(519, 220)
        Me.btn_Quitte.Name = "btn_Quitte"
        Me.btn_Quitte.PressedTextColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_Quitte.Size = New System.Drawing.Size(87, 30)
        Me.btn_Quitte.TabIndex = 7
        Me.btn_Quitte.Text = "Quitter"
        Me.btn_Quitte.TextColour = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        '
        'btn_Submit
        '
        Me.btn_Submit.BackColor = System.Drawing.Color.Transparent
        Me.btn_Submit.BaseColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_Submit.BorderColour = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.btn_Submit.Location = New System.Drawing.Point(297, 208)
        Me.btn_Submit.Name = "btn_Submit"
        Me.btn_Submit.PressedTextColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_Submit.Size = New System.Drawing.Size(91, 31)
        Me.btn_Submit.TabIndex = 6
        Me.btn_Submit.Text = "Connexion"
        Me.btn_Submit.TextColour = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        '
        'txtB_MDP
        '
        Me.txtB_MDP.BackColor = System.Drawing.Color.Transparent
        Me.txtB_MDP.BaseColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtB_MDP.BorderColour = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.txtB_MDP.LeftPolygonColour = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtB_MDP.LineColour = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.txtB_MDP.Location = New System.Drawing.Point(258, 123)
        Me.txtB_MDP.MaxLength = 32767
        Me.txtB_MDP.Multiline = False
        Me.txtB_MDP.Name = "txtB_MDP"
        Me.txtB_MDP.Picture = GSB_Admin.ElegantThemeTextBox.Pictures.Password
        Me.txtB_MDP.ReadOnly = False
        Me.txtB_MDP.Size = New System.Drawing.Size(204, 27)
        Me.txtB_MDP.TabIndex = 5
        Me.txtB_MDP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtB_MDP.TextColour = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.txtB_MDP.UseSystemPasswordChar = True
        '
        'txtB_Login
        '
        Me.txtB_Login.BackColor = System.Drawing.Color.Transparent
        Me.txtB_Login.BaseColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtB_Login.BorderColour = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.txtB_Login.LeftPolygonColour = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtB_Login.LineColour = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.txtB_Login.Location = New System.Drawing.Point(258, 65)
        Me.txtB_Login.MaxLength = 32767
        Me.txtB_Login.Multiline = False
        Me.txtB_Login.Name = "txtB_Login"
        Me.txtB_Login.Picture = GSB_Admin.ElegantThemeTextBox.Pictures.Username
        Me.txtB_Login.ReadOnly = False
        Me.txtB_Login.Size = New System.Drawing.Size(204, 27)
        Me.txtB_Login.TabIndex = 4
        Me.txtB_Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtB_Login.TextColour = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.txtB_Login.UseSystemPasswordChar = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(194, 169)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'form_Connexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 262)
        Me.Controls.Add(Me.ElegantThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "form_Connexion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connexion"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ElegantThemeContainer1.ResumeLayout(False)
        Me.ElegantThemeContainer1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ElegantThemeContainer1 As GSB_Admin.ElegantThemeContainer
    Friend WithEvents btn_Quitte As GSB_Admin.ElegantThemeButton
    Friend WithEvents btn_Submit As GSB_Admin.ElegantThemeButton
    Friend WithEvents txtB_MDP As GSB_Admin.ElegantThemeTextBox
    Friend WithEvents txtB_Login As GSB_Admin.ElegantThemeTextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_Error As GSB_Admin.ElegantThemeLabel
End Class
