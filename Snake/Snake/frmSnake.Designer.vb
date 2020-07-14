<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSnake
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSnake))
        Me.btnStart = New System.Windows.Forms.Button()
        Me.tmrMain = New System.Windows.Forms.Timer(Me.components)
        Me.lisSpace = New System.Windows.Forms.ListBox()
        Me.lblHighScore = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.lblDirection = New System.Windows.Forms.Label()
        Me.lblSegments = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.tmrTime = New System.Windows.Forms.Timer(Me.components)
        Me.grpInfo = New System.Windows.Forms.GroupBox()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.grpControls = New System.Windows.Forms.GroupBox()
        Me.picPad = New System.Windows.Forms.PictureBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.grpInfo.SuspendLayout()
        Me.grpControls.SuspendLayout()
        CType(Me.picPad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.Fuchsia
        Me.btnStart.Location = New System.Drawing.Point(584, 281)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(235, 121)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'tmrMain
        '
        Me.tmrMain.Interval = 300
        '
        'lisSpace
        '
        Me.lisSpace.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lisSpace.FormattingEnabled = True
        Me.lisSpace.ItemHeight = 18
        Me.lisSpace.Location = New System.Drawing.Point(840, 12)
        Me.lisSpace.Name = "lisSpace"
        Me.lisSpace.Size = New System.Drawing.Size(560, 472)
        Me.lisSpace.TabIndex = 1
        Me.lisSpace.Visible = False
        '
        'lblHighScore
        '
        Me.lblHighScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblHighScore.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighScore.Location = New System.Drawing.Point(6, 16)
        Me.lblHighScore.Name = "lblHighScore"
        Me.lblHighScore.Size = New System.Drawing.Size(249, 23)
        Me.lblHighScore.TabIndex = 3
        Me.lblHighScore.Text = "High Score:"
        Me.lblHighScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTime.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(6, 73)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(249, 23)
        Me.lblTime.TabIndex = 4
        Me.lblTime.Text = "Time: "
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnUp
        '
        Me.btnUp.BackColor = System.Drawing.Color.Red
        Me.btnUp.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUp.Location = New System.Drawing.Point(707, 375)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(60, 60)
        Me.btnUp.TabIndex = 5
        Me.btnUp.Text = "UP"
        Me.btnUp.UseVisualStyleBackColor = False
        '
        'btnLeft
        '
        Me.btnLeft.BackColor = System.Drawing.Color.Red
        Me.btnLeft.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLeft.Location = New System.Drawing.Point(646, 436)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(60, 60)
        Me.btnLeft.TabIndex = 6
        Me.btnLeft.Text = "LEFT"
        Me.btnLeft.UseVisualStyleBackColor = False
        '
        'btnDown
        '
        Me.btnDown.BackColor = System.Drawing.Color.Red
        Me.btnDown.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDown.Location = New System.Drawing.Point(707, 497)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(60, 60)
        Me.btnDown.TabIndex = 7
        Me.btnDown.Text = "DOWN"
        Me.btnDown.UseVisualStyleBackColor = False
        '
        'btnRight
        '
        Me.btnRight.BackColor = System.Drawing.Color.Red
        Me.btnRight.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRight.Location = New System.Drawing.Point(768, 436)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(60, 60)
        Me.btnRight.TabIndex = 8
        Me.btnRight.Text = "RIGHT"
        Me.btnRight.UseVisualStyleBackColor = False
        '
        'lblDirection
        '
        Me.lblDirection.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblDirection.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirection.Location = New System.Drawing.Point(6, 113)
        Me.lblDirection.Name = "lblDirection"
        Me.lblDirection.Size = New System.Drawing.Size(249, 23)
        Me.lblDirection.TabIndex = 9
        Me.lblDirection.Text = "Direction: "
        Me.lblDirection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSegments
        '
        Me.lblSegments.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblSegments.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSegments.Location = New System.Drawing.Point(6, 145)
        Me.lblSegments.Name = "lblSegments"
        Me.lblSegments.Size = New System.Drawing.Size(249, 23)
        Me.lblSegments.TabIndex = 10
        Me.lblSegments.Text = "Segments: "
        Me.lblSegments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitle.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(641, 12)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(193, 50)
        Me.lblTitle.TabIndex = 12
        Me.lblTitle.Text = "Snake"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrTime
        '
        Me.tmrTime.Interval = 1000
        '
        'grpInfo
        '
        Me.grpInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpInfo.Controls.Add(Me.lblScore)
        Me.grpInfo.Controls.Add(Me.lblHighScore)
        Me.grpInfo.Controls.Add(Me.lblTime)
        Me.grpInfo.Controls.Add(Me.lblDirection)
        Me.grpInfo.Controls.Add(Me.lblSegments)
        Me.grpInfo.Location = New System.Drawing.Point(840, 490)
        Me.grpInfo.Name = "grpInfo"
        Me.grpInfo.Size = New System.Drawing.Size(266, 182)
        Me.grpInfo.TabIndex = 15
        Me.grpInfo.TabStop = False
        '
        'lblScore
        '
        Me.lblScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblScore.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(6, 44)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(249, 23)
        Me.lblScore.TabIndex = 11
        Me.lblScore.Text = "Score:"
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpControls
        '
        Me.grpControls.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grpControls.Controls.Add(Me.picPad)
        Me.grpControls.Location = New System.Drawing.Point(634, 366)
        Me.grpControls.Name = "grpControls"
        Me.grpControls.Size = New System.Drawing.Size(200, 195)
        Me.grpControls.TabIndex = 16
        Me.grpControls.TabStop = False
        '
        'picPad
        '
        Me.picPad.BackColor = System.Drawing.Color.Fuchsia
        Me.picPad.Location = New System.Drawing.Point(73, 70)
        Me.picPad.Name = "picPad"
        Me.picPad.Size = New System.Drawing.Size(60, 60)
        Me.picPad.TabIndex = 17
        Me.picPad.TabStop = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Red
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.Black
        Me.btnReset.Location = New System.Drawing.Point(12, 551)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(174, 74)
        Me.btnReset.TabIndex = 17
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'frmSnake
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1097, 684)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnLeft)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.lisSpace)
        Me.Controls.Add(Me.grpInfo)
        Me.Controls.Add(Me.grpControls)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSnake"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Snake"
        Me.grpInfo.ResumeLayout(False)
        Me.grpControls.ResumeLayout(False)
        CType(Me.picPad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents tmrMain As Timer
    Friend WithEvents lisSpace As ListBox
    Friend WithEvents lblHighScore As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents btnUp As Button
    Friend WithEvents btnLeft As Button
    Friend WithEvents btnDown As Button
    Friend WithEvents btnRight As Button
    Friend WithEvents lblDirection As Label
    Friend WithEvents lblSegments As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents tmrTime As Timer
    Friend WithEvents grpInfo As GroupBox
    Friend WithEvents grpControls As GroupBox
    Friend WithEvents picPad As PictureBox
    Friend WithEvents lblScore As Label
    Friend WithEvents btnReset As Button
End Class
