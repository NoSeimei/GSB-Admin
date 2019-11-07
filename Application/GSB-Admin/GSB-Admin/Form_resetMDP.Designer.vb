<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_resetMDP
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
        Me.cbx_showhide = New System.Windows.Forms.CheckBox()
        Me.lbl_Mdp = New System.Windows.Forms.Label()
        Me.btn_Default = New System.Windows.Forms.Button()
        Me.btn_Valider = New System.Windows.Forms.Button()
        Me.lbl_InfoMdp = New System.Windows.Forms.Label()
        Me.progressBar_Mdp = New System.Windows.Forms.ProgressBar()
        Me.tb_mdpchange = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbx_showhide
        '
        Me.cbx_showhide.AutoSize = True
        Me.cbx_showhide.Location = New System.Drawing.Point(215, 56)
        Me.cbx_showhide.Name = "cbx_showhide"
        Me.cbx_showhide.Size = New System.Drawing.Size(108, 17)
        Me.cbx_showhide.TabIndex = 30
        Me.cbx_showhide.Text = "Afficher/Masquer"
        Me.cbx_showhide.UseVisualStyleBackColor = True
        '
        'lbl_Mdp
        '
        Me.lbl_Mdp.AutoSize = True
        Me.lbl_Mdp.Location = New System.Drawing.Point(80, 37)
        Me.lbl_Mdp.Name = "lbl_Mdp"
        Me.lbl_Mdp.Size = New System.Drawing.Size(71, 13)
        Me.lbl_Mdp.TabIndex = 29
        Me.lbl_Mdp.Text = "Mot de passe"
        '
        'btn_Default
        '
        Me.btn_Default.Location = New System.Drawing.Point(169, 171)
        Me.btn_Default.Name = "btn_Default"
        Me.btn_Default.Size = New System.Drawing.Size(75, 26)
        Me.btn_Default.TabIndex = 28
        Me.btn_Default.Text = "Par défaut"
        Me.btn_Default.UseVisualStyleBackColor = True
        '
        'btn_Valider
        '
        Me.btn_Valider.Location = New System.Drawing.Point(76, 171)
        Me.btn_Valider.Name = "btn_Valider"
        Me.btn_Valider.Size = New System.Drawing.Size(75, 26)
        Me.btn_Valider.TabIndex = 27
        Me.btn_Valider.Text = "Valider"
        Me.btn_Valider.UseVisualStyleBackColor = True
        '
        'lbl_InfoMdp
        '
        Me.lbl_InfoMdp.AutoSize = True
        Me.lbl_InfoMdp.Location = New System.Drawing.Point(32, 127)
        Me.lbl_InfoMdp.Name = "lbl_InfoMdp"
        Me.lbl_InfoMdp.Size = New System.Drawing.Size(0, 13)
        Me.lbl_InfoMdp.TabIndex = 26
        '
        'progressBar_Mdp
        '
        Me.progressBar_Mdp.Location = New System.Drawing.Point(113, 144)
        Me.progressBar_Mdp.Name = "progressBar_Mdp"
        Me.progressBar_Mdp.Size = New System.Drawing.Size(96, 10)
        Me.progressBar_Mdp.TabIndex = 25
        '
        'tb_mdpchange
        '
        Me.tb_mdpchange.Location = New System.Drawing.Point(35, 53)
        Me.tb_mdpchange.Name = "tb_mdpchange"
        Me.tb_mdpchange.Size = New System.Drawing.Size(174, 20)
        Me.tb_mdpchange.TabIndex = 24
        Me.tb_mdpchange.UseSystemPasswordChar = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(35, 97)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(174, 20)
        Me.TextBox1.TabIndex = 31
        Me.TextBox1.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Confirmer le nouveau mot de passe"
        '
        'Form_resetMDP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 220)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cbx_showhide)
        Me.Controls.Add(Me.lbl_Mdp)
        Me.Controls.Add(Me.btn_Default)
        Me.Controls.Add(Me.btn_Valider)
        Me.Controls.Add(Me.lbl_InfoMdp)
        Me.Controls.Add(Me.progressBar_Mdp)
        Me.Controls.Add(Me.tb_mdpchange)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form_resetMDP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_resetMDP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbx_showhide As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Mdp As System.Windows.Forms.Label
    Friend WithEvents btn_Default As System.Windows.Forms.Button
    Friend WithEvents btn_Valider As System.Windows.Forms.Button
    Friend WithEvents lbl_InfoMdp As System.Windows.Forms.Label
    Friend WithEvents progressBar_Mdp As System.Windows.Forms.ProgressBar
    Friend WithEvents tb_mdpchange As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
