﻿Class MainWindow
    Private Sub btn_close_Click(sender As Object, e As RoutedEventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_sig_Click(sender As Object, e As RoutedEventArgs) Handles bt_sig.Click
        If txt_user.Text = "mod1" And txt_pass.Password = "1234" Then
            Dim Base As New Base
            Base.Show()
            Me.Close()
        End If
    End Sub
End Class
