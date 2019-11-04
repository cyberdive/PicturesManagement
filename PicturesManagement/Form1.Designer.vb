<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LstFile = New System.Windows.Forms.DataGridView()
        Me.GetInfo = New System.Windows.Forms.Button()
        Me.LoadInfo = New System.Windows.Forms.Button()
        Me.SaveInfo = New System.Windows.Forms.Button()
        Me.Filename = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Path = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Size = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.crc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.crcLimited = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.LstFile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LstFile
        '
        Me.LstFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LstFile.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Filename, Me.Path, Me.Size, Me.crc, Me.crcLimited})
        Me.LstFile.Location = New System.Drawing.Point(12, 12)
        Me.LstFile.Name = "LstFile"
        Me.LstFile.Size = New System.Drawing.Size(889, 536)
        Me.LstFile.TabIndex = 0
        '
        'GetInfo
        '
        Me.GetInfo.Location = New System.Drawing.Point(918, 22)
        Me.GetInfo.Name = "GetInfo"
        Me.GetInfo.Size = New System.Drawing.Size(75, 23)
        Me.GetInfo.TabIndex = 1
        Me.GetInfo.Text = "GetInfo"
        Me.GetInfo.UseVisualStyleBackColor = True
        '
        'LoadInfo
        '
        Me.LoadInfo.Location = New System.Drawing.Point(918, 52)
        Me.LoadInfo.Name = "LoadInfo"
        Me.LoadInfo.Size = New System.Drawing.Size(75, 23)
        Me.LoadInfo.TabIndex = 2
        Me.LoadInfo.Text = "LoadInfo"
        Me.LoadInfo.UseVisualStyleBackColor = True
        '
        'SaveInfo
        '
        Me.SaveInfo.Location = New System.Drawing.Point(918, 82)
        Me.SaveInfo.Name = "SaveInfo"
        Me.SaveInfo.Size = New System.Drawing.Size(75, 23)
        Me.SaveInfo.TabIndex = 3
        Me.SaveInfo.Text = "SaveInfo"
        Me.SaveInfo.UseVisualStyleBackColor = True
        '
        'Filename
        '
        Me.Filename.HeaderText = "Filename"
        Me.Filename.Name = "Filename"
        '
        'Path
        '
        Me.Path.HeaderText = "Path"
        Me.Path.Name = "Path"
        '
        'Size
        '
        Me.Size.HeaderText = "Size"
        Me.Size.Name = "Size"
        '
        'crc
        '
        Me.crc.HeaderText = "crc"
        Me.crc.Name = "crc"
        '
        'crcLimited
        '
        Me.crcLimited.HeaderText = "crcLimited"
        Me.crcLimited.Name = "crcLimited"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1007, 572)
        Me.Controls.Add(Me.SaveInfo)
        Me.Controls.Add(Me.LoadInfo)
        Me.Controls.Add(Me.GetInfo)
        Me.Controls.Add(Me.LstFile)
        Me.Name = "Form1"
        Me.Text = "PicturesManager"
        CType(Me.LstFile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LstFile As System.Windows.Forms.DataGridView
    Friend WithEvents GetInfo As System.Windows.Forms.Button
    Friend WithEvents LoadInfo As System.Windows.Forms.Button
    Friend WithEvents SaveInfo As System.Windows.Forms.Button
    Friend WithEvents Filename As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Path As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Size As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents crc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents crcLimited As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
