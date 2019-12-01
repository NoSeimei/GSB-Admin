﻿Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Module fonction
    Public Auth As New Dictionary(Of String, String)
    Public Database As New Dictionary(Of String, String)
    Private tabVigene As New Dictionary(Of String, ArrayList)
    Private key As String = "GSB-Admin"


    'Fonction permetttant de vérifier la complexité d'un mot de passe
    Function ValidatePassword(ByVal pwd As String,
    Optional ByVal minLength As Integer = 8,
    Optional ByVal numUpper As Integer = 2,
    Optional ByVal numLower As Integer = 2,
    Optional ByVal numNumbers As Integer = 2,
    Optional ByVal numSpecial As Integer = 2) As Integer

        'Valeur de retour
        Dim valueReturn As Integer = 100

        ' Replace [A-Z] with \p{Lu}, to allow for Unicode uppercase letters.
        Dim upper As New System.Text.RegularExpressions.Regex("[A-Z]")
        Dim lower As New System.Text.RegularExpressions.Regex("[a-z]")
        Dim number As New System.Text.RegularExpressions.Regex("[0-9]")
        ' Special is "none of the above".
        Dim special As New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]")

        ' Check the length.
        If Len(pwd) < minLength Then valueReturn -= 20
        ' Check for minimum number of occurrences.
        If upper.Matches(pwd).Count < numUpper Then valueReturn -= 20
        If lower.Matches(pwd).Count < numLower Then valueReturn -= 20
        If number.Matches(pwd).Count < numNumbers Then valueReturn -= 20
        If special.Matches(pwd).Count < numSpecial Then valueReturn -= 20

        ' Passed all checks.
        Return valueReturn
    End Function




   'Fonction permettant de récupérer les informations dans le fichier .ini et décrypte les valeurs 
    Public Sub lectureFichier()
        'Récupération du fichier de configuration au format .ini (LOCAL)
        ' Dim Lignes() As String = File.ReadAllLines("CryptFile/local.ini")
        'Récupération du fichier (PPE)
        Dim Lignes() As String = File.ReadAllLines("CryptFile/localConfig.ini")
        Dim paragraphe As String = ""


        'Parcourt de notre fichier .ini
        For stepLine As Integer = 0 To Lignes.Length - 1



            ' pour les []
            If Lignes(stepLine).StartsWith("[") And Lignes(stepLine).EndsWith("]") Then
                'Récupére le nom sur lequel on travaille (entres les [])
                paragraphe = Lignes(stepLine).Substring(Lignes(stepLine).IndexOf("[") + 1, Lignes(stepLine).IndexOf("]") - 1)


                'Pour les chaînes contenant une clé=valeur
            ElseIf Lignes(stepLine).Contains("=") Then
                'récupération de la clé 
                Dim key As String = Lignes(stepLine).Substring(0, Lignes(stepLine).IndexOf("="))
                'récupération de la valeur
                Dim value As String = Lignes(stepLine).Substring(Lignes(stepLine).IndexOf("=") + 1)

                'On fait appel à notre méthode de décryptage
                value = deryptValue(value)

                ' Ajoute dans le tableau la valeur
                If paragraphe = "Auth" Then
                    Auth.Add(key, value)
                ElseIf paragraphe = "Database" Then
                    Database.Add(key, value)
                End If
            End If


        Next

    End Sub

    Function deryptValue(text As String)
        'Décrypte la valeur
        Dim ResultatBytes() As Byte = Convert.FromBase64String(text)

        Dim KeyBytes() As Byte = Encoding.UTF8.GetBytes("aGioP782")
        Dim Crypto As New DESCryptoServiceProvider()
        Crypto.Key = KeyBytes
        Crypto.IV = KeyBytes
        Dim Icrypto As ICryptoTransform = Crypto.CreateDecryptor()

        Dim Donnees() As Byte = Icrypto.TransformFinalBlock(ResultatBytes, 0, ResultatBytes.Length)

        'Récupération de la ligne décoder
        text = Encoding.UTF8.GetString(Donnees)

        Return text
    End Function


    Function cryptValue(text As String)
        'Crypte la valeur
        Dim TexteEnBytes() As Byte = Encoding.UTF8.GetBytes(text)
        Dim KeyBytes() As Byte = Encoding.UTF8.GetBytes("aGioP782")
        Dim Crypto As New DESCryptoServiceProvider()
        Crypto.Key = KeyBytes
        Crypto.IV = KeyBytes
        Dim Icrypto As ICryptoTransform = Crypto.CreateEncryptor()
        Dim ResultatBytes() As Byte = Icrypto.TransformFinalBlock(TexteEnBytes, 0, TexteEnBytes.Length)
        text = Convert.ToBase64String(ResultatBytes)

        'Renvoi l'information
        Return text
    End Function




    'Permet de retourner le visiteur s'il existe
    Function trouverVisiteur(idVisiteur As Integer)
        For Each unVisiteur In CollectionVisiteur
            If unVisiteur.idUser = idVisiteur Then
                Return unVisiteur
            End If
        Next

        Throw New Exception("Le visiteur n'existe pas") 'On génére une exception
    End Function


    'Permet de retourner le véhicule s'il existe
    Function trouverVehicule(immat As String)
        For Each unVehicule In CollectionVehicule
            If unVehicule.LireImmat = immat Then
                Return unVehicule
            End If
        Next

        Throw New Exception("Le véhicule n'est pas répertorié") 'On génére une exception
    End Function
    Function trouverUser(idUser As Integer)

        For Each unVisiteur In CollectionVisiteur
            If unVisiteur.idUser = idUser Then
                Return "Visiteur"
            End If
        Next

        For Each unUser In CollectionComptable
            If unUser.idUser = idUser Then
                Return "Comptable"
            End If
        Next

        Throw New Exception("L'utilisateur n'appartient à aucune catégorie") 'On génére une exception
    End Function

    'Permet de retourner l'utilisateur s'il existe
    Function trouverUtilisateur(id As Integer)
        For Each unUser In CollectionUser
            If unUser.idUser = id Then
                Return unUser
            End If
        Next

        Throw New Exception("L'utilisateur n'existe pas") 'On génére une exception
    End Function

    'Permet de retourner le comptable s'il existe
    Function trouverComptable(id As Integer)
        For Each unUser In CollectionComptable
            If unUser.idUser = id Then
                Return unUser
            End If
        Next

        Throw New Exception("Le comptable n'existe pas") 'On génére une exception
    End Function


    'Permet de retourner le comptable s'il existe
    Function trouverVoitureUtilise(immat As String)
        For Each uneVoiture In CollectionVoitureUtiliser
            If uneVoiture.vehiculeVoiture.LireImmat = immat Then
                Return uneVoiture
            End If
        Next

        Throw New Exception("La voiture n'est pas utilisé") 'On génére une exception
    End Function


    'Retourne le visiteur ou le comptable en fonction de l'Id
    Sub DeleteUserCorrespondant(id As Integer)

        If CollectionComptable.Contains(trouverComptable(id)) Then
            CollectionComptable.Remove(trouverComptable(id))
        ElseIf CollectionVisiteur.Contains(trouverVisiteur(id)) Then
            CollectionVisiteur.Remove(trouverVisiteur(id))
        End If
    End Sub

    Public Function IncreUser() As Integer
        Dim i As Integer = 0
        For Each UnUser In CollectionUser
            If UnUser.idUser > i Then
                i = UnUser.idUser
            End If
        Next
        Return i + 1
    End Function



    '----------------------------------------------------------------------------------------------------------------------------------------------
    'Méthode nécessaire au cryptage du carré de Vigenére

    'Fonction pour permettre le cryptage d'une donnée grâce à la méthode du carre de vigenère
    Function cryptage_carré_Vigenére(valeur As String)
        'Tout d'abord, on rempit notre tableau de vigenére
        remplir_Tableau_Vigenere()

        Dim valeurCrypte As String = ""
        Dim premiereLigne = tabVigene.Item("²")
        Dim caractereKey As String
        Dim indexCaracteresKey As Integer = 0
        'On crypte maintenant toutes les données de notre chaîne de caractères
        For i As Integer = 0 To valeur.Length - 1

            'On reprend de 0 si la limite as été atteinte
            If indexCaracteresKey = key.Length Then
                indexCaracteresKey = 0
            End If

            'On récupére l'emplacement du caractères i de la chaîne envoyé
            Dim place_caracteres = premiereLigne.IndexOf(valeur.Substring(i, 1))
            'Et onrécupére le caractère de notre clé de cryptage
            caractereKey = key.Substring(indexCaracteresKey, 1)

            'On récupére maintenant la ligne correspondant au caractères x de la clé 
            Dim cléLigne = tabVigene.Item(caractereKey)
            'Enfin on récupére l'emplacement i contenu dans notre ligne correspondant au caractères x de la clé
            Dim caracteresCrypté = cléLigne.Item(place_caracteres)

            'on l'incrémente dans notre chaîne de caractères
            valeurCrypte = valeurCrypte + caracteresCrypté
            'On incrémente pour passer au caractères suivant de notre clé de cryptage
            indexCaracteresKey = indexCaracteresKey + 1
        Next

        'On vide le tableau à la fin
        tabVigene.Clear()

        Return valeurCrypte
    End Function



    'Fonction pour permettre le décryptage d'une donnée grâce à la méthode du carre de vigenère
    Function décryptage_carré_Vigenére(valeur As String)
        'Tout d'abord, on rempit notre tableau de vigenére
        remplir_Tableau_Vigenere()

        Dim valeurDecrypte As String = ""
        Dim premiereLigne = tabVigene.Item("²")
        Dim caractereLigne As String
        Dim indexCaracteresKey As Integer = 0
        'On crypte maintenant toutes les données de notre chaîne de caractères
        For i As Integer = 0 To valeur.Length - 1

            'On reprend de 0 si la limite as été atteinte
            If indexCaracteresKey = key.Length Then
                indexCaracteresKey = 0
            End If

            'On commence par récupérer la ligne du caractère c de la clé
            Dim ligneCrypte = tabVigene.Item(key.Substring(indexCaracteresKey, 1))
            'On récupére l'emplacement du caractère crypté
            Dim emplacementCrypte = ligneCrypte.IndexOf(valeur.Substring(i, 1))
            'Ensuite on récupére l'emplacement correspondant à notre premier caractère de la chaîne
            caractereLigne = premiereLigne.Item(emplacementCrypte)

            'on l'incrémente dans notre chaîne de caractères
            valeurDecrypte = valeurDecrypte + caractereLigne
            'On incrémente pour passer au caractères suivant de notre clé de cryptage
            indexCaracteresKey = indexCaracteresKey + 1
        Next

        'On vide le tableau à la fin
        tabVigene.Clear()

        Return valeurDecrypte
    End Function


    'Méthode permettant de remplir le tableau sur lequel on va travailler
    Sub remplir_Tableau_Vigenere()
        'Récupération du fichier du fichier texte permettant le cryptage
        Dim Lignes() As String = File.ReadAllLines("CryptFile/all_touche.txt", Encoding.Default)
        'Tableau contenant notre première ligne du carré de vigenère


        'Pour chaque caractère x correspondant à la clé 
        For i As Integer = 0 To Lignes.Length - 1
            Dim index As Integer = 0
            Dim value = i
            Dim ligneTab As New ArrayList

            'On ajoute la valeur en commençant par la clé x
            While (index < Lignes.Length)
                'On vérifie que la limite de la ligne n'a pas déjà été atteinte
                If value = Lignes.Length Then
                    value = 0
                End If

                ligneTab.Add(Lignes(value))

                'On incrémente +1
                value = value + 1
                index = index + 1
            End While

            'On ajoute à la clé x l'ensemble de sa ligne le correspondant
            tabVigene.Add(Lignes(i), ligneTab)
        Next

    End Sub
    'Méthode précédente du carré de Vigenére
    '----------------------------------------------------------------------------------------------------------------------------------------------




    'Procédure qui va permettre de gérer la création d'un user ou d'un comptable mais aussi de l'insérer dans la BDD
    Sub createUser(name As String, surname As String, login As String, mdp As String, adr As String, cp As String,
                        ville As String, dateEbauche As Date, Optional nbFiche As Integer = -1)

        Dim idUser As Integer = IncreUser()

        'On crée aussi le user
        Dim unUser As New user(idUser, name, surname, login, mdp, adr, cp, ville, dateEbauche)
        CollectionUser.Add(unUser) ' on l'ajoute à la collection de user

        'On vérifie quel type d'utilisateur a voulu être enregistrer
        If nbFiche = -1 Then
            Dim unVisiteur As New visiteur(idUser, name, surname, login, mdp, adr, cp, ville, dateEbauche)
            CollectionVisiteur.Add(unVisiteur) ' on l'ajoute à la collection de visiteur
        Else
            Dim unComptable As New comptable(idUser, name, surname, login, mdp, adr, cp, ville, dateEbauche, nbFiche)
            CollectionComptable.Add(unComptable) ' on l'ajoute à la collection de comptable
        End If

        'On insére maintenant l'utilisateur pour effectuer la persistance des données
        ConnexionSQL.Insert_Update_User(idUser, name, surname, login, mdp, adr, cp, ville, dateEbauche, nbFiche)
    End Sub




    'Procédure qui va permettre de gérer l'association entre un visiteur et un véhicule
    Sub addVehicule_Visiteur(immat As String, id As Integer, dateDebut As Date, dateFin As Date)

        Try
            ConnexionSQL.verifDispoVehicule(immat, dateDebut)
        Catch ex As Exception
            MsgBox(ex.Message) 'On affiche ici le message renvoyé par la fonction
        End Try


        'Si l'exception n'a pas été levé alors on crée notre objet
        Dim voitureUtilise As New voitureUtilise(trouverVehicule(immat), trouverVisiteur(id), dateDebut, dateFin)
        CollectionVoitureUtiliser.Add(voitureUtilise)

        'On met en lien le véhicule avec le visiteur dans la BDD afin de faire persister les données
        ConnexionSQL.insertUtiliser(immat, dateDebut, id, dateFin)
    End Sub




    Function doubleCryptage(value As String)
        Dim valueCrypte = cryptage_carré_Vigenére(value) 'On crypte une première fois avec le carré de vigenére
        valueCrypte = cryptValue(valueCrypte) 'On recrypte grâce au cryptage du système
        Return valueCrypte 'on reourne la valeur
    End Function


    Function doubleDecryptage(value As String)
        Dim valueDecrypte = deryptValue(value) 'On décrypte une première fois avec le décryptage du système
        valueDecrypte = décryptage_carré_Vigenére(valueDecrypte) 'On décrypte ensuite avec le décryptage du crré de vigenére
        Return valueDecrypte 'on retourne enfin la valeur décrypter
    End Function
End Module

