Public Class connexion


    '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Boutton pour quitter l'application
    Private Sub btn_Quitte_Click(sender As Object, e As EventArgs) Handles btn_Quitte.Click
        Dim Reponse As DialogResult 'Déclaration de la variavle "Reponse" en local
        Reponse = MessageBox.Show("Quitter l'application GSB-Admin?", "Quitter", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'Affichage de la message box avec le choix de quitter ou de rester
        If Reponse = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub


    '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Bouton de connexion
    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
        'A CHANGER
        If txtB_Login.Text = "root" And txtB_MDP.Text = "root" Then
            Me.Hide()
            frm_principal.Show()
        Else
            lbl_Erreur.Visible = True
            lbl_Erreur.Text = "Login ou mot de passe incorrects"
        End If
    End Sub
End Class