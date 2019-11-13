Public Class form_MDIContainer

    Private Sub ListeDesUtilisateursToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeDesUtilisateursToolStripMenuItem.Click
        form_Principal.MdiParent = Me
        form_Principal.Show()
    End Sub

<<<<<<< HEAD
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Bouton de déconnexion
=======
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        form_Utilisateur.MdiParent = Me
        form_Utilisateur.Show()
    End Sub

>>>>>>> parent of ce9ae01... Travail PPE (12 Novembre 2016)
    Private Sub DéconnexionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DéconnexionToolStripMenuItem.Click
        Dim Reponse As DialogResult 'Déclaration de la variavle "Reponse" en local
        Reponse = MessageBox.Show("Voulez-vous vraiment vous déconnecter ?", "Quitter", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'Affichage de la message box avec le choix de quitter ou de rester
        If Reponse = DialogResult.Yes Then
            form_Connexion.Close()
            form_Connexion.Show()
            Me.Close()
        End If
    End Sub

    Private Sub MDIContainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
<<<<<<< HEAD
        'Connexion à la BDD en appelant notre méthode
        ConnexionSQLServeur()
        form_ListeUsers.MdiParent = Me
        form_ListeUsers.Show() 
=======
        form_Principal.MdiParent = Me
        form_Principal.Show()
>>>>>>> parent of ce9ae01... Travail PPE (12 Novembre 2016)
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        form_aProposDe.MdiParent = Me
        form_aProposDe.Show()
    End Sub
<<<<<<< HEAD
    Private Sub ListeDesUtilisateursToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeDesUtilisateursToolStripMenuItem.Click
        form_ListeUsers.MdiParent = Me
        form_ListeUsers.Show()
    End Sub
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        form_CreateUser.MdiParent = Me
        form_CreateUser.Show()
    End Sub
=======

>>>>>>> parent of ce9ae01... Travail PPE (12 Novembre 2016)
    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Form_resetMDP.MdiParent = Me
        Form_resetMDP.Show()
    End Sub
End Class