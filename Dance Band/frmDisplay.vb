Public Class frmDisplay
    Private _intSizeOfArray As Integer = 10
    Private _strTitle(_intSizeOfArray) As String
    Private _strGenre(_intSizeOfArray) As String
    Private _strLength(_intSizeOfArray) As String
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim frmBand As New frmBand()
        frmBand.Show()
        Me.Close()
    End Sub

    Private Sub frmDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objReader As IO.StreamReader
        Dim strFileLocation As String = "C:\Users\HELLO\Source\Repos\Dance Band\songs.txt"
        Dim intCount As Integer = 0
        Dim intFill As Integer
        ' Verify if the file exists
        If IO.File.Exists(strFileLocation) Then
            ' Open it
            objReader = IO.File.OpenText(strFileLocation)
            ' Read it
            Do While objReader.Peek <> -1
                _strTitle(intCount) = objReader.ReadLine()
                _strGenre(intCount) = objReader.ReadLine()
                _strLength(intCount) = objReader.ReadLine()
                intCount += 1
            Loop
            objReader.Close()
            For intFill = 0 To _strTitle.Length - 1
                If _strTitle(intFill) IsNot Nothing Then
                    lstSongs.Items.Add(_strTitle(intFill))
                End If
            Next
        Else
            MsgBox("File not found", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "File Not Found")
        End If
    End Sub
End Class