Imports System.Data.SqlClient

Public Class form_ListeUsers


    '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Bouton pour afficher et modifier le mot d passe d'un utilisateur


    '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Bouton d'ouverture du formulaire de création d'un nouvel utilisateur





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

    Private Sub form_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'On prépare notre requête SQL dans un objet Command
        Dim Mycommand As SqlCommand = form_MDIContainer.MyConnexion.CreateCommand()
        Mycommand.CommandText = "SELECT * FROM utilisateur"

        'On crée un DataReader
        Dim myReader As SqlDataReader = Mycommand.ExecuteReader()

        'On parcourt l'ensemble pour remplir notre ListView
        Do While myReader.Read()

            Dim item As New ListViewItem
            item = New ListViewItem({myReader.GetString(0), myReader.GetString(1), myReader.GetString(2)})
            lstV_visiteur.Items.Add(item)

        Loop

        myReader.Close()
        form_MDIContainer.MyConnexion.Close()


    End Sub
End Class
