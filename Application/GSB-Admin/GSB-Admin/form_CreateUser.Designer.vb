<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_CreateUser
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
        Me.btn_Submit = New System.Windows.Forms.Button()
        Me.btn_return = New System.Windows.Forms.Button()
        Me.lbl_Name = New System.Windows.Forms.Label()
        Me.txtB_name = New System.Windows.Forms.TextBox()
        Me.txt_Prenom = New System.Windows.Forms.TextBox()
        Me.lbl_prenom = New System.Windows.Forms.Label()
        Me.txtB_Login = New System.Windows.Forms.TextBox()
        Me.lbl_Login = New System.Windows.Forms.Label()
        Me.txtB_MDP = New System.Windows.Forms.TextBox()
        Me.lbl_Mdp = New System.Windows.Forms.Label()
        Me.txtB_Adresse = New System.Windows.Forms.TextBox()
        Me.lbl_Adr = New System.Windows.Forms.Label()
        Me.txtB_CodePostal = New System.Windows.Forms.TextBox()
        Me.lbl_CodePostal = New System.Windows.Forms.Label()
        Me.txtB_Ville = New System.Windows.Forms.TextBox()
        Me.lbl_Ville = New System.Windows.Forms.Label()
        Me.lbl_DateEmbauche = New System.Windows.Forms.Label()
        Me.grpb_TypeUser = New System.Windows.Forms.GroupBox()
        Me.rb_Visiteur = New System.Windows.Forms.RadioButton()
        Me.rb_Comptable = New System.Windows.Forms.RadioButton()
        Me.date_DateEmbauche = New System.Windows.Forms.DateTimePicker()
        Me.lstV_Voitures = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbl_InfoMdp = New System.Windows.Forms.Label()
        Me.progressBar_Mdp = New System.Windows.Forms.ProgressBar()
        Me.lbl_Voitures = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gb_login = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtB_ConfirmMDP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dateDebutLoc = New System.Windows.Forms.DateTimePicker()
        Me.dateFinLocation = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.checkBox_AffichAllVehicule = New System.Windows.Forms.CheckBox()
        Me.grpb_TypeUser.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gb_login.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Submit
        '
        Me.btn_Submit.Location = New System.Drawing.Point(130, 615)
        Me.btn_Submit.Name = "btn_Submit"
        Me.btn_Submit.Size = New System.Drawing.Size(83, 32)
        Me.btn_Submit.TabIndex = 0
        Me.btn_Submit.Text = "Valider"
        Me.btn_Submit.UseVisualStyleBackColor = True
        '
        'btn_return
        '
        Me.btn_return.Location = New System.Drawing.Point(10, 672)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(75, 23)
        Me.btn_return.TabIndex = 1
        Me.btn_return.Text = "&Annuler"
        Me.btn_return.UseVisualStyleBackColor = True
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.Location = New System.Drawing.Point(67, 27)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(29, 13)
        Me.lbl_Name.TabIndex = 2
        Me.lbl_Name.Text = "Nom"
        '
        'txtB_name
        '
        Me.txtB_name.Location = New System.Drawing.Point(102, 24)
        Me.txtB_name.Name = "txtB_name"
        Me.txtB_name.Size = New System.Drawing.Size(148, 20)
        Me.txtB_name.TabIndex = 3
        '
        'txt_Prenom
        '
        Me.txt_Prenom.Location = New System.Drawing.Point(102, 68)
        Me.txt_Prenom.Name = "txt_Prenom"
        Me.txt_Prenom.Size = New System.Drawing.Size(148, 20)
        Me.txt_Prenom.TabIndex = 5
        '
        'lbl_prenom
        '
        Me.lbl_prenom.AutoSize = True
        Me.lbl_prenom.Location = New System.Drawing.Point(53, 71)
        Me.lbl_prenom.Name = "lbl_prenom"
        Me.lbl_prenom.Size = New System.Drawing.Size(43, 13)
        Me.lbl_prenom.TabIndex = 4
        Me.lbl_prenom.Text = "Prénom"
        '
        'txtB_Login
        '
        Me.txtB_Login.Location = New System.Drawing.Point(158, 23)
        Me.txtB_Login.Name = "txtB_Login"
        Me.txtB_Login.Size = New System.Drawing.Size(148, 20)
        Me.txtB_Login.TabIndex = 7
        '
        'lbl_Login
        '
        Me.lbl_Login.AutoSize = True
        Me.lbl_Login.Location = New System.Drawing.Point(61, 25)
        Me.lbl_Login.Name = "lbl_Login"
        Me.lbl_Login.Size = New System.Drawing.Size(36, 13)
        Me.lbl_Login.TabIndex = 6
        Me.lbl_Login.Text = "Login "
        '
        'txtB_MDP
        '
        Me.txtB_MDP.Location = New System.Drawing.Point(158, 63)
        Me.txtB_MDP.Name = "txtB_MDP"
        Me.txtB_MDP.Size = New System.Drawing.Size(148, 20)
        Me.txtB_MDP.TabIndex = 9
        '
        'lbl_Mdp
        '
        Me.lbl_Mdp.AutoSize = True
        Me.lbl_Mdp.Location = New System.Drawing.Point(47, 66)
        Me.lbl_Mdp.Name = "lbl_Mdp"
        Me.lbl_Mdp.Size = New System.Drawing.Size(71, 13)
        Me.lbl_Mdp.TabIndex = 8
        Me.lbl_Mdp.Text = "Mot de passe"
        '
        'txtB_Adresse
        '
        Me.txtB_Adresse.Location = New System.Drawing.Point(101, 107)
        Me.txtB_Adresse.Name = "txtB_Adresse"
        Me.txtB_Adresse.Size = New System.Drawing.Size(148, 20)
        Me.txtB_Adresse.TabIndex = 11
        '
        'lbl_Adr
        '
        Me.lbl_Adr.AutoSize = True
        Me.lbl_Adr.Location = New System.Drawing.Point(53, 110)
        Me.lbl_Adr.Name = "lbl_Adr"
        Me.lbl_Adr.Size = New System.Drawing.Size(45, 13)
        Me.lbl_Adr.TabIndex = 10
        Me.lbl_Adr.Text = "Adresse"
        '
        'txtB_CodePostal
        '
        Me.txtB_CodePostal.Location = New System.Drawing.Point(101, 146)
        Me.txtB_CodePostal.Name = "txtB_CodePostal"
        Me.txtB_CodePostal.Size = New System.Drawing.Size(72, 20)
        Me.txtB_CodePostal.TabIndex = 13
        '
        'lbl_CodePostal
        '
        Me.lbl_CodePostal.AutoSize = True
        Me.lbl_CodePostal.Location = New System.Drawing.Point(34, 149)
        Me.lbl_CodePostal.Name = "lbl_CodePostal"
        Me.lbl_CodePostal.Size = New System.Drawing.Size(64, 13)
        Me.lbl_CodePostal.TabIndex = 12
        Me.lbl_CodePostal.Text = "Code Postal"
        '
        'txtB_Ville
        '
        Me.txtB_Ville.Location = New System.Drawing.Point(101, 186)
        Me.txtB_Ville.Name = "txtB_Ville"
        Me.txtB_Ville.Size = New System.Drawing.Size(151, 20)
        Me.txtB_Ville.TabIndex = 15
        '
        'lbl_Ville
        '
        Me.lbl_Ville.AutoSize = True
        Me.lbl_Ville.Location = New System.Drawing.Point(72, 189)
        Me.lbl_Ville.Name = "lbl_Ville"
        Me.lbl_Ville.Size = New System.Drawing.Size(26, 13)
        Me.lbl_Ville.TabIndex = 14
        Me.lbl_Ville.Text = "Ville"
        '
        'lbl_DateEmbauche
        '
        Me.lbl_DateEmbauche.AutoSize = True
        Me.lbl_DateEmbauche.Location = New System.Drawing.Point(4, 230)
        Me.lbl_DateEmbauche.Name = "lbl_DateEmbauche"
        Me.lbl_DateEmbauche.Size = New System.Drawing.Size(91, 13)
        Me.lbl_DateEmbauche.TabIndex = 16
        Me.lbl_DateEmbauche.Text = "Date d'embauche"
        '
        'grpb_TypeUser
        '
        Me.grpb_TypeUser.Controls.Add(Me.rb_Visiteur)
        Me.grpb_TypeUser.Controls.Add(Me.rb_Comptable)
        Me.grpb_TypeUser.Location = New System.Drawing.Point(85, 277)
        Me.grpb_TypeUser.Name = "grpb_TypeUser"
        Me.grpb_TypeUser.Size = New System.Drawing.Size(168, 58)
        Me.grpb_TypeUser.TabIndex = 18
        Me.grpb_TypeUser.TabStop = False
        Me.grpb_TypeUser.Text = "Type d'utilisateur"
        '
        'rb_Visiteur
        '
        Me.rb_Visiteur.AutoSize = True
        Me.rb_Visiteur.Location = New System.Drawing.Point(13, 28)
        Me.rb_Visiteur.Name = "rb_Visiteur"
        Me.rb_Visiteur.Size = New System.Drawing.Size(59, 17)
        Me.rb_Visiteur.TabIndex = 9
        Me.rb_Visiteur.Text = "Visiteur"
        Me.rb_Visiteur.UseVisualStyleBackColor = True
        '
        'rb_Comptable
        '
        Me.rb_Comptable.AutoSize = True
        Me.rb_Comptable.Checked = True
        Me.rb_Comptable.Location = New System.Drawing.Point(89, 28)
        Me.rb_Comptable.Name = "rb_Comptable"
        Me.rb_Comptable.Size = New System.Drawing.Size(75, 17)
        Me.rb_Comptable.TabIndex = 8
        Me.rb_Comptable.TabStop = True
        Me.rb_Comptable.Text = "Comptable"
        Me.rb_Comptable.UseVisualStyleBackColor = True
        '
        'date_DateEmbauche
        '
        Me.date_DateEmbauche.Location = New System.Drawing.Point(101, 224)
        Me.date_DateEmbauche.Name = "date_DateEmbauche"
        Me.date_DateEmbauche.Size = New System.Drawing.Size(192, 20)
        Me.date_DateEmbauche.TabIndex = 20
        '
        'lstV_Voitures
        '
        Me.lstV_Voitures.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lstV_Voitures.FullRowSelect = True
        Me.lstV_Voitures.Location = New System.Drawing.Point(436, 206)
        Me.lstV_Voitures.Name = "lstV_Voitures"
        Me.lstV_Voitures.Size = New System.Drawing.Size(272, 327)
        Me.lstV_Voitures.TabIndex = 21
        Me.lstV_Voitures.UseCompatibleStateImageBehavior = False
        Me.lstV_Voitures.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Matricule"
        Me.ColumnHeader1.Width = 91
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Puissance"
        Me.ColumnHeader2.Width = 71
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Marque"
        Me.ColumnHeader3.Width = 106
        '
        'lbl_InfoMdp
        '
        Me.lbl_InfoMdp.AutoSize = True
        Me.lbl_InfoMdp.Location = New System.Drawing.Point(9, 111)
        Me.lbl_InfoMdp.Name = "lbl_InfoMdp"
        Me.lbl_InfoMdp.Size = New System.Drawing.Size(0, 13)
        Me.lbl_InfoMdp.TabIndex = 23
        '
        'progressBar_Mdp
        '
        Me.progressBar_Mdp.Location = New System.Drawing.Point(188, 88)
        Me.progressBar_Mdp.Name = "progressBar_Mdp"
        Me.progressBar_Mdp.Size = New System.Drawing.Size(90, 11)
        Me.progressBar_Mdp.TabIndex = 22
        '
        'lbl_Voitures
        '
        Me.lbl_Voitures.AutoSize = True
        Me.lbl_Voitures.Location = New System.Drawing.Point(543, 190)
        Me.lbl_Voitures.Name = "lbl_Voitures"
        Me.lbl_Voitures.Size = New System.Drawing.Size(45, 13)
        Me.lbl_Voitures.TabIndex = 24
        Me.lbl_Voitures.Text = "Voitures"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_Name)
        Me.GroupBox1.Controls.Add(Me.txtB_name)
        Me.GroupBox1.Controls.Add(Me.lbl_prenom)
        Me.GroupBox1.Controls.Add(Me.txt_Prenom)
        Me.GroupBox1.Controls.Add(Me.lbl_Adr)
        Me.GroupBox1.Controls.Add(Me.date_DateEmbauche)
        Me.GroupBox1.Controls.Add(Me.txtB_Adresse)
        Me.GroupBox1.Controls.Add(Me.lbl_CodePostal)
        Me.GroupBox1.Controls.Add(Me.lbl_DateEmbauche)
        Me.GroupBox1.Controls.Add(Me.txtB_CodePostal)
        Me.GroupBox1.Controls.Add(Me.txtB_Ville)
        Me.GroupBox1.Controls.Add(Me.lbl_Ville)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(314, 259)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informations"
        '
        'gb_login
        '
        Me.gb_login.Controls.Add(Me.Label8)
        Me.gb_login.Controls.Add(Me.Label7)
        Me.gb_login.Controls.Add(Me.txtB_ConfirmMDP)
        Me.gb_login.Controls.Add(Me.Label5)
        Me.gb_login.Controls.Add(Me.Label4)
        Me.gb_login.Controls.Add(Me.Label6)
        Me.gb_login.Controls.Add(Me.lbl_Login)
        Me.gb_login.Controls.Add(Me.txtB_Login)
        Me.gb_login.Controls.Add(Me.lbl_Mdp)
        Me.gb_login.Controls.Add(Me.lbl_InfoMdp)
        Me.gb_login.Controls.Add(Me.txtB_MDP)
        Me.gb_login.Controls.Add(Me.progressBar_Mdp)
        Me.gb_login.Location = New System.Drawing.Point(25, 341)
        Me.gb_login.Name = "gb_login"
        Me.gb_login.Size = New System.Drawing.Size(321, 267)
        Me.gb_login.TabIndex = 26
        Me.gb_login.TabStop = False
        Me.gb_login.Text = "Authentification"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(66, 180)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "·2 majuscules "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 13)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Confirmation du mot de passe"
        '
        'txtB_ConfirmMDP
        '
        Me.txtB_ConfirmMDP.Location = New System.Drawing.Point(158, 115)
        Me.txtB_ConfirmMDP.Name = "txtB_ConfirmMDP"
        Me.txtB_ConfirmMDP.Size = New System.Drawing.Size(148, 20)
        Me.txtB_ConfirmMDP.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(66, 208)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "·2 caractère spécial"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(66, 194)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "·2 chiffres"
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(47, 150)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(206, 30)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Le mot de passe doit contenir minimum " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "8 caractères avec:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'dateDebutLoc
        '
        Me.dateDebutLoc.Location = New System.Drawing.Point(153, 21)
        Me.dateDebutLoc.Name = "dateDebutLoc"
        Me.dateDebutLoc.Size = New System.Drawing.Size(177, 20)
        Me.dateDebutLoc.TabIndex = 27
        '
        'dateFinLocation
        '
        Me.dateFinLocation.Location = New System.Drawing.Point(153, 66)
        Me.dateFinLocation.Name = "dateFinLocation"
        Me.dateFinLocation.Size = New System.Drawing.Size(177, 20)
        Me.dateFinLocation.TabIndex = 28
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.dateDebutLoc)
        Me.GroupBox3.Controls.Add(Me.dateFinLocation)
        Me.GroupBox3.Location = New System.Drawing.Point(419, 50)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(344, 107)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Location"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Date de fin de la location"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Date de début de la location"
        '
        'checkBox_AffichAllVehicule
        '
        Me.checkBox_AffichAllVehicule.AutoSize = True
        Me.checkBox_AffichAllVehicule.Checked = True
        Me.checkBox_AffichAllVehicule.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox_AffichAllVehicule.Location = New System.Drawing.Point(436, 549)
        Me.checkBox_AffichAllVehicule.Name = "checkBox_AffichAllVehicule"
        Me.checkBox_AffichAllVehicule.Size = New System.Drawing.Size(231, 17)
        Me.checkBox_AffichAllVehicule.TabIndex = 30
        Me.checkBox_AffichAllVehicule.Text = "Afficher uniquement les voitures disponibles"
        Me.checkBox_AffichAllVehicule.UseVisualStyleBackColor = True
        '
        'form_CreateUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 705)
        Me.Controls.Add(Me.checkBox_AffichAllVehicule)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.gb_login)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_Voitures)
        Me.Controls.Add(Me.lstV_Voitures)
        Me.Controls.Add(Me.grpb_TypeUser)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.btn_Submit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "form_CreateUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Création d'un nouvel utilisateur"
        Me.grpb_TypeUser.ResumeLayout(False)
        Me.grpb_TypeUser.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gb_login.ResumeLayout(False)
        Me.gb_login.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Submit As System.Windows.Forms.Button
    Friend WithEvents btn_return As System.Windows.Forms.Button
    Friend WithEvents lbl_Name As System.Windows.Forms.Label
    Friend WithEvents txtB_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_Prenom As System.Windows.Forms.TextBox
    Friend WithEvents lbl_prenom As System.Windows.Forms.Label
    Friend WithEvents txtB_Login As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Login As System.Windows.Forms.Label
    Friend WithEvents txtB_MDP As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Mdp As System.Windows.Forms.Label
    Friend WithEvents txtB_Adresse As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Adr As System.Windows.Forms.Label
    Friend WithEvents txtB_CodePostal As System.Windows.Forms.TextBox
    Friend WithEvents lbl_CodePostal As System.Windows.Forms.Label
    Friend WithEvents txtB_Ville As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Ville As System.Windows.Forms.Label
    Friend WithEvents lbl_DateEmbauche As System.Windows.Forms.Label
    Friend WithEvents grpb_TypeUser As System.Windows.Forms.GroupBox
    Friend WithEvents rb_Visiteur As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Comptable As System.Windows.Forms.RadioButton
    Friend WithEvents date_DateEmbauche As System.Windows.Forms.DateTimePicker
    Friend WithEvents lstV_Voitures As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbl_InfoMdp As System.Windows.Forms.Label
    Friend WithEvents progressBar_Mdp As System.Windows.Forms.ProgressBar
    Friend WithEvents lbl_Voitures As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gb_login As System.Windows.Forms.GroupBox
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents dateDebutLoc As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateFinLocation As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtB_ConfirmMDP As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents checkBox_AffichAllVehicule As System.Windows.Forms.CheckBox
End Class
