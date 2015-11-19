Public Class DayCalc
    Dim gFormShown As Boolean = False
    Private Sub DayCalc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

     
            Dim vStartDate As String = DateTime.Now().Year.ToString + "-" + DateTime.Now().Month.ToString + "-" + DateTime.Now().Day.ToString + " 08:00" '+ DateTime.Now().Hour.ToString + ":" + DateTime.Now().Minute.ToString

            Dim dt = DateTime.Parse(vStartDate) ', "yyyy-MM-dd hh:mm", Nothing)

            StartTime.Value = dt
            EndTime.Value = DateAdd(DateInterval.Hour, 8, dt)
        Catch ex As Exception
            ' MessageBox.Show("Error in 
        End Try

    End Sub


    Private Sub CalculateMhrs()
        If gFormShown = False Then Exit Sub
        Dim vManhours As Decimal = 0.0
        Dim vTempEndDate As DateTime = EndTime.Value
        Try
            If LunchChk.Checked = True Then
                Dim vSubtractMinutes As Decimal = CType(LunchMinutesTxt.Text, Decimal) * -1
                vTempEndDate = DateAdd(DateInterval.Minute, vSubtractMinutes, vTempEndDate)
            End If
            If OtherChk.Checked = True Then
                vTempEndDate = DateAdd(DateInterval.Minute, CType(OtherMinutesTxt.Text, Decimal) * -1, vTempEndDate)
            End If
            vManhours = DateDiff(DateInterval.Minute, StartTime.Value, vTempEndDate)
            TxtMhrsOut.Text = Math.Round((vManhours / 60), 2).ToString
        Catch ex As Exception
            MessageBox.Show("Something wrong with the lunch/other minutes, maybe not decimals?")
        End Try

    End Sub
    Private Sub StartTime_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartTime.ValueChanged, EndTime.ValueChanged
        CalculateMhrs()
    End Sub

    
    Private Sub LunchChk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LunchChk.CheckedChanged, OtherChk.CheckedChanged
        CalculateMhrs()
    End Sub

    Private Sub OtherMinutesTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtherMinutesTxt.TextChanged, LunchMinutesTxt.TextChanged
        CalculateMhrs()
    End Sub

 
    Private Sub BtnSetTimeNow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSetTimeNow.Click
        EndTime.Value = DateTime.Now()
    End Sub

    Private Sub DayCalc_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        gFormShown = True
    End Sub
End Class
