Public Class form_ListeUtiliasteurs


    '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Bouton pour afficher et modifier le mot d passe d'un utilisateur


    '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Bouton d'ouverture du formulaire de création d'un nouvel utilisateur





    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        form_Utilisateur.Show()
    End Sub



    Private Sub OUiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OUiToolStripMenuItem.Click
        Dim formU As New form_Utilisateur
        formU.Show()
        formU.gb_login.Hide()
    End Sub

    Private Sub LacheMoiMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LacheMoiMToolStripMenuItem.Click
        Dim Reponse As DialogResult 'Déclaration de la variavle "Reponse" en local
        Reponse = MessageBox.Show("Voulez-vous vraiment supprimer cet utilisateur ?", "Supprimer", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'Affichage de la message box avec le choix de quitter ou de rester
        If Reponse = DialogResult.Yes Then

            Me.Close()
        End If
    End Sub


    Private Sub progressBar_Mdp_Click(sender As Object, e As EventArgs)

    End Sub
End Class
