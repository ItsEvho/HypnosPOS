Public Class Form1

    Dim eMail As String
    Dim passwordStuff As String
    Private txtpass As Object

    'Made by Evho (Will Clifford) - 7th November (Updated on 14th November, 28th November and 5th December)'

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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If TextBox2.UseSystemPasswordChar = True Then

            TextBox2.UseSystemPasswordChar = False
            Button3.Text = "Hide Password"

        Else

            TextBox2.UseSystemPasswordChar = True
            Button3.Text = "Show Password"

        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox2.UseSystemPasswordChar = True

    End Sub

End Class
