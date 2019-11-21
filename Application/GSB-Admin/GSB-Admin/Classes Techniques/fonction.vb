Imports System.IO
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

        'Récupération du fichier de configuration au format .ini
        Dim Lignes() As String = File.ReadAllLines("CryptFile/LocalConfig.ini")
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




    'Permet de retourner le visiteur s'il existe
    Function trouverVisiteur(idVisiteur As Integer)
        For Each unVisiteur In CollectionVisiteur
            If unVisiteur.idUser = idVisiteur Then
                Return unVisiteur
            End If
        Next

        Throw New Exception("Ce visiteur n'existe pas")
    End Function


    'Permet de retourner le véhicule s'il existe
    Function trouverVehicule(immat As String)
        For Each unVehicule In CollectionVehicule
            If unVehicule.LireImmat = immat Then
                Return unVehicule
            End If
        Next

        Throw New Exception("Cette immatriculation n'existe pas")
    End Function


    'Permet de retourner l'utilisateur s'il existe
    Function trouverUtilisateur(id As Integer)
        For Each unUser In CollectionUser
            If unUser.idUser = id Then
                Return unUser
            End If
        Next

        Throw New Exception("Cette utilisateur n'existe pas")
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



End Module
