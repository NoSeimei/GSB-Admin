<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_Principal
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
        Me.lbl_InfoMdp = New System.Windows.Forms.Label()
        Me.rb_AllUser = New System.Windows.Forms.RadioButton()
        Me.rb_Visiteur = New System.Windows.Forms.RadioButton()
        Me.rb_Comptable = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.lstV_visiteur = New System.Windows.Forms.ListView()
        Me.ColumnNom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnPrenom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClicDroit = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OUiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LacheMoiMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.ClicDroit.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_InfoMdp
        '
        Me.lbl_InfoMdp.AutoSize = True
        Me.lbl_InfoMdp.Location = New System.Drawing.Point(509, 269)
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
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'lstV_visiteur
        '
        Me.lstV_visiteur.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnNom, Me.ColumnPrenom, Me.ColumnType})
        Me.lstV_visiteur.ContextMenuStrip = Me.ClicDroit
        Me.lstV_visiteur.FullRowSelect = True
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
        'ClicDroit
        '
        Me.ClicDroit.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OUiToolStripMenuItem, Me.LacheMoiMToolStripMenuItem})
        Me.ClicDroit.Name = "ContextMenuStrip2"
        Me.ClicDroit.Size = New System.Drawing.Size(130, 48)
        '
        'OUiToolStripMenuItem
        '
        Me.OUiToolStripMenuItem.Name = "OUiToolStripMenuItem"
        Me.OUiToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.OUiToolStripMenuItem.Text = "Modifier"
        '
        'LacheMoiMToolStripMenuItem
        '
        Me.LacheMoiMToolStripMenuItem.Name = "LacheMoiMToolStripMenuItem"
        Me.LacheMoiMToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.LacheMoiMToolStripMenuItem.Text = "Supprimer"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(317, 462)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 23)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Réinitialiser le mot de passe"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'form_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 516)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lstV_visiteur)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_InfoMdp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "form_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GSB-Admin"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ClicDroit.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_InfoMdp As System.Windows.Forms.Label
    Friend WithEvents rb_AllUser As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Visiteur As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Comptable As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents lstV_visiteur As System.Windows.Forms.ListView
    Friend WithEvents ColumnNom As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnPrenom As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnType As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClicDroit As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OUiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LacheMoiMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
