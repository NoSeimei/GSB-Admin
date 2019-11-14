Imports System.Data.SqlClient

Public Class form_ListeUsers
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        form_CreateUser.Show()
    End Sub



    Private Sub OUiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OUiToolStripMenuItem.Click
        Dim formU As New form_CreateUser
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form_resetMDP.Show()
    End Sub



    '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Bouton radio
    Private Sub rb_AllUser_CheckedChanged(sender As Object, e As EventArgs) Handles rb_AllUser.CheckedChanged

        'Vérifie que ce bouton est bien checké
        If rb_AllUser.Checked = True Then
            'On prépare un item de notre listView
            Dim item As ListViewItem

            'On parcourt l'ensemble de notre collection d'utilisateurs
            For Each unUser In CollectionUser
                item = New ListViewItem({unUser.nomUser, unUser.prenomUSer, unUser.dateEmbaucheUser})
                lstV_visiteur.Items.Add(item)
            Next

        End If

    End Sub

    Private Sub rb_Visiteur_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Visiteur.CheckedChanged

    End Sub

    Private Sub rb_Comptable_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Comptable.CheckedChanged

    End Sub

    '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
End Class
