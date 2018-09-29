Imports Substrate
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub

    Private Sub Button_ChooseSavegame_Click(sender As Object, e As EventArgs) Handles Button_ChooseSavegame.Click
        OpenFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\.minecraft\saves"
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()

        ' Test result.
        If result = Windows.Forms.DialogResult.OK Then
            ' Get the file name.
            Dim path As String = OpenFileDialog1.FileName
            Me.TextBox_LevelDatPath.Text = path
        End If
    End Sub





    Private Sub TextBox_LevelDatPath_MouseDown(sender As Object, e As MouseEventArgs) Handles TextBox_LevelDatPath.MouseDown
        TextBox_LevelDatPath.SelectAll()
    End Sub
End Class
