Public Class Main
    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub L01INPUTOUTPUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles L01INPUTOUTPUTToolStripMenuItem.Click
        L01_18518241046.Show()
    End Sub

    Private Sub L02SevenSegmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles L02SevenSegmentToolStripMenuItem.Click
        L02.Show()
    End Sub

    Private Sub L03MotorStepperToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles L03MotorStepperToolStripMenuItem.Click
        L03.Show()
    End Sub

    Private Sub L04serialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles L04serialToolStripMenuItem.Click
        L04.Show()
    End Sub
End Class
