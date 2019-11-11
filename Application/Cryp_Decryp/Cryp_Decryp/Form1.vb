Imports System.Security.Cryptography
Imports System.Text
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim TexteEnBytes() As Byte = Encoding.UTF8.GetBytes(TextBox1.Text)
        Dim KeyBytes() As Byte = Encoding.UTF8.GetBytes("admin974")
        Dim Crypto As New DESCryptoServiceProvider()
        Crypto.Key = KeyBytes
        Crypto.IV = KeyBytes
        Dim Icrypto As ICryptoTransform = Crypto.CreateEncryptor()
        Dim ResultatBytes() As Byte = Icrypto.TransformFinalBlock(TexteEnBytes, 0, TexteEnBytes.Length)
        TextBox3.Text = Convert.ToBase64String(ResultatBytes)
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ResultatBytes() As Byte = Convert.FromBase64String(TextBox2.Text)
        Dim KeyBytes() As Byte = Encoding.UTF8.GetBytes("admin974")
        Dim Crypto As New DESCryptoServiceProvider()
        Crypto.Key = KeyBytes
        Crypto.IV = KeyBytes
        Dim Icrypto As ICryptoTransform = Crypto.CreateDecryptor()
        Dim Donnees() As Byte = Icrypto.TransformFinalBlock(ResultatBytes, 0, ResultatBytes.Length)
        TextBox4.Text = Encoding.UTF8.GetString(Donnees)
    End Sub
End Class
