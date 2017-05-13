Public Class Hauptmaske
    Dim z1 As New Zentral1


    Private Sub Hauptmaske_Load(sender As Object, e As EventArgs) Handles Me.Load

        z1.Start = "1"

    End Sub

    Private Sub TreeView1_Click(sender As Object, e As EventArgs)
        'MsgBox("Klick")
    End Sub

    Private Sub TreeView1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs)
        'MsgBox(TreeView1.SelectedNode.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SuchTabelle.ShowDialog()
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBSuchwort.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SuchTabelle.ShowDialog()
            e.Handled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TestRekursivesSuchen.ShowDialog()
    End Sub
End Class