Public Class Class1
    ' TODO : Add constructor code after InitializeComponents
    '
    ''' <summary>
    ''' Search files in directory and subdirectories 
    ''' </summary>
    ''' <param name="searchDir">Start Directory</param>
    ''' <param name="searchPattern">Search Pattern</param>
    ''' <param name="maxDepth">maximum depth; 0 for unlimited depth</param>
    ''' <param name="maxDurationMS">maximum duration; 0 for unlimited duration</param>
    ''' <returns>a list of filenames including the path</returns>
    ''' <remarks>
    ''' recursive use of   Sub dirS
    ''' 
    ''' wallner-novak@bemessung.at
    ''' </remarks>
    Public Shared Function dirRecursively(searchDir As String, searchPattern As String, _
                                        Optional maxDepth As Integer = 0, _
                                        Optional maxDurationMS As Long = 0) As List(Of String)
        Dim fileList As New List(Of String)
        Dim depth As Integer = 0
        Dim sw As New Stopwatch

        dirS(searchDir, searchPattern, maxDepth, maxDurationMS, fileList, depth, sw)

        Return fileList

    End Function

    ''' <summary>
    ''' Recursive file search
    ''' </summary>
    ''' <param name="searchDir">Start Directory</param>
    ''' <param name="searchPattern">Search Pattern</param>
    ''' <param name="maxDepth">maximum depth; 0 for unlimited depth</param>
    ''' <param name="maxDurationMS">maximum duration; 0 for unlimited duration</param>
    ''' <param name="fileList">Filelist to append to</param>
    ''' <param name="depth">current depth</param>
    ''' <param name="sw">stopwatch</param>
    ''' <param name="quit">boolean value to quit early (at given depth or duration)</param>
    ''' <remarks>
    ''' wallner-novak@bemessung.at
    ''' </remarks>
    Private Shared Sub dirS(searchDir As String, searchPattern As String, _
                                Optional maxDepth As Integer = 0, _
                                Optional maxDurationMS As Long = 0, _
                                Optional ByRef fileList As List(Of String) = Nothing, _
                                Optional ByRef depth As Integer = 0, _
                                Optional ByRef sw As Stopwatch = Nothing, _
                                Optional ByRef quit As Boolean = False)
        debug.write(searchDir)
        If maxDurationMS > 0 Then
            If depth = 0 Then
                sw = New Stopwatch
                sw.Start()
            Else
                If sw.ElapsedMilliseconds > maxDurationMS Then
                    quit = True
                    Exit Sub
                End If
            End If
        End If

        If maxDepth > 0 Then
            If depth > maxDepth Then
                quit = True
                Exit Sub
            End If
        End If

        ' check if directory exists
        If Not IO.Directory.Exists(searchDir) Then
            Exit Sub
        End If

        ' find files
        For Each myFile As String In IO.Directory.GetFiles(searchDir, searchPattern)
            fileList.Add(myFile)
        Next

        ' recursively scan subdirectories 
        For Each myDir In IO.Directory.GetDirectories(searchDir)
            depth += 1
            dirS(myDir, searchPattern, maxDepth, maxDurationMS, fileList, depth, sw, quit)

            If quit Then Exit For
            depth -= 1
        Next

    End Sub

End Class
