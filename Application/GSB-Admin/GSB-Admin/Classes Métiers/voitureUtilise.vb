Public Class voitureUtilise
    'Cette classe permet de faire la correspondance entres la voitures et l'utilisateur
    Private m_Vehicule As Vehicule
    Private m_Visiteur As visiteur
    Private m_dateDebutUtilisatation As Date
    Private m_dateFinUtilisatation As Date


    'Constructeur de la classe qui permet de mettre en lien le visiteur ainsi que la voiture qu'il utilise
    Sub New(vehicule As Vehicule, visiteur As visiteur, dateDebut As Date, dateFin As Date)
        m_Vehicule = vehicule
        m_Visiteur = visiteur
        m_dateDebutUtilisatation = dateDebut
        m_dateFinUtilisatation = dateFin
    End Sub



    '------------------------------------------------------------------------------------------------------------------------------------------------------
    'Méthode get et set

    Property visiteurVoiture
        Get
            Return m_Visiteur
        End Get
        Set(value)
            m_Visiteur = value
        End Set
    End Property


    Property vehiculeVoiture
        Get
            Return m_Vehicule
        End Get
        Set(value)
            m_Vehicule = value
        End Set
    End Property


    Property dateDebut
        Get
            Return m_dateDebutUtilisatation
        End Get
        Set(value)
            m_dateDebutUtilisatation = value
        End Set
    End Property


    Property dateFin
        Get
            Return m_dateFinUtilisatation
        End Get
        Set(value)
            m_dateFinUtilisatation = value
        End Set
    End Property
    '------------------------------------------------------------------------------------------------------------------------------------------------------


    Shared Function voitureDispo(immat As String)
        Dim uneVoitureUtilise
        Try
            uneVoitureUtilise = trouverVoitureUtilise(immat) 'on tente de récupérer la voiture utilisé
        Catch ex As Exception
            Return False 'Sinon c'est qu'elle n'existe pas, on retourne alors false
        End Try


        'Si elle existe on effectue des tests afin de vérifier que cette voiture n'est pas en cours d'utilisation
        If uneVoitureUtilise.dateFin >= DateTime.Now.Date Then
            Return True
        Else
            Return False
        End If

    End Function

End Class
