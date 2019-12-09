Public Class form_updateIdentifiant

    'On récupére les valeurs contenus dans le fichier et on l'ajoute dans les zons de textes
    Private Sub form_updateIdentifiant_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'On remplit les informations dans les zones de textes par les valeurs décrypter 
        txtb_AdresseIP.Text = Database.Item("serveur")
        txtb_IdentifiantBDD.Text = Database.Item("user")
        txtb_Login.Text = Auth.Item("login")
        txtb_MDP.Text = Auth.Item("motdepasse")
        txtb_MDP_BDD.Text = Database.Item("mdpUser")
        txtb_nomBDD.Text = Database.Item("baseDeDonnees")
    End Sub


    'Permet la fermeture compléte de l'application
    Private Sub btn_Annuler_Click(sender As Object, e As EventArgs) Handles btn_Annuler.Click
        End
    End Sub

    Private Sub btn_Valider_Click(sender As Object, e As EventArgs) Handles btn_Valider.Click

        'On demande confirmation car ses informations sont très importantes
        Dim Reponse As DialogResult 'Déclaration de la variavle "Reponse" en local
        Reponse = MessageBox.Show("Modifier les informations de connexion à l'application et à la Base De Données ?", "Modifier /!\", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'Affichage de la message box avec le choix de quitter ou de rester
        If Reponse = DialogResult.Yes Then
            'On envoie les valeurs à modifier à notre fonction
            modificationFichier(txtb_Login.Text, txtb_MDP.Text, txtb_AdresseIP.Text, txtb_nomBDD.Text, txtb_IdentifiantBDD.Text, txtb_MDP_BDD.Text)

            'On affiche les nouveaux identifiants de connexion
            MsgBox("Nouvel identifiant : " + txtb_Login.Text + vbCr + "Nouveau mot de passe : " + txtb_MDP.Text)

            'On met fin à l'exécution de l'application
            End
        End If
    End Sub
End Class