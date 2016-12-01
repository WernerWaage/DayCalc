<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DayCalc
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
        Me.DescriptionLbl = New System.Windows.Forms.Label
        Me.StartTime = New System.Windows.Forms.DateTimePicker
        Me.StartLbl = New System.Windows.Forms.Label
        Me.EndLbl = New System.Windows.Forms.Label
        Me.EndTime = New System.Windows.Forms.DateTimePicker
        Me.LunchChk = New System.Windows.Forms.CheckBox
        Me.OtherChk = New System.Windows.Forms.CheckBox
        Me.LunchMinutesTxt = New System.Windows.Forms.TextBox
        Me.OtherMinutesTxt = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.BtnSetTimeNow = New System.Windows.Forms.Button
        Me.TxtMhrsOut = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'DescriptionLbl
        '
        Me.DescriptionLbl.AutoSize = True
        Me.DescriptionLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionLbl.Location = New System.Drawing.Point(45, 15)
        Me.DescriptionLbl.Name = "DescriptionLbl"
        Me.DescriptionLbl.Size = New System.Drawing.Size(124, 16)
        Me.DescriptionLbl.TabIndex = 0
        Me.DescriptionLbl.Text = "Manhours Today"
        '
        'StartTime
        '
        Me.StartTime.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartTime.CustomFormat = "dd.MMM - HH:mm"
        Me.StartTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.StartTime.Location = New System.Drawing.Point(98, 43)
        Me.StartTime.Name = "StartTime"
        Me.StartTime.ShowUpDown = True
        Me.StartTime.Size = New System.Drawing.Size(122, 22)
        Me.StartTime.TabIndex = 2
        '
        'StartLbl
        '
        Me.StartLbl.AutoSize = True
        Me.StartLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartLbl.Location = New System.Drawing.Point(56, 46)
        Me.StartLbl.Name = "StartLbl"
        Me.StartLbl.Size = New System.Drawing.Size(35, 16)
        Me.StartLbl.TabIndex = 3
        Me.StartLbl.Text = "Start"
        '
        'EndLbl
        '
        Me.EndLbl.AutoSize = True
        Me.EndLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndLbl.Location = New System.Drawing.Point(59, 122)
        Me.EndLbl.Name = "EndLbl"
        Me.EndLbl.Size = New System.Drawing.Size(32, 16)
        Me.EndLbl.TabIndex = 5
        Me.EndLbl.Text = "End"
        '
        'EndTime
        '
        Me.EndTime.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndTime.CustomFormat = "dd.MMM - HH:mm"
        Me.EndTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EndTime.Location = New System.Drawing.Point(98, 117)
        Me.EndTime.Name = "EndTime"
        Me.EndTime.ShowUpDown = True
        Me.EndTime.Size = New System.Drawing.Size(122, 22)
        Me.EndTime.TabIndex = 4
        '
        'LunchChk
        '
        Me.LunchChk.AutoSize = True
        Me.LunchChk.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LunchChk.Checked = True
        Me.LunchChk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.LunchChk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LunchChk.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.LunchChk.Location = New System.Drawing.Point(15, 68)
        Me.LunchChk.Name = "LunchChk"
        Me.LunchChk.Size = New System.Drawing.Size(97, 20)
        Me.LunchChk.TabIndex = 6
        Me.LunchChk.Text = "Lunchbreak"
        Me.LunchChk.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.LunchChk.UseVisualStyleBackColor = True
        '
        'OtherChk
        '
        Me.OtherChk.AutoSize = True
        Me.OtherChk.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OtherChk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OtherChk.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.OtherChk.Location = New System.Drawing.Point(14, 94)
        Me.OtherChk.Name = "OtherChk"
        Me.OtherChk.Size = New System.Drawing.Size(98, 20)
        Me.OtherChk.TabIndex = 7
        Me.OtherChk.Text = "Other Break"
        Me.OtherChk.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.OtherChk.UseVisualStyleBackColor = True
        '
        'LunchMinutesTxt
        '
        Me.LunchMinutesTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LunchMinutesTxt.Location = New System.Drawing.Point(118, 68)
        Me.LunchMinutesTxt.Name = "LunchMinutesTxt"
        Me.LunchMinutesTxt.Size = New System.Drawing.Size(41, 22)
        Me.LunchMinutesTxt.TabIndex = 8
        Me.LunchMinutesTxt.Text = "30"
        Me.LunchMinutesTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'OtherMinutesTxt
        '
        Me.OtherMinutesTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OtherMinutesTxt.Location = New System.Drawing.Point(118, 92)
        Me.OtherMinutesTxt.Name = "OtherMinutesTxt"
        Me.OtherMinutesTxt.Size = New System.Drawing.Size(41, 22)
        Me.OtherMinutesTxt.TabIndex = 9
        Me.OtherMinutesTxt.Text = "0"
        Me.OtherMinutesTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(165, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Min"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(165, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Min"
        '
        'BtnSetTimeNow
        '
        Me.BtnSetTimeNow.Location = New System.Drawing.Point(17, 118)
        Me.BtnSetTimeNow.Name = "BtnSetTimeNow"
        Me.BtnSetTimeNow.Size = New System.Drawing.Size(38, 23)
        Me.BtnSetTimeNow.TabIndex = 12
        Me.BtnSetTimeNow.Text = "Now"
        Me.BtnSetTimeNow.UseVisualStyleBackColor = True
        '
        'TxtMhrsOut
        '
        Me.TxtMhrsOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMhrsOut.Location = New System.Drawing.Point(175, 12)
        Me.TxtMhrsOut.Name = "TxtMhrsOut"
        Me.TxtMhrsOut.Size = New System.Drawing.Size(45, 21)
        Me.TxtMhrsOut.TabIndex = 13
        '
        'DayCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(243, 161)
        Me.Controls.Add(Me.TxtMhrsOut)
        Me.Controls.Add(Me.BtnSetTimeNow)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.OtherMinutesTxt)
        Me.Controls.Add(Me.LunchMinutesTxt)
        Me.Controls.Add(Me.OtherChk)
        Me.Controls.Add(Me.LunchChk)
        Me.Controls.Add(Me.EndLbl)
        Me.Controls.Add(Me.EndTime)
        Me.Controls.Add(Me.StartLbl)
        Me.Controls.Add(Me.StartTime)
        Me.Controls.Add(Me.DescriptionLbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "DayCalc"
        Me.Opacity = 0.8
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "DayCalc"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DescriptionLbl As System.Windows.Forms.Label
    Friend WithEvents StartTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents StartLbl As System.Windows.Forms.Label
    Friend WithEvents EndLbl As System.Windows.Forms.Label
    Friend WithEvents EndTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents LunchChk As System.Windows.Forms.CheckBox
    Friend WithEvents OtherChk As System.Windows.Forms.CheckBox
    Friend WithEvents LunchMinutesTxt As System.Windows.Forms.TextBox
    Friend WithEvents OtherMinutesTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnSetTimeNow As System.Windows.Forms.Button
    Friend WithEvents TxtMhrsOut As System.Windows.Forms.TextBox

End Class
