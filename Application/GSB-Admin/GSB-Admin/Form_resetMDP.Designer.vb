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
        Me.tb_mdpchange = New System.Windows.Forms.TextBox()
        Me.tb_confirmMdp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.progressBar_Mdp = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstV_visiteur = New System.Windows.Forms.ListView()
        Me.ColumnNom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnPrenom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnDateEmbauche = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.bt_Select = New System.Windows.Forms.Button()
        Me.lb_infosUser = New System.Windows.Forms.Label()
        Me.lb_upper = New System.Windows.Forms.Label()
        Me.lb_symbols = New System.Windows.Forms.Label()
        Me.lb_number = New System.Windows.Forms.Label()
        Me.lb_carac = New System.Windows.Forms.Label()
        Me.lb_minus = New System.Windows.Forms.Label()
        Me.ColumnId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'cbx_showhide
        '
        Me.cbx_showhide.AutoSize = True
        Me.cbx_showhide.Location = New System.Drawing.Point(750, 82)
        Me.cbx_showhide.Name = "cbx_showhide"
        Me.cbx_showhide.Size = New System.Drawing.Size(108, 17)
        Me.cbx_showhide.TabIndex = 30
        Me.cbx_showhide.Text = "Afficher/Masquer"
        Me.cbx_showhide.UseVisualStyleBackColor = True
        '
        'lbl_Mdp
        '
        Me.lbl_Mdp.AutoSize = True
        Me.lbl_Mdp.Location = New System.Drawing.Point(615, 63)
        Me.lbl_Mdp.Name = "lbl_Mdp"
        Me.lbl_Mdp.Size = New System.Drawing.Size(71, 13)
        Me.lbl_Mdp.TabIndex = 29
        Me.lbl_Mdp.Text = "Mot de passe"
        '
        'btn_Default
        '
        Me.btn_Default.Location = New System.Drawing.Point(663, 293)
        Me.btn_Default.Name = "btn_Default"
        Me.btn_Default.Size = New System.Drawing.Size(75, 26)
        Me.btn_Default.TabIndex = 28
        Me.btn_Default.Text = "Par défaut"
        Me.btn_Default.UseVisualStyleBackColor = True
        '
        'btn_Valider
        '
        Me.btn_Valider.Location = New System.Drawing.Point(570, 293)
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
        'tb_mdpchange
        '
        Me.tb_mdpchange.Location = New System.Drawing.Point(570, 79)
        Me.tb_mdpchange.Name = "tb_mdpchange"
        Me.tb_mdpchange.Size = New System.Drawing.Size(174, 20)
        Me.tb_mdpchange.TabIndex = 24
        Me.tb_mdpchange.UseSystemPasswordChar = True
        '
        'tb_confirmMdp
        '
        Me.tb_confirmMdp.Location = New System.Drawing.Point(570, 123)
        Me.tb_confirmMdp.Name = "tb_confirmMdp"
        Me.tb_confirmMdp.Size = New System.Drawing.Size(174, 20)
        Me.tb_confirmMdp.TabIndex = 31
        Me.tb_confirmMdp.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(571, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Confirmer le nouveau mot de passe"
        '
        'progressBar_Mdp
        '
        Me.progressBar_Mdp.Location = New System.Drawing.Point(642, 149)
        Me.progressBar_Mdp.Name = "progressBar_Mdp"
        Me.progressBar_Mdp.Size = New System.Drawing.Size(96, 10)
        Me.progressBar_Mdp.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(567, 162)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 23)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Le mot de passe doit contenir minimum :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lstV_visiteur
        '
        Me.lstV_visiteur.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnId, Me.ColumnNom, Me.ColumnPrenom, Me.ColumnDateEmbauche})
        Me.lstV_visiteur.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstV_visiteur.FullRowSelect = True
        Me.lstV_visiteur.Location = New System.Drawing.Point(6, 9)
        Me.lstV_visiteur.MultiSelect = False
        Me.lstV_visiteur.Name = "lstV_visiteur"
        Me.lstV_visiteur.Size = New System.Drawing.Size(492, 281)
        Me.lstV_visiteur.TabIndex = 53
        Me.lstV_visiteur.UseCompatibleStateImageBehavior = False
        Me.lstV_visiteur.View = System.Windows.Forms.View.Details
        '
        'ColumnNom
        '
        Me.ColumnNom.Text = "Nom"
        Me.ColumnNom.Width = 149
        '
        'ColumnPrenom
        '
        Me.ColumnPrenom.Text = "Prénom"
        Me.ColumnPrenom.Width = 159
        '
        'ColumnDateEmbauche
        '
        Me.ColumnDateEmbauche.Text = "Date d'embauche"
        Me.ColumnDateEmbauche.Width = 132
        '
        'bt_Select
        '
        Me.bt_Select.Location = New System.Drawing.Point(197, 310)
        Me.bt_Select.Name = "bt_Select"
        Me.bt_Select.Size = New System.Drawing.Size(75, 23)
        Me.bt_Select.TabIndex = 55
        Me.bt_Select.Text = "Confirmer"
        Me.bt_Select.UseVisualStyleBackColor = True
        '
        'lb_infosUser
        '
        Me.lb_infosUser.AutoSize = True
        Me.lb_infosUser.Location = New System.Drawing.Point(574, 9)
        Me.lb_infosUser.Name = "lb_infosUser"
        Me.lb_infosUser.Size = New System.Drawing.Size(13, 13)
        Me.lb_infosUser.TabIndex = 56
        Me.lb_infosUser.Text = "?"
        '
        'lb_upper
        '
        Me.lb_upper.AutoSize = True
        Me.lb_upper.ForeColor = System.Drawing.Color.DimGray
        Me.lb_upper.Location = New System.Drawing.Point(580, 218)
        Me.lb_upper.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_upper.Name = "lb_upper"
        Me.lb_upper.Size = New System.Drawing.Size(74, 13)
        Me.lb_upper.TabIndex = 59
        Me.lb_upper.Text = "·2 majuscules "
        '
        'lb_symbols
        '
        Me.lb_symbols.AutoSize = True
        Me.lb_symbols.ForeColor = System.Drawing.Color.DimGray
        Me.lb_symbols.Location = New System.Drawing.Point(580, 246)
        Me.lb_symbols.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_symbols.Name = "lb_symbols"
        Me.lb_symbols.Size = New System.Drawing.Size(100, 13)
        Me.lb_symbols.TabIndex = 58
        Me.lb_symbols.Text = "·2 caractère spécial"
        '
        'lb_number
        '
        Me.lb_number.AutoSize = True
        Me.lb_number.ForeColor = System.Drawing.Color.DimGray
        Me.lb_number.Location = New System.Drawing.Point(580, 232)
        Me.lb_number.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_number.Name = "lb_number"
        Me.lb_number.Size = New System.Drawing.Size(53, 13)
        Me.lb_number.TabIndex = 57
        Me.lb_number.Text = "·2 chiffres"
        '
        'lb_carac
        '
        Me.lb_carac.AutoSize = True
        Me.lb_carac.ForeColor = System.Drawing.Color.DimGray
        Me.lb_carac.Location = New System.Drawing.Point(580, 185)
        Me.lb_carac.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_carac.Name = "lb_carac"
        Me.lb_carac.Size = New System.Drawing.Size(69, 13)
        Me.lb_carac.TabIndex = 35
        Me.lb_carac.Text = "·8 caractères"
        '
        'lb_minus
        '
        Me.lb_minus.AutoSize = True
        Me.lb_minus.ForeColor = System.Drawing.Color.DimGray
        Me.lb_minus.Location = New System.Drawing.Point(580, 205)
        Me.lb_minus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_minus.Name = "lb_minus"
        Me.lb_minus.Size = New System.Drawing.Size(74, 13)
        Me.lb_minus.TabIndex = 60
        Me.lb_minus.Text = "·2 minuscules "
        '
        'ColumnId
        '
        Me.ColumnId.Text = "N°"
        Me.ColumnId.Width = 44
        '
        'Form_resetMDP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 359)
        Me.Controls.Add(Me.lb_minus)
        Me.Controls.Add(Me.lb_upper)
        Me.Controls.Add(Me.lb_symbols)
        Me.Controls.Add(Me.lb_number)
        Me.Controls.Add(Me.lb_infosUser)
        Me.Controls.Add(Me.bt_Select)
        Me.Controls.Add(Me.lstV_visiteur)
        Me.Controls.Add(Me.lb_carac)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_confirmMdp)
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
        Me.Text = "Réinitialisation d'un mot de passe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbx_showhide As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Mdp As System.Windows.Forms.Label
    Friend WithEvents btn_Default As System.Windows.Forms.Button
    Friend WithEvents btn_Valider As System.Windows.Forms.Button
    Friend WithEvents lbl_InfoMdp As System.Windows.Forms.Label
    Friend WithEvents tb_mdpchange As System.Windows.Forms.TextBox
    Friend WithEvents tb_confirmMdp As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents progressBar_Mdp As System.Windows.Forms.ProgressBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstV_visiteur As System.Windows.Forms.ListView
    Friend WithEvents ColumnNom As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnPrenom As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnDateEmbauche As System.Windows.Forms.ColumnHeader
    Friend WithEvents bt_Select As System.Windows.Forms.Button
    Friend WithEvents lb_infosUser As System.Windows.Forms.Label
    Friend WithEvents lb_upper As System.Windows.Forms.Label
    Friend WithEvents lb_symbols As System.Windows.Forms.Label
    Friend WithEvents lb_number As System.Windows.Forms.Label
    Friend WithEvents lb_carac As System.Windows.Forms.Label
    Friend WithEvents lb_minus As System.Windows.Forms.Label
    Friend WithEvents ColumnId As System.Windows.Forms.ColumnHeader
End Class
