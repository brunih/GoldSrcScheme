Public Class GoldSrcFrame
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub GoldSrcFrame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowName.Text = ParentForm.Text
    End Sub

    Private Sub GoldSrcFrame_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, WindowName.MouseDown
        drag = True
        mousex = Cursor.Position.X - ParentForm.Left
        mousey = Cursor.Position.Y - ParentForm.Top
    End Sub

    Private Sub GoldSrcFrame_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, WindowName.MouseMove
        If drag Then
            ParentForm.Top = Cursor.Position.Y - mousey
            ParentForm.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub GoldSrcFrame_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, WindowName.MouseUp
        drag = False
    End Sub

    Private Sub Icon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Icon.MouseDoubleClick
        ParentForm.Close()
    End Sub
End Class
