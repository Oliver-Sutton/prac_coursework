Imports System.IO
Module fileHandler
    Function readFile(fileUrl As String) As String
        Dim fileString As String = ""

        Dim fileStream As FileStream = New FileStream(fileUrl, FileMode.Open, FileAccess.Read)
        Dim streamReader As StreamReader = New StreamReader(fileStream)

        Do Until streamReader.Peek() = -1
            fileString += streamReader.ReadLine
        Loop

        fileStream.Close()

        Return fileString

    End Function

    Function getUser(fileUrl As String, user As String) As String
        Dim userString As String = ""

        Dim fileStream As FileStream = New FileStream(fileUrl, FileMode.Open, FileAccess.Read)
        Dim streamReader As StreamReader = New StreamReader(fileStream)

        Dim tempUsers As String = ""
        Dim users() As String

        Do Until streamReader.Peek() = -1
            tempUsers += streamReader.ReadLine()
        Loop

        users = tempUsers.Split("#")
        Array.Resize(users, user.Length - 1)

        For i = 1 To user.Length
            Dim userSplit = users(i).Split(",")
            If user = userSplit(2) Then
                userString = user(i)
                Exit For
            End If
        Next

        Return userString

    End Function

    Public Sub changeUser(fileUrl As String, user As String)

    End Sub
End Module
