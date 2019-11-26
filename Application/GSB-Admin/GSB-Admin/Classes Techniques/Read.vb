Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text


Public Class Read
    


    Dim Lignes() As String = File.ReadAllLines("test.txt")


    Public Function lectureFichier(ByRef Login As String, ByRef mdp As String) As Boolean



        Dim ResultatBytes() As Byte = Convert.FromBase64String(Lignes(0))
        Dim ResultatBytes1() As Byte = Convert.FromBase64String(Lignes(1))
        Dim KeyBytes() As Byte = Encoding.UTF8.GetBytes("admin974")
        Dim Crypto As New DESCryptoServiceProvider()
        Crypto.Key = KeyBytes
        Crypto.IV = KeyBytes
        Dim Icrypto As ICryptoTransform = Crypto.CreateDecryptor()
        Dim Donnees() As Byte = Icrypto.TransformFinalBlock(ResultatBytes, 0, ResultatBytes.Length)
        Dim Donnees1() As Byte = Icrypto.TransformFinalBlock(ResultatBytes1, 0, ResultatBytes1.Length)
        Login = Encoding.UTF8.GetString(Donnees)
        mdp = Encoding.UTF8.GetString(Donnees1)

        If Encoding.UTF8.GetString(Donnees) = Login And Encoding.UTF8.GetString(Donnees1) = mdp Then
            Return True
        Else
            Return False
        End If

    End Function


    Public Sub ConnexionBDD()
        Dim ChaineConnexion As String
        Dim ResultatBytes() As Byte = Convert.FromBase64String(Lignes(2))
        Dim KeyBytes() As Byte = Encoding.UTF8.GetBytes("admin974")
        Dim Crypto As New DESCryptoServiceProvider()
        Crypto.Key = KeyBytes
        Crypto.IV = KeyBytes
        Dim Icrypto As ICryptoTransform = Crypto.CreateDecryptor()
        Dim Donnees() As Byte = Icrypto.TransformFinalBlock(ResultatBytes, 0, ResultatBytes.Length)
        ChaineConnexion = Encoding.UTF8.GetString(Donnees)

        Dim MyConnexion As SqlConnection = New SqlConnection(ChaineConnexion)

        Dim MycommandServ As SqlCommand = MyConnexion.CreateCommand()

        MycommandServ.CommandText = "SELECT vehicule.* FROM vehicule"
       MyConnexion.Open()
        Dim myReaderServ As SqlDataReader = MycommandServ.ExecuteReader()
       


        myReaderServ.Close()
        MyConnexion.Close()
       
    End Sub


 

End Class
