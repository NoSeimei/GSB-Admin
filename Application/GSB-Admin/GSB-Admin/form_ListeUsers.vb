﻿Imports System.Data.SqlClient

Public Class form_ListeUsers
    'Variable global
    Public unUtilisateur As user
    Dim item As ListViewItem
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        form_CreateUser.Show()
    End Sub



    Private Sub OUiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OUiToolStripMenuItem.Click
        unUtilisateur = trouverUtilisateur(lstV_visiteur.SelectedItems.Item(0).Text)


                Dim formM As New form_modifUser
                formM.Show()
                Me.Close()
       

    End Sub

    Private Sub LacheMoiMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LacheMoiMToolStripMenuItem.Click
        Dim Reponse As DialogResult 'Déclaration de la variavle "Reponse" en local
        Reponse = MessageBox.Show("Voulez-vous vraiment supprimer cet utilisateur ?", "Supprimer", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'Affichage de la message box avec le choix de quitter ou de rester
        If Reponse = DialogResult.Yes Then

            Dim idUser As Integer = lstV_visiteur.SelectedItems.Item(0).Text 'On récupére l'identifiant de cette personne
            user.SupprimeUser(idUser) 'On exécute la méthode qui gère la suppression


            'On remet à jour la listView des users
            Me.lstV_visiteur.Items.Clear()
            Me.lstV_visiteur.Refresh()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form_resetMDP.Show()
    End Sub



    '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Bouton radio
    Private Sub rb_AllUser_CheckedChanged(sender As Object, e As EventArgs) Handles rb_AllUser.CheckedChanged
        Me.lstV_visiteur.Items.Clear()
        Me.lstV_visiteur.Refresh()


        Dim item As ListViewItem

        'On parcourt l'ensemble de notre collection d'utilisateurs

        For Each unUser In CollectionUser
            item = New ListViewItem({unUser.idUser, unUser.nomUser, unUser.prenomUSer, unUser.dateEmbaucheUser})
            Me.lstV_visiteur.Items.Add(item)
            Me.lstV_visiteur.Refresh()

        Next



    End Sub

    Private Sub rb_Visiteur_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Visiteur.CheckedChanged
        If rb_Visiteur.Checked = True Then
            Me.lstV_visiteur.Items.Clear()




            'On parcourt l'ensemble de notre collection d'utilisateurs

            For Each unVisiteur In CollectionVisiteur
                item = New ListViewItem({unVisiteur.idUser, unVisiteur.nomUser, unVisiteur.prenomUSer, unVisiteur.dateEmbaucheUser})
                Me.lstV_visiteur.Items.Add(item)
                Me.lstV_visiteur.Refresh()

            Next



        End If

    End Sub

    Private Sub rb_Comptable_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Comptable.CheckedChanged
        If rb_Comptable.Checked = True Then
            Me.lstV_visiteur.Items.Clear()




            'On parcourt l'ensemble de notre collection d'utilisateurs
            For Each unComptable In CollectionComptable
                item = New ListViewItem({unComptable.idUser, unComptable.nomUser, unComptable.prenomUSer, unComptable.dateEmbaucheUser})
                Me.lstV_visiteur.Items.Add(item)
                Me.lstV_visiteur.Refresh()


            Next
        End If
    End Sub

    '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    Private Sub form_ListeUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
