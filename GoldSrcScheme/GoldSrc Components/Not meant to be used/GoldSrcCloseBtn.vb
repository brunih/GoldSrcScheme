Public Class GoldSrcCloseBtn
    Private Sub GoldSrcWindowClose_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, CloseBtn.MouseDown
        CloseBtn.Location = New Point(2, 2)
        RightColor.BackColor = Color.FromArgb(136, 145, 128)
        DownColor.BackColor = Color.FromArgb(136, 145, 128)
        LeftColor.BackColor = Color.FromArgb(40, 46, 34)
        TopColor.BackColor = Color.FromArgb(40, 46, 34)
    End Sub

    Private Sub GoldSrcWindowClose_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, CloseBtn.MouseUp
        CloseBtn.Location = New Point(1, 1)
        RightColor.BackColor = Color.FromArgb(40, 46, 34)
        DownColor.BackColor = Color.FromArgb(40, 46, 34)
        LeftColor.BackColor = Color.FromArgb(136, 145, 128)
        TopColor.BackColor = Color.FromArgb(136, 145, 128)
    End Sub

    Private Sub GoldSrcWindowCtrls_Click(sender As Object, e As EventArgs) Handles MyBase.Click, CloseBtn.Click
        ParentForm.Close()
    End Sub
End Class
