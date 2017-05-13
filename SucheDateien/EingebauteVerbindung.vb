Public Class EingebauteVerbindung
    Private Sub DateiBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DateiBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DateiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DateienDataSet)

    End Sub

    Private Sub EingebauteVerbindung_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DateienDataSet.Datei". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.DateiBindingSource.ResetCurrentItem()

        Me.DateiTableAdapter.Fill(Me.DateienDataSet.Datei)

    End Sub


End Class