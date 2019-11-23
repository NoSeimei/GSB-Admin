Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Module fonction
    Public Auth As New Dictionary(Of String, String)
    Public Database As New Dictionary(Of String, String)
    Private key As String = "GS"

<<<<<<< Updated upstream
=======

>>>>>>> Stashed changes
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
        Dim Lignes() As String = File.ReadAllLines("CryptFile/localConfig.ini")
        'Récupération du fichier (PPE)
        'Dim Lignes() As String = File.ReadAllLines("CryptFile/config.ini")
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

    Public Function IncreVisiteur() As Integer
        Dim i As Integer = 0
        For Each UnVisiteur In CollectionVisiteur
            If UnVisiteur.idUser > i Then
                i = UnVisiteur.idUser
            End If
        Next
        Return i + 1
    End Function

    Public Function IncreComptable() As Integer
        Dim i As Integer = 0
        For Each UnComptable In CollectionComptable
            If UnComptable.idUser > i Then
                i = UnComptable.idUser
            End If
        Next
        Return i + 1
    End Function



    'Méthode pour permettre le cryptage d'une donnée grâce à la méthode du carre de vigenère
    Function cryptage_carré_Vigenére(valeur As String)
        'Valeur crypté qui sera retourné
        Dim valeurCrytpe As String = ""
        valeur = valeur.ToCharArray

        'Récupération du fichier du fichier texte permettant le cryptage
        Dim Lignes() As String = File.ReadAllLines("CryptFile/all_touche.txt", Encoding.Default)
        'Tableau contenant notre première ligne du carré de vigenère
        Dim tabVigene As New ArrayList



        'Parcourt du fichier texte afin d'en récupérer les informations
        For caracteres As Integer = 0 To Lignes.Length - 1
            tabVigene.Add(Lignes(caracteres))
        Next


        'On parcourt maintenant la valeur qui nous as été envoyé pour en crypter cahque caractères
        For i As Integer = 0 To valeur.Length - 1
            'On récupére le caractère i de la chaîne
            Dim indexPremierLigne = tabVigene.IndexOf(valeur.Substring(i, 1))
            Dim indexKey As Integer
            'Permet d'avoir la position de notre caractères i dans notre tableau
            Dim indexCleCryptage As Integer

            'On vérifie tout d'abord sur quels caractères de la clé le cryptage sera effectué en fonction
            ' de la valeur envoyé
            If key.Length <= i Then
                indexKey = key.IndexOf(key.Substring(i Mod key.Length, 1))
                indexCleCryptage = tabVigene.IndexOf(tabVigene.Item(indexKey))
            Else
                indexCleCryptage = tabVigene.IndexOf(key.Substring(i, 1))
            End If


            Dim caracteresCryptage As String
            'Maintenant on crypte le caratère et on le conserve
            If indexPremierLigne + indexCleCryptage > tabVigene.Count - 1 Then
                Dim indexOfCaracteres = indexCleCryptage - ((tabVigene.Count - 1) - (indexPremierLigne))
                caracteresCryptage = tabVigene(indexOfCaracteres)
            Else
                caracteresCryptage = tabVigene(indexCleCryptage)
            End If


            valeurCrytpe = valeurCrytpe + caracteresCryptage
        Next


        Return valeurCrytpe
    End Function



<<<<<<< Updated upstream
    'Méthode pour permettre le décryptage d'une donnée grâce à la méthode du carre de vigenère
    Function décryptage_carré_Vigenére(valeur As String)
        Dim valeurDecrypte As String

        Return valeurDecrypte
    End Function
=======
>>>>>>> Stashed changes
End Module

