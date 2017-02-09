Imports System.IO
Module fileHandler
    ''' <summary>
    '''     Reads an entire file returning all of its records in a single array.
    ''' </summary>
    ''' <param name="fileUrl">Url of the file you want to read.</param>
    ''' <returns>Every record in the file.</returns>
    Function readFile(ByVal fileUrl As String) As String()

        Dim fileContents(0) As String

        ' opens filestreams ready for the file to be read.
        Dim fileStream As FileStream = New FileStream(fileUrl, FileMode.Open, FileAccess.Read)
        Dim streamReader As StreamReader = New StreamReader(fileStream)

        ' reads the entire file adding it to filecontents array.
        Do Until streamReader.Peek() = -1
            fileContents(fileContents.Length - 1) = streamReader.ReadLine
            Array.Resize(fileContents, fileContents.Length + 1)
        Loop

        Array.Resize(fileContents, fileContents.Length - 1)

        ' closes and flushes the filestream readying it for use again.
        fileStream.Flush()
        streamReader.Close()
        fileStream.Close()

        ' returns the entire array of the records in the array.
        Return fileContents

    End Function

    ''' <summary>
    '''     Gets a single record using a primary key.
    ''' </summary>
    ''' <param name="fileUrl">Url of the file you want to get the record from.</param>
    ''' <param name="key">Primary key that you are going to search with.</param>
    ''' <param name="arrayVal">Position in the record that the primary key is at from 0</param>
    ''' <returns>A record if it is found </returns>
    Function getRecord(ByVal fileUrl As String, ByVal key As String, ByVal arrayVal As Integer) As String

        ' create variable that will be returned at end of function.
        Dim recordString As String = ""

        ' opens new filestream ready ot read the file.
        Dim fileStream As FileStream = New FileStream(fileUrl, FileMode.Open, FileAccess.Read)
        Dim streamReader As StreamReader = New StreamReader(fileStream)

        Dim records(0) As String

        ' reads every record in the file.
        Do Until streamReader.Peek() = -1
            records(records.Length - 1) = streamReader.ReadLine
            Array.Resize(records, records.Length + 1)
        Loop

        Array.Resize(records, records.Length - 1)

        ' closes and flushes the file so it is ready for use again.
        fileStream.Flush()
        streamReader.Close()
        fileStream.Close()

        ' searches through all of the items at the value given to add to the recordString and to be returned. (Exits sub once found.)
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

        ' gets all of the items in a file by caling readFile() above it.
        Dim items() As String = readFile(fileUrl)

        ' if the search value is equal to something at that array value in the file it will return false that it is not unique.
        For i = 0 To items.Length - 1
            Dim itemSplit = items(i).Split(",")
            If search = itemSplit(arrayVal) Then
                Return False
            End If
        Next

        ' else it will return that it is true that it is unique.
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

        ' opem filestreams to read the data.
        Dim fileSteamRead As FileStream = New FileStream(fileUrl, FileMode.Open, FileAccess.Read)
        Dim streamReader As StreamReader = New StreamReader(fileSteamRead)

        Dim records(0) As String

        ' adds items to the array resizing the array allowing for dynamic file sizes.
        Do Until streamReader.Peek() = -1
            records(records.Length - 1) = streamReader.ReadLine()
            Array.Resize(records, records.Length + 1)
        Loop

        ' takes the last value from the array that will be equal to nothing anyway.
        Array.Resize(records, records.Length - 1)

        ' closes and flushes all the filestreams ready for writer streams.
        fileSteamRead.Flush()
        streamReader.Close()
        fileSteamRead.Close()

        Dim newRecords(0) As String
        Dim changedRecord(0) As String

        ' loops through all the records. At the each record checking is the current values are equal and the primary keys are equal so it can make the changed in data.
        For i = 0 To records.Length - 1
            Dim usersSplit() As String = records(i).Split(",")
            If usersSplit(arrayVal) <> currentValue Or usersSplit(keyVal) <> key Then
                newRecords(newRecords.Length - 1) = records(i)
                Array.Resize(newRecords, newRecords.Length + 1)
            ElseIf usersSplit(arrayVal) = currentValue And usersSplit(keyVal) = key Then
                changedRecord(changedRecord.Length - 1) = records(i)
            End If
        Next

        Array.Resize(newRecords, newRecords.Length - 1)

        Dim changedRecordArray() As String = changedRecord(0).Split(",")
        Dim newChangedRecord As String = ""

        ' loops through the changed item and changed the item that needs to be changed to it new value. 
        For i = 0 To changedRecordArray.Length - 1
            If i <> arrayVal Then
                newChangedRecord += changedRecordArray(i) & ","
            ElseIf i = arrayVal Then
                newChangedRecord += newValue & ","
            End If
        Next

        ' removes the , that is added by the process.
        newChangedRecord = newChangedRecord.Substring(0, newChangedRecord.Length - 1)

        ' opens new filestream ready to write the new data, clearing the old data.
        Dim fileStreamWrite As FileStream = New FileStream(fileUrl, FileMode.Truncate, FileAccess.Write)
        Dim writerStream As StreamWriter = New StreamWriter(fileStreamWrite)

        ' writes the old and new data to the file.
        For i = 0 To newRecords.Length - 1
            writerStream.WriteLine(newRecords(i))
        Next

        writerStream.WriteLine(newChangedRecord)

        'closes the filestreams
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

        ' opens filestream ready to read file.
        Dim fileStream As FileStream = New FileStream(fileUrl, FileMode.Open, FileAccess.Read)
        Dim readerStream As StreamReader = New StreamReader(fileStream)

        Dim records(0) As String

        ' reads the file.
        Do Until readerStream.Peek = -1
            records(records.Length - 1) = readerStream.ReadLine()
            Array.Resize(records, records.Length + 1)
        Loop

        Array.Resize(records, records.Length - 1)

        Dim newRecords(0) As String

        ' adds items to new records if its Primary Key is not equal to the one being removed.
        For i = 0 To records.Length - 1
            Dim recordSplit() As String = records(i).Split(",")
            If id <> recordSplit(arrayVal) Then
                newRecords(newRecords.Length - 1) = records(i)
                Array.Resize(newRecords, newRecords.Length + 1)
            End If
        Next

        ' removes blank item at the end of the array
        Array.Resize(newRecords, newRecords.Length - 1)

        ' closes and flushes the filestream so its ready for a new use.
        fileStream.Flush()
        readerStream.Close()
        fileStream.Close()

        ' opens a new filestream so it can be used to write the new data clears the file ready to recieve new data.
        Dim fileStreamWriter As FileStream = New FileStream(fileUrl, FileMode.Truncate, FileAccess.Write)
        Dim writerStream As StreamWriter = New StreamWriter(fileStreamWriter)

        ' writes all of the data that is in the new records to the file.
        For i = 0 To newRecords.Length - 1
            writerStream.WriteLine(newRecords(i))
        Next

        ' closes and flushes the file stream so its ready for use.
        fileStreamWriter.Flush()
        writerStream.Close()
        fileStreamWriter.Close()

    End Sub

    ''' <summary>
    '''     Duplicates current state of the file you parse adding the current date onto the file to identify it.
    ''' </summary>
    ''' <param name="fileUrl">The url of th file that you want to backup</param>
    Public Sub backupFile(ByVal fileUrl As String)


        Dim fileUrlSplit() As String = fileUrl.Split(".") ' gets the url and splits it at the . to remove the file extension.
        Dim strDate As String = Date.Today ' gets the current date.
        Dim dateSplit() As String = strDate.Split("/") ' splits the date at / since it cant be used in a file name.
        Dim backupfileUrl As String = fileUrlSplit(0) & "_" & dateSplit(0) & "_" & dateSplit(1) & "_" & dateSplit(2) & ".txt" ' creates a new txt file with the same name plus a date.

        ' opens a filestream with the main file url NOT THE BACKUP.
        Dim fileStreamMain As FileStream = New FileStream(fileUrl, FileMode.Open, FileAccess.Read)
        Dim readerStream As StreamReader = New StreamReader(fileStreamMain)

        Dim backupRecords(0) As String

        ' reads the main file.
        Do
            backupRecords(backupRecords.Length - 1) = readerStream.ReadLine()
            Array.Resize(backupRecords, backupRecords.Length + 1)
        Loop Until readerStream.Peek = -1

        Array.Resize(backupRecords, backupRecords.Length - 1)

        'closes and flushes the file stream ready for use.
        fileStreamMain.Flush()
        readerStream.Close()
        fileStreamMain.Close()

        ' creates a filestream with the backup file url and creates a file there.
        Dim fileStreamBackup As FileStream = New FileStream(backupfileUrl, FileMode.Create, FileAccess.Write)
        Dim writerStreamBackup As StreamWriter = New StreamWriter(fileStreamBackup)

        ' writes all of the data to the backup file.
        For i = 0 To backupRecords.Length - 1
            writerStreamBackup.WriteLine(backupRecords(i))
        Next

        ' closes and flushes filestream.
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

        ' opens filestream to write to the file.
        Dim fileStream As FileStream = New FileStream(fileUrl, FileMode.Append, FileAccess.Write)
        Dim writerStream As StreamWriter = New StreamWriter(fileStream)

        ' writes the record passed through the sub.
        writerStream.WriteLine(record)

        ' closes and flushes the files streams.
        fileStream.Flush()
        writerStream.Close()
        fileStream.Close()

    End Sub
End Module
