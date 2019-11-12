Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports System.Data.SqlClient
Module functionUse

    'Fichier .ini
    Public Auth As New Dictionary(Of String, String)
    Public Database As New Dictionary(Of String, String)


    'Database
    Public MyConnexion As New SqlConnection("Data Source=" + Database.Item("serveur") + ";" & _
        "Integrated Security=True;Initial Catalog=" + Database.Item("baseDeDonnees"))
    'BDD BIBI
    'On ce connecte à la base de données
    'Public MyConnexion As New SqlConnection("Data Source=" + Database.Item("serveur") + ";Initial Catalog=" + Database.Item("baseDeDonnees") & _
    ' ";User Id=" + Database.Item("user") + ";Password=" + Database.Item("mdpUser") + ";")



    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Méthode de connexion à la base de données
    Sub ConnexionSQLServeur()
        Try
            MyConnexion.Open()
        Catch ex As Exception
            MsgBox("La connexion à la base de données a échouée")
        End Try
    End Sub
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------




    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------
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
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------



    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Fonction permettant de récupérer les informations dans le fichier .ini et décrypte les valeurs 
    Sub lectureFichier_Config()
        'Récupération du fichier de configuration au format .ini
        Dim Lignes() As String = File.ReadAllLines("config Local.ini")
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

                'On décrypte en passant par notre méthode de décryptage
                value = decryptValue(value)

                ' Ajoute dans le tableau la valeur
                If paragraphe = "Auth" Then
                    Auth.Add(key, value)
                ElseIf paragraphe = "Database" Then
                    Database.Add(key, value)
                End If
            End If
        Next
    End Sub
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------


    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Fonction pour décrypter la valeur qu'on lui envoie
    Function decryptValue(texte As String)

        'Décrypte la valeur
        Dim ResultatBytes() As Byte = Convert.FromBase64String(texte)

        Dim KeyBytes() As Byte = Encoding.UTF8.GetBytes("aGioP782")
        Dim Crypto As New DESCryptoServiceProvider()
        Crypto.Key = KeyBytes
        Crypto.IV = KeyBytes
        Dim Icrypto As ICryptoTransform = Crypto.CreateDecryptor()

        Dim Donnees() As Byte = Icrypto.TransformFinalBlock(ResultatBytes, 0, ResultatBytes.Length)

        'Récupération de la ligne décoder
        Dim txtModif As String = Encoding.UTF8.GetString(Donnees)

        'retourne la valeur
        Return txtModif
    End Function
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------

End Module

