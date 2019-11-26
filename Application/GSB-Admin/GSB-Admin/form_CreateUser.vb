Public Class form_CreateUser

    '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Bouton de retour au formulaire principal
    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click
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
            Me.Size = New Size(780, Me.Size.Height)
        Else
            Me.Size = New Size(370, Me.Size.Height)
        End If

    End Sub

    Private Sub creatUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rb_Comptable.Checked = True

        Dim item As ListViewItem

        'On parcourt l'ensemble de notre collection d'utilisateurs
        For Each uneVoiture In CollectionVehicule
            item = New ListViewItem({uneVoiture.LireImmat, uneVoiture.LirePuiss, uneVoiture.LireModele})
            lstV_Voitures.Items.Add(item)
        Next


    End Sub



    Private Sub txtB_MDP_TextChanged(sender As Object, e As EventArgs) Handles txtB_MDP.TextChanged
        Dim valueProgressBar = ValidatePassword(txtB_MDP.Text)
        progressBar_Mdp.Value = valueProgressBar
    End Sub

    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
        Dim Reponse As DialogResult 'Déclaration de la variavle "Reponse" en local
        Reponse = MessageBox.Show("Voulez-vous vraiment ajouter cet utilisateur ?", "Ajouter", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'Affichage de la message box avec le choix de quitter ou de rester
        If Reponse = DialogResult.Yes Then

            Dim t
            For Each t In Me.Controls
                If TypeOf t Is TextBox Then
                    If t.Text = "" Then
                        MsgBox("Complete Entry!")
                        Exit Sub
                        Exit For
                    End If
                End If
            Next


        ElseIf rb_Visiteur.Checked = True Then

            Dim unVisiteur As New visiteur(IncreVisiteur, txtB_name.Text, txt_Prenom.Text, txtB_Login.Text, txtB_MDP.Text, txtB_Adresse.Text, txtB_CodePostal.Text, txtB_Ville.Text, date_DateEmbauche.Text)
            ' on l'ajoute à la collection de visiteur
            CollectionVisiteur.Add(unVisiteur)

            'Variables permettant de parcourir une boucle
            Dim i As Integer = 0

            'Lorsque l'élément aura été choisie on parcourt la liste pour le retrouver 
            For Each Element As ListViewItem In lstV_Voitures.SelectedItems

                ' On cherche l'élément sélectionné
                If Element.Selected = True Then
                    'Une fois trouvé, on travaille dessus

                    'tout d'abord on recherche le produit sur lequel on va travailler
                    While i < CollectionVehicule.Count And CollectionVehicule.Item(i).LireImmat <> Element.SubItems(0).Text
                        i = i + 1
                    End While

                    'On récupére le véhicule sélectionné
                    Dim LeVehicule = CollectionVehicule.Item(i)

                    'On déclare l'objet et on l'insère dans la collection
                    Dim LeVehiculeUtilise As New voitureUtilise(LeVehicule, unVisiteur, DateTimePicker1.Text, DateTimePicker2.Text)
                    CollectionVoitureUtiliser.Add(LeVehiculeUtilise)


                End If
            Next

        Else

            Dim unComptable As New comptable(IncreComptable, txtB_name.Text, txt_Prenom.Text, txtB_Login.Text, txtB_MDP.Text, txtB_Adresse.Text, txtB_CodePostal.Text, txtB_Ville.Text, date_DateEmbauche.Text, False)
            ' on l'ajoute à la collection de comptable
            CollectionComptable.Add(unComptable)



            form_ListeUsers.lstV_visiteur.Refresh()
            form_ListeUsers.Show()
            Me.Close()


        End If



    End Sub


    
    
End Class