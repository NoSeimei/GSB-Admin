<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class connexion
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
        Me.txtB_MDP = New System.Windows.Forms.TextBox()
        Me.lbl_Mdp = New System.Windows.Forms.Label()
        Me.txtB_Login = New System.Windows.Forms.TextBox()
        Me.lbl_Login = New System.Windows.Forms.Label()
        Me.lbl_GSBAdmin = New System.Windows.Forms.Label()
        Me.btn_Quitte = New System.Windows.Forms.Button()
        Me.btn_Submit = New System.Windows.Forms.Button()
        Me.lbl_Erreur = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtB_MDP
        '
        Me.txtB_MDP.Enabled = False
        Me.txtB_MDP.Location = New System.Drawing.Point(216, 116)
        Me.txtB_MDP.Name = "txtB_MDP"
        Me.txtB_MDP.Size = New System.Drawing.Size(122, 20)
        Me.txtB_MDP.TabIndex = 13
        Me.txtB_MDP.UseSystemPasswordChar = True
        '
        'lbl_Mdp
        '
        Me.lbl_Mdp.AutoSize = True
        Me.lbl_Mdp.Location = New System.Drawing.Point(142, 119)
        Me.lbl_Mdp.Name = "lbl_Mdp"
        Me.lbl_Mdp.Size = New System.Drawing.Size(71, 13)
        Me.lbl_Mdp.TabIndex = 12
        Me.lbl_Mdp.Text = "Mot de passe"
        '
        'txtB_Login
        '
        Me.txtB_Login.Location = New System.Drawing.Point(216, 72)
        Me.txtB_Login.Name = "txtB_Login"
        Me.txtB_Login.Size = New System.Drawing.Size(122, 20)
        Me.txtB_Login.TabIndex = 11
        '
        'lbl_Login
        '
        Me.lbl_Login.AutoSize = True
        Me.lbl_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Login.Location = New System.Drawing.Point(174, 75)
        Me.lbl_Login.Name = "lbl_Login"
        Me.lbl_Login.Size = New System.Drawing.Size(36, 13)
        Me.lbl_Login.TabIndex = 10
        Me.lbl_Login.Text = "Login "
        '
        'lbl_GSBAdmin
        '
        Me.lbl_GSBAdmin.AutoSize = True
        Me.lbl_GSBAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GSBAdmin.Location = New System.Drawing.Point(111, 31)
        Me.lbl_GSBAdmin.Name = "lbl_GSBAdmin"
        Me.lbl_GSBAdmin.Size = New System.Drawing.Size(307, 20)
        Me.lbl_GSBAdmin.TabIndex = 14
        Me.lbl_GSBAdmin.Text = "Connexion à l'application GSB-Admin"
        '
        'btn_Quitte
        '
        Me.btn_Quitte.Location = New System.Drawing.Point(443, 227)
        Me.btn_Quitte.Name = "btn_Quitte"
        Me.btn_Quitte.Size = New System.Drawing.Size(75, 23)
        Me.btn_Quitte.TabIndex = 16
        Me.btn_Quitte.Text = "&Quitter"
        Me.btn_Quitte.UseVisualStyleBackColor = True
        '
        'btn_Submit
        '
        Me.btn_Submit.Enabled = False
        Me.btn_Submit.Location = New System.Drawing.Point(228, 171)
        Me.btn_Submit.Name = "btn_Submit"
        Me.btn_Submit.Size = New System.Drawing.Size(88, 36)
        Me.btn_Submit.TabIndex = 15
        Me.btn_Submit.Text = "Connexion"
        Me.btn_Submit.UseVisualStyleBackColor = True
        '
        'lbl_Erreur
        '
        Me.lbl_Erreur.AutoSize = True
        Me.lbl_Erreur.Location = New System.Drawing.Point(195, 146)
        Me.lbl_Erreur.Name = "lbl_Erreur"
        Me.lbl_Erreur.Size = New System.Drawing.Size(0, 13)
        Me.lbl_Erreur.TabIndex = 17
        '
        'connexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 262)
        Me.Controls.Add(Me.lbl_Erreur)
        Me.Controls.Add(Me.btn_Quitte)
        Me.Controls.Add(Me.btn_Submit)
        Me.Controls.Add(Me.lbl_GSBAdmin)
        Me.Controls.Add(Me.txtB_MDP)
        Me.Controls.Add(Me.lbl_Mdp)
        Me.Controls.Add(Me.txtB_Login)
        Me.Controls.Add(Me.lbl_Login)
        Me.Name = "connexion"
        Me.Text = "connexion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtB_MDP As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Mdp As System.Windows.Forms.Label
    Friend WithEvents txtB_Login As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Login As System.Windows.Forms.Label
    Friend WithEvents lbl_GSBAdmin As System.Windows.Forms.Label
    Friend WithEvents btn_Quitte As System.Windows.Forms.Button
    Friend WithEvents btn_Submit As System.Windows.Forms.Button
    Friend WithEvents lbl_Erreur As System.Windows.Forms.Label
End Class
