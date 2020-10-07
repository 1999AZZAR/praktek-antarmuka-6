Public Class L01_18518241046
    Public Declare Sub out Lib "io.dll" Alias "PortOut" (PortAddress As Short, PortData As Byte)
    Public Declare Function inp Lib "io.dll" Alias "PortIn" (PortAddress As Short) As Byte

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim data As Long
        If RadioButton1.Checked = True Then

            data = Val("&H" & TextBox1.Text)
        Else

            data = Val(TextBox1.Text)
        End If
        out(&H378, data)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        out(&H378, &HFF)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        out(&H378, &H0)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim data As Integer
        If (RadioButton1.Checked) Then

            data = Val("&H" & TextBox2.Text)
        Else

            data = Val(TextBox2.Text)
        End If
        out(&H37A, data And &HF Xor &HB)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        out(&H37A, &H4)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        out(&H37A, &HB)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If RadioButton1.Checked = True Then
            TextBox3.Text = Hex$(inp(&H379) And &HF8 Xor &H80)
        ElseIf RadioButton1.Checked = False Then
            TextBox3.Text = (inp(&H379) And &HF8 Xor &H80)
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then

            Timer1.Enabled = True

            Button7.Enabled = False
        ElseIf CheckBox1.Checked = False Then

            Timer1.Enabled = False

            Button7.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If RadioButton1.Checked = True Then
            TextBox3.Text = Hex$(inp(&H379) And &HF8 Xor &H80)
        ElseIf RadioButton1.Checked = False Then
            TextBox3.Text = (inp(&H379) And &HF8 Xor &H80)
        End If
    End Sub
End Class