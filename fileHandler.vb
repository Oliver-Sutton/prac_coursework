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

    Public Sub changeUser(fileUrl As String, user As String, edit As String, arrayVal As Integer)

        Dim fileSteamRead As FileStream = New FileStream(fileUrl, FileMode.Open, FileAccess.Read)
        Dim streamReader As StreamReader = New StreamReader(fileSteamRead)

        Dim tempUsers As String = ""
        Dim users() As String

        Do Until streamReader.Peek() = -1
            tempUsers += streamReader.ReadLine()
        Loop

        streamReader.Close()
        fileSteamRead.Close()

        users = tempUsers.Split("#")
        Array.Resize(users, users.Length - 1)

        Dim newUsersTemp As String = ""
        Dim changedUser As String = ""

        For i = 0 To users.Length - 1
            Dim usersSplit() As String = users(i).Split(",")
            If usersSplit(3) <> user Then
                newUsersTemp += user(i) & "#"
            ElseIf usersSplit(3) = user Then
                changedUser = user(i)
            End If
        Next

        Dim changedUserArray() As String = changedUser.Split(",")

        Dim newChangedUser As String = ""

        For i = 0 To changedUserArray.Length - 1
            If i <> arrayVal Then
                newChangedUser += changedUserArray(i) & ","
            ElseIf i = arrayVal Then
                newChangedUser += edit & ","
            End If
        Next

        newChangedUser = newChangedUser.Substring(0, newChangedUser.Length - 1)
        Dim fileStreamWrite As FileStream = New FileStream(fileUrl, FileMode.Append, FileAccess.Write)
        Dim writerStream As StreamWriter = New StreamWriter(fileStreamWrite)

        Dim newUsers() As String = newUsersTemp.Split("#")

        For i = 0 To newUsers.Length
            writerStream.WriteLine(newUsers(i) & "#")
        Next
        writerStream.WriteLine(newChangedUser & "#")

        fileStreamWrite.Close()

    End Sub
End Module
