' Program Name: Dance Band
' Date: January 3, 2025
' Author: K Bola
' Purpose: This application opens a text file that contains song names ordered by popularity, their music genre and the song length in minutes. The application allows a user to select a genre of music and list of songs and their length can be displayed. it also allows the users to view all songs that the dance band can play in order of popularity in order of popularity or alphabetical order
Option Strict On
Public Class frmBand
    Dim songs As New List(Of String)
    Private Sub cboGenres_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGenres.SelectedIndexChanged
        Dim lines() As String = IO.File.ReadAllLines("C:\Users\HELLO\Source\Repos\Dance Band\songs.txt")
        For i As Integer = 0 To lines.Length - 1
            If i + 2 < lines.Length Then
                Dim title As String = lines(i)
                Dim genre As String = lines(i + 1)
                Dim length As String = lines(i + 2)

                If genre.Equals(cboGenres.SelectedItem.ToString(), StringComparison.OrdinalIgnoreCase) Then
                    lstSongs.Items.Add($"{title}")
                    lstTime.Items.Add($"{length} minutes")
                    songs.Add($"{title}, {genre}, {length}")
                End If
            End If
        Next
    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        cboGenres.Text = "Select Genre:"
        lstSongs.Items.Clear()
        lstTime.Items.Clear()
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Close()
    End Sub

    Private Sub mnuDisplay_Click(sender As Object, e As EventArgs) Handles mnuDisplay.Click
        Dim frmDisplay As New frmDisplay()
        frmDisplay.Show()
        Me.Hide()
    End Sub
End Class
