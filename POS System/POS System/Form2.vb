Public Class Form2

    Dim fileReader As String

    'Made by Evho (Will Clifford) - 7th November (Updated on 14th November, 28th November and 5th December)'

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        fileReader = My.Computer.FileSystem.ReadAllText("H:\Documents\4. Coding\Visual Basic\POS System\Updates\Alpha1.txt")
        MsgBox(fileReader)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        fileReader = My.Computer.FileSystem.ReadAllText("H:\Documents\4. Coding\Visual Basic\POS System\Updates\Alpha2.txt")
        MsgBox(fileReader)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        fileReader = My.Computer.FileSystem.ReadAllText("H:\Documents\4. Coding\Visual Basic\POS System\Updates\Alpha3.txt")
        MsgBox(fileReader)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Me.Hide()
        Form3.Show()

    End Sub

End Class