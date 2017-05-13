Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class Form1
    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal caption As String)
        InitializeComponent()
        ' gewuenschte Operation mit dem Parameter durchfuehren
        Me.Text = caption
    End Sub
    Public Property Properties As Object

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DateienDataSet.Datei". Sie können sie bei Bedarf verschieben oder entfernen.
        'Me.DateiTableAdapter.Fill(Me.DateienDataSet.Datei)
        'Dim con As DbConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programmierung\SucheDateien\SucheDateien\Dateien.mdf;Integrated Security=True")
        'HasRows(con)
        'Anzahlds()

        sucheDS(Me.Text)
    End Sub

    Private Sub HasRows(ByVal connection As SqlConnection)
        Using connection
            Dim command As SqlCommand = New SqlCommand("SELECT * FROM Datei;", connection)
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            If Anzahlds() > 0 Then
                reader.Read()
                Me.TBBeschreibung.Text = reader("Beschreibung")
                Me.TBName.Text = reader("DName")
                Me.TBPfad.Text = reader("DPfad")
                Me.TBID.Text = reader("ID")
            Else
                Meldung.Text = "No rows found."
            End If
        End Using





    End Sub
    Function Anzahlds() As Integer
        Dim connection As DbConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programmierung\SucheDateien\SucheDateien\Dateien.mdf;Integrated Security=True")
        Using connection
            Dim command As SqlCommand = New SqlCommand("SELECT count (*) FROM Datei;", connection)
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()

            If reader.HasRows Then
                Do While reader.Read()
                    Meldung.Text = "Anzahl Datensätze: " & reader.Item(0)
                    Return reader.Item(0)
                Loop
            Else
                Meldung.Text = "No rows found."
                Return 0
            End If

            reader.Close()
        End Using

    End Function
    Private Sub BNeu_Click(sender As Object, e As EventArgs) Handles BNeu.Click
        'Dim con As DbConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programmierung\SucheDateien\SucheDateien\Dateien.mdf;Integrated Security=True")
        Dim sqlConnection1 As New System.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programmierung\SucheDateien\SucheDateien\Dateien.mdf;Integrated Security=True")

        Dim cmd As New System.Data.SqlClient.SqlCommand
        cmd.CommandType = System.Data.CommandType.Text
        cmd.CommandText = "INSERT Datei (Beschreibung, DName, DPfad) VALUES ('" & TBBeschreibung.Text & "','" & TBName.Text & "','" & TBPfad.Text & "')"
        cmd.Connection = sqlConnection1

        sqlConnection1.Open()
        cmd.ExecuteNonQuery()
        sqlConnection1.Close()
        Meldung.Text = "Datensatz erfasst!"

        Aktualisiere_Combobox1()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        sucheDS(ComboBox1.SelectedValue)
    End Sub
    Function sucheDS(suchbegriff As Integer)
        Dim connection As DbConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programmierung\SucheDateien\SucheDateien\Dateien.mdf;Integrated Security=True")
        Using connection
            Dim command As SqlCommand = New SqlCommand("SELECT * FROM Datei where ID = " & suchbegriff & ";", connection)
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.HasRows Then
                Do While reader.Read()
                    Me.TBBeschreibung.Text = reader("Beschreibung")
                    Me.TBName.Text = reader("DName")
                    Me.TBPfad.Text = reader("DPfad")
                    Me.TBID.Text = reader("ID")
                Loop
            Else
                Meldung.Text = "No rows found."
            End If

            reader.Close()
        End Using
        Return 0
    End Function
    Function sucheDS2(suchbegriff As String)
        Dim connection As DbConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programmierung\SucheDateien\SucheDateien\Dateien.mdf;Integrated Security=True")
        Using connection
            Dim command As SqlCommand = New SqlCommand("SELECT * FROM Datei where Beschreibung like '%" & suchbegriff & "%';", connection)
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.HasRows Then
                Do While reader.Read()
                    Me.TBBeschreibung.Text = reader("Beschreibung")
                    Me.TBName.Text = reader("DName")
                    Me.TBPfad.Text = reader("DPfad")
                    Me.TBID.Text = reader("ID")
                Loop
            Else
                Meldung.Text = "No rows found."
            End If

            reader.Close()
        End Using
        Return 0
    End Function

    Private Sub TBSuche_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBSuche.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            sucheDS2(TBSuche.Text)
            e.Handled = True
        End If
    End Sub

    Private Sub BLoesch_Click(sender As Object, e As EventArgs) Handles BLoesch.Click
        Dim sqlConnection1 As New System.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programmierung\SucheDateien\SucheDateien\Dateien.mdf;Integrated Security=True")

        Dim cmd As New System.Data.SqlClient.SqlCommand
        cmd.CommandType = System.Data.CommandType.Text
        cmd.CommandText = "DELETE Datei WHERE ID = " & TBID.Text
        cmd.Connection = sqlConnection1

        sqlConnection1.Open()
        cmd.ExecuteNonQuery()
        sqlConnection1.Close()
        Meldung.Text = "Datensatz gelöscht!"

        Me.TBBeschreibung.Text = ""
        Me.TBName.Text = ""
        Me.TBPfad.Text = ""
        Me.TBID.Text = ""
        Aktualisiere_Combobox1()
    End Sub
    Function Aktualisiere_Combobox1()
        Dim connection As New System.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programmierung\SucheDateien\SucheDateien\Dateien.mdf;Integrated Security=True")
        Using connection
            Dim command As SqlCommand = New SqlCommand("SELECT * FROM Datei;", connection)
            connection.Open()

            ' DataAdapter:
            'Dim reader As SqlDataReader = command.ExecuteReader()
            Dim da As New SqlDataAdapter(command)

            ' DataSet:
            Dim ds As New DataSet()

            ' DataSet füllen:

            da.Fill(ds, "Datei")

            ' Daten an ComboBox binden:
            ComboBox1.DisplayMember = "Beschreibung"
            ComboBox1.ValueMember = "ID"
            ComboBox1.DataSource = ds.Tables("Datei")
        End Using
        Return 0
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BÄndern.Click
        Dim sqlConnection1 As New System.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programmierung\SucheDateien\SucheDateien\Dateien.mdf;Integrated Security=True")

        Dim cmd As New System.Data.SqlClient.SqlCommand
        cmd.CommandType = System.Data.CommandType.Text
        'Dim sql As String = "Update Customers SET ContactName = 'Alfred Schmidt', City= 'Frankfurt' WHERE CustomerID = 1;"
        cmd.CommandText = "Update Datei SET Beschreibung = '" & TBBeschreibung.Text & "', DName = '" & TBName.Text & "', DPfad = '" & TBPfad.Text & "' where ID = " & TBID.Text & ";"
        cmd.Connection = sqlConnection1

        sqlConnection1.Open()
        cmd.ExecuteNonQuery()
        sqlConnection1.Close()
        Meldung.Text = "Datensatz geändert!"
        SuchTabelle.sucheTabelle(SuchTabelle.TBSuchB.Text)
        Aktualisiere_Combobox1()
    End Sub
End Class
