<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class memes
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
        Me.btnDonald = New System.Windows.Forms.Button()
        Me.btnKid = New System.Windows.Forms.Button()
        Me.btnDwight = New System.Windows.Forms.Button()
        Me.btnDoge = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDonald
        '
        Me.btnDonald.BackgroundImage = Global.finalProject.My.Resources.Resources.veemothememo
        Me.btnDonald.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDonald.Location = New System.Drawing.Point(2, 250)
        Me.btnDonald.Name = "btnDonald"
        Me.btnDonald.Size = New System.Drawing.Size(382, 370)
        Me.btnDonald.TabIndex = 3
        Me.btnDonald.UseVisualStyleBackColor = True
        '
        'btnKid
        '
        Me.btnKid.BackgroundImage = Global.finalProject.My.Resources.Resources.crazykid
        Me.btnKid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnKid.Location = New System.Drawing.Point(390, -1)
        Me.btnKid.Name = "btnKid"
        Me.btnKid.Size = New System.Drawing.Size(311, 245)
        Me.btnKid.TabIndex = 2
        Me.btnKid.UseVisualStyleBackColor = True
        '
        'btnDwight
        '
        Me.btnDwight.BackgroundImage = Global.finalProject.My.Resources.Resources.Dwitanic
        Me.btnDwight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDwight.Location = New System.Drawing.Point(390, 250)
        Me.btnDwight.Name = "btnDwight"
        Me.btnDwight.Size = New System.Drawing.Size(470, 370)
        Me.btnDwight.TabIndex = 1
        Me.btnDwight.UseVisualStyleBackColor = True
        '
        'btnDoge
        '
        Me.btnDoge.BackgroundImage = Global.finalProject.My.Resources.Resources.dogeMeme
        Me.btnDoge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDoge.Location = New System.Drawing.Point(2, -15)
        Me.btnDoge.Name = "btnDoge"
        Me.btnDoge.Size = New System.Drawing.Size(382, 259)
        Me.btnDoge.TabIndex = 0
        Me.btnDoge.UseVisualStyleBackColor = True
        '
        'memes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 632)
        Me.Controls.Add(Me.btnDonald)
        Me.Controls.Add(Me.btnKid)
        Me.Controls.Add(Me.btnDwight)
        Me.Controls.Add(Me.btnDoge)
        Me.Name = "memes"
        Me.Text = "memes"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDoge As System.Windows.Forms.Button
    Friend WithEvents btnDwight As System.Windows.Forms.Button
    Friend WithEvents btnKid As System.Windows.Forms.Button
    Friend WithEvents btnDonald As System.Windows.Forms.Button
End Class
