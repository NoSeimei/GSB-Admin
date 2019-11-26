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
        Me.tb_Confirmation = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgw_Utilisateurs = New System.Windows.Forms.DataGridView()
        Me.tb_Rech = New System.Windows.Forms.TextBox()
        Me.Btn_Select = New System.Windows.Forms.Button()
        CType(Me.dgw_Utilisateurs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbx_showhide
        '
        Me.cbx_showhide.AutoSize = True
        Me.cbx_showhide.Location = New System.Drawing.Point(601, 104)
        Me.cbx_showhide.Name = "cbx_showhide"
        Me.cbx_showhide.Size = New System.Drawing.Size(108, 17)
        Me.cbx_showhide.TabIndex = 30
        Me.cbx_showhide.Text = "Afficher/Masquer"
        Me.cbx_showhide.UseVisualStyleBackColor = True
        '
        'lbl_Mdp
        '
        Me.lbl_Mdp.AutoSize = True
        Me.lbl_Mdp.Location = New System.Drawing.Point(422, 85)
        Me.lbl_Mdp.Name = "lbl_Mdp"
        Me.lbl_Mdp.Size = New System.Drawing.Size(71, 13)
        Me.lbl_Mdp.TabIndex = 29
        Me.lbl_Mdp.Text = "Mot de passe"
        '
        'btn_Default
        '
        Me.btn_Default.Location = New System.Drawing.Point(508, 209)
        Me.btn_Default.Name = "btn_Default"
        Me.btn_Default.Size = New System.Drawing.Size(87, 26)
        Me.btn_Default.TabIndex = 28
        Me.btn_Default.Text = "Par défaut"
        Me.btn_Default.UseVisualStyleBackColor = True
        '
        'btn_Valider
        '
        Me.btn_Valider.Location = New System.Drawing.Point(425, 209)
        Me.btn_Valider.Name = "btn_Valider"
        Me.btn_Valider.Size = New System.Drawing.Size(77, 26)
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
        Me.progressBar_Mdp.Location = New System.Drawing.Point(425, 127)
        Me.progressBar_Mdp.Name = "progressBar_Mdp"
        Me.progressBar_Mdp.Size = New System.Drawing.Size(96, 10)
        Me.progressBar_Mdp.TabIndex = 25
        '
        'tb_mdpchange
        '
        Me.tb_mdpchange.Location = New System.Drawing.Point(421, 101)
        Me.tb_mdpchange.Name = "tb_mdpchange"
        Me.tb_mdpchange.Size = New System.Drawing.Size(174, 20)
        Me.tb_mdpchange.TabIndex = 24
        Me.tb_mdpchange.UseSystemPasswordChar = True
        '
        'tb_Confirmation
        '
        Me.tb_Confirmation.Location = New System.Drawing.Point(425, 183)
        Me.tb_Confirmation.Name = "tb_Confirmation"
        Me.tb_Confirmation.Size = New System.Drawing.Size(174, 20)
        Me.tb_Confirmation.TabIndex = 31
        Me.tb_Confirmation.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(422, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Confirmer le nouveau mot de passe"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(661, 312)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 23)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "&Annuler"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgw_Utilisateurs
        '
        Me.dgw_Utilisateurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw_Utilisateurs.Location = New System.Drawing.Point(35, 85)
        Me.dgw_Utilisateurs.Name = "dgw_Utilisateurs"
        Me.dgw_Utilisateurs.Size = New System.Drawing.Size(339, 221)
        Me.dgw_Utilisateurs.TabIndex = 34
        '
        'tb_Rech
        '
        Me.tb_Rech.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tb_Rech.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tb_Rech.Location = New System.Drawing.Point(35, 59)
        Me.tb_Rech.Name = "tb_Rech"
        Me.tb_Rech.Size = New System.Drawing.Size(143, 20)
        Me.tb_Rech.TabIndex = 35
        '
        'Btn_Select
        '
        Me.Btn_Select.Location = New System.Drawing.Point(35, 312)
        Me.Btn_Select.Name = "Btn_Select"
        Me.Btn_Select.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Select.TabIndex = 36
        Me.Btn_Select.Text = "Sélectionner"
        Me.Btn_Select.UseVisualStyleBackColor = True
        '
        'Form_resetMDP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 347)
        Me.Controls.Add(Me.Btn_Select)
        Me.Controls.Add(Me.tb_Rech)
        Me.Controls.Add(Me.dgw_Utilisateurs)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_Confirmation)
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
        CType(Me.dgw_Utilisateurs, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents tb_Confirmation As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgw_Utilisateurs As System.Windows.Forms.DataGridView
    Friend WithEvents tb_Rech As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Select As System.Windows.Forms.Button
End Class
