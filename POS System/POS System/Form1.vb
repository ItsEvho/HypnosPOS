Public Class Form1

    Dim eMail As String
    Dim passwordStuff As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        eMail = TextBox1.Text
        passwordStuff = TextBox2.Text

        If eMail = "evho@hypnos.io" Then

            MsgBox("Email is correct.")

        ElseIf eMail = "linx@hypnos.io" Then

            MsgBox("Email is correct.")

        ElseIf eMail = "bartschboi@hypnos.io" Then

            MsgBox("Email is correct.")

        ElseIf eMail = "solar@hypnos.io" Then

            MsgBox("Email is correct.")

        ElseIf eMail = "tester@hypnos.io" Then

            MsgBox("Email is correct.")

        End If

        If passwordStuff = "itsevho" Then

            MsgBox("Password is correct.")
            Me.Hide()
            Form2.Show()

        ElseIf passwordStuff = "linxxd" Then

            MsgBox("Password is correct.")
            Me.Hide()
            Form2.Show()

        ElseIf passwordStuff = "bartschboi" Then

            MsgBox("Password is correct.")
            Me.Hide()
            Form2.Show()

        ElseIf passwordStuff = "solarnolar" Then

            MsgBox("Password is correct.")
            Me.Hide()
            Form2.Show()

        ElseIf passwordStuff = "tester123" Then

            MsgBox("Password is correct.")
            Me.Hide()
            Form2.Show()

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Hide()
        Form3.Show()

    End Sub

End Class
