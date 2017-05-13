Imports Microsoft.VisualBasic
Imports System.Data.Common
Imports System.Data.SqlClient
Public Class Zentral1
    Public suchwort As String
    Public Start As String

    Public con As DbConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programmierung\SucheDateien\SucheDateien\Dateien.mdf;Integrated Security=True")
    'Public sqlConnection1 As New System.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programmierung\SucheDateien\SucheDateien\Dateien.mdf;Integrated Security=True")
    Public Function vorhanden(DPfad As String, DName As String)
        Dim connection As DbConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programmierung\SucheDateien\SucheDateien\Dateien.mdf;Integrated Security=True")
        Using connection
            Dim command As SqlCommand = New SqlCommand("SELECT * FROM Datei where DPfad = '" & DPfad & "' and DName = '" & DName & "';", connection)
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.HasRows Then
                Return 1
            Else
                Return 0
            End If
            reader.Close()
        End Using

    End Function

    Public Function neuerDatensatz(beschreibung As String, Dateiname As String, Pfad As String)
        Try
            Dim sqlConnection1 As New System.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programmierung\SucheDateien\SucheDateien\Dateien.mdf;Integrated Security=True")
            If beschreibung = "" Then
                beschreibung = "Keine Beschreibung"
            End If

            If Dateiname = "" Then
                Dateiname = "Kein Dateiname"
            End If

            If Pfad = "" Then
                Pfad = "Kein Pfad"
            End If

            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "INSERT Datei (Beschreibung, DName, DPfad) VALUES ('" & beschreibung & "','" & Dateiname & "','" & Pfad & "')"
            cmd.Connection = sqlConnection1

            sqlConnection1.Open()
            cmd.ExecuteNonQuery()
            sqlConnection1.Close()
        Catch ex As System.Data.SqlClient.SqlException
            'TestRekursivesSuchen.LBMeldung.Items.Add(beschreibung & "-" & Pfad & "-" & Dateiname & "-->Fehler: " & ex.Message)
            TestRekursivesSuchen.LBMeldung.Items.Add(Pfad & "-" & Dateiname & "-->Fehler: " & ex.Message)
        End Try

        'Meldung.Text = "Datensatz erfasst!"
        Return 0
    End Function

End Class
