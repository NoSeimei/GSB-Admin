<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_principal
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.progressBar_Mdp = New System.Windows.Forms.ProgressBar()
        Me.lbl_InfoMdp = New System.Windows.Forms.Label()
        Me.rb_AllUser = New System.Windows.Forms.RadioButton()
        Me.rb_Visiteur = New System.Windows.Forms.RadioButton()
        Me.rb_Comptable = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grpB_reset = New System.Windows.Forms.GroupBox()
        Me.rb_ResetNo = New System.Windows.Forms.RadioButton()
        Me.rb_resetYes = New System.Windows.Forms.RadioButton()
        Me.rb_Reset = New System.Windows.Forms.RadioButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.btn_Valider = New System.Windows.Forms.Button()
        Me.btn_Default = New System.Windows.Forms.Button()
        Me.btn_deco = New System.Windows.Forms.Button()
        Me.lstV_Users = New System.Windows.Forms.ListView()
        Me.btn_CreateUser = New System.Windows.Forms.Button()
        Me.lbl_Mdp = New System.Windows.Forms.Label()
        Me.btn_SeeMdp = New System.Windows.Forms.Button()
        Me.btn_ChangeMdp = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.grpB_reset.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(940, 256)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(174, 20)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.UseSystemPasswordChar = True
        '
        'progressBar_Mdp
        '
        Me.progressBar_Mdp.Location = New System.Drawing.Point(940, 282)
        Me.progressBar_Mdp.Name = "progressBar_Mdp"
        Me.progressBar_Mdp.Size = New System.Drawing.Size(174, 27)
        Me.progressBar_Mdp.TabIndex = 4
        Me.progressBar_Mdp.Value = 10
        '
        'lbl_InfoMdp
        '
        Me.lbl_InfoMdp.AutoSize = True
        Me.lbl_InfoMdp.Location = New System.Drawing.Point(937, 325)
        Me.lbl_InfoMdp.Name = "lbl_InfoMdp"
        Me.lbl_InfoMdp.Size = New System.Drawing.Size(148, 13)
        Me.lbl_InfoMdp.TabIndex = 5
        Me.lbl_InfoMdp.Text = "2 caractères Minimum ... (info)"
        '
        'rb_AllUser
        '
        Me.rb_AllUser.AutoSize = True
        Me.rb_AllUser.Location = New System.Drawing.Point(23, 67)
        Me.rb_AllUser.Name = "rb_AllUser"
        Me.rb_AllUser.Size = New System.Drawing.Size(49, 17)
        Me.rb_AllUser.TabIndex = 6
        Me.rb_AllUser.TabStop = True
        Me.rb_AllUser.Text = "Tous"
        Me.rb_AllUser.UseVisualStyleBackColor = True
        '
        'rb_Visiteur
        '
        Me.rb_Visiteur.AutoSize = True
        Me.rb_Visiteur.Location = New System.Drawing.Point(23, 44)
        Me.rb_Visiteur.Name = "rb_Visiteur"
        Me.rb_Visiteur.Size = New System.Drawing.Size(59, 17)
        Me.rb_Visiteur.TabIndex = 7
        Me.rb_Visiteur.TabStop = True
        Me.rb_Visiteur.Text = "Visiteur"
        Me.rb_Visiteur.UseVisualStyleBackColor = True
        '
        'rb_Comptable
        '
        Me.rb_Comptable.AutoSize = True
        Me.rb_Comptable.Location = New System.Drawing.Point(23, 21)
        Me.rb_Comptable.Name = "rb_Comptable"
        Me.rb_Comptable.Size = New System.Drawing.Size(75, 17)
        Me.rb_Comptable.TabIndex = 8
        Me.rb_Comptable.TabStop = True
        Me.rb_Comptable.Text = "Comptable"
        Me.rb_Comptable.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_Visiteur)
        Me.GroupBox1.Controls.Add(Me.rb_Comptable)
        Me.GroupBox1.Controls.Add(Me.rb_AllUser)
        Me.GroupBox1.Location = New System.Drawing.Point(45, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Utilisateur"
        '
        'grpB_reset
        '
        Me.grpB_reset.Controls.Add(Me.rb_ResetNo)
        Me.grpB_reset.Controls.Add(Me.rb_resetYes)
        Me.grpB_reset.Controls.Add(Me.rb_Reset)
        Me.grpB_reset.Location = New System.Drawing.Point(558, 52)
        Me.grpB_reset.Name = "grpB_reset"
        Me.grpB_reset.Size = New System.Drawing.Size(200, 100)
        Me.grpB_reset.TabIndex = 10
        Me.grpB_reset.TabStop = False
        Me.grpB_reset.Text = "Réinitialisation"
        Me.grpB_reset.Visible = False
        '
        'rb_ResetNo
        '
        Me.rb_ResetNo.AutoSize = True
        Me.rb_ResetNo.Location = New System.Drawing.Point(23, 44)
        Me.rb_ResetNo.Name = "rb_ResetNo"
        Me.rb_ResetNo.Size = New System.Drawing.Size(109, 17)
        Me.rb_ResetNo.TabIndex = 7
        Me.rb_ResetNo.TabStop = True
        Me.rb_ResetNo.Text = "Aucune demande"
        Me.rb_ResetNo.UseVisualStyleBackColor = True
        Me.rb_ResetNo.Visible = False
        '
        'rb_resetYes
        '
        Me.rb_resetYes.AutoSize = True
        Me.rb_resetYes.Location = New System.Drawing.Point(23, 21)
        Me.rb_resetYes.Name = "rb_resetYes"
        Me.rb_resetYes.Size = New System.Drawing.Size(71, 17)
        Me.rb_resetYes.TabIndex = 8
        Me.rb_resetYes.TabStop = True
        Me.rb_resetYes.Text = "Demande"
        Me.rb_resetYes.UseVisualStyleBackColor = True
        Me.rb_resetYes.Visible = False
        '
        'rb_Reset
        '
        Me.rb_Reset.AutoSize = True
        Me.rb_Reset.Location = New System.Drawing.Point(23, 67)
        Me.rb_Reset.Name = "rb_Reset"
        Me.rb_Reset.Size = New System.Drawing.Size(49, 17)
        Me.rb_Reset.TabIndex = 6
        Me.rb_Reset.TabStop = True
        Me.rb_Reset.Text = "Tous"
        Me.rb_Reset.UseVisualStyleBackColor = True
        Me.rb_Reset.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(777, 25)
        Me.ToolStrip1.TabIndex = 11
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(12, 22)
        Me.ToolStripLabel1.Text = "?"
        '
        'btn_Valider
        '
        Me.btn_Valider.Location = New System.Drawing.Point(940, 379)
        Me.btn_Valider.Name = "btn_Valider"
        Me.btn_Valider.Size = New System.Drawing.Size(75, 23)
        Me.btn_Valider.TabIndex = 12
        Me.btn_Valider.Text = "Valider"
        Me.btn_Valider.UseVisualStyleBackColor = True
        '
        'btn_Default
        '
        Me.btn_Default.Location = New System.Drawing.Point(1039, 379)
        Me.btn_Default.Name = "btn_Default"
        Me.btn_Default.Size = New System.Drawing.Size(75, 23)
        Me.btn_Default.TabIndex = 13
        Me.btn_Default.Text = "Par défaut"
        Me.btn_Default.UseVisualStyleBackColor = True
        '
        'btn_deco
        '
        Me.btn_deco.Location = New System.Drawing.Point(675, 529)
        Me.btn_deco.Name = "btn_deco"
        Me.btn_deco.Size = New System.Drawing.Size(88, 23)
        Me.btn_deco.TabIndex = 14
        Me.btn_deco.Text = "Déconnexion"
        Me.btn_deco.UseVisualStyleBackColor = True
        '
        'lstV_Users
        '
        Me.lstV_Users.Location = New System.Drawing.Point(40, 158)
        Me.lstV_Users.Name = "lstV_Users"
        Me.lstV_Users.Size = New System.Drawing.Size(718, 321)
        Me.lstV_Users.TabIndex = 15
        Me.lstV_Users.UseCompatibleStateImageBehavior = False
        '
        'btn_CreateUser
        '
        Me.btn_CreateUser.Location = New System.Drawing.Point(40, 529)
        Me.btn_CreateUser.Name = "btn_CreateUser"
        Me.btn_CreateUser.Size = New System.Drawing.Size(181, 23)
        Me.btn_CreateUser.TabIndex = 16
        Me.btn_CreateUser.Text = "Créer un nouvel utilisateur"
        Me.btn_CreateUser.UseVisualStyleBackColor = True
        '
        'lbl_Mdp
        '
        Me.lbl_Mdp.AutoSize = True
        Me.lbl_Mdp.Location = New System.Drawing.Point(937, 230)
        Me.lbl_Mdp.Name = "lbl_Mdp"
        Me.lbl_Mdp.Size = New System.Drawing.Size(71, 13)
        Me.lbl_Mdp.TabIndex = 17
        Me.lbl_Mdp.Text = "Mot de passe"
        '
        'btn_SeeMdp
        '
        Me.btn_SeeMdp.Location = New System.Drawing.Point(1120, 256)
        Me.btn_SeeMdp.Name = "btn_SeeMdp"
        Me.btn_SeeMdp.Size = New System.Drawing.Size(18, 23)
        Me.btn_SeeMdp.TabIndex = 18
        Me.btn_SeeMdp.Text = "0"
        Me.btn_SeeMdp.UseVisualStyleBackColor = True
        '
        'btn_ChangeMdp
        '
        Me.btn_ChangeMdp.Cursor = System.Windows.Forms.Cursors.PanEast
        Me.btn_ChangeMdp.Location = New System.Drawing.Point(732, 12)
        Me.btn_ChangeMdp.Name = "btn_ChangeMdp"
        Me.btn_ChangeMdp.Size = New System.Drawing.Size(26, 23)
        Me.btn_ChangeMdp.TabIndex = 19
        Me.btn_ChangeMdp.Text = ">"
        Me.btn_ChangeMdp.UseVisualStyleBackColor = True
        '
        'frm_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 558)
        Me.Controls.Add(Me.btn_ChangeMdp)
        Me.Controls.Add(Me.btn_SeeMdp)
        Me.Controls.Add(Me.lbl_Mdp)
        Me.Controls.Add(Me.btn_CreateUser)
        Me.Controls.Add(Me.lstV_Users)
        Me.Controls.Add(Me.btn_deco)
        Me.Controls.Add(Me.btn_Default)
        Me.Controls.Add(Me.btn_Valider)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.grpB_reset)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_InfoMdp)
        Me.Controls.Add(Me.progressBar_Mdp)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "frm_principal"
        Me.Text = "GSB-Admin"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpB_reset.ResumeLayout(False)
        Me.grpB_reset.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents progressBar_Mdp As System.Windows.Forms.ProgressBar
    Friend WithEvents lbl_InfoMdp As System.Windows.Forms.Label
    Friend WithEvents rb_AllUser As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Visiteur As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Comptable As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grpB_reset As System.Windows.Forms.GroupBox
    Friend WithEvents rb_ResetNo As System.Windows.Forms.RadioButton
    Friend WithEvents rb_resetYes As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Reset As System.Windows.Forms.RadioButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btn_Valider As System.Windows.Forms.Button
    Friend WithEvents btn_Default As System.Windows.Forms.Button
    Friend WithEvents btn_deco As System.Windows.Forms.Button
    Friend WithEvents lstV_Users As System.Windows.Forms.ListView
    Friend WithEvents btn_CreateUser As System.Windows.Forms.Button
    Friend WithEvents lbl_Mdp As System.Windows.Forms.Label
    Friend WithEvents btn_SeeMdp As System.Windows.Forms.Button
    Friend WithEvents btn_ChangeMdp As System.Windows.Forms.Button

End Class
