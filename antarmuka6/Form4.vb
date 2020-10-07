Public Class L03
    Public Declare Sub Out Lib "io.dll" Alias "PortOut" (PortAddress As Short, PortData As Byte)
    Public Declare Function inp Lib "io.dll" Alias "PortIn" (PortAddress As Short) As Byte
    Dim Hidari, Migi As Boolean
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If RB_1p.Checked = True Then
            Hidari = True
            Migi = False
            Out(&H378, 1)
            TextBox2.Text = "1"
            Call delay()
            TextBox2.Refresh()
            Out(&H378, 2)
            TextBox2.Text = "2"
            Call delay()
            TextBox2.Refresh()
            Out(&H378, 4)
            TextBox2.Text = "4"
            Call delay()
            TextBox2.Refresh()
            Out(&H378, 8)
            TextBox2.Text = "8"
            Call delay()
            TextBox2.Refresh()
        ElseIf RB_2p.Checked = True Then
            Hidari = True
            Migi = False
            Out(&H378, 9)
            TextBox2.Text = "9"
            Call delay()
            TextBox2.Refresh()
            Out(&H378, 3)
            TextBox2.Text = "3"
            Call delay()
            TextBox2.Refresh()
            Out(&H378, 6)
            TextBox2.Text = "6"
            Call delay()
            TextBox2.Refresh()
            Out(&H378, 12)
            TextBox2.Text = "12"
            Call delay()
            TextBox2.Refresh()
        ElseIf RB_Half.Checked = True Then
            Hidari = True
            Migi = False
            Out(&H378, 9)
            TextBox2.Text = "9"
            Call delay()
            TextBox2.Refresh()
            Out(&H378, 1)
            TextBox2.Text = "1"
            Call delay()
            TextBox2.Refresh()
            Out(&H378, 3)
            TextBox2.Text = "3"
            Call delay()
            TextBox2.Refresh()
            Out(&H378, 2)
            TextBox2.Text = "2"
            Call delay()
            TextBox2.Refresh()
            Out(&H378, 6)
            TextBox2.Text = "6"
            Call delay()
            TextBox2.Refresh()
            Out(&H378, 4)
            TextBox2.Text = "4"
            Call delay()
            TextBox2.Refresh()
            Out(&H378, 12)
            TextBox2.Text = "12"
            Call delay()
            TextBox2.Refresh()
            Out(&H378, 8)
            TextBox2.Text = "8"
            Call delay()
            TextBox2.Refresh()
            Out(&H378, 0)
            TextBox2.Text = "0"
            Call delay()
            TextBox2.Refresh()
        End If
        BT_kanan.Enabled = False
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If RB_1p.Checked = True Then
            Hidari = False
            Migi = True
            Out(&H378, 8)
            TextBox2.Text = "8"
            Call delay()
            TextBox2.Refresh()
            Out(&H378, 4)
            TextBox2.Text = "4"
            Call delay()
            TextBox2.Refresh()
            Out(&H378, 2)
            TextBox2.Text = "2"
            Call delay()
            TextBox2.Refresh()
            Out(&H378, 1)
            TextBox2.Text = "1"
            Call delay()
            TextBox2.Refresh()
        ElseIf RB_2p.Checked = True Then
            Hidari = False
            Migi = True
            Out(&H378, 12)
            TextBox2.Text = "12"
            Call delay()
            TextBox2.Refresh()
            Out(&H378, 6)
            TextBox2.Text = "6"
            Call delay()
            TextBox2.Refresh()
            Out(&H378, 3)
            TextBox2.Text = "3"
            Call delay()
            TextBox2.Refresh()
            Out(&H378, 9)
            TextBox2.Text = "9"
            Call delay()
            TextBox2.Refresh()
        ElseIf RB_Half.Checked = True Then
            Hidari = False
            Migi = True
            Out(&H378, 0)
            TextBox2.Text = "8"
            Call delay()
            TextBox2.Refresh()
            Out(&H378, 8)
            TextBox2.Text = "12"
            Call delay()
            TextBox2.Refresh()
            Out(&H378, 12)
            TextBox2.Text = "4"
            Call delay()
            TextBox2.Refresh()
            Out(&H378, 4)
            TextBox2.Text = "6"
            Call delay()
            TextBox2.Refresh()
            Out(&H378, 6)
            TextBox2.Text = "2"
            Call delay()
            TextBox2.Refresh()
            Out(&H378, 2)
            TextBox2.Text = "3"
            Call delay()
            TextBox2.Refresh()
            Out(&H378, 3)
            TextBox2.Text = "1"
            Call delay()
            TextBox2.Refresh()
            Out(&H378, 1)
            TextBox2.Text = "9"
            Call delay()
            TextBox2.Refresh()
            Out(&H378, 9)
            TextBox2.Text = "0"
            Call delay()
            TextBox2.Refresh()
        End If
        BT_kiri.Enabled = False
    End Sub
    Private Sub HS_delay_Scroll(sender As Object, e As ScrollEventArgs) Handles HS_delay.Scroll
        TextBox2.Text = HS_delay.Value.ToString
    End Sub
    Private Sub BT_kiri_Click(sender As Object, e As EventArgs) Handles BT_kiri.Click
        Timer1.Start()
        Timer2.Stop()
    End Sub
    Private Sub BT_kanan_Click(sender As Object, e As EventArgs) Handles BT_kanan.Click
        Timer2.Start()
        Timer1.Stop()
    End Sub
    Private Sub BT_Stop_Click(sender As Object, e As EventArgs) Handles BT_Stop.Click
        Timer1.Stop()
        Timer2.Stop()
        BT_kanan.Enabled = True
        BT_kiri.Enabled = True
    End Sub
    Private Sub delay()
        System.Threading.Thread.Sleep(HS_delay.Value)
    End Sub
End Class