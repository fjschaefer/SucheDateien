<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TBBeschreibung = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBName = New System.Windows.Forms.TextBox()
        Me.TBPfad = New System.Windows.Forms.TextBox()
        Me.Meldung = New System.Windows.Forms.Label()
        Me.BNeu = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DateiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DateienDataSet = New SucheDateien.DateienDataSet()
        Me.DateiTableAdapter = New SucheDateien.DateienDataSetTableAdapters.DateiTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBSuche = New System.Windows.Forms.TextBox()
        Me.BLoesch = New System.Windows.Forms.Button()
        Me.TBID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BÄndern = New System.Windows.Forms.Button()
        CType(Me.DateiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateienDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TBBeschreibung
        '
        Me.TBBeschreibung.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBBeschreibung.Location = New System.Drawing.Point(230, 148)
        Me.TBBeschreibung.Margin = New System.Windows.Forms.Padding(4)
        Me.TBBeschreibung.Multiline = True
        Me.TBBeschreibung.Name = "TBBeschreibung"
        Me.TBBeschreibung.Size = New System.Drawing.Size(480, 118)
        Me.TBBeschreibung.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(89, 148)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Beschreibung"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(89, 284)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Dateiname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(89, 320)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Dateipfad"
        '
        'TBName
        '
        Me.TBName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBName.Location = New System.Drawing.Point(230, 284)
        Me.TBName.Margin = New System.Windows.Forms.Padding(4)
        Me.TBName.Name = "TBName"
        Me.TBName.Size = New System.Drawing.Size(480, 26)
        Me.TBName.TabIndex = 4
        '
        'TBPfad
        '
        Me.TBPfad.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBPfad.Location = New System.Drawing.Point(230, 320)
        Me.TBPfad.Margin = New System.Windows.Forms.Padding(4)
        Me.TBPfad.Name = "TBPfad"
        Me.TBPfad.Size = New System.Drawing.Size(480, 26)
        Me.TBPfad.TabIndex = 5
        '
        'Meldung
        '
        Me.Meldung.AutoSize = True
        Me.Meldung.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Meldung.Location = New System.Drawing.Point(13, 505)
        Me.Meldung.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Meldung.Name = "Meldung"
        Me.Meldung.Size = New System.Drawing.Size(46, 18)
        Me.Meldung.TabIndex = 6
        Me.Meldung.Text = "keine"
        '
        'BNeu
        '
        Me.BNeu.Location = New System.Drawing.Point(5, 16)
        Me.BNeu.Name = "BNeu"
        Me.BNeu.Size = New System.Drawing.Size(75, 23)
        Me.BNeu.TabIndex = 7
        Me.BNeu.Text = "neu"
        Me.BNeu.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.DateiBindingSource
        Me.ComboBox1.DisplayMember = "Beschreibung"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(230, 97)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(480, 26)
        Me.ComboBox1.TabIndex = 9
        Me.ComboBox1.ValueMember = "Id"
        '
        'DateiBindingSource
        '
        Me.DateiBindingSource.DataMember = "Datei"
        Me.DateiBindingSource.DataSource = Me.DateienDataSet
        '
        'DateienDataSet
        '
        Me.DateienDataSet.DataSetName = "DateienDataSet"
        Me.DateienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DateiTableAdapter
        '
        Me.DateiTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TBSuche)
        Me.Panel1.Location = New System.Drawing.Point(16, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(694, 51)
        Me.Panel1.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 11)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Suche nach"
        '
        'TBSuche
        '
        Me.TBSuche.Location = New System.Drawing.Point(117, 11)
        Me.TBSuche.Name = "TBSuche"
        Me.TBSuche.Size = New System.Drawing.Size(356, 26)
        Me.TBSuche.TabIndex = 0
        '
        'BLoesch
        '
        Me.BLoesch.Location = New System.Drawing.Point(601, 16)
        Me.BLoesch.Name = "BLoesch"
        Me.BLoesch.Size = New System.Drawing.Size(75, 23)
        Me.BLoesch.TabIndex = 11
        Me.BLoesch.Text = "löschen"
        Me.BLoesch.UseVisualStyleBackColor = True
        '
        'TBID
        '
        Me.TBID.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBID.Location = New System.Drawing.Point(230, 354)
        Me.TBID.Margin = New System.Windows.Forms.Padding(4)
        Me.TBID.Name = "TBID"
        Me.TBID.Size = New System.Drawing.Size(480, 26)
        Me.TBID.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(89, 354)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "ID"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.BÄndern)
        Me.Panel2.Controls.Add(Me.BNeu)
        Me.Panel2.Controls.Add(Me.BLoesch)
        Me.Panel2.Location = New System.Drawing.Point(16, 424)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(694, 51)
        Me.Panel2.TabIndex = 11
        '
        'BÄndern
        '
        Me.BÄndern.Location = New System.Drawing.Point(86, 16)
        Me.BÄndern.Name = "BÄndern"
        Me.BÄndern.Size = New System.Drawing.Size(75, 23)
        Me.BÄndern.TabIndex = 12
        Me.BÄndern.Text = "ändern"
        Me.BÄndern.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 532)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TBID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Meldung)
        Me.Controls.Add(Me.TBPfad)
        Me.Controls.Add(Me.TBName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBBeschreibung)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dateimanagement"
        CType(Me.DateiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateienDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBBeschreibung As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TBName As TextBox
    Friend WithEvents TBPfad As TextBox
    Friend WithEvents Meldung As Label
    Friend WithEvents BNeu As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateienDataSet As DateienDataSet
    Friend WithEvents DateiBindingSource As BindingSource
    Friend WithEvents DateiTableAdapter As DateienDataSetTableAdapters.DateiTableAdapter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents TBSuche As TextBox
    Friend WithEvents BLoesch As Button
    Friend WithEvents TBID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BÄndern As Button
End Class
