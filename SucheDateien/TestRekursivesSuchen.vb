Imports System.IO
Imports Microsoft.VisualBasic
Public Class TestRekursivesSuchen
    Private time As New Timer()

    ' Call this method from the constructor of the form.
    Private Sub InitializeMyTimer()
        ' Set the interval for the timer.
        time.Interval = 2500
        ' Connect the Tick event of the timer to its event handler.
        AddHandler time.Tick, AddressOf IncreaseProgressBar
        ' Start the timer.
        time.Start()
    End Sub


    Private Sub IncreaseProgressBar(ByVal sender As Object, ByVal e As EventArgs)
        ' Increment the value of the ProgressBar a value of one each time.
        ProgressBar1.Increment(1)
        ' Display the textual value of the ProgressBar in the StatusBar control's first panel.
        'statusBarPanel1.Text = ProgressBar1.Value.ToString() + "% Completed"
        ' Determine if we have completed by comparing the value of the Value property to the Maximum value.
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            ' Stop the timer.
            time.Stop()
        End If
    End Sub
    Private Sub BScannen_Click(sender As Object, e As EventArgs) Handles BScannen.Click
        'InitializeMyTimer()
        Dim files As Integer = 0
        Try
            files = My.Computer.FileSystem.GetFiles("\\WDMYCLOUD\Moritz\2_IT_Informatik\", FileIO.SearchOption.SearchAllSubDirectories, "*.*").Count
        Catch ex As System.IO.PathTooLongException
            MsgBox(files)
        End Try


        'MsgBox(files)
        ProgressBar1.Maximum = files
        ProgressBar1.Increment(1)
        Dim FSearch As New FileSearch
        Dim Filter As New FileSearch.SearchFilter
        Dim FileArray As New List(Of String)
        ListBox1.Items.Clear()
        'With Filter
        '    .Listing = FileSearch.SearchFilter.LO.FILES_ONLY
        '    .FileTypes = "txt"
        '    .MaxSize = 1000
        '    .MinSize = 100
        '    .SizeType = FileSearch.SearchFilter.ST.BYTES
        'End With
        With Filter
            .Listing = FileSearch.SearchFilter.LO.FILES_ONLY
            '.FileTypes = "txt"
            '.MaxSize = 1000
            '.MinSize = 100
            .SizeType = FileSearch.SearchFilter.ST.BYTES
        End With
        Try
            LBMeldung.Items.Add("Suche Dateien")
            FSearch.Search(TBQPfad.Text, "", Filter, FileArray)
        Catch ex As System.IO.PathTooLongException
            LBMeldung.Items.Add(ex.Message)
        End Try

        ProgressBar1.Maximum = FileArray.Count
        For Each FA In FileArray
            Debug.WriteLine(FA)
            Try
                LBMeldung.Items.Add("Liste Dateien")
                ProgressBar1.Increment(1)
                ListBox1.Items.Add(FA)
            Catch ex As System.IO.PathTooLongException
                LBMeldung.Items.Add(FA & "-" & ex.Message)
            End Try

        Next

        ListBox1.Items.Add("FERTIG " & FileArray.Count.ToString())
    End Sub
    'Parameter: pFolder als Pfad des zu durchsuchenden Ordners, pSuffix als Endung der zu suchenden Dateien (bei allen Typen "*.*")
    Public Function GetFiles(ByVal pFolder As String, ByVal pSuffix As String) As List(Of ListViewItem) 'Gibt eine Auflistung von ListViewItems zurück
        'Eine temporäre Liste wird angelegt
        Dim TempLVI As New List(Of ListViewItem)
        'Für jede Datei des Typs pSuffix im Ordner pFolder...
        For Each FILE As String In System.IO.Directory.GetFiles(pFolder, "*." & pSuffix, IO.SearchOption.TopDirectoryOnly)
            'Erstelle neues ListViewItem und weise ihm Beizeichnung und Informationen in den Subitems zu
            Dim LVI As New ListViewItem
            LVI.Text = New System.IO.FileInfo(FILE).Name 'Dateiname
            With LVI
                .SubItems.Add(New System.IO.FileInfo(FILE).Directory.FullName) 'Ordner der Datei
                .SubItems.Add(Math.Round(New System.IO.FileInfo(FILE).Length / 1000, 2) & " KB") 'Größe der Datei (hier in KB, bis auf zwei Dezimalstellen gerundet
                'Natürlich können hier noch Subitems hinzugefügt werden...
            End With
            'Füge das ListViewItem der Liste hinzu
            TempLVI.Add(LVI)
        Next
        'Für jeden Unterordner FOLDER des Ordners pFolder
        For Each FOLDER As String In System.IO.Directory.GetDirectories(pFolder)
            'Für jedes ListViewItem LVI der zurückgegebenen Liste der rekursiv aufgerufenen Funktion
            For Each LVI As ListViewItem In GetFiles(FOLDER, pSuffix)
                'Füge der temporären Liste die Ergebnisse des rekursiven Aufrufes hinzu    
                TempLVI.Add(LVI)
            Next
        Next
        'Gebe die komplette Liste zurück
        Return TempLVI
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BPfad.Click
        'If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
        '    Dim sr As New System.IO.StreamReader(OpenFileDialog1.FileName)
        '    MessageBox.Show(sr.ReadToEnd)
        '    sr.Close()
        'End If
        'Dim myStream As Stream
        'Dim OpenFileDialog1 As New OpenFileDialog()

        'With OpenFileDialog1
        '    .InitialDirectory = "c:\"
        '    .Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        '    .FilterIndex = 1
        '    .RestoreDirectory = True

        '    If .ShowDialog() = DialogResult.OK Then
        '        MsgBox(.FileName)
        '        'myStream = .OpenFile()
        '        'If Not (myStream Is Nothing) Then
        '        '    Me.Text = .FileName

        '        '    Dim myReader As StreamReader = New StreamReader(myStream)
        '        '    Dim i As Integer

        '        '    ListBox1.Items.Clear()

        '        '    Do Until myReader.Peek() = -1
        '        '        ListBox1.Items.Add(myReader.ReadLine)
        '        '        i += 1
        '        '    Loop

        '        '    myStream.Close()
        '        'End If
        '    End If
        'End With

        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            TBQPfad.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub BEinlesenDB_Click(sender As Object, e As EventArgs) Handles BEinlesenDB.Click
        Dim Posrechts As Integer = 0

        For Each ls As String In ListBox1.Items
            'If ls.Contains("abc") Then
            '    MsgBox(ls)
            'End If

            ' Position des ersten \ von rechts ermitteln
            Posrechts = InStrRev(ls, "\")
            ' Lesen der Datei
            Dim Datei As String = Microsoft.VisualBasic.Strings.Right(ls, Len(ls) - Posrechts)
            ' Lesen des Pfades
            Dim Pfad As String = Microsoft.VisualBasic.Strings.Left(ls, Posrechts)

            Dim z As New Zentral1
            If z.vorhanden(Pfad, Datei) = 0 Then
                If InStr(ls, "FERTIG") Then
                ElseIf InStr(ls, "zu lang") Then
                Else
                    z.neuerDatensatz(ls, Datei, Pfad)
                    If z.vorhanden(Pfad, Datei) <> 0 Then
                        Debug.WriteLine("Datensatz gespeichert:" & ls)
                        LBMeldung.Items.Add("Datensatz gespeichert:" & ls)
                    End If
                End If
            End If

            'Debug.WriteLine(ls)
            ''Debug.WriteLine(Posrechts.ToString)
            'Debug.WriteLine(Datei)
            'Debug.WriteLine(Pfad)
        Next
    End Sub


End Class