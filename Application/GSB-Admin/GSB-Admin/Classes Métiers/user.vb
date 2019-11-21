﻿Imports System.Data.SqlClient

Public Class user

    'propriétés de notre classe user
    Private m_id As Integer
    Private m_nom As String
    Private m_prenom As String
    Private m_login As String
    Private m_mdp As String
    Private m_adresse As String
    Private m_cp As String
    Private m_ville As String
    Private m_dateEmbauche As Date


    'Constructeur de notre classe user
    Sub New(id As Integer, nom As String, prenom As String, login As String, mdp As String, adresse As String, cp As String, ville As String, dateEmbauche As Date)
        m_id = id
        m_nom = nom
        m_prenom = prenom
        m_login = login
        m_mdp = mdp
        m_adresse = adresse
        m_cp = cp
        m_ville = ville
        m_dateEmbauche = dateEmbauche
    End Sub


    '------------------------------------------------------------------------------------------------------------------------------------------------------
    'Méthode get set
    Property idUser
        Get
            Return m_id
        End Get
        Set(value)

            'Ouverture de la connexion
            ConnexionSQL.OpenConnexion()
            'Faire des requêtes dans une classe connexion qui permettrait de pouvoir effectuer les opérations dont on as besoin CRUD
            ConnexionSQL.CloseConnexion()


            m_id = value
        End Set
    End Property

    Property nomUser
        Get
            Return m_nom
        End Get
        Set(value)
            m_nom = value
        End Set
    End Property

    Property prenomUSer
        Get
            Return m_prenom
        End Get
        Set(value)
            m_prenom = value
        End Set
    End Property

    Property loginUser
        Get
            Return m_login
        End Get
        Set(value)
            'Faire le cryptage de la value pour le SET
        End Set
    End Property

    Property mdpUser
        Get
            Return m_mdp
        End Get
        Set(value)
            'Idem ici

        End Set
    End Property


    Property adrUser
        Get
            Return m_adresse
        End Get
        Set(value)
            m_adresse = value
        End Set
    End Property


    Property cpUser
        Get
            Return m_cp
        End Get
        Set(value)
            m_cp = value
        End Set
    End Property

    Property villeUSer
        Get
            Return m_ville
        End Get
        Set(value)
            m_ville = value
        End Set
    End Property

    Property dateEmbaucheUser
        Get
            Return m_dateEmbauche
        End Get
        Set(value)
            m_dateEmbauche = value
        End Set
    End Property
    '------------------------------------------------------------------------------------------------------------------------------------------------------


End Class
