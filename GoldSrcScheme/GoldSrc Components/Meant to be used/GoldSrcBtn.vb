Public Class GoldSrcBtn
    Private Sub GoldSrcBtn_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, text1.MouseDown
        text1.Location = New Point(4, 5)
        RightColor.BackColor = Color.FromArgb(136, 145, 128)
        DownColor.BackColor = Color.FromArgb(136, 145, 128)
        LeftColor.BackColor = Color.FromArgb(40, 46, 34)
        TopColor.BackColor = Color.FromArgb(40, 46, 34)
    End Sub

    Private Sub GoldSrcBtn_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, text1.MouseUp
        text1.Location = New Point(3, 4)
        RightColor.BackColor = Color.FromArgb(40, 46, 34)
        DownColor.BackColor = Color.FromArgb(40, 46, 34)
        LeftColor.BackColor = Color.FromArgb(136, 145, 128)
        TopColor.BackColor = Color.FromArgb(136, 145, 128)
    End Sub
End Class
