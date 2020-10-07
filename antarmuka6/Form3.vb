Public Class L02
    Public Declare Sub out Lib "io.dll" Alias "PortOut" (PortAddress As Short, PortData As Byte)
    Public Declare Function inp Lib "io.dll" Alias "PortIn" (PortAddress As Short) As Byte
    Dim Number(0 To 9) As Integer
    Dim Index As Integer
    Dim Exits As Boolean
    Dim index1, index2, index3, index4 As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles B1_SA.Click
        Timer1.Interval = Val(TextBox2.Text)
        Timer1.Enabled = True
        Timer2.Enabled = False
        Timer3.Enabled = False
        Timer4.Enabled = False
        B1_SA.Enabled = False
        B1_SO.Enabled = True
        B2_SA.Enabled = False
        B2_SO.Enabled = False
        B2_SA.Enabled = False
        B3_SO.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Index < 9 Then
            'Out(&H378, number(index))
            Index = Index + 1
        Else
            Index = 0
        End If
        TextBox1.Text = Index.ToString
        out(&H378, Number(Index))
        out(&H37A, &H5)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles B1_SO.Click
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
        Timer4.Enabled = False
        Index = 0
        TextBox1.Text = "0"
        B1_SA.Enabled = True
        B1_SO.Enabled = False
        B2_SO.Enabled = False
        B3_SO.Enabled = False
        B2_SA.Enabled = True
        B2_SA.Enabled = True
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HS1.Scroll
        TextBox7.Text = HS1.Value.ToString
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        out(&H378, Number(Val(TextBox3.Text)))
        out(&H37A, &H5)
        Call Delay()
        out(&H378, Number(Val(TextBox4.Text)))
        out(&H37A, &H6)
        Call Delay()
        out(&H378, Number(Val(TextBox5.Text)))
        out(&H37A, &H0)
        Call Delay()
        out(&H378, Number(Val(TextBox6.Text)))
        out(&H37A, &HC)
        Call Delay()
    End Sub
    Private Sub B1_SO_Click(sender As System.Object, e As EventArgs) Handles B1_SO.Click
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
        Timer4.Enabled = False
        Index = 0
        TextBox1.Text = "0"
        B1_SA.Enabled = True
        B1_SO.Enabled = False
        B2_SO.Enabled = False
        B3_SO.Enabled = False
        B2_SA.Enabled = True
        B2_SA.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles B2_SA.Click
        B2_SA.Enabled = False
        B2_SO.Enabled = True
        Timer1.Enabled = False
        Timer2.Enabled = True
        Timer3.Enabled = False
        Timer4.Enabled = False
        B1_SA.Enabled = False
        B1_SO.Enabled = False
        B2_SA.Enabled = False
        B3_SO.Enabled = False
    End Sub

    Private Sub B2_SO_Click(sender As Object, e As EventArgs) Handles B2_SO.Click
        B2_SA.Enabled = True
        B2_SO.Enabled = False
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
        Timer4.Enabled = False
        B1_SA.Enabled = True
        B1_SO.Enabled = False
        B3_SA.Enabled = True
        B3_SO.Enabled = False
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If CheckBox1.Checked = True Then
            CheckBox2.Enabled = False
            TextBox8.Text = Format(Now, "hh:mm")
        ElseIf CheckBox2.Checked = True Then
            CheckBox1.Enabled = False
            TextBox8.Text = Format(Now, "mm:ss")
        End If
        index1 = Asc(Mid(TextBox8.Text, 5, 1)) - &H30
        index2 = Asc(Mid(TextBox8.Text, 4, 1)) - &H30
        index3 = Asc(Mid(TextBox8.Text, 2, 1)) - &H30
        index4 = Asc(Mid(TextBox8.Text, 1, 1)) - &H30
    End Sub
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        out(&H378, Number(Val(index1)))
        out(&H37A, &H5)
        Call delay_jam()
        out(&H378, Number(Val(index2)))
        out(&H37A, &H6)
        Call delay_jam()
        out(&H378, Number(Val(index3)))
        out(&H37A, &H0)
        Call delay_jam()
        out(&H378, Number(Val(index4)))
        out(&H37A, &HC)
        Call delay_jam()
    End Sub
    Private Sub B3_SA_Click(sender As Object, e As EventArgs) Handles B3_SA.Click
        Exits = False
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = True
        Timer4.Enabled = True
        B1_SA.Enabled = False
        B1_SO.Enabled = False
        B2_SA.Enabled = False
        B2_SO.Enabled = False
        B3_SA.Enabled = False
        B3_SO.Enabled = True
    End Sub
    Private Sub B3_SO_Click(sender As Object, e As EventArgs) Handles B3_SO.Click
        Exits = True
        Exits = False
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
        Timer4.Enabled = False
        B1_SA.Enabled = True
        B1_SO.Enabled = True
        B2_SA.Enabled = True
        B2_SO.Enabled = True
        B3_SA.Enabled = True
        B3_SO.Enabled = True
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub
    Private Sub Delay()
        System.Threading.Thread.Sleep(HS1.Value)
    End Sub
    Sub delay_jam()
        System.Threading.Thread.Sleep(1)
    End Sub
    Private Sub L02_NIM_Load(sender As System.Object, e As EventArgs) Handles MyBase.Load
        Number(0) = &H3F
        Number(1) = &H6
        Number(2) = &H5B
        Number(3) = &H4F
        Number(4) = &H66
        Number(5) = &H6D
        Number(6) = &H7D
        Number(7) = &H7
        Number(8) = &H7F
        Number(9) = &H6F
    End Sub
End Class