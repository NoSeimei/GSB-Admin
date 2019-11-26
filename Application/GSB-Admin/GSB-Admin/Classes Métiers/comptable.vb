Public Class comptable
    Inherits user

    'Propriété de la classe fille
    Private m_nbFicheRefuse As Integer


    Sub New(id As Integer, nom As String, prenom As String, login As String, mdp As String,
            adresse As String, cp As String, ville As String, dateEmbauche As Date, nbFicheRefuse As Integer)

        'Appel du constructeur de la classe mère 
        MyBase.New(id, nom, prenom, login, mdp, adresse, cp, ville, dateEmbauche)

        'Définition de la propriété de la classe fille
        m_nbFicheRefuse = nbFicheRefuse
    End Sub



    '------------------------------------------------------------------------------------------------------------------------------------------------------
    'Property get set
    Property nbFicheComptable
        Get
            Return m_nbFicheRefuse
        End Get
        Set(value)
            m_nbFicheRefuse = value
        End Set
    End Property
    '------------------------------------------------------------------------------------------------------------------------------------------------------



    '------------------------------------------------------------------------------------------------------------------------------------------------------

    Sub deleteComptable(unComptable As comptable)

    End Sub


End Class
