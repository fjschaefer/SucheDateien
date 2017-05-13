Imports Microsoft.VisualBasic
Imports System.Data.Common
Imports System.Data.SqlClient
Public Class Zentral1
    Public con As DbConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programmierung\SucheDateien\SucheDateien\Dateien.mdf;Integrated Security=True")

    Public Function vorhanden(DPfad As String, DName As String)
        'Dim connection As DbConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programmierung\SucheDateien\SucheDateien\Dateien.mdf;Integrated Security=True")
        Using con
            Dim command As SqlCommand = New SqlCommand("SELECT count (*) FROM Datei where DPfad = '" & DPfad & "' and DName = '" & DName & "';", con)
            con.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.HasRows Then
                Do While reader.Read()
                    Return reader.Item(0)
                Loop
            Else
                Meldung.Text = "No rows found."
            End If
            reader.Close()
        End Using
        Return 0
    End Function
End Class
