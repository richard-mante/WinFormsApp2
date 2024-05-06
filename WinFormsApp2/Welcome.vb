Public Class Welcome
    Dim txtName As String
    Dim level As Integer
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        txtName = TextBox1.Text
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        level = TextBox2.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If level = 1 Then
            MsgBox("Hello hero" & vbNewLine & "level " & level)
        ElseIf level = 2 Then
            MsgBox("Hello hero" & vbNewLine & "level " & level)
        ElseIf level = 3 Then
            MsgBox("Hello hero" & vbNewLine & "level " & level)
        ElseIf level = 4 Then
            MsgBox("Hello hero" & vbNewLine & "level " & level)
        ElseIf level = 5 Then
            MsgBox("Hello hero" & vbNewLine & "level " & level)

        End If
        Form1.Activate()
    End Sub
End Class