
Public Class form_Connexion



    '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Boutton pour quitter l'application
    Private Sub btn_Quitte_Click(sender As Object, e As EventArgs) Handles btn_Quitte.Click
        End
    End Sub


    '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Bouton de connexion
    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click

        'Appel de la fonction qui charge nos Dictyonnary (connexion à la base de donées ainsi qu'à l'application)
        lectureFichier_Config()

        'On vérifie ici les informations qui ont été rentrer par la personne
        If Auth.Item("login") = txtB_Login.Text And Auth.Item("motdepasse") = txtB_MDP.Text Then
            form_MDIContainer.Show()
            Me.Hide()
        Else
            txtB_MDP.Text = ""
            lbl_Erreur.Text = " Login ou mot de passe incorrects..."
        End If

    End Sub
    '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Gestion des ENABLED
    Private Sub txtB_Login_TextChanged(sender As Object, e As EventArgs) Handles txtB_Login.TextChanged
        If txtB_Login.Text.Trim.Length > 0 Then
            txtB_MDP.Enabled = True
        Else
            txtB_MDP.Enabled = False
        End If
    End Sub

    Private Sub txtB_MDP_TextChanged(sender As Object, e As EventArgs) Handles txtB_MDP.TextChanged
        If txtB_MDP.Text.Trim.Length > 0 Then
            btn_Submit.Enabled = True
        Else
            btn_Submit.Enabled = False
        End If
    End Sub
    '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Chargement de l'application
    Private Sub connexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtB_Login.Text = ""
        txtB_MDP.Text = ""
    End Sub
    '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
End Class