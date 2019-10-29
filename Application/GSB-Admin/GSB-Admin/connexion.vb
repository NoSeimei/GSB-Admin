Public Class connexion


    '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Boutton pour quitter l'application
    Private Sub btn_Quitte_Click(sender As Object, e As EventArgs) Handles btn_Quitte.Click
        Me.Close()
    End Sub


    '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Bouton de connexion
    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
        If txtB_Login.Text = "root" & txtB_MDP.Text = "root" Then
            frm_principal.Show()
        Else
            lbl_Erreur.Text = "NON"
        End If
    End Sub
End Class