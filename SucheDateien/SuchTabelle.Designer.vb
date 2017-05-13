<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SuchTabelle
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SuchTabelle))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.start = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Detail = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TBSuchB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LMeldung = New System.Windows.Forms.Label()
        Me.Bloesch = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.start, Me.Detail})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 81)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1216, 304)
        Me.DataGridView1.TabIndex = 0
        '
        'start
        '
        Me.start.HeaderText = "Explorer"
        Me.start.Name = "start"
        Me.start.ReadOnly = True
        Me.start.Text = "start"
        Me.start.ToolTipText = "Explorer starten"
        Me.start.UseColumnTextForButtonValue = True
        Me.start.Width = 51
        '
        'Detail
        '
        Me.Detail.HeaderText = "Detail"
        Me.Detail.Name = "Detail"
        Me.Detail.ReadOnly = True
        Me.Detail.Text = "sehen"
        Me.Detail.ToolTipText = "Details der Datei sehen"
        Me.Detail.UseColumnTextForButtonValue = True
        Me.Detail.Width = 40
        '
        'TBSuchB
        '
        Me.TBSuchB.Location = New System.Drawing.Point(79, 12)
        Me.TBSuchB.Name = "TBSuchB"
        Me.TBSuchB.Size = New System.Drawing.Size(181, 20)
        Me.TBSuchB.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Suchbegriff:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1008, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Meldung:"
        '
        'LMeldung
        '
        Me.LMeldung.AutoSize = True
        Me.LMeldung.Location = New System.Drawing.Point(1065, 19)
        Me.LMeldung.Name = "LMeldung"
        Me.LMeldung.Size = New System.Drawing.Size(34, 13)
        Me.LMeldung.TabIndex = 4
        Me.LMeldung.Text = "Keine"
        '
        'Bloesch
        '
        Me.Bloesch.Location = New System.Drawing.Point(801, 19)
        Me.Bloesch.Name = "Bloesch"
        Me.Bloesch.Size = New System.Drawing.Size(75, 23)
        Me.Bloesch.TabIndex = 5
        Me.Bloesch.Text = "löschen"
        Me.Bloesch.UseVisualStyleBackColor = True
        '
        'SuchTabelle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1240, 397)
        Me.Controls.Add(Me.Bloesch)
        Me.Controls.Add(Me.LMeldung)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBSuchB)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SuchTabelle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Suche nach Dateien"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TBSuchB As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents start As DataGridViewButtonColumn
    Friend WithEvents Detail As DataGridViewButtonColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents LMeldung As Label
    Friend WithEvents Bloesch As Button
End Class
