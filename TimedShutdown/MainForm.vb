Public Class MainForm

    Private buttonStatus As Boolean = False

    Private Countdown As UShort

    Private Sub TimeTrackBar_ValueChanged(sender As Object, e As EventArgs) Handles TimeTrackBar.ValueChanged
        ' 当滑块滑动时更新提示文本内容
        If TimeTrackBar.Value < 60 Then
            TipText.Text = TimeTrackBar.Value & " 分钟后将关机"
        ElseIf TimeTrackBar.Value = 60 Then
            TipText.Text = "1 小时后将关机"
        ElseIf TimeTrackBar.Value < 120 Then
            TipText.Text = "1 小时 " & TimeTrackBar.Value - 60 & " 分钟后将关机"
        Else
            TipText.Text = "2 小时后将关机"
        End If
    End Sub

    Private Sub ControlButton_Click(sender As Object, e As EventArgs) Handles ControlButton.Click
        If Not buttonStatus Then
            ' 开启Timer
            Timer_Minute.Start()
            ' 定时关机
            Shell("shutdown /s /t " & TimeTrackBar.Value * 60, vbHide)
            ' 禁用滑块
            TimeTrackBar.Enabled = False
            ' 更新按钮内容
            ControlButton.Text = "取消"
            ' 更新按钮状态
            buttonStatus = True
        Else
            ' 停止Timer
            Timer_Minute.Stop()
            Timer_Second.Stop()
            ' 取消定时关机
            Shell("shutdown /a", vbHide)
            ' 启用滑块
            TimeTrackBar.Enabled = True
            ' 更新按钮内容
            ControlButton.Text = "定时"
            ' 更新按钮状态
            buttonStatus = False
            ' 取消置顶状态
            Me.TopMost = False
        End If
    End Sub

    Private Sub Timer_Minute_Tick(sender As Object, e As EventArgs) Handles Timer_Minute.Tick
        If TimeTrackBar.Value > 1 Then
            ' 更新滑块
            TimeTrackBar.Value = TimeTrackBar.Value - 1
            If TimeTrackBar.Value = 1 Then
                ' 提示用户,置顶窗口
                Me.WindowState = FormWindowState.Normal
                Me.TopMost = True
                ' 进入倒计时
                Countdown = 59
                Timer_Second.Start()
            End If
        End If
    End Sub

    Private Sub Timer_Second_Tick(sender As Object, e As EventArgs) Handles Timer_Second.Tick
        If Countdown > 0 Then
            TipText.Text = Countdown & " 秒后将关机"
            Countdown = Countdown - 1
        End If
    End Sub
End Class
