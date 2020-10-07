Public Class L04
    Dim data As Byte()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Connect" Then
            SerialPort1.PortName = ComboBox1.Text
            SerialPort1.Open()
            Button1.Text = "Disconnect"
        Else
            SerialPort1.Close()
            Button1.Text = "Connect"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (RadioButton1.Checked) Then
            Try
                TextBox2.Text = Hex$(SerialPort1.ReadByte())
            Catch ex As Exception
            End Try
        ElseIf (RadioButton2.Checked) Then
            Try
                TextBox2.Text = (SerialPort1.ReadByte())
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If RadioButton1.Checked Then
            data = New Byte() {Val("&H" & TextBox1.Text)}
            SerialPort1.Write(data, 0, 1)
        ElseIf (RadioButton2.Checked) Then
            data = New Byte() {Val(TextBox1.Text)}
            SerialPort1.Write(data, 0, 1)
        End If
    End Sub
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        data = New Byte() {255}
        SerialPort1.Write(data, 0, 1)
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        data = New Byte() {0}
        SerialPort1.Write(data, 0, 1)
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (RadioButton1.Checked) Then
            Try
                TextBox2.Text = Hex$(SerialPort1.ReadByte())
            Catch ex As Exception
            End Try
        ElseIf (RadioButton2.Checked) Then
            Try
                TextBox2.Text = (SerialPort1.ReadByte())
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Timer1.Start()
            Button5.Enabled = False
        Else
            Timer1.Stop()
            Button5.Enabled = True
        End If

    End Sub
    Private Sub L04_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SerialPort1.ReadTimeout = 1
        Dim Ports As String() = IO.Ports.SerialPort.GetPortNames()
        For Each Port In Ports
            ComboBox1.Items.Add(Port)
        Next Port
        ComboBox1.SelectedIndex = 0
    End Sub
End Class