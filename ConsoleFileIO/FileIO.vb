'header
'File IO
'Spring 2025

Option Strict On
Option Explicit On

Module FileIO

    Sub Main()
        'WriteToFile()
        'AppendToFile()
        ReadFromFile()
    End Sub

    Sub WriteToFile()
        'openmode .Output
        'write to the file
        'overwrites existing data
        'if it doesn't exist it creates it
        FileOpen(1, "MyCoolFile.txt", OpenMode.Output)

        Write(1, "Wake up Neo...")
        'write(1, "Follow The White Rabbit...")
        FileClose(1)

    End Sub

    Sub AppendToFile()
        'openmode .Output
        'write to the file
        'if it doesn't exist it creates it
        FileOpen(1, "MyCoolFile.txt", OpenMode.Append)

        For i = 1 To 10
            Write(1, "Follow the White Rabbit")
        Next

        FileClose(1)

    End Sub

    Sub ReadFromFile()
        Dim currentRecord As String
        Dim fileName As String = "MyCoolFile.txt"
        Try
            FileOpen(1, fileName, OpenMode.Input)

            ''crashes if you read past end of file
            'For i = 1 To 12
            '    Input(1, currentRecord)
            '    Console.WriteLine(currentRecord)

            'Next
            'Input(1, currentRecord)

            Do Until EOF(1) ' EOF() returns true when there are no more records to read
                Input(1, currentRecord)
                Console.WriteLine(currentRecord)
            Loop

            FileClose(1)


        Catch ex As Exception
            MsgBox($"oops! Looks like the file {fileName} doesn't exist...")
        End Try

    End Sub

End Module
