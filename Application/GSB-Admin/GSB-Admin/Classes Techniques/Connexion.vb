Imports System.Data.SqlClient

Public Class Connexion
    Private m_Connexion As SqlConnection


    'Constructeur qui va permettre de spécifier la connexion à la bdd et va faire appel aux méthodes de construction des objets
    Sub New()
        'On ce connecte à la base de données BIBI
        ' m_Connexion = New SqlConnection("Data Source=" + Database.Item("serveur") + ";Initial Catalog=" + Database.Item("baseDeDonnees") & _
        '";User Id=" + Database.Item("user") + ";Password=" + Database.Item("mdpUser") + ";")

        'LOCAL
        m_Connexion = New SqlConnection("Data Source=" + Database.Item("serveur") + ";" & _
         "Integrated Security=SSPI;Initial Catalog=" + Database.Item("baseDeDonnees"))


        'On ouvre la connexion
        OpenConnexion()

        'On appel les méthodes qui crée nos objets et les insérent dans des collections
        remplirVehicule()
        remplirUsers()
        remplirComptable()
        remplirVisiteur()
        remplirUtiliser()
        'Enfin on ferme la connexion
        CloseConnexion()
    End Sub



    'Permet d'ouvrir la connexion
    Public Sub OpenConnexion()
        'On tente d'ouvrir la connexion, sinon on prévient l'utilisateur
        Try
            m_Connexion.Open()
        Catch ex As Exception
            MsgBox("La connexion à la base de données a échouée")
            End
        End Try
    End Sub



    'Permet de fermer la connexion
    Public Sub CloseConnexion()
        'On tente d'ouvrir la connexion, sinon on prévient l'utilisateur
        Try
            m_Connexion.Close()
        Catch ex As Exception
            MsgBox("La connexion n'a pas pu être fermée")
        End Try
    End Sub


    'Permet la création des objets vehicule et le remplissage de la collection
    Public Sub remplirVehicule()

        'On prépare notre requête SQL dans un objet Command
        Dim Mycommand As SqlCommand = m_Connexion.CreateCommand()
        Mycommand.CommandText = "SELECT * FROM vehicule"

        'On crée un DataReader
        Dim myReader As SqlDataReader = Mycommand.ExecuteReader()

        'On parcourt l'ensemble pour remplir notre ListView
        Do While myReader.Read()

            'On instancie un objet véhicule
            Dim unVehicule As New Vehicule(myReader.GetString(0), myReader.GetInt32(1), myReader.GetString(2))
            'On l'ajoute à notre collection de véhicule
            CollectionVehicule.Add(unVehicule)
        Loop

        'On ferme le datareader
        myReader.Close()
    End Sub



    'Permet la création des objets utilisateur et le remplissage de la collection
    Public Sub remplirUsers()

        'On prépare notre requête SQL dans un objet Command
        Dim Mycommand As SqlCommand = m_Connexion.CreateCommand()
        Mycommand.CommandText = "SELECT * FROM utilisateur"

        'On crée un DataReader
        Dim myReader As SqlDataReader = Mycommand.ExecuteReader()

        'On parcourt l'ensemble pour remplir notre ListView
        Do While myReader.Read()

            'On instancie un objet utilisateur
            Dim unUser As New user(myReader.GetInt32(0), myReader.GetString(1), myReader.GetString(2), myReader.GetString(3),
                                           myReader.GetString(4), myReader.GetString(5), myReader.GetString(6),
                                           myReader.GetString(7), myReader.GetDateTime(8))

            'On l'ajoute à notre collection d'utilisateur
            CollectionUser.Add(unUser)
        Loop

        'On ferme le datareader
        myReader.Close()
    End Sub



    'Permet la création des objets comptable et le remplissage de la collection
    Public Sub remplirComptable()

        'On prépare notre requête SQL dans un objet Command
        Dim Mycommand As SqlCommand = m_Connexion.CreateCommand()
        Mycommand.CommandText = "SELECT comptable.id, comptable.nbFicheRefusee FROM utilisateur INNER JOIN comptable ON utilisateur.id = comptable.id"


        'On crée un DataReader
        Dim myReader As SqlDataReader = Mycommand.ExecuteReader()

        'On parcourt l'ensemble pour remplir notre ListView
        Do While myReader.Read()
            'On récupére l'utilisateur
            Dim unUser = trouverUtilisateur(myReader.GetInt32(0))
            'On instancie un objet comptable
            Dim unComptable As New comptable(unUser.idUser, unUser.nomUser, unUser.prenomUSer, unUser.loginUser, unUser.mdpUser, unUser.adrUser,
                                         unUser.cpUser, unUser.villeUSer, unUser.dateEmbaucheUser, myReader.GetInt32(0))

            'On l'ajoute à notre collection de notre comptable
            CollectionComptable.Add(unComptable)
        Loop

        'On ferme le datareader
        myReader.Close()
    End Sub



    'Permet la création des objets visiteur et le remplissage de la collection
    Public Sub remplirVisiteur()

        'On prépare notre requête SQL dans un objet Command
        Dim Mycommand As SqlCommand = m_Connexion.CreateCommand()
        Mycommand.CommandText = "SELECT visiteur.id FROM utilisateur INNER JOIN visiteur ON visiteur.id = utilisateur.id"


        'On crée un DataReader
        Dim myReader As SqlDataReader = Mycommand.ExecuteReader()

        'On parcourt l'ensemble pour remplir notre ListView
        Do While myReader.Read()

            'On récupére l'utilisateur
            Dim unUser = trouverUtilisateur(myReader.GetInt32(0))
            'On instancie un objet visiteur
            Dim unVisiteur As New visiteur(unUser.idUser, unUser.nomUser, unUser.prenomUSer, unUser.loginUser, unUser.mdpUser, unUser.adrUser,
                                         unUser.cpUser, unUser.villeUSer, unUser.dateEmbaucheUser)

            'On l'ajoute à notre collection de visiteur
            CollectionVisiteur.Add(unVisiteur)
        Loop

        'On ferme le datareader
        myReader.Close()
    End Sub



    'Permet la création des objets voitureUtiliser et le remplissage de la collection
    Public Sub remplirUtiliser()

        'On prépare notre requête SQL dans un objet Command
        Dim Mycommand As SqlCommand = m_Connexion.CreateCommand()
        Mycommand.CommandText = "SELECT * FROM utiliser"


        'On crée un DataReader
        Dim myReader As SqlDataReader = Mycommand.ExecuteReader()

        'On parcourt l'ensemble pour remplir notre ListView
        Do While myReader.Read()

            'On récupére le visiteur et le véhicule correspondant
            Dim leVisiteur = trouverVisiteur(myReader.GetInt32(2))
            Dim leVehicule = trouverVehicule(myReader.GetString(0))

            'On instancie un objet visiteur
            Dim uneVoitureUtiliser As New voitureUtilise(leVehicule, leVisiteur, myReader.GetDateTime(1))


            myReader.GetValue(3)
            IsDBNull(myReader.GetValue(3))
            'On vérifie que la date as été renseigné
            If Not IsDBNull(myReader.GetValue(3)) Then
                'On met à jour cette date de fin si jamais
                uneVoitureUtiliser.dateFin = myReader.GetDateTime(3)
            End If


            'On l'ajoute à notre collection de visiteur
            CollectionVoitureUtiliser.Add(uneVoitureUtiliser)
        Loop

        'On ferme le datareader
        myReader.Close()
    End Sub
End Class
