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
        Me.components = New System.ComponentModel.Container()
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Jean", "Oui", "Visteur"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.MenuHighlight, Nothing)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Benoit", "Patrick", "Comptable"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.Window, Nothing)
        Me.tb_mdpchange = New System.Windows.Forms.TextBox()
        Me.progressBar_Mdp = New System.Windows.Forms.ProgressBar()
        Me.lbl_InfoMdp = New System.Windows.Forms.Label()
        Me.rb_AllUser = New System.Windows.Forms.RadioButton()
        Me.rb_Visiteur = New System.Windows.Forms.RadioButton()
        Me.rb_Comptable = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_Valider = New System.Windows.Forms.Button()
        Me.btn_Default = New System.Windows.Forms.Button()
        Me.btn_deco = New System.Windows.Forms.Button()
        Me.lbl_Mdp = New System.Windows.Forms.Label()
        Me.btn_ChangeMdp = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.lstV_visiteur = New System.Windows.Forms.ListView()
        Me.ColumnNom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnPrenom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cbx_showhide = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tb_mdpchange
        '
        Me.tb_mdpchange.Location = New System.Drawing.Point(512, 231)
        Me.tb_mdpchange.Name = "tb_mdpchange"
        Me.tb_mdpchange.Size = New System.Drawing.Size(174, 20)
        Me.tb_mdpchange.TabIndex = 2
        Me.tb_mdpchange.UseSystemPasswordChar = True
        '
        'progressBar_Mdp
        '
        Me.progressBar_Mdp.Location = New System.Drawing.Point(590, 257)
        Me.progressBar_Mdp.Name = "progressBar_Mdp"
        Me.progressBar_Mdp.Size = New System.Drawing.Size(96, 10)
        Me.progressBar_Mdp.TabIndex = 4
        Me.progressBar_Mdp.Value = 10
        '
        'lbl_InfoMdp
        '
        Me.lbl_InfoMdp.AutoSize = True
        Me.lbl_InfoMdp.Location = New System.Drawing.Point(562, 241)
        Me.lbl_InfoMdp.Name = "lbl_InfoMdp"
        Me.lbl_InfoMdp.Size = New System.Drawing.Size(0, 13)
        Me.lbl_InfoMdp.TabIndex = 5
        '
        'rb_AllUser
        '
        Me.rb_AllUser.AutoSize = True
        Me.rb_AllUser.Checked = True
        Me.rb_AllUser.Location = New System.Drawing.Point(16, 21)
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
        Me.rb_Visiteur.Location = New System.Drawing.Point(86, 21)
        Me.rb_Visiteur.Name = "rb_Visiteur"
        Me.rb_Visiteur.Size = New System.Drawing.Size(59, 17)
        Me.rb_Visiteur.TabIndex = 7
        Me.rb_Visiteur.Text = "Visiteur"
        Me.rb_Visiteur.UseVisualStyleBackColor = True
        '
        'rb_Comptable
        '
        Me.rb_Comptable.AutoSize = True
        Me.rb_Comptable.Location = New System.Drawing.Point(162, 21)
        Me.rb_Comptable.Name = "rb_Comptable"
        Me.rb_Comptable.Size = New System.Drawing.Size(75, 17)
        Me.rb_Comptable.TabIndex = 8
        Me.rb_Comptable.Text = "Comptable"
        Me.rb_Comptable.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_Visiteur)
        Me.GroupBox1.Controls.Add(Me.rb_Comptable)
        Me.GroupBox1.Controls.Add(Me.rb_AllUser)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(246, 44)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Les utilisateurs"
        '
        'btn_Valider
        '
        Me.btn_Valider.Location = New System.Drawing.Point(537, 291)
        Me.btn_Valider.Name = "btn_Valider"
        Me.btn_Valider.Size = New System.Drawing.Size(75, 23)
        Me.btn_Valider.TabIndex = 12
        Me.btn_Valider.Text = "Valider"
        Me.btn_Valider.UseVisualStyleBackColor = True
        '
        'btn_Default
        '
        Me.btn_Default.Location = New System.Drawing.Point(618, 291)
        Me.btn_Default.Name = "btn_Default"
        Me.btn_Default.Size = New System.Drawing.Size(75, 23)
        Me.btn_Default.TabIndex = 13
        Me.btn_Default.Text = "Par défaut"
        Me.btn_Default.UseVisualStyleBackColor = True
        '
        'btn_deco
        '
        Me.btn_deco.Location = New System.Drawing.Point(187, 501)
        Me.btn_deco.Name = "btn_deco"
        Me.btn_deco.Size = New System.Drawing.Size(109, 38)
        Me.btn_deco.TabIndex = 14
        Me.btn_deco.Text = "Déconnexion"
        Me.btn_deco.UseVisualStyleBackColor = True
        '
        'lbl_Mdp
        '
        Me.lbl_Mdp.AutoSize = True
        Me.lbl_Mdp.Location = New System.Drawing.Point(509, 205)
        Me.lbl_Mdp.Name = "lbl_Mdp"
        Me.lbl_Mdp.Size = New System.Drawing.Size(71, 13)
        Me.lbl_Mdp.TabIndex = 17
        Me.lbl_Mdp.Text = "Mot de passe"
        '
        'btn_ChangeMdp
        '
        Me.btn_ChangeMdp.Location = New System.Drawing.Point(444, 48)
        Me.btn_ChangeMdp.Name = "btn_ChangeMdp"
        Me.btn_ChangeMdp.Size = New System.Drawing.Size(26, 23)
        Me.btn_ChangeMdp.TabIndex = 19
        Me.btn_ChangeMdp.Text = "&>"
        Me.btn_ChangeMdp.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(483, 24)
        Me.MenuStrip1.TabIndex = 21
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(158, 20)
        Me.ToolStripMenuItem1.Text = "Créer un nouvel utilisateur"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Margin = New System.Windows.Forms.Padding(230, 0, 0, 0)
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(86, 20)
        Me.ToolStripMenuItem2.Text = "À propos de "
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(302, 451)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(160, 17)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Uniquement les demandeurs"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'lstV_visiteur
        '
        Me.lstV_visiteur.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnNom, Me.ColumnPrenom, Me.ColumnType})
        Me.lstV_visiteur.FullRowSelect = True
        Me.lstV_visiteur.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem5, ListViewItem6})
        Me.lstV_visiteur.Location = New System.Drawing.Point(25, 124)
        Me.lstV_visiteur.MultiSelect = False
        Me.lstV_visiteur.Name = "lstV_visiteur"
        Me.lstV_visiteur.Size = New System.Drawing.Size(437, 321)
        Me.lstV_visiteur.TabIndex = 22
        Me.lstV_visiteur.UseCompatibleStateImageBehavior = False
        Me.lstV_visiteur.UseWaitCursor = True
        Me.lstV_visiteur.View = System.Windows.Forms.View.Details
        '
        'ColumnNom
        '
        Me.ColumnNom.Text = "Nom"
        Me.ColumnNom.Width = 148
        '
        'ColumnPrenom
        '
        Me.ColumnPrenom.Text = "Prénom"
        Me.ColumnPrenom.Width = 153
        '
        'ColumnType
        '
        Me.ColumnType.Text = "Type"
        Me.ColumnType.Width = 132
        '
        'cbx_showhide
        '
        Me.cbx_showhide.AutoSize = True
        Me.cbx_showhide.Location = New System.Drawing.Point(692, 231)
        Me.cbx_showhide.Name = "cbx_showhide"
        Me.cbx_showhide.Size = New System.Drawing.Size(108, 17)
        Me.cbx_showhide.TabIndex = 23
        Me.cbx_showhide.Text = "Afficher/Masquer"
        Me.cbx_showhide.UseVisualStyleBackColor = True
        '
        'frm_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 551)
        Me.Controls.Add(Me.cbx_showhide)
        Me.Controls.Add(Me.lstV_visiteur)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btn_ChangeMdp)
        Me.Controls.Add(Me.lbl_Mdp)
        Me.Controls.Add(Me.btn_deco)
        Me.Controls.Add(Me.btn_Default)
        Me.Controls.Add(Me.btn_Valider)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_InfoMdp)
        Me.Controls.Add(Me.progressBar_Mdp)
        Me.Controls.Add(Me.tb_mdpchange)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_principal"
        Me.Text = "GSB-Admin"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_mdpchange As System.Windows.Forms.TextBox
    Friend WithEvents progressBar_Mdp As System.Windows.Forms.ProgressBar
    Friend WithEvents lbl_InfoMdp As System.Windows.Forms.Label
    Friend WithEvents rb_AllUser As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Visiteur As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Comptable As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Valider As System.Windows.Forms.Button
    Friend WithEvents btn_Default As System.Windows.Forms.Button
    Friend WithEvents btn_deco As System.Windows.Forms.Button
    Friend WithEvents lbl_Mdp As System.Windows.Forms.Label
    Friend WithEvents btn_ChangeMdp As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstV_visiteur As System.Windows.Forms.ListView
    Friend WithEvents ColumnNom As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnPrenom As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnType As System.Windows.Forms.ColumnHeader
    Friend WithEvents cbx_showhide As System.Windows.Forms.CheckBox

End Class
