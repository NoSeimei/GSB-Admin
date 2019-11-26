Public Class visiteur
    Inherits user

    '------------------------------------------------------------------------------------------------------------------------------------------------------
    'Structure de la classe
    Sub New(id As Integer, nom As String, prenom As String, login As String, mdp As String, adresse As String,
            cp As String, ville As String, dateEmbauche As Date)

        'Appel du constructeur de la classe mère
        MyBase.New(id, nom, prenom, login, mdp, adresse, cp, ville, dateEmbauche)

    End Sub
    '------------------------------------------------------------------------------------------------------------------------------------------------------



    '------------------------------------------------------------------------------------------------------------------------------------------------------

End Class
