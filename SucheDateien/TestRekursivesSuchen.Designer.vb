<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TestRekursivesSuchen
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.BScannen = New System.Windows.Forms.Button()
        Me.TBQPfad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.BPfad = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.BEinlesenDB = New System.Windows.Forms.Button()
        Me.LBMeldung = New System.Windows.Forms.ListBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(1274, 12)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(23, 20)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.Visible = False
        '
        'BScannen
        '
        Me.BScannen.Location = New System.Drawing.Point(864, 27)
        Me.BScannen.Name = "BScannen"
        Me.BScannen.Size = New System.Drawing.Size(75, 23)
        Me.BScannen.TabIndex = 1
        Me.BScannen.Text = "Scanne"
        Me.BScannen.UseVisualStyleBackColor = True
        '
        'TBQPfad
        '
        Me.TBQPfad.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TBQPfad.Location = New System.Drawing.Point(13, 30)
        Me.TBQPfad.Name = "TBQPfad"
        Me.TBQPfad.Size = New System.Drawing.Size(796, 20)
        Me.TBQPfad.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Quellpfad eingeben"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(13, 96)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(1284, 290)
        Me.ListBox1.TabIndex = 7
        '
        'BPfad
        '
        Me.BPfad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BPfad.Location = New System.Drawing.Point(815, 27)
        Me.BPfad.Name = "BPfad"
        Me.BPfad.Size = New System.Drawing.Size(43, 23)
        Me.BPfad.TabIndex = 8
        Me.BPfad.Text = "Pfad"
        Me.BPfad.UseVisualStyleBackColor = True
        '
        'BEinlesenDB
        '
        Me.BEinlesenDB.Location = New System.Drawing.Point(1194, 27)
        Me.BEinlesenDB.Name = "BEinlesenDB"
        Me.BEinlesenDB.Size = New System.Drawing.Size(103, 23)
        Me.BEinlesenDB.TabIndex = 9
        Me.BEinlesenDB.Text = "Datenbankimport"
        Me.BEinlesenDB.UseVisualStyleBackColor = True
        '
        'LBMeldung
        '
        Me.LBMeldung.FormattingEnabled = True
        Me.LBMeldung.HorizontalScrollbar = True
        Me.LBMeldung.Location = New System.Drawing.Point(13, 393)
        Me.LBMeldung.Name = "LBMeldung"
        Me.LBMeldung.Size = New System.Drawing.Size(1285, 56)
        Me.LBMeldung.TabIndex = 10
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(11, 67)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1286, 23)
        Me.ProgressBar1.TabIndex = 11
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 439)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1309, 22)
        Me.StatusStrip1.TabIndex = 12
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TestRekursivesSuchen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1309, 461)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.LBMeldung)
        Me.Controls.Add(Me.BEinlesenDB)
        Me.Controls.Add(Me.BPfad)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBQPfad)
        Me.Controls.Add(Me.BScannen)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "TestRekursivesSuchen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TestRekursivesSuchen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents BScannen As Button
    Friend WithEvents TBQPfad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents BPfad As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents BEinlesenDB As Button
    Friend WithEvents LBMeldung As ListBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents StatusStrip1 As StatusStrip
End Class
