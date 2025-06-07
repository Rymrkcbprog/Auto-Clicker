Public Class Form1
    Declare Sub mouse_event Lib "user32" Alias "mouse_event" (ByVal dwFlags As Long, ByVal dx As Long, ByVal dy As Long, ByVal cButtons As Long, ByVal dwExtraInfo As Long)
    Private Const mouseclickup = 4
    Private Const mouseclickdown = 2
    Dim x, y As Integer
    Dim newpoint As New System.Drawing.Point
    Private Sub btnstop_Click(sender As Object, e As EventArgs) Handles btnstop.Click
        Timer1.Stop()
    End Sub


    Private Sub btnnstart_Click(sender As Object, e As EventArgs) Handles btnnstart.Click
        Timer1.Start()
    End Sub
    Private Sub btntest_Click(sender As Object, e As EventArgs) Handles btntest.Click
        txttest.Text = Val(txttest.Text) + 1
    End Sub

    Private Sub cbfast_CheckedChanged(sender As Object, e As EventArgs) Handles cbfast.CheckedChanged
        If cbfast.Checked Then
            cbnormal.Checked = False
            Timer1.Interval = 1
        End If
    End Sub

    Private Sub cbnormal_CheckedChanged(sender As Object, e As EventArgs) Handles cbnormal.CheckedChanged
        If cbnormal.Checked Then
            cbnormal.Checked = False
            Timer1.Interval = 1000
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        mouse_event(mouseclickdown, 0, 0, 0, 0)
        mouse_event(mouseclickup, 0, 0, 0, 0)
    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = 97 Or Asc(e.KeyChar) = 65 Then
            Timer1.Start()
        ElseIf Asc(e.KeyChar) = 98 Or Asc(e.KeyChar) = 66 Then
            Timer1.Stop()
        ElseIf Asc(e.KeyChar) = 49 Then
            cbfast.Checked = Not cbfast.Checked
        ElseIf Asc(e.KeyChar) = 50 Then
            cbnormal.Checked = Not cbnormal.Checked
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Me.ControlBox = False
        Me.Text = ""
        Me.TopMost = True
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
        End If
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        x = MousePosition.X - Me.Location.X
        y = MousePosition.Y - Me.Location.Y
    End Sub
End Class
