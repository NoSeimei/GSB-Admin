Public Class frm_principal


    '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Bouton pour afficher et modifier le mot d passe d'un utilisateur
    Private Sub btn_ChangeMdp_Click(sender As Object, e As EventArgs) Handles btn_ChangeMdp.Click

        If btn_ChangeMdp.Text = ">" Then

            btn_ChangeMdp.Text = "<"
            btn_ChangeMdp.Cursor = Cursors.PanWest


            grpB_reset.Visible = True
            rb_Reset.Visible = True
            rb_ResetNo.Visible = True
            rb_resetYes.Visible = True

            Me.Size = New Size(1200, Me.Size.Height)


        Else

            btn_ChangeMdp.Text = ">"
            btn_ChangeMdp.Cursor = Cursors.PanEast

            grpB_reset.Visible = False
            rb_Reset.Visible = False
            rb_ResetNo.Visible = False
            rb_resetYes.Visible = False

            Me.Size = New Size(793, Me.Size.Height)
        End If


    End Sub

    '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Bouton d'ouverture du formulaire de création d'un nouvel utilisateur
    Private Sub btn_CreateUser_Click(sender As Object, e As EventArgs) Handles btn_CreateUser.Click
        Me.Close()
        creatUser.Show()
    End Sub

    Private Sub btn_deco_Click(sender As Object, e As EventArgs) Handles btn_deco.Click
        Dim Reponse As DialogResult 'Déclaration de la variavle "Reponse" en local
        Reponse = MessageBox.Show("Se déconnecter?", "Quitter", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'Affichage de la message box avec le choix de quitter ou de rester
        If Reponse = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
