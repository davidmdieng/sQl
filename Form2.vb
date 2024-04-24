Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim stFirstName As String




        stFirstName = InputBox("please enter your first name")

        MsgBox("hello" & stFirstName)
    End Sub
End Class