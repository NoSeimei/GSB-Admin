Imports System.Data.SqlClient

Public Class Connexion
    Private m_Connexion As SqlConnection



    '------------------------------------------------------------------------------------------------------------------------------------------------------------
    'CONSTRUCTEUR
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
    'FIN CONSTRUCTEUR
    '------------------------------------------------------------------------------------------------------------------------------------------------------------





    '------------------------------------------------------------------------------------------------------------------------------------------------------------
    'FONCTION D'OUVERTURE ET DE FERMETURE DE LA CONNEXION
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
    'FIN FONCTIOND'OUVERTURE ET DE FERMETURE DE LA CONNEXION
    '------------------------------------------------------------------------------------------------------------------------------------------------------------






    '------------------------------------------------------------------------------------------------------------------------------------------------------------
    'DEBUT FONCTION DE REMPLISSAGE DES COLLECTIONS



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
            Dim uneVoitureUtiliser As New voitureUtilise(leVehicule, leVisiteur, myReader.GetDateTime(1), myReader.GetDateTime(3))


            
            'On l'ajoute à notre collection de visiteur
            CollectionVoitureUtiliser.Add(uneVoitureUtiliser)
        Loop

        'On ferme le datareader
        myReader.Close()
    End Sub
    'FIN DE LA PARTIE DES METHODES DE REMPLISSAGE DES COLLECTIONS
    '----------------------------------------------------------------------------------------------------------------------------------------------------------------






    '----------------------------------------------------------------------------------------------------------------------------------------------------------------
    'DEBUT DE LA PARTIE PERSISTANCE DES DONNEES

    'Permet la création des objets voitureUtiliser et le remplissage de la collection
    Public Sub deleteUser(idUser As Integer)

        OpenConnexion() 'Ouverture de la connexion

        'On prépare notre requête SQL dans un objet Command
        Dim Mycommand As SqlCommand = m_Connexion.CreateCommand()
        Mycommand.CommandText = "DELETE FROM utilisateur WHERE id =" + idUser.ToString 'On prépapre notre requête SQL
        Mycommand.ExecuteNonQuery() 'On exécute la commande

        CloseConnexion() 'Fermeture de la connexion
    End Sub



    'Permet d'insérer une information dans la table utiliser (voiture utilisé par un visiteur)
    Public Sub insertUtiliser(immat As String, dateDebut As Date, idUser As Integer, dateFin As Date)

        OpenConnexion() 'Ouverture de la connexion

        'On prépare notre requête SQL dans un objet Command
        Dim Mycommand As SqlCommand = m_Connexion.CreateCommand()
        Mycommand.CommandText = "INSERT INTO utiliser VALUES('" + immat.ToString + "','" + dateDebut.ToString("yyyy-MM-dd") + "'," + idUser.ToString + ",'" + dateFin.ToString("yyyy-MM-dd") + "')"
        'On prépapre notre requête SQL


        'On effectue notre requête
        Try
            Mycommand.ExecuteNonQuery() 'On exécute la commande
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



        CloseConnexion() 'Fermeture de la connexion
    End Sub



    'Permet de vérifier que la valeur qui va être enregistrer dans la table utiliser pourra l'être 
    Public Function verifDispoVehicule(immat As String, dateDebut As Date, dateFin As Date)

        OpenConnexion() 'Ouverture de la connexion

        Dim Mycommand As SqlCommand = m_Connexion.CreateCommand() 'On crée notre objet Command
        Mycommand.CommandText = "verifAdd_VoitureForVisiteur" 'On Spécifie notre procédure stockée
        Mycommand.CommandType = CommandType.StoredProcedure 'On spcifie que c'est une procédure stockée

        'On spécifie les paramètres nécessaires
        Mycommand.Parameters.AddWithValue("@immat", immat)
        Mycommand.Parameters.AddWithValue("@dateDebut", dateDebut)
        Mycommand.Parameters.AddWithValue("@dateFin", dateFin)

        'On exécute la requête en DataReader afin de pouvoir lire ce que la procédure nous renvoit
        Dim valueReturn As SqlDataReader = Mycommand.ExecuteReader()


        Try
            valueReturn.Read() 'On prend la première ligne
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim tabValue As New ArrayList
        tabValue.Add(valueReturn.GetValue(0))
        tabValue.Add(valueReturn.GetValue(1))
        tabValue.Add(valueReturn.GetValue(2))
        tabValue.Add(valueReturn.GetValue(3))

        valueReturn.Close()
        CloseConnexion() 'Fermeture de la connexion

        Return tabValue

    End Function




    'Permet d'insérer via la procédure stockée présentes sur le serveur de BDD
    Public Sub Insert_Update_User(id As Integer, name As String, surname As String, login As String, mdp As String, adr As String, cp As String,
                        ville As String, dateEbauche As Date, nbFiche As Integer)


        'On utilise la fonction de double cryptage afin de crypter nos informations
        login = doubleCryptage(login)
        mdp = doubleCryptage(mdp)

        OpenConnexion() 'Ouverture de la connexion

        Dim Mycommand As SqlCommand = m_Connexion.CreateCommand() 'On crée notre objet Command
        Mycommand.CommandText = "Insert_Update_User" 'On Spécifie notre procédure stockée
        Mycommand.CommandType = CommandType.StoredProcedure 'On spcifie que c'est une procédure stockée


        'On spécifie les paramètres nécessaires
        Mycommand.Parameters.AddWithValue("@param_id", id)
        Mycommand.Parameters.AddWithValue("@param_nom", name)
        Mycommand.Parameters.AddWithValue("@param_prenom", surname)
        Mycommand.Parameters.AddWithValue("@param_login", login)
        Mycommand.Parameters.AddWithValue("@param_mdp", mdp)
        Mycommand.Parameters.AddWithValue("@param_adresse", adr)
        Mycommand.Parameters.AddWithValue("@param_cp", cp)
        Mycommand.Parameters.AddWithValue("@param_ville", ville)
        Mycommand.Parameters.AddWithValue("@param_dateEmbauche", dateEbauche)

        ' On effectue un test afin de vérifier quel paramètres on envoie
        If nbFiche <> -1 Then
            Mycommand.Parameters.AddWithValue("@param_nbFichesRefuse", nbFiche)
        Else
            Mycommand.Parameters.AddWithValue("@param_nbFichesRefuse", DBNull.Value)
        End If




        Try
            'On exécute la commande
            Mycommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    

        CloseConnexion() 'Fermeture de la connexion

    End Sub

    'FIN DE LA PARTIE PERSISTANCE DES DONNEES
    '------------------------------------------------------------------------------------------------------------------------------------------------------------
End Class
