Imports System.IO
Module fileHandler
    ''' <summary>
    '''     Reads an entire file returning all of its records in a single string using "#" to split.
    ''' </summary>
    ''' <param name="fileUrl">Url of the file you want to read.</param>
    ''' <returns>Every record in the file.</returns>
    Function readFile(ByVal fileUrl As String) As String

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

    ''' <summary>
    '''     Gets a single record using a primary key.
    ''' </summary>
    ''' <param name="fileUrl">Url of the file you want to get the record from.</param>
    ''' <param name="key">Primary key that you are going to search with.</param>
    ''' <param name="arrayVal">Position in the record that the primary key is at from 0</param>
    ''' <returns>A record if it is found </returns>
    Function getRecord(ByVal fileUrl As String, ByVal key As String, ByVal arrayVal As Integer) As String

        Dim recordString As String = ""

        Dim fileStream As FileStream = New FileStream(fileUrl, FileMode.Open, FileAccess.Read)
        Dim streamReader As StreamReader = New StreamReader(fileStream)

        Dim tempRecords As String = ""
        Dim records() As String

        Do Until streamReader.Peek() = -1
            tempRecords += streamReader.ReadLine()
        Loop

        fileStream.Flush()
        streamReader.Close()
        fileStream.Close()

        records = tempRecords.Split("#")
        Array.Resize(records, records.Length - 1)

        For i = 0 To records.Length - 1
            Dim recordSplit = records(i).Split(",")
            If key = recordSplit(arrayVal) Then
                recordString = records(i)
                Exit For
            End If
        Next

        Return recordString

    End Function

    ''' <summary>
    '''     This function checks if the search value is unique to the file url your parse, arrayVal is the postion the unique item is in from 0
    ''' </summary>
    ''' <param name="search"></param>
    ''' <returns>If username is unique returns true else false</returns>
    Public Function isUnique(ByVal search As String, ByVal fileUrl As String, ByVal arrayVal As Integer) As Boolean

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

    ''' <summary>
    '''     This class edits a record that already in a file.
    ''' </summary>
    ''' <param name="fileUrl">The url of the file you want to edit</param>
    ''' <param name="currentValue">Current value of the item you are changing</param>
    ''' <param name="key">Primary key of the record you are editing</param>
    ''' <param name="newValue">New valye of the item you are changing</param>
    ''' <param name="arrayVal">Position the field is in from 0</param>
    ''' <param name="keyVal">Postion the primary key is in from 0</param>
    Public Sub changeRecord(ByVal fileUrl As String, ByVal currentValue As String, ByVal key As String, ByVal newValue As String, ByVal arrayVal As Integer, ByVal keyVal As Integer)

        Dim fileSteamRead As FileStream = New FileStream(fileUrl, FileMode.Open, FileAccess.Read)
        Dim streamReader As StreamReader = New StreamReader(fileSteamRead)

        Dim tempRecords As String = ""
        Dim records() As String

        Do Until streamReader.Peek() = -1
            tempRecords += streamReader.ReadLine()
        Loop

        fileSteamRead.Flush()
        streamReader.Close()
        fileSteamRead.Close()

        records = tempRecords.Split("#")
        Array.Resize(records, records.Length - 1)

        Dim newRecordsTemp As String = ""
        Dim changedRecord As String = ""

        For i = 0 To records.Length - 1
            Dim usersSplit() As String = records(i).Split(",")
            If usersSplit(arrayVal) <> currentValue Or usersSplit(keyVal) <> key Then
                newRecordsTemp += records(i) & "#"
            ElseIf usersSplit(arrayVal) = currentValue And usersSplit(keyVal) = key Then
                changedRecord = records(i)
            End If
        Next

        Dim changedRecordArray() As String = changedRecord.Split(",")
        Dim newChangedRecord As String = ""

        For i = 0 To changedRecordArray.Length - 1
            If i <> arrayVal Then
                newChangedRecord += changedRecordArray(i) & ","
            ElseIf i = arrayVal Then
                newChangedRecord += newValue & ","
            End If
        Next

        newChangedRecord = newChangedRecord.Substring(0, newChangedRecord.Length - 1)
        Dim fileStreamWrite As FileStream = New FileStream(fileUrl, FileMode.Truncate, FileAccess.Write)
        Dim writerStream As StreamWriter = New StreamWriter(fileStreamWrite)

        Dim newRecords() As String = newRecordsTemp.Split("#")
        Array.Resize(newRecords, newRecords.Length - 1)

        For i = 0 To newRecords.Length - 1
            writerStream.WriteLine(newRecords(i) & "#")
        Next
        writerStream.WriteLine(newChangedRecord & "#")

        fileStreamWrite.Flush()
        writerStream.Close()
        fileStreamWrite.Close()

    End Sub

    ''' <summary>
    '''     This class removes record from a file using its primary key.
    ''' </summary>
    ''' <param name="fileUrl">Url that the file is stored in</param>
    ''' <param name="id">The primary key of record being deleted</param>
    Public Sub removeRecord(ByVal fileUrl As String, ByVal id As String, ByVal arrayVal As Integer)

        Dim fileStream As FileStream = New FileStream(fileUrl, FileMode.Open, FileAccess.Read)
        Dim readerStream As StreamReader = New StreamReader(fileStream)

        Dim tempRecords As String = ""

        Do Until readerStream.Peek = -1
            tempRecords += readerStream.ReadLine()
        Loop

        Dim records() As String = tempRecords.Split("#")
        Array.Resize(records, records.Length - 1)

        Dim newRecords As String = ""

        For i = 0 To records.Length - 1
            Dim recordSplit() As String = records(i).Split(",")
            If id <> recordSplit(arrayVal) Then
                newRecords += records(i) & "#"
            End If
        Next

        fileStream.Flush()
        readerStream.Close()
        fileStream.Close()


        Dim fileStreamWriter As FileStream = New FileStream(fileUrl, FileMode.Truncate, FileAccess.Write)
        Dim writerStream As StreamWriter = New StreamWriter(fileStreamWriter)

        Dim newRecordsSplit() As String = newRecords.Split("#")
        Array.Resize(newRecordsSplit, newRecordsSplit.Length - 1)

        For i = 0 To newRecordsSplit.Length - 1
            writerStream.WriteLine(newRecordsSplit(i) & "#")
        Next

        fileStreamWriter.Flush()
        writerStream.Close()
        fileStreamWriter.Close()

    End Sub

    ''' <summary>
    '''     Duplicates current state of the file you parse adding the current date onto the file to identify it.
    ''' </summary>
    ''' <param name="fileUrl">The url of th file that you want to backup</param>
    Public Sub backupFile(ByVal fileUrl As String)

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

        Dim fileStreamBackup As FileStream = New FileStream(backupfileUrl, FileMode.Create, FileAccess.Write)
        Dim writerStreamBackup As StreamWriter = New StreamWriter(fileStreamBackup)

        For i = 0 To backupItems.Length - 1
            writerStreamBackup.WriteLine(backupItems(i) & "#")
        Next

        fileStreamBackup.Flush()
        writerStreamBackup.Close()
        fileStreamBackup.Close()

    End Sub

    ''' <summary>
    '''     Adds record to file you parse.
    ''' </summary>
    ''' <param name="fileUrl">Url of the file you want to add the record to</param>
    ''' <param name="record">The complete string of the record you want to add.</param>
    Public Sub addRecord(ByVal fileUrl As String, ByVal record As String)

        Dim fileStream As FileStream = New FileStream(fileUrl, FileMode.Append, FileAccess.Write)
        Dim writerStream As StreamWriter = New StreamWriter(fileStream)

        writerStream.WriteLine(record)

        fileStream.Flush()
        writerStream.Close()
        fileStream.Close()

    End Sub
End Module
