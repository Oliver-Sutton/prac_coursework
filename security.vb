Imports System.Security.Cryptography
Imports System.Text
Module security

    ''' since everything in this project is being stored in .txt files eveyrthing will be either hashed or encrypted.
    ''' <summary>
    '''     This function encrypts data using a shift beased on value of the key you input.
    ''' </summary>
    ''' <param name="data">The data that you want to encrypt.</param>
    ''' <param name="key">The key you want to encrypt the data by.</param>
    ''' <returns>Returns the encrypted string that has been encrypted.</returns>
    Public Function encrypt(ByVal data As String, ByVal key As Char) As String
        Dim intKey As Integer = Convert.ToInt32(key) ' turns the key into a integer value.

        Dim charString As Char() = data.ToCharArray() 'puts the data string into a char array.
        Dim encryptedString As String = "" ' inits the string that will be returned.
        For i = 0 To charString.Length - 1 ' loops through all of the characters in the data.
            Dim intChar As Integer = Convert.ToInt32(charString(i)) ' turns the single character into a integer to be shifted.
            intChar += intKey ' shifts the character by the key.
            encryptedString += Convert.ToChar(intChar)
        Next

        Return encryptedString
    End Function

    ''' <summary>
    '''     This function decrypts data using the opposite shift that the encrypt uses.
    ''' </summary>
    ''' <param name="data">The encrypted that you want to decrypt.</param>
    ''' <param name="key">The key that the data was encrypted by.</param>
    ''' <returns>Returns the decrypted string that has been decrypted.</returns>
    Public Function decrypt(ByVal data As String, ByVal key As Char) As String
        Dim intKey As Integer = Convert.ToInt32(key) ' turns the key into a integer value.

        Dim charString As Char() = data.ToCharArray() 'puts the data string into a char array.
        Dim decryptedString As String = "" ' inits the string that will be returned.
        For i = 0 To charString.Length - 1 ' loops through all of the characters in the data.
            Dim intChar As Integer = Convert.ToInt32(charString(i)) ' turns the single character into a integer to be shifted.
            intChar -= intKey ' shifts the character down by the key.
            decryptedString += Convert.ToChar(intChar)
        Next

        Return decryptedString
    End Function

    ''' <summary>
    '''     Hashes data using salt and SHA512.
    ''' </summary>
    ''' <param name="data">The data that you want to hash.</param>
    ''' <param name="salt">Salt you want to hash with.</param>
    ''' <returns>Returns a hashed string.</returns>
    Public Function hash(ByVal data As String, ByVal salt As String) As String

        Dim bytes As Byte() = Encoding.UTF8.GetBytes(data & salt) ' adds the string and salt together, transforms then into bytes.
        Dim sha512 As HashAlgorithm = New SHA512Managed() ' generates a new sha512 hashing algorithm.
        Dim hashedBytes As Byte() = sha512.ComputeHash(bytes) ' puts the bytes into the hashing algorithm 

        Return Convert.ToBase64String(hashedBytes) ' converts the hashedBytes into a base 64 string.
    End Function

    ''' <summary>
    '''     Generates random salt for hashing.
    ''' </summary>
    ''' <param name="length">The length of the salt you want to generate.</param>
    ''' <returns>Returns the length of salt that you parsed.</returns>
    Public Function generateSalt(length As String) As String

        Dim salt As String = ""
        Dim rndNumber As Integer = 0
        Dim chars As Char() = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890!£$%^&*(){}~@:?><".ToCharArray() ' generates a char array for the salt.

        Dim i As Integer = 0
        For i = 1 To length
            Randomize()
            rndNumber = Int(chars.Length * Rnd()) ' creates a random number between the char length.
            salt += chars(rndNumber) ' adds charcacter to the salt string.
        Next

        Return salt
    End Function
End Module
