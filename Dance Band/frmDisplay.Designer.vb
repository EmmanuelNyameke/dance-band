<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisplay
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
        lstSongs = New ListBox()
        picImage = New PictureBox()
        lblHeading = New Label()
        lblSongs = New Label()
        btnBack = New Button()
        CType(picImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lstSongs
        ' 
        lstSongs.BorderStyle = BorderStyle.None
        lstSongs.Font = New Font("Verdana", 14.25F)
        lstSongs.FormattingEnabled = True
        lstSongs.ItemHeight = 23
        lstSongs.Location = New Point(147, 161)
        lstSongs.Name = "lstSongs"
        lstSongs.Size = New Size(223, 138)
        lstSongs.TabIndex = 0
        ' 
        ' picImage
        ' 
        picImage.Image = My.Resources.Resources.dance
        picImage.Location = New Point(3, 3)
        picImage.Name = "picImage"
        picImage.Size = New Size(185, 112)
        picImage.SizeMode = PictureBoxSizeMode.StretchImage
        picImage.TabIndex = 1
        picImage.TabStop = False
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.Location = New Point(245, 38)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(148, 32)
        lblHeading.TabIndex = 2
        lblHeading.Text = "Song Set"
        ' 
        ' lblSongs
        ' 
        lblSongs.AutoSize = True
        lblSongs.Font = New Font("Verdana", 15.75F, FontStyle.Bold)
        lblSongs.Location = New Point(147, 133)
        lblSongs.Name = "lblSongs"
        lblSongs.Size = New Size(83, 25)
        lblSongs.TabIndex = 4
        lblSongs.Text = "Songs"
        ' 
        ' btnBack
        ' 
        btnBack.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBack.Location = New Point(221, 316)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(75, 34)
        btnBack.TabIndex = 6
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' frmDisplay
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(516, 450)
        Controls.Add(btnBack)
        Controls.Add(lblSongs)
        Controls.Add(lblHeading)
        Controls.Add(picImage)
        Controls.Add(lstSongs)
        Name = "frmDisplay"
        Text = "Display Song Set"
        CType(picImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstSongs As ListBox
    Friend WithEvents picImage As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblSongs As Label
    Friend WithEvents btnBack As Button
End Class
