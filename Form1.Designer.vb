<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Render = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.tmrFollow = New System.Windows.Forms.Timer(Me.components)
        Me.txtSpeedX = New System.Windows.Forms.TextBox()
        Me.txtSpeedY = New System.Windows.Forms.TextBox()
        Me.txtSize = New System.Windows.Forms.TextBox()
        Me.txtMass = New System.Windows.Forms.TextBox()
        Me.txtFlag = New System.Windows.Forms.TextBox()
        Me.butAddBall = New System.Windows.Forms.Button()
        Me.txtStep = New System.Windows.Forms.TextBox()
        Me.butRemoveBalls = New System.Windows.Forms.Button()
        Me.butUpdate = New System.Windows.Forms.Button()
        Me.lblBalls = New System.Windows.Forms.Label()
        Me.chkTrails = New System.Windows.Forms.CheckBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.UpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.chkShadow = New System.Windows.Forms.CheckBox()
        Me.txtFPS = New System.Windows.Forms.TextBox()
        Me.chkDraw = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.Render, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Render
        '
        Me.Render.BackColor = System.Drawing.Color.White
        Me.Render.Location = New System.Drawing.Point(8, 28)
        Me.Render.Name = "Render"
        Me.Render.Size = New System.Drawing.Size(1084, 672)
        Me.Render.TabIndex = 15
        Me.Render.TabStop = False
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 125
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Black
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(9, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 16)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "FPS: "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(692, 298)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Label11"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(989, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 20)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "G: Off"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(910, 710)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 20)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Friction: On"
        Me.Label13.Visible = False
        '
        'Timer3
        '
        Me.Timer3.Interval = 1
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(597, 702)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 28)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(347, 710)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(57, 19)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(175, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(57, 23)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = "Stop"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'tmrFollow
        '
        Me.tmrFollow.Interval = 20
        '
        'txtSpeedX
        '
        Me.txtSpeedX.Location = New System.Drawing.Point(321, 5)
        Me.txtSpeedX.Name = "txtSpeedX"
        Me.txtSpeedX.Size = New System.Drawing.Size(53, 20)
        Me.txtSpeedX.TabIndex = 29
        Me.ToolTip1.SetToolTip(Me.txtSpeedX, "X Velocity")
        '
        'txtSpeedY
        '
        Me.txtSpeedY.Location = New System.Drawing.Point(380, 5)
        Me.txtSpeedY.Name = "txtSpeedY"
        Me.txtSpeedY.Size = New System.Drawing.Size(52, 20)
        Me.txtSpeedY.TabIndex = 30
        Me.ToolTip1.SetToolTip(Me.txtSpeedY, "Y Velocity")
        '
        'txtSize
        '
        Me.txtSize.Location = New System.Drawing.Point(438, 5)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(61, 20)
        Me.txtSize.TabIndex = 31
        Me.ToolTip1.SetToolTip(Me.txtSize, "Body Diameter")
        '
        'txtMass
        '
        Me.txtMass.Location = New System.Drawing.Point(505, 5)
        Me.txtMass.Name = "txtMass"
        Me.txtMass.Size = New System.Drawing.Size(63, 20)
        Me.txtMass.TabIndex = 32
        Me.ToolTip1.SetToolTip(Me.txtMass, "Body Mass")
        '
        'txtFlag
        '
        Me.txtFlag.Location = New System.Drawing.Point(574, 5)
        Me.txtFlag.Name = "txtFlag"
        Me.txtFlag.Size = New System.Drawing.Size(37, 20)
        Me.txtFlag.TabIndex = 33
        Me.ToolTip1.SetToolTip(Me.txtFlag, "Flags")
        '
        'butAddBall
        '
        Me.butAddBall.BackColor = System.Drawing.SystemColors.ControlDark
        Me.butAddBall.ForeColor = System.Drawing.Color.Black
        Me.butAddBall.Location = New System.Drawing.Point(2, 3)
        Me.butAddBall.Name = "butAddBall"
        Me.butAddBall.Size = New System.Drawing.Size(75, 23)
        Me.butAddBall.TabIndex = 34
        Me.butAddBall.Text = "Add Bodies"
        Me.butAddBall.UseVisualStyleBackColor = False
        '
        'txtStep
        '
        Me.txtStep.Location = New System.Drawing.Point(238, 5)
        Me.txtStep.Name = "txtStep"
        Me.txtStep.Size = New System.Drawing.Size(44, 20)
        Me.txtStep.TabIndex = 35
        Me.txtStep.Text = "0.001"
        Me.ToolTip1.SetToolTip(Me.txtStep, "Time Step")
        '
        'butRemoveBalls
        '
        Me.butRemoveBalls.Location = New System.Drawing.Point(83, 3)
        Me.butRemoveBalls.Name = "butRemoveBalls"
        Me.butRemoveBalls.Size = New System.Drawing.Size(86, 23)
        Me.butRemoveBalls.TabIndex = 36
        Me.butRemoveBalls.Text = "Remove All"
        Me.butRemoveBalls.UseVisualStyleBackColor = True
        '
        'butUpdate
        '
        Me.butUpdate.Location = New System.Drawing.Point(617, 4)
        Me.butUpdate.Name = "butUpdate"
        Me.butUpdate.Size = New System.Drawing.Size(54, 21)
        Me.butUpdate.TabIndex = 37
        Me.butUpdate.Text = "Update"
        Me.butUpdate.UseVisualStyleBackColor = True
        '
        'lblBalls
        '
        Me.lblBalls.AutoSize = True
        Me.lblBalls.BackColor = System.Drawing.Color.Black
        Me.lblBalls.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalls.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBalls.Location = New System.Drawing.Point(9, 47)
        Me.lblBalls.Name = "lblBalls"
        Me.lblBalls.Size = New System.Drawing.Size(41, 16)
        Me.lblBalls.TabIndex = 38
        Me.lblBalls.Text = "Balls:"
        '
        'chkTrails
        '
        Me.chkTrails.AutoSize = True
        Me.chkTrails.Location = New System.Drawing.Point(748, 7)
        Me.chkTrails.Name = "chkTrails"
        Me.chkTrails.Size = New System.Drawing.Size(51, 17)
        Me.chkTrails.TabIndex = 41
        Me.chkTrails.Text = "Trails"
        Me.chkTrails.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(679, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(64, 22)
        Me.Button4.TabIndex = 42
        Me.Button4.Text = "ToT Mass"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(933, 6)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(50, 20)
        Me.Button5.TabIndex = 43
        Me.Button5.Text = "S-Shot"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'UpDown1
        '
        Me.UpDown1.Location = New System.Drawing.Point(1051, 6)
        Me.UpDown1.Name = "UpDown1"
        Me.UpDown1.Size = New System.Drawing.Size(48, 20)
        Me.UpDown1.TabIndex = 44
        '
        'chkShadow
        '
        Me.chkShadow.AutoSize = True
        Me.chkShadow.Location = New System.Drawing.Point(805, 7)
        Me.chkShadow.Name = "chkShadow"
        Me.chkShadow.Size = New System.Drawing.Size(65, 17)
        Me.chkShadow.TabIndex = 45
        Me.chkShadow.Text = "Shadow"
        Me.chkShadow.UseVisualStyleBackColor = True
        '
        'txtFPS
        '
        Me.txtFPS.Location = New System.Drawing.Point(288, 5)
        Me.txtFPS.Name = "txtFPS"
        Me.txtFPS.Size = New System.Drawing.Size(30, 20)
        Me.txtFPS.TabIndex = 46
        Me.txtFPS.Text = "60"
        Me.ToolTip1.SetToolTip(Me.txtFPS, "FPS Limiter")
        '
        'chkDraw
        '
        Me.chkDraw.AutoSize = True
        Me.chkDraw.Checked = True
        Me.chkDraw.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDraw.Location = New System.Drawing.Point(876, 7)
        Me.chkDraw.Name = "chkDraw"
        Me.chkDraw.Size = New System.Drawing.Size(51, 17)
        Me.chkDraw.TabIndex = 47
        Me.chkDraw.Text = "Draw"
        Me.chkDraw.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 0
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ShowAlways = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1101, 737)
        Me.Controls.Add(Me.chkDraw)
        Me.Controls.Add(Me.txtFPS)
        Me.Controls.Add(Me.chkShadow)
        Me.Controls.Add(Me.UpDown1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.chkTrails)
        Me.Controls.Add(Me.lblBalls)
        Me.Controls.Add(Me.butUpdate)
        Me.Controls.Add(Me.butRemoveBalls)
        Me.Controls.Add(Me.txtStep)
        Me.Controls.Add(Me.butAddBall)
        Me.Controls.Add(Me.txtFlag)
        Me.Controls.Add(Me.txtMass)
        Me.Controls.Add(Me.txtSize)
        Me.Controls.Add(Me.txtSpeedY)
        Me.Controls.Add(Me.txtSpeedX)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Render)
        Me.Controls.Add(Me.Label11)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gravity Simulator by Bobby Lovell"
        CType(Me.Render, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Render As System.Windows.Forms.PictureBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents tmrFollow As System.Windows.Forms.Timer
    Friend WithEvents txtSpeedX As System.Windows.Forms.TextBox
    Friend WithEvents txtSpeedY As System.Windows.Forms.TextBox
    Friend WithEvents txtSize As System.Windows.Forms.TextBox
    Friend WithEvents txtMass As System.Windows.Forms.TextBox
    Friend WithEvents txtFlag As System.Windows.Forms.TextBox
    Friend WithEvents butAddBall As System.Windows.Forms.Button
    Friend WithEvents txtStep As System.Windows.Forms.TextBox
    Friend WithEvents butRemoveBalls As System.Windows.Forms.Button
    Friend WithEvents butUpdate As System.Windows.Forms.Button
    Friend WithEvents lblBalls As System.Windows.Forms.Label
    Friend WithEvents chkTrails As System.Windows.Forms.CheckBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents UpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkShadow As System.Windows.Forms.CheckBox
    Friend WithEvents txtFPS As System.Windows.Forms.TextBox
    Friend WithEvents chkDraw As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
