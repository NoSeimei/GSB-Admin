Public Class frm_principal


    '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Bouton pour afficher et modifier le mot d passe d'un utilisateur
    Private Sub btn_ChangeMdp_Click(sender As Object, e As EventArgs) Handles btn_ChangeMdp.Click

        If btn_ChangeMdp.Text = "&>" Then

            btn_ChangeMdp.Text = "&<"
            btn_ChangeMdp.Cursor = Cursors.PanWest



            Me.Size = New Size(830, Me.Size.Height)


        Else

            btn_ChangeMdp.Text = "&>"
            btn_ChangeMdp.Cursor = Cursors.PanWest


            Me.Size = New Size(499, Me.Size.Height)
        End If


    End Sub

    '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Bouton d'ouverture du formulaire de création d'un nouvel utilisateur
    

  
  
    
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        creatUser.Show()
    End Sub

   
    
    Private Sub btn_Valider_Click(sender As Object, e As EventArgs) Handles btn_Valider.Click
        If tb_mdpchange.Text.Trim.Length < 8 Then
            lbl_InfoMdp.Text = "Le mot de passe doit contenir minimun 8 caractères"
        
        End If
    End Sub

    Private Sub tb_mdpchange_TextChanged(sender As Object, e As EventArgs) Handles tb_mdpchange.TextChanged
        If tb_mdpchange.Text.Trim.Length < 4 Then
            progressBar_Mdp.Value = 10

        End If

        If tb_mdpchange.Text.Trim.Length >= 4 Then
            progressBar_Mdp.Value = 50

        End If
        If tb_mdpchange.Text.Trim.Length >= 6 Then
            progressBar_Mdp.Value = 70

        End If

        If tb_mdpchange.Text.Trim.Length >= 7 Then
            progressBar_Mdp.Value = 85

        End If
        If tb_mdpchange.Text.Trim.Length >= 8 Then
            progressBar_Mdp.Value = 100


        End If
    End Sub

    


    Private Sub btn_deco_Click(sender As Object, e As EventArgs) Handles btn_deco.Click
        Dim Reponse As DialogResult 'Déclaration de la variavle "Reponse" en local
        Reponse = MessageBox.Show("Voulez-vous vraiment vous déconnecter ?", "Quitter", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'Affichage de la message box avec le choix de quitter ou de rester
        If Reponse = DialogResult.Yes Then
            connexion.Close()
            connexion.Show()
            Me.Close()

        End If
    End Sub

   
  
   
   
    

    Private Sub cbx_showhide_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_showhide.CheckedChanged
        If cbx_showhide.Checked = True Then
            tb_mdpchange.UseSystemPasswordChar = False
        Else
            tb_mdpchange.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class
