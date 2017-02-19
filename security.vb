Imports System.Security.Cryptography
Imports System.Text
Module security

    ' since everything in this project is being stored in .txt files eveyrthing will be either hashed or encrypted.

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="data"></param>
    ''' <returns></returns>
    Public Function encrypt(ByVal data As String, ByVal key As Char) As String
        Dim intKey As Integer = Convert.ToInt32(key)

        Dim charString As Char() = data.ToCharArray()
        Dim encryptedString As String = ""
        For i = 0 To charString.Length - 1
            Dim intChar As Integer = Convert.ToInt32(charString(i))
            intChar += intKey
            If Convert.ToChar(intChar) = ","c Then
                encryptedString += "#"
            Else
                encryptedString += Convert.ToChar(intChar)
            End If

        Next

        Return encryptedString
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="data"></param>
    ''' <param name="key"></param>
    ''' <returns></returns>
    Public Function decrypt(ByVal data As String, ByVal key As Char) As String
        Dim intKey As Integer = Convert.ToInt32(key)

        Dim charString As Char() = data.ToCharArray()
        Dim decryptedString As String = ""
        For i = 0 To charString.Length - 1
            Dim intChar As Integer = Convert.ToInt32(charString(i))
            intChar -= intKey
            If Convert.ToChar(intChar) = ","c Then
                decryptedString &= "#"
            Else
                decryptedString &= Convert.ToChar(intChar)
            End If

        Next

        Return decryptedString
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="data"></param>
    ''' <param name="salt"></param>
    ''' <returns></returns>
    Public Function hash(ByVal data As String, ByVal salt As String) As String

        Dim bytes As Byte() = Encoding.UTF8.GetBytes(data & salt)
        Dim sha512 As HashAlgorithm = New SHA512Managed()
        Dim hashedBytes As Byte() = sha512.ComputeHash(bytes)

        Return Convert.ToBase64String(hashedBytes)
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="length"></param>
    ''' <returns></returns>
    Public Function generateSalt(length As String) As String

        Dim salt As String = ""
        Dim rndNumber As Integer = 0
        Dim chars As Char() = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890!£$%^&*(){}~@:?><".ToCharArray()

        Dim i As Integer = 0
        For i = 1 To length
            Randomize()
            rndNumber = Int(chars.Length * Rnd())
            salt += chars(rndNumber)
        Next

        Return salt
    End Function
End Module
