<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParallerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.L01INPUTOUTPUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.L02SevenSegmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.L03MotorStepperToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SerialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.USBHIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.I2CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.L04serialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KeluarToolStripMenuItem, Me.ParallerToolStripMenuItem, Me.SerialToolStripMenuItem, Me.USBHIDToolStripMenuItem, Me.I2CToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(427, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.KeluarToolStripMenuItem.Text = "keluar"
        '
        'ParallerToolStripMenuItem
        '
        Me.ParallerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.L01INPUTOUTPUTToolStripMenuItem, Me.L02SevenSegmentToolStripMenuItem, Me.L03MotorStepperToolStripMenuItem})
        Me.ParallerToolStripMenuItem.Name = "ParallerToolStripMenuItem"
        Me.ParallerToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.ParallerToolStripMenuItem.Text = "parallel"
        '
        'L01INPUTOUTPUTToolStripMenuItem
        '
        Me.L01INPUTOUTPUTToolStripMenuItem.Name = "L01INPUTOUTPUTToolStripMenuItem"
        Me.L01INPUTOUTPUTToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.L01INPUTOUTPUTToolStripMenuItem.Text = "L01_input output"
        '
        'L02SevenSegmentToolStripMenuItem
        '
        Me.L02SevenSegmentToolStripMenuItem.Name = "L02SevenSegmentToolStripMenuItem"
        Me.L02SevenSegmentToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.L02SevenSegmentToolStripMenuItem.Text = "L02_Seven Segment"
        '
        'L03MotorStepperToolStripMenuItem
        '
        Me.L03MotorStepperToolStripMenuItem.Name = "L03MotorStepperToolStripMenuItem"
        Me.L03MotorStepperToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.L03MotorStepperToolStripMenuItem.Text = "L03_Motor Stepper"
        '
        'SerialToolStripMenuItem
        '
        Me.SerialToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.L04serialToolStripMenuItem})
        Me.SerialToolStripMenuItem.Name = "SerialToolStripMenuItem"
        Me.SerialToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.SerialToolStripMenuItem.Text = "serial"
        '
        'USBHIDToolStripMenuItem
        '
        Me.USBHIDToolStripMenuItem.Name = "USBHIDToolStripMenuItem"
        Me.USBHIDToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.USBHIDToolStripMenuItem.Text = "USB HID"
        '
        'I2CToolStripMenuItem
        '
        Me.I2CToolStripMenuItem.Name = "I2CToolStripMenuItem"
        Me.I2CToolStripMenuItem.Size = New System.Drawing.Size(36, 20)
        Me.I2CToolStripMenuItem.Text = "I2C"
        '
        'L04serialToolStripMenuItem
        '
        Me.L04serialToolStripMenuItem.Name = "L04serialToolStripMenuItem"
        Me.L04serialToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.L04serialToolStripMenuItem.Text = "L04_Komunikasi serial 1"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(427, 244)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Text = "teknik antarmuka - 18518241046 - azzar budiyanto"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ParallerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents L01INPUTOUTPUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents L02SevenSegmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents L03MotorStepperToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SerialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents USBHIDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents I2CToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents L04serialToolStripMenuItem As ToolStripMenuItem
End Class
