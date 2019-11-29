Public Class form_modifUser
    Dim unUtilisateur = form_ListeUsers.unUtilisateur
    Dim vehicule As Vehicule

    Private Sub form_modifUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim item As ListViewItem

                txtB_name.Text = unUtilisateur.nomUser
                txt_Prenom.Text = unUtilisateur.prenomUser
                txtB_Adresse.Text = unUtilisateur.adrUser
                txtB_CodePostal.Text = unUtilisateur.cpUser
                txtB_Ville.Text = unUtilisateur.villeUSer
                date_DateEmbauche.Text = unUtilisateur.dateEmbaucheUser
                txtB_Login.Text = unUtilisateur.loginUser
                txtB_MDP.Text = unUtilisateur.mdpUser


        If trouverUser(unUtilisateur.idUser) = "Visiteur" Then
            rb_Visiteur.Checked = True
            For Each uneVoiture In CollectionVehicule
                item = New ListViewItem({uneVoiture.LireImmat, uneVoiture.LirePuiss, uneVoiture.LireModele})

                If voitureUtilise.voitureDispo(uneVoiture.LireImmat) = False Then 'On vérifie si la voiture est disponible ou non
                    lstV_Voitures.Items.Add(item) 'Ajout de l'item à la listview
                End If

            Next
        Else
            rb_Comptable.Checked = True


        End If

















    End Sub

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
End Class