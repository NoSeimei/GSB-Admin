Public Class creatUser

    '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Bouton de retour au formulaire principal
    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click
        Me.Close()
        frm_principal.Show()
    End Sub

    Private Sub rb_Visiteur_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Visiteur.CheckedChanged
        If rb_Visiteur.Checked = True Then
            Me.Size = New Size(850, Me.Size.Height)
        Else
            Me.Size = New Size(470, Me.Size.Height)
        End If

    End Sub
End Class