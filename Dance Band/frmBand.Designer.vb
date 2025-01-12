<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBand
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        mnuItems = New MenuStrip()
        mnuAction = New ToolStripMenuItem()
        mnuDisplay = New ToolStripMenuItem()
        mnuClear = New ToolStripMenuItem()
        mnuExit = New ToolStripMenuItem()
        picImage = New PictureBox()
        lblTitle = New Label()
        cboGenres = New ComboBox()
        lstSongs = New ListBox()
        lstTime = New ListBox()
        mnuItems.SuspendLayout()
        CType(picImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' mnuItems
        ' 
        mnuItems.Items.AddRange(New ToolStripItem() {mnuAction})
        mnuItems.Location = New Point(0, 0)
        mnuItems.Name = "mnuItems"
        mnuItems.Padding = New Padding(7, 2, 0, 2)
        mnuItems.Size = New Size(755, 24)
        mnuItems.TabIndex = 0
        mnuItems.Text = "MenuStrip1"
        ' 
        ' mnuAction
        ' 
        mnuAction.DropDownItems.AddRange(New ToolStripItem() {mnuDisplay, mnuClear, mnuExit})
        mnuAction.Name = "mnuAction"
        mnuAction.Size = New Size(54, 20)
        mnuAction.Text = "&Action"
        ' 
        ' mnuDisplay
        ' 
        mnuDisplay.Name = "mnuDisplay"
        mnuDisplay.Size = New Size(180, 22)
        mnuDisplay.Text = "&Display Song Set"
        ' 
        ' mnuClear
        ' 
        mnuClear.Name = "mnuClear"
        mnuClear.Size = New Size(180, 22)
        mnuClear.Text = "&Clear"
        ' 
        ' mnuExit
        ' 
        mnuExit.Name = "mnuExit"
        mnuExit.Size = New Size(180, 22)
        mnuExit.Text = "E&xit"
        ' 
        ' picImage
        ' 
        picImage.Dock = DockStyle.Left
        picImage.Image = My.Resources.Resources.dance
        picImage.Location = New Point(0, 24)
        picImage.Name = "picImage"
        picImage.Size = New Size(359, 396)
        picImage.SizeMode = PictureBoxSizeMode.StretchImage
        picImage.TabIndex = 1
        picImage.TabStop = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.FlatStyle = FlatStyle.System
        lblTitle.Font = New Font("Verdana", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.RoyalBlue
        lblTitle.Location = New Point(436, 24)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(172, 29)
        lblTitle.TabIndex = 2
        lblTitle.Text = "Dance Band"
        ' 
        ' cboGenres
        ' 
        cboGenres.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cboGenres.FormattingEnabled = True
        cboGenres.Items.AddRange(New Object() {"Rock", "Country", "Rap", "R&B"})
        cboGenres.Location = New Point(436, 89)
        cboGenres.Name = "cboGenres"
        cboGenres.Size = New Size(172, 31)
        cboGenres.TabIndex = 3
        cboGenres.Text = "Select Genre:"
        ' 
        ' lstSongs
        ' 
        lstSongs.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lstSongs.FormattingEnabled = True
        lstSongs.ItemHeight = 23
        lstSongs.Location = New Point(365, 164)
        lstSongs.Name = "lstSongs"
        lstSongs.Size = New Size(232, 234)
        lstSongs.TabIndex = 4
        ' 
        ' lstTime
        ' 
        lstTime.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lstTime.FormattingEnabled = True
        lstTime.ItemHeight = 23
        lstTime.Location = New Point(595, 164)
        lstTime.Name = "lstTime"
        lstTime.Size = New Size(148, 234)
        lstTime.TabIndex = 5
        ' 
        ' frmBand
        ' 
        AutoScaleDimensions = New SizeF(8F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(755, 420)
        Controls.Add(lstTime)
        Controls.Add(lstSongs)
        Controls.Add(cboGenres)
        Controls.Add(lblTitle)
        Controls.Add(picImage)
        Controls.Add(mnuItems)
        Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MainMenuStrip = mnuItems
        Name = "frmBand"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dance Band"
        mnuItems.ResumeLayout(False)
        mnuItems.PerformLayout()
        CType(picImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents mnuItems As MenuStrip
    Friend WithEvents mnuAction As ToolStripMenuItem
    Friend WithEvents mnuDisplay As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents picImage As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents cboGenres As ComboBox
    Friend WithEvents lstSongs As ListBox
    Friend WithEvents lstTime As ListBox

End Class
