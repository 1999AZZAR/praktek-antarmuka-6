<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class L03
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(L03))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RB_Half = New System.Windows.Forms.RadioButton()
        Me.RB_1p = New System.Windows.Forms.RadioButton()
        Me.RB_2p = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.HS_delay = New System.Windows.Forms.HScrollBar()
        Me.BT_kiri = New System.Windows.Forms.Button()
        Me.BT_kanan = New System.Windows.Forms.Button()
        Me.BT_Stop = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Delay"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Output"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Delay Scrollbar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(81, 309)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "azzar budiyanto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(209, 309)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "18518241046"
        '
        'RB_Half
        '
        Me.RB_Half.AutoSize = True
        Me.RB_Half.Location = New System.Drawing.Point(229, 46)
        Me.RB_Half.Name = "RB_Half"
        Me.RB_Half.Size = New System.Drawing.Size(77, 17)
        Me.RB_Half.TabIndex = 5
        Me.RB_Half.TabStop = True
        Me.RB_Half.Text = "Half Phase"
        Me.RB_Half.UseVisualStyleBackColor = True
        '
        'RB_1p
        '
        Me.RB_1p.AutoSize = True
        Me.RB_1p.Location = New System.Drawing.Point(229, 72)
        Me.RB_1p.Name = "RB_1p"
        Me.RB_1p.Size = New System.Drawing.Size(64, 17)
        Me.RB_1p.TabIndex = 6
        Me.RB_1p.TabStop = True
        Me.RB_1p.Text = "1 Phase"
        Me.RB_1p.UseVisualStyleBackColor = True
        '
        'RB_2p
        '
        Me.RB_2p.AutoSize = True
        Me.RB_2p.Location = New System.Drawing.Point(229, 96)
        Me.RB_2p.Name = "RB_2p"
        Me.RB_2p.Size = New System.Drawing.Size(64, 17)
        Me.RB_2p.TabIndex = 7
        Me.RB_2p.TabStop = True
        Me.RB_2p.Text = "2 Phase"
        Me.RB_2p.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(113, 39)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(65, 32)
        Me.TextBox1.TabIndex = 8
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(113, 92)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(65, 32)
        Me.TextBox2.TabIndex = 9
        '
        'HS_delay
        '
        Me.HS_delay.Location = New System.Drawing.Point(63, 193)
        Me.HS_delay.Maximum = 225
        Me.HS_delay.Minimum = 1
        Me.HS_delay.Name = "HS_delay"
        Me.HS_delay.Size = New System.Drawing.Size(256, 27)
        Me.HS_delay.TabIndex = 10
        Me.HS_delay.Value = 1
        '
        'BT_kiri
        '
        Me.BT_kiri.Location = New System.Drawing.Point(63, 254)
        Me.BT_kiri.Name = "BT_kiri"
        Me.BT_kiri.Size = New System.Drawing.Size(75, 23)
        Me.BT_kiri.TabIndex = 11
        Me.BT_kiri.Text = "Kiri "
        Me.BT_kiri.UseVisualStyleBackColor = True
        '
        'BT_kanan
        '
        Me.BT_kanan.Location = New System.Drawing.Point(153, 254)
        Me.BT_kanan.Name = "BT_kanan"
        Me.BT_kanan.Size = New System.Drawing.Size(75, 23)
        Me.BT_kanan.TabIndex = 12
        Me.BT_kanan.Text = "Kanan"
        Me.BT_kanan.UseVisualStyleBackColor = True
        '
        'BT_Stop
        '
        Me.BT_Stop.Location = New System.Drawing.Point(244, 254)
        Me.BT_Stop.Name = "BT_Stop"
        Me.BT_Stop.Size = New System.Drawing.Size(75, 23)
        Me.BT_Stop.TabIndex = 13
        Me.BT_Stop.Text = "Stop "
        Me.BT_Stop.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'L03
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 359)
        Me.Controls.Add(Me.BT_Stop)
        Me.Controls.Add(Me.BT_kanan)
        Me.Controls.Add(Me.BT_kiri)
        Me.Controls.Add(Me.HS_delay)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.RB_2p)
        Me.Controls.Add(Me.RB_1p)
        Me.Controls.Add(Me.RB_Half)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "L03"
        Me.Text = "L03_Motor_Stepper"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RB_Half As RadioButton
    Friend WithEvents RB_1p As RadioButton
    Friend WithEvents RB_2p As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents HS_delay As HScrollBar
    Friend WithEvents BT_kiri As Button
    Friend WithEvents BT_kanan As Button
    Friend WithEvents BT_Stop As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
