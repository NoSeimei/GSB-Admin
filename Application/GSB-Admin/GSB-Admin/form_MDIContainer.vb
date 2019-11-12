Imports System.Data.SqlClient

Public Class form_MDIContainer

    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Bouton de déconnexion
    Private Sub DéconnexionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DéconnexionToolStripMenuItem.Click
        Dim Reponse As DialogResult 'Déclaration de la variavle "Reponse" en local
        Reponse = MessageBox.Show("Voulez-vous vraiment vous déconnecter ?", "Quitter", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'Affichage de la message box avec le choix de quitter ou de rester
        If Reponse = DialogResult.Yes Then
            form_Connexion.Close()
            form_Connexion.Show()
            Auth.Clear()
            Database.Clear()
            Me.Close()
        End If
    End Sub
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------


    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Chargement du formulaire (Authentification et connexion à la base de données)
    Private Sub MDIContainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Connexion à la BDD en appelant notre méthode
        ConnexionSQLServeur()
        form_ListeUsers.MdiParent = Me
        form_ListeUsers.Show() 
    End Sub
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------



    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Menu du formulaire MDI
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        form_aProposDe.MdiParent = Me
        form_aProposDe.Show()
    End Sub
    Private Sub ListeDesUtilisateursToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeDesUtilisateursToolStripMenuItem.Click
        form_ListeUsers.MdiParent = Me
        form_ListeUsers.Show()
    End Sub
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        form_CreateUser.MdiParent = Me
        form_CreateUser.Show()
    End Sub
    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Form_resetMDP.MdiParent = Me
        Form_resetMDP.Show()
    End Sub
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------
End Class