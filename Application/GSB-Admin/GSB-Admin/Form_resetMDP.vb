Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Public Class Form_resetMDP

    Dim item As ListViewItem
    Public id As Integer = 0
    Dim upper As New System.Text.RegularExpressions.Regex("[A-Z]")
    Dim lower As New System.Text.RegularExpressions.Regex("[a-z]")
    Dim number As New System.Text.RegularExpressions.Regex("[0-9]")
    ' Special is "none of the above".
    Dim special As New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]")

    Private Sub tb_mdpchange_TextChanged(sender As Object, e As EventArgs) Handles tb_mdpchange.TextChanged
        Dim valueProgressBar = ValidatePassword(tb_mdpchange.Text)
        progressBar_Mdp.Value = valueProgressBar


        'On regarde si le mot de passe correspond aux critères de sécurité, tant que cela ne correspond pas les critères sont en rouge.

        If upper.Matches(tb_mdpchange.Text).Count < 2 Then
            lb_upper.ForeColor = Color.Red
        Else
            lb_upper.ForeColor = Color.Green
        End If


        If lower.Matches(tb_mdpchange.Text).Count < 2 Then
            lb_minus.ForeColor = Color.Red
        Else
            lb_minus.ForeColor = Color.Green
        End If


        If number.Matches(tb_mdpchange.Text).Count < 2 Then
            lb_number.ForeColor = Color.Red
        Else
            lb_number.ForeColor = Color.Green
        End If


        If special.Matches(tb_mdpchange.Text).Count < 2 Then
            lb_symbols.ForeColor = Color.Red
        Else
            lb_symbols.ForeColor = Color.Green
        End If


        If tb_mdpchange.Text.Count < 8 Then
            lb_carac.ForeColor = Color.Red
        Else
            lb_carac.ForeColor = Color.Green
        End If





    End Sub

    Private Sub cbx_showhide_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_showhide.CheckedChanged
        'permet d'afficher le mot de passe ou non 
        If cbx_showhide.Checked = True Then
            tb_mdpchange.UseSystemPasswordChar = False
        Else
            tb_mdpchange.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btn_Valider_Click(sender As Object, e As EventArgs) Handles btn_Valider.Click
        'On vérifie (même si impossible tecniquement s'il n'a pas choisit d'utilisateur pour modifier le mot de passe.
        If lb_infosUser.Text = "?" Then
            Dim Reponse As DialogResult
            Reponse = MessageBox.Show("Vous n'avez pas choisit d'utilisateur sur lequel modifier le mot de passe !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Exit Sub
        End If


        'on vérifie si les deux mot de passe correspondent sinon on envoit un message d'erreur
        If tb_mdpchange.Text <> tb_confirmMdp.Text Then
            Dim Reponse As DialogResult
            Reponse = MessageBox.Show("Les mots de passes ne correspondent pas !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        'on vérifie si l'utilisateur n'as entrer de mot de passe
        If tb_mdpchange.Text.Count = 0 Or tb_confirmMdp.Text.Count = 0 Then
            Dim Reponse As DialogResult
            Reponse = MessageBox.Show("Vous n'avez pas écrit de mot de passe / remplit toutes les informations nécesssaire  !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        'On vérifie s'il a remplit toutes les conditions, sinon on demande quand même s'il veut insérer ou non,
        'nous n 'allons pas l'obliger à  respecter toutes les conditions.
        If progressBar_Mdp.Value < 100 Then




            Dim Reponse As DialogResult 'Déclaration de la variable "Reponse" en local
            Reponse = MessageBox.Show("Ce mot de passe ne correspond pas aux critères de sécurité, voulez-vosu réellement mettre à jour ?", "Mise à jour", _
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'Affichage de la message box avec le choix de quitter ou de rester
            If Reponse = DialogResult.Yes Then
                modifMDP(lstV_visiteur.SelectedItems.Item(0).Text, tb_mdpchange.Text)
                Me.Close()
            End If

        Else

            Dim Reponse As DialogResult 'Déclaration de la variable "Reponse" en local
            Reponse = MessageBox.Show("Voulez-vous vraiment mettre à jour le mot de passe ?", "Mise à jour", _
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'Affichage de la message box avec le choix de quitter ou de rester
            If Reponse = DialogResult.Yes Then
                modifMDP(lstV_visiteur.SelectedItems.Item(0).Text, tb_mdpchange.Text)
                Me.Close()
            End If

        End If
    End Sub

    Private Sub btn_Default_Click(sender As Object, e As EventArgs) Handles btn_Default.Click
        tb_mdpchange.Text = "12-SoLeil&"
        tb_confirmMdp.Text = "12-SoLeil&"
    End Sub


    Private Sub Form_resetMDP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim item As New ListViewItem

        'On parcourt l'ensemble de notre collection d'utilisateurs
        For Each unUser In CollectionUser
            item = New ListViewItem({unUser.idUser, unUser.nomUser, unUser.prenomUSer, unUser.dateEmbaucheUser})

            If unUser.idUser = id Then
                item.Selected = True
            End If

            lstV_visiteur.Items.Add(item)
            lstV_visiteur.Refresh()
        Next

    End Sub



    Private Sub bt_Select_Click(sender As Object, e As EventArgs) Handles bt_Select.Click

        If lstV_visiteur.SelectedItems.Count = 0 Then
            MsgBox("Choisir un utilisateur!!!")
            Exit Sub
        End If

        If lb_infosUser.Text <> "?" Then
            Dim Reponse As DialogResult 'Déclaration de la variable "Reponse" en local
            Reponse = MessageBox.Show("Vous êtes déjà en train de modifier le mot de passe d'un autre utilisateur, êtes vous sûr de changer votre choix ? ", "Mise à jour", _
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'Affichage de la message box avec le choix de quitter ou de rester
            If Reponse = DialogResult.Yes Then

                Dim visiteur = trouverUtilisateur(lstV_visiteur.SelectedItems.Item(0).Text)
                lb_infosUser.Text = visiteur.nomUser + " " + visiteur.prenomUser
                Me.Size = New Size(Me.Size.Width + 400, Me.Size.Height)

            End If
        Else
            Dim visiteur = trouverUtilisateur(lstV_visiteur.SelectedItems.Item(0).Text)
            lb_infosUser.Text = visiteur.nomUser + " " + visiteur.prenomUser
            Me.Size = New Size(Me.Size.Width + 400, Me.Size.Height)
        End If


    End Sub
End Class