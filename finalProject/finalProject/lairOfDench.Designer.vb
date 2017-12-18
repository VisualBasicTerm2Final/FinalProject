<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lairOfDench
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnWarCry = New System.Windows.Forms.Button()
        Me.btnFight = New System.Windows.Forms.Button()
        Me.btnRunPast = New System.Windows.Forms.Button()
        Me.btnInsultHim = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.timeLeft = New System.Windows.Forms.Timer(Me.components)
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btnAcceptYourFate = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.finalProject.My.Resources.Resources.denchOrc1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(346, 346)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(403, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(441, 72)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "This is Dench the Orc. He is your first fight." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You see that huge freaking mallet" & _
    " in his hand?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "He killed Thor with that. "
        '
        'btnWarCry
        '
        Me.btnWarCry.Location = New System.Drawing.Point(717, 260)
        Me.btnWarCry.Name = "btnWarCry"
        Me.btnWarCry.Size = New System.Drawing.Size(91, 35)
        Me.btnWarCry.TabIndex = 2
        Me.btnWarCry.Text = "War Cry"
        Me.btnWarCry.UseVisualStyleBackColor = True
        '
        'btnFight
        '
        Me.btnFight.Location = New System.Drawing.Point(717, 178)
        Me.btnFight.Name = "btnFight"
        Me.btnFight.Size = New System.Drawing.Size(91, 35)
        Me.btnFight.TabIndex = 3
        Me.btnFight.Text = "Fight"
        Me.btnFight.UseVisualStyleBackColor = True
        '
        'btnRunPast
        '
        Me.btnRunPast.Location = New System.Drawing.Point(442, 178)
        Me.btnRunPast.Name = "btnRunPast"
        Me.btnRunPast.Size = New System.Drawing.Size(91, 35)
        Me.btnRunPast.TabIndex = 4
        Me.btnRunPast.Text = "Run past"
        Me.btnRunPast.UseVisualStyleBackColor = True
        '
        'btnInsultHim
        '
        Me.btnInsultHim.Location = New System.Drawing.Point(442, 260)
        Me.btnInsultHim.Name = "btnInsultHim"
        Me.btnInsultHim.Size = New System.Drawing.Size(91, 35)
        Me.btnInsultHim.TabIndex = 5
        Me.btnInsultHim.Text = "Remind him he's ugly"
        Me.btnInsultHim.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(536, 317)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "What do you do? "
        '
        'timeLeft
        '
        Me.timeLeft.Enabled = True
        Me.timeLeft.Interval = 5000
        '
        'lblTime
        '
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(419, 390)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(162, 23)
        Me.lblTime.TabIndex = 7
        '
        'btnAcceptYourFate
        '
        Me.btnAcceptYourFate.Location = New System.Drawing.Point(579, 217)
        Me.btnAcceptYourFate.Name = "btnAcceptYourFate"
        Me.btnAcceptYourFate.Size = New System.Drawing.Size(91, 35)
        Me.btnAcceptYourFate.TabIndex = 8
        Me.btnAcceptYourFate.Text = "Accept your fate"
        Me.btnAcceptYourFate.UseVisualStyleBackColor = True
        '
        'lairOfDench
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(884, 473)
        Me.Controls.Add(Me.btnAcceptYourFate)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnInsultHim)
        Me.Controls.Add(Me.btnRunPast)
        Me.Controls.Add(Me.btnFight)
        Me.Controls.Add(Me.btnWarCry)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "lairOfDench"
        Me.Text = "lairOfDench"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnWarCry As System.Windows.Forms.Button
    Friend WithEvents btnFight As System.Windows.Forms.Button
    Friend WithEvents btnRunPast As System.Windows.Forms.Button
    Friend WithEvents btnInsultHim As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents timeLeft As System.Windows.Forms.Timer
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents btnAcceptYourFate As System.Windows.Forms.Button
End Class
