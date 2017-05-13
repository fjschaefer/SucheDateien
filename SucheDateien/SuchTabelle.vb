Imports System.Data.Common
Imports System.Data.SqlClient
Public Class SuchTabelle
    'Dim z1 As New Zentral1
    Private Sub SuchTabelle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Hauptmaske.TBSuchwort.Text <> "" Then
            TBSuchB.Text = Hauptmaske.TBSuchwort.Text
            sucheTabelle(TBSuchB.Text)
        Else
            TBSuchB.Text = ""
            sucheTabelle(TBSuchB.Text)
        End If

        'CreateUnboundButtonColumn()
    End Sub
    Function sucheTabelle(suchbegriff As String)
        Dim str As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programmierung\SucheDateien\SucheDateien\Dateien.mdf;Integrated Security=True"
        Dim com As String = ""
        Dim con As New SqlConnection(str)

        com = "SELECT * FROM Datei where Beschreibung like '%" & suchbegriff & "%';"

        Dim Adpt As New SqlDataAdapter(com, con)

        Dim ds As New DataSet()

        Adpt.Fill(ds, "Emp")

        DataGridView1.DataSource = ds.Tables(0)
        LMeldung.Text = DataGridView1.RowCount & " Datensätze!"
        'DataGridView1.Columns("Beschreibung").Width = 200
        Return 0
    End Function
    Private Sub CreateUnboundButtonColumn()

        ' Initialize the button column.
        Dim buttonColumn As New DataGridViewButtonColumn

        With buttonColumn
            .HeaderText = "Details"
            .Name = "Details"
            .Text = "View Details"

            ' Use the Text property for the button text for all cells rather
            ' than using each cell's value as the text for its own button.
            .UseColumnTextForButtonValue = True
        End With

        ' Add the button column to the control.
        DataGridView1.Columns.Insert(0, buttonColumn)

    End Sub
    Private Sub TBSuchB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBSuchB.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            sucheTabelle(TBSuchB.Text)
            e.Handled = True
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'If e.ColumnIndex <> 0 Then
        '    Exit Sub
        'End If
        If e.ColumnIndex = 0 Then
            Dim v As String = DataGridView1.Rows(e.RowIndex).Cells("DPfad").Value
            Process.Start("explorer", v)
        End If
        If e.ColumnIndex = 1 Then
            Dim v As Integer = DataGridView1.Rows(e.RowIndex).Cells("ID").Value
            Dim frm As Form1 = New Form1(v)
            'frm.Show()
            frm.ShowDialog()
            'MsgBox(v)
        End If

    End Sub

    Private Sub Bloesch_Click(sender As Object, e As EventArgs) Handles Bloesch.Click
        Dim i As Integer = 0
        For Each DGWR As DataGridViewRow In Me.DataGridView1.SelectedRows
            'MsgBox(DGWR.Cells(3).Value)
            loescheDS(DGWR.Cells(2).Value.ToString)
            i = i + 1
        Next
        sucheTabelle(TBSuchB.Text)
    End Sub
    Function loescheDS(LID As Integer)
        Dim sqlConnection1 As New System.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programmierung\SucheDateien\SucheDateien\Dateien.mdf;Integrated Security=True")

        Dim cmd As New System.Data.SqlClient.SqlCommand
        cmd.CommandType = System.Data.CommandType.Text
        cmd.CommandText = "DELETE Datei WHERE ID = " & LID
        cmd.Connection = sqlConnection1

        sqlConnection1.Open()
        cmd.ExecuteNonQuery()
        sqlConnection1.Close()
        Return 0
    End Function
End Class