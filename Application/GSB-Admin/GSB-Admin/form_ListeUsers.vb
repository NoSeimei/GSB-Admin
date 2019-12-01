Imports System.Data.SqlClient

Public Class form_ListeUsers
    Public unUtilisateur As user
    Dim item As ListViewItem
    Dim collec As New AutoCompleteStringCollection() 'On définit ici une collection destiné à l'auto-complétion

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        form_CreateUser.Show()
    End Sub



    Private Sub OUiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OUiToolStripMenuItem.Click
        unUtilisateur = trouverUtilisateur(lstV_visiteur.SelectedItems.Item(0).Text)
        form_modifUser.MdiParent = form_MDIContainer

        form_modifUser.Show()
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

        txtB_Search.AutoCompleteCustomSource.Clear()

        Dim item As ListViewItem
        'On parcourt l'ensemble de notre collection d'utilisateurs
        For Each unUser In CollectionUser
            item = New ListViewItem({unUser.idUser, unUser.nomUser, unUser.prenomUSer, unUser.dateEmbaucheUser})
            Me.lstV_visiteur.Items.Add(item)
            Me.lstV_visiteur.Refresh()
            collec.Add(unUser.nomUser)
        Next

        txtB_Search.AutoCompleteCustomSource = collec
    End Sub

    Private Sub rb_Visiteur_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Visiteur.CheckedChanged
        If rb_Visiteur.Checked = True Then
            Me.lstV_visiteur.Items.Clear()
            txtB_Search.AutoCompleteCustomSource.Clear()
            'On parcourt l'ensemble de notre collection d'utilisateurs
            For Each unVisiteur In CollectionVisiteur
                item = New ListViewItem({unVisiteur.idUser, unVisiteur.nomUser, unVisiteur.prenomUSer, unVisiteur.dateEmbaucheUser})
                Me.lstV_visiteur.Items.Add(item)
                Me.lstV_visiteur.Refresh()
                collec.Add(unVisiteur.nomUser)
            Next
            txtB_Search.AutoCompleteCustomSource = collec

        End If

    End Sub

    Private Sub rb_Comptable_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Comptable.CheckedChanged
        If rb_Comptable.Checked = True Then
            Me.lstV_visiteur.Items.Clear()
            txtB_Search.AutoCompleteCustomSource.Clear()
            'On parcourt l'ensemble de notre collection d'utilisateurs
            For Each unComptable In CollectionComptable
                item = New ListViewItem({unComptable.idUser, unComptable.nomUser, unComptable.prenomUSer, unComptable.dateEmbaucheUser})
                Me.lstV_visiteur.Items.Add(item)
                Me.lstV_visiteur.Refresh()
                collec.Add(unComptable.nomUser)

            Next

            txtB_Search.AutoCompleteCustomSource = collec
        End If
    End Sub

    '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    Private Sub form_ListeUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'On parcourt maintenant tout nos utilisateurs afin de remplir notre collection
        For Each unUser In CollectionUser
            collec.Add(unUser.nomUser)
        Next

        'On met dans notre txtbox la source d'auto-complétion
        txtB_Search.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtB_Search.AutoCompleteCustomSource = collec
    End Sub

    Private Sub txtB_Search_Click(sender As Object, e As EventArgs) Handles txtB_Search.Click
        txtB_Search.Text = ""
    End Sub

    Private Sub txtB_Search_TextChanged(sender As Object, e As EventArgs) Handles txtB_Search.TextChanged
        lstV_visiteur.Items.Clear() 'On vide la listView
        Dim item As New ListViewItem 'On crée un objet item 

        'On vérifie tout d'abord dans quel catégorie la personne souhaite rechercher 
        If rb_AllUser.Checked = True Then
            'On parcourt l'ensemble de notre collection d'utilisateurs
            For Each unUser In CollectionUser
                'On vérifie ici grâce à notre fonction que ce que l'on recherche 
                If searchUser(txtB_Search.Text, unUser.nomUser) Then
                    item = New ListViewItem({unUser.idUser, unUser.nomUser, unUser.prenomUSer, unUser.dateEmbaucheUser})
                    lstV_visiteur.Items.Add(item)
                    lstV_visiteur.Refresh()
                End If
            Next

        ElseIf rb_Comptable.Checked = True Then

            'On parcourt l'ensemble de notre collection d'utilisateurs
            For Each unUser In CollectionComptable
                'On vérifie ici grâce à notre fonction que ce que l'on recherche 
                If searchUser(txtB_Search.Text, unUser.nomUser) Then
                    item = New ListViewItem({unUser.idUser, unUser.nomUser, unUser.prenomUSer, unUser.dateEmbaucheUser})
                    lstV_visiteur.Items.Add(item)
                    lstV_visiteur.Refresh()
                End If
            Next

        ElseIf rb_Visiteur.Checked = True Then

            'On parcourt l'ensemble de notre collection d'utilisateurs
            For Each unUser In CollectionVisiteur
                'On vérifie ici grâce à notre fonction que ce que l'on recherche 
                If searchUser(txtB_Search.Text, unUser.nomUser) Then
                    item = New ListViewItem({unUser.idUser, unUser.nomUser, unUser.prenomUSer, unUser.dateEmbaucheUser})
                    lstV_visiteur.Items.Add(item)
                    lstV_visiteur.Refresh()
                End If
            Next

        End If
    End Sub

    Private Sub lstV_visiteur_DoubleClick(sender As Object, e As EventArgs) Handles lstV_visiteur.DoubleClick
        Dim unIdUser = lstV_visiteur.SelectedItems.Item(0).Text 'On récupére le numéro de l'utilisateur sélectionné
        'NE PAS TOUCHER POUR LE MOMENT SVP EN COURS D'AMELIORATION!!!! MERCI
        showInfo_User(unIdUser)
    End Sub

End Class
