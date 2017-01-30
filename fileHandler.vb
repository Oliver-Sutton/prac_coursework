Imports System.IO
Module fileHandler
    Function readFile(fileUrl As String) As String
        Dim fileString As String = ""

        Dim fileStream As FileStream = New FileStream(fileUrl, FileMode.Open, FileAccess.Read)
        Dim streamReader As StreamReader = New StreamReader(fileStream)

        Do Until streamReader.Peek() = -1
            fileString += streamReader.ReadLine
        Loop

        fileStream.Flush()
        streamReader.Close()
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

    ''' <summary>
    '''     This function checks if the search value is unique to the file url your parse, arrayVal is the postion the unique item is in from 0
    ''' </summary>
    ''' <param name="search"></param>
    ''' <returns>If username is unique returns true else false</returns>
    Public Function isUnique(search As String, fileUrl As String, arrayVal As Integer) As Boolean

        Dim tempItems As String = readFile(fileUrl)
        Dim items = tempItems.Split("#")

        If items(items.Length - 1) = "" Then
            Array.Resize(items, items.Length - 1)
        End If

        For i = 0 To items.Length - 1
            Dim itemSplit = items(i).Split(",")
            If search = itemSplit(arrayVal) Then
                Return False
            End If
        Next
        Return True
    End Function

    Public Sub changeUser(fileUrl As String, current As String, username As String, edit As String, arrayVal As Integer)

        Dim fileSteamRead As FileStream = New FileStream(fileUrl, FileMode.Open, FileAccess.Read)
        Dim streamReader As StreamReader = New StreamReader(fileSteamRead)

        Dim tempUsers As String = ""
        Dim users() As String

        Do Until streamReader.Peek() = -1
            tempUsers += streamReader.ReadLine()
        Loop

        fileSteamRead.Flush()
        streamReader.Close()
        fileSteamRead.Close()

        users = tempUsers.Split("#")
        Array.Resize(users, users.Length - 1)

        Dim newUsersTemp As String = ""
        Dim changedUser As String = ""

        For i = 0 To users.Length - 1
            Dim usersSplit() As String = users(i).Split(",")
            If usersSplit(arrayVal) <> current Or usersSplit(2) <> username Then
                newUsersTemp += users(i) & "#"
            ElseIf usersSplit(arrayVal) = current And usersSplit(2) = username Then
                changedUser = users(i)
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
        Dim fileStreamWrite As FileStream = New FileStream(fileUrl, FileMode.Truncate, FileAccess.Write)
        Dim writerStream As StreamWriter = New StreamWriter(fileStreamWrite)

        Dim newUsers() As String = newUsersTemp.Split("#")
        Array.Resize(newUsers, newUsers.Length - 1)

        For i = 0 To newUsers.Length - 1
            writerStream.WriteLine(newUsers(i) & "#")
        Next
        writerStream.WriteLine(newChangedUser & "#")

        fileStreamWrite.Flush()
        writerStream.Close()
        fileStreamWrite.Close()

    End Sub

    Public Sub backupFile(fileUrl As String)
        Dim fileUrlSplit() As String = fileUrl.Split(".")
        Dim strDate As String = Date.Today
        Dim dateSplit() As String = strDate.Split("/")
        Dim backupfileUrl As String = fileUrlSplit(0) & "_" & dateSplit(0) & "_" & dateSplit(1) & "_" & dateSplit(2) & ".txt"


        Dim fileStreamMain As FileStream = New FileStream(fileUrl, FileMode.Open, FileAccess.Read)
        Dim readerStream As StreamReader = New StreamReader(fileStreamMain)

        Dim backupString As String = ""

        Do
            backupString += readerStream.ReadLine()
        Loop Until readerStream.Peek = -1

        fileStreamMain.Flush()
        readerStream.Close()
        fileStreamMain.Close()

        Dim backupItems() As String = backupString.Split("#")
        Array.Resize(backupItems, backupItems.Length - 1)

        Dim fileStreamBackup As FileStream = New FileStream(backupfileUrl, FileMode.Truncate, FileAccess.Write)
        Dim writerStreamBackup As StreamWriter = New StreamWriter(fileStreamBackup)

        For i = 0 To backupItems.Length - 1
            writerStreamBackup.WriteLine(backupItems(i) & "#")
        Next

        fileStreamBackup.Flush()
        writerStreamBackup.Close()
        fileStreamBackup.Close()

    End Sub
End Module
