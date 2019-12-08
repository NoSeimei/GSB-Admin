Public Class form_CreateUser

    '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Bouton de retour au formulaire principal
    Private Sub btn_return_Click(sender As Object, e As EventArgs)
        Dim Reponse As DialogResult 'Déclaration de la variavle "Reponse" en local
        Reponse = MessageBox.Show("Voulez-vous vraiment annuler l'ajout de cet utilisateur ?", "Annuler", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'Affichage de la message box avec le choix de quitter ou de rester
        If Reponse = DialogResult.Yes Then
            form_ListeUsers.lstV_visiteur.Refresh()
            form_ListeUsers.Show()
            Me.Close()
        End If
    End Sub

    Private Sub rb_Visiteur_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Visiteur.CheckedChanged
        If rb_Visiteur.Checked = True Then
            Me.Size = New Size(800, Me.Size.Height)
        Else
            Me.Size = New Size(432, Me.Size.Height)
        End If

    End Sub

    Private Sub creatUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rb_Comptable.Checked = True
        dateFinLocation.Value = DateAdd(DateInterval.Month, 3, dateDebutLoc.Value) 'Permet de mettre 3 mois en plus par défaut
    End Sub



    Private Sub txtB_MDP_TextChanged(sender As Object, e As EventArgs) Handles txtB_MDP.TextChanged
        Dim valueProgressBar = ValidatePassword(txtB_MDP.Text)
        progressBar_Mdp.Value = valueProgressBar



        Dim upper As New System.Text.RegularExpressions.Regex("[A-Z]")
        Dim lower As New System.Text.RegularExpressions.Regex("[a-z]")
        Dim number As New System.Text.RegularExpressions.Regex("[0-9]")
        ' Special is "none of the above".
        Dim special As New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]")


        'On regarde si le mot de passe correspond aux critères de sécurité, tant que cela ne correspond pas les critères sont en rouge.

        If upper.Matches(txtB_MDP.Text).Count < 2 Then
            lb_upper.ForeColor = Color.Red
        Else
            lb_upper.ForeColor = Color.Green
        End If


        If lower.Matches(txtB_MDP.Text).Count < 2 Then
            lb_minus.ForeColor = Color.Red
        Else
            lb_minus.ForeColor = Color.Green
        End If


        If number.Matches(txtB_MDP.Text).Count < 2 Then
            lb_number.ForeColor = Color.Red
        Else
            lb_number.ForeColor = Color.Green
        End If


        If special.Matches(txtB_MDP.Text).Count < 2 Then
            lb_symbols.ForeColor = Color.Red
        Else
            lb_symbols.ForeColor = Color.Green
        End If


        If txtB_MDP.Text.Count < 8 Then
            lb_carac.ForeColor = Color.Red
        Else
            lb_carac.ForeColor = Color.Green
        End If
    End Sub

    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
        Dim Reponse As DialogResult 'Déclaration de la variavle "Reponse" en local
        Reponse = MessageBox.Show("Voulez-vous vraiment ajouter cet utilisateur ?", "Ajouter", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'Affichage de la message box avec le choix de quitter ou de rester
        If Reponse = DialogResult.Yes Then


            'Test ici que toutes les informations ont bien été entrées
            Dim t
            For Each t In Me.Controls
                If TypeOf t Is TextBox Then
                    If t.Text = "" Then
                        MsgBox("Complete Entry!")
                        Exit Sub 'Arrête l'exécution de la Sub
                        Exit For
                    End If
                End If
            Next


            'On test ici que les mots de passe sont bien identique
            If txtB_MDP.Text <> txtB_ConfirmMDP.Text Then
                MsgBox("Les mots de passes ne sont pas identiques!")
                Exit Sub 'Arrête l'exécution de la Sub
            End If

            If rb_Visiteur.Checked = True Then



                'On vérifie tout d'abord qu'un véhicule as été assigné avant d'insérer le visiteur
                If lstV_Voitures.SelectedItems.Count > 0 Then


                    createUser(txtB_name.Text, txt_Prenom.Text, txtB_Login.Text, txtB_MDP.Text, txtB_Adresse.Text,
                               txtB_CodePostal.Text, txtB_Ville.Text, date_DateEmbauche.Text)

                    'On récupére ici le dernier visiteur qui viens d'être insérer
                    Dim leVisiteur = CollectionVisiteur.Item(CollectionVisiteur.Count - 1)
                    'Appel de la fonction avec les paramètres dont la méthode a besoin
                    addVehicule_Visiteur(lstV_Voitures.SelectedItems.Item(0).Text, leVisiteur.idUser, dateDebutLoc.Text, dateFinLocation.Text)

                    MsgBox(txtB_name.Text + " " + txt_Prenom.Text + " as été ajouté")
                    form_ListeUsers.Close()
                    form_ListeUsers.Show()
                    Me.Close()
                Else

                    'On le prévient ici qu'aucun véhicule n'a été assigné
                    Reponse = MessageBox.Show("Aucun véhicule n'a été attribué à au visiteur " + vbCrLf +
                                               txt_Prenom.Text + " " + txtB_Login.Text + vbCrLf +
                    "Effectué l'ajout?", "Information", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'Affichage de la message box avec un choix 
                    If Reponse = DialogResult.Yes Then

                        'On crée ici l'user
                        createUser(txtB_name.Text, txt_Prenom.Text, txtB_Login.Text, txtB_MDP.Text, txtB_Adresse.Text,
                                    txtB_CodePostal.Text, txtB_Ville.Text, date_DateEmbauche.Text)

                        MsgBox(txtB_name.Text + " " + txt_Prenom.Text + " as été ajouté")
                        form_ListeUsers.Close()
                        form_ListeUsers.Show()
                        Me.Close()
                    End If
                End If

            Else

                'On crée ici le comptable
                createUser(txtB_name.Text, txt_Prenom.Text, txtB_Login.Text, txtB_MDP.Text, txtB_Adresse.Text,
txtB_CodePostal.Text, txtB_Ville.Text, date_DateEmbauche.Text, 0)
                'Affichage de la message box d'information
                MsgBox(txtB_name.Text + " " + txt_Prenom.Text + " as été ajouté")
                form_ListeUsers.Close()
                form_ListeUsers.Show()
                Me.Close()
            End If
        End If


    End Sub


    
    'Permet d'afficher toutes les voitures
    Private Sub checkBox_AffichAllVehicule_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox_AffichAllVehicule.CheckedChanged
        Dim item As ListViewItem

        lstV_Voitures.Items.Clear()
        lstV_Voitures.Refresh()

            'On parcourt l'ensemble de notre collection d'utilisateurs
            For Each uneVoiture In CollectionVehicule
                item = New ListViewItem({uneVoiture.LireImmat, uneVoiture.LirePuiss, uneVoiture.LireModele})

            'On vérifie le check de la checkbox
            If checkBox_AffichAllVehicule.Checked = True Then
                If voitureUtilise.voitureDispo(uneVoiture.LireImmat) = False Then 'On vérifie si la voiture est disponible ou non
                    lstV_Voitures.Items.Add(item) 'Ajout de l'item à la listview
                End If
            Else
                If voitureUtilise.voitureDispo(uneVoiture.LireImmat) = True Then 'On vérifie si la voiture est disponible ou non
                    item.BackColor = Color.PaleVioletRed
                End If
                lstV_Voitures.Items.Add(item) 'Ajout de l'item à la listview
            End If


            Next

    End Sub


    'Permet de générer un login 
    Private Sub txtB_Login_Click(sender As Object, e As EventArgs) Handles txtB_Login.Click
        If txt_Prenom.TextLength > 0 And txtB_name.TextLength > 0 Then
            txtB_Login.Text = txtB_name.Text.Substring(0, 1) + txt_Prenom.Text
        End If
    End Sub


    'Permet d'afficher ou non le mot de passe
    Private Sub chkBox_Show_CheckedChanged(sender As Object, e As EventArgs) Handles chkBox_Show.CheckedChanged
        If chkBox_Show.Checked = True Then
            txtB_MDP.UseSystemPasswordChar = False
        Else
            txtB_MDP.UseSystemPasswordChar = True
        End If
    End Sub


End Class