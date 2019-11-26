Public Class Form_resetMDP

    
    Private Sub tb_mdpchange_TextChanged(sender As Object, e As EventArgs) Handles tb_mdpchange.TextChanged
        Dim valueProgressBar = ValidatePassword(tb_mdpchange.Text)
        progressBar_Mdp.Value = valueProgressBar
    End Sub

    Private Sub cbx_showhide_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_showhide.CheckedChanged
        If cbx_showhide.Checked = True Then
            tb_mdpchange.UseSystemPasswordChar = False
        Else
            tb_mdpchange.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btn_Valider_Click(sender As Object, e As EventArgs) Handles btn_Valider.Click
        If progressBar_Mdp.Value < 100 Then

            Dim Reponse As DialogResult 'Déclaration de la variavle "Reponse" en local
            Reponse = MessageBox.Show("Ce mot de passe n'est pas complexe, mettre à jour ?", "Mise à jour", _
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'Affichage de la message box avec le choix de quitter ou de rester
            If Reponse = DialogResult.Yes Then
                Me.Close()
            End If

        Else

            Dim Reponse As DialogResult 'Déclaration de la variavle "Reponse" en local
            Reponse = MessageBox.Show("Voulez-vous vraiment mettre à jour le mot de passe ?", "Mise à jour", _
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'Affichage de la message box avec le choix de quitter ou de rester
            If Reponse = DialogResult.Yes Then
                Me.Close()
            End If

        End If
    End Sub

    Private Sub btn_Default_Click(sender As Object, e As EventArgs) Handles btn_Default.Click
        tb_mdpchange.Text = "12-SoLeil&"
    End Sub

   
    Private Sub Form_resetMDP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class