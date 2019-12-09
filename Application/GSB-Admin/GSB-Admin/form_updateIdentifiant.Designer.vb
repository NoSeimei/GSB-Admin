<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_updateIdentifiant
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
        Me.btn_Valider = New System.Windows.Forms.Button()
        Me.btn_Annuler = New System.Windows.Forms.Button()
        Me.txtb_Login = New System.Windows.Forms.TextBox()
        Me.txtb_MDP = New System.Windows.Forms.TextBox()
        Me.lbl_IdConnexion = New System.Windows.Forms.Label()
        Me.lbl_MDP = New System.Windows.Forms.Label()
        Me.grpBox_IdConnexion = New System.Windows.Forms.GroupBox()
        Me.grpBox_BDD = New System.Windows.Forms.GroupBox()
        Me.lbl_MDP_BDD = New System.Windows.Forms.Label()
        Me.lbl_IdentifiantBDD = New System.Windows.Forms.Label()
        Me.lbl_NomBDD = New System.Windows.Forms.Label()
        Me.lbl_AdresseIP = New System.Windows.Forms.Label()
        Me.txtb_MDP_BDD = New System.Windows.Forms.TextBox()
        Me.txtb_IdentifiantBDD = New System.Windows.Forms.TextBox()
        Me.txtb_nomBDD = New System.Windows.Forms.TextBox()
        Me.txtb_AdresseIP = New System.Windows.Forms.TextBox()
        Me.grpBox_IdConnexion.SuspendLayout()
        Me.grpBox_BDD.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Valider
        '
        Me.btn_Valider.Location = New System.Drawing.Point(134, 324)
        Me.btn_Valider.Name = "btn_Valider"
        Me.btn_Valider.Size = New System.Drawing.Size(75, 23)
        Me.btn_Valider.TabIndex = 0
        Me.btn_Valider.Text = "Valider"
        Me.btn_Valider.UseVisualStyleBackColor = True
        '
        'btn_Annuler
        '
        Me.btn_Annuler.Location = New System.Drawing.Point(270, 371)
        Me.btn_Annuler.Name = "btn_Annuler"
        Me.btn_Annuler.Size = New System.Drawing.Size(75, 23)
        Me.btn_Annuler.TabIndex = 1
        Me.btn_Annuler.Text = "Annuler"
        Me.btn_Annuler.UseVisualStyleBackColor = True
        '
        'txtb_Login
        '
        Me.txtb_Login.Location = New System.Drawing.Point(107, 20)
        Me.txtb_Login.Name = "txtb_Login"
        Me.txtb_Login.Size = New System.Drawing.Size(220, 20)
        Me.txtb_Login.TabIndex = 2
        '
        'txtb_MDP
        '
        Me.txtb_MDP.Location = New System.Drawing.Point(107, 46)
        Me.txtb_MDP.Name = "txtb_MDP"
        Me.txtb_MDP.Size = New System.Drawing.Size(220, 20)
        Me.txtb_MDP.TabIndex = 3
        '
        'lbl_IdConnexion
        '
        Me.lbl_IdConnexion.AutoSize = True
        Me.lbl_IdConnexion.Location = New System.Drawing.Point(-3, 26)
        Me.lbl_IdConnexion.Name = "lbl_IdConnexion"
        Me.lbl_IdConnexion.Size = New System.Drawing.Size(53, 13)
        Me.lbl_IdConnexion.TabIndex = 8
        Me.lbl_IdConnexion.Text = "Identifiant"
        '
        'lbl_MDP
        '
        Me.lbl_MDP.AutoSize = True
        Me.lbl_MDP.Location = New System.Drawing.Point(-3, 53)
        Me.lbl_MDP.Name = "lbl_MDP"
        Me.lbl_MDP.Size = New System.Drawing.Size(71, 13)
        Me.lbl_MDP.TabIndex = 9
        Me.lbl_MDP.Text = "Mot de passe"
        '
        'grpBox_IdConnexion
        '
        Me.grpBox_IdConnexion.Controls.Add(Me.txtb_MDP)
        Me.grpBox_IdConnexion.Controls.Add(Me.txtb_Login)
        Me.grpBox_IdConnexion.Controls.Add(Me.lbl_IdConnexion)
        Me.grpBox_IdConnexion.Controls.Add(Me.lbl_MDP)
        Me.grpBox_IdConnexion.Location = New System.Drawing.Point(12, 12)
        Me.grpBox_IdConnexion.Name = "grpBox_IdConnexion"
        Me.grpBox_IdConnexion.Size = New System.Drawing.Size(333, 93)
        Me.grpBox_IdConnexion.TabIndex = 14
        Me.grpBox_IdConnexion.TabStop = False
        Me.grpBox_IdConnexion.Text = "Identifiant de connexion"
        '
        'grpBox_BDD
        '
        Me.grpBox_BDD.Controls.Add(Me.lbl_MDP_BDD)
        Me.grpBox_BDD.Controls.Add(Me.lbl_IdentifiantBDD)
        Me.grpBox_BDD.Controls.Add(Me.lbl_NomBDD)
        Me.grpBox_BDD.Controls.Add(Me.lbl_AdresseIP)
        Me.grpBox_BDD.Controls.Add(Me.txtb_MDP_BDD)
        Me.grpBox_BDD.Controls.Add(Me.txtb_IdentifiantBDD)
        Me.grpBox_BDD.Controls.Add(Me.txtb_nomBDD)
        Me.grpBox_BDD.Controls.Add(Me.txtb_AdresseIP)
        Me.grpBox_BDD.Location = New System.Drawing.Point(12, 138)
        Me.grpBox_BDD.Name = "grpBox_BDD"
        Me.grpBox_BDD.Size = New System.Drawing.Size(333, 167)
        Me.grpBox_BDD.TabIndex = 15
        Me.grpBox_BDD.TabStop = False
        Me.grpBox_BDD.Text = "Base de données"
        '
        'lbl_MDP_BDD
        '
        Me.lbl_MDP_BDD.AutoSize = True
        Me.lbl_MDP_BDD.Location = New System.Drawing.Point(4, 126)
        Me.lbl_MDP_BDD.Name = "lbl_MDP_BDD"
        Me.lbl_MDP_BDD.Size = New System.Drawing.Size(71, 13)
        Me.lbl_MDP_BDD.TabIndex = 21
        Me.lbl_MDP_BDD.Text = "Mot de passe"
        '
        'lbl_IdentifiantBDD
        '
        Me.lbl_IdentifiantBDD.AutoSize = True
        Me.lbl_IdentifiantBDD.Location = New System.Drawing.Point(4, 100)
        Me.lbl_IdentifiantBDD.Name = "lbl_IdentifiantBDD"
        Me.lbl_IdentifiantBDD.Size = New System.Drawing.Size(53, 13)
        Me.lbl_IdentifiantBDD.TabIndex = 20
        Me.lbl_IdentifiantBDD.Text = "Identifiant"
        '
        'lbl_NomBDD
        '
        Me.lbl_NomBDD.AutoSize = True
        Me.lbl_NomBDD.Location = New System.Drawing.Point(4, 70)
        Me.lbl_NomBDD.Name = "lbl_NomBDD"
        Me.lbl_NomBDD.Size = New System.Drawing.Size(55, 13)
        Me.lbl_NomBDD.TabIndex = 19
        Me.lbl_NomBDD.Text = "Nom BDD"
        '
        'lbl_AdresseIP
        '
        Me.lbl_AdresseIP.AutoSize = True
        Me.lbl_AdresseIP.Location = New System.Drawing.Point(4, 44)
        Me.lbl_AdresseIP.Name = "lbl_AdresseIP"
        Me.lbl_AdresseIP.Size = New System.Drawing.Size(58, 13)
        Me.lbl_AdresseIP.TabIndex = 18
        Me.lbl_AdresseIP.Text = "Adresse IP"
        '
        'txtb_MDP_BDD
        '
        Me.txtb_MDP_BDD.Location = New System.Drawing.Point(107, 119)
        Me.txtb_MDP_BDD.Name = "txtb_MDP_BDD"
        Me.txtb_MDP_BDD.Size = New System.Drawing.Size(220, 20)
        Me.txtb_MDP_BDD.TabIndex = 17
        '
        'txtb_IdentifiantBDD
        '
        Me.txtb_IdentifiantBDD.Location = New System.Drawing.Point(107, 93)
        Me.txtb_IdentifiantBDD.Name = "txtb_IdentifiantBDD"
        Me.txtb_IdentifiantBDD.Size = New System.Drawing.Size(220, 20)
        Me.txtb_IdentifiantBDD.TabIndex = 16
        '
        'txtb_nomBDD
        '
        Me.txtb_nomBDD.Location = New System.Drawing.Point(107, 67)
        Me.txtb_nomBDD.Name = "txtb_nomBDD"
        Me.txtb_nomBDD.Size = New System.Drawing.Size(220, 20)
        Me.txtb_nomBDD.TabIndex = 15
        '
        'txtb_AdresseIP
        '
        Me.txtb_AdresseIP.Location = New System.Drawing.Point(107, 41)
        Me.txtb_AdresseIP.Name = "txtb_AdresseIP"
        Me.txtb_AdresseIP.Size = New System.Drawing.Size(220, 20)
        Me.txtb_AdresseIP.TabIndex = 14
        '
        'form_updateIdentifiant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 406)
        Me.Controls.Add(Me.grpBox_BDD)
        Me.Controls.Add(Me.grpBox_IdConnexion)
        Me.Controls.Add(Me.btn_Annuler)
        Me.Controls.Add(Me.btn_Valider)
        Me.Name = "form_updateIdentifiant"
        Me.Text = "Formulaire de mise à jour"
        Me.grpBox_IdConnexion.ResumeLayout(False)
        Me.grpBox_IdConnexion.PerformLayout()
        Me.grpBox_BDD.ResumeLayout(False)
        Me.grpBox_BDD.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Valider As System.Windows.Forms.Button
    Friend WithEvents btn_Annuler As System.Windows.Forms.Button
    Friend WithEvents txtb_Login As System.Windows.Forms.TextBox
    Friend WithEvents txtb_MDP As System.Windows.Forms.TextBox
    Friend WithEvents lbl_IdConnexion As System.Windows.Forms.Label
    Friend WithEvents lbl_MDP As System.Windows.Forms.Label
    Friend WithEvents grpBox_IdConnexion As System.Windows.Forms.GroupBox
    Friend WithEvents grpBox_BDD As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_MDP_BDD As System.Windows.Forms.Label
    Friend WithEvents lbl_IdentifiantBDD As System.Windows.Forms.Label
    Friend WithEvents lbl_NomBDD As System.Windows.Forms.Label
    Friend WithEvents lbl_AdresseIP As System.Windows.Forms.Label
    Friend WithEvents txtb_MDP_BDD As System.Windows.Forms.TextBox
    Friend WithEvents txtb_IdentifiantBDD As System.Windows.Forms.TextBox
    Friend WithEvents txtb_nomBDD As System.Windows.Forms.TextBox
    Friend WithEvents txtb_AdresseIP As System.Windows.Forms.TextBox
End Class
