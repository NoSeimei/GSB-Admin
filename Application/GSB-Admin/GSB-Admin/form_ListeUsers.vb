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

    '-------------------------------------------------------------------------------------------------------------------------------------------
    'Chargement du formulaire (remplissage de la liste des utilisateurs
    Private Sub form_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'On crée notre commande ici
        Dim reqListeUsers As String = "SELECT * from utilisateur"
        Dim Commande As New SqlCommand(reqListeUsers, MyConnexion)
        'On crée notre Reader
        Dim ReaderTableUsers As SqlDataReader = Commande.ExecuteReader()

        While ReaderTableUsers.Read()

        End While

    End Sub
End Class
