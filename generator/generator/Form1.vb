Public Class Form1
    Function Rand(ByVal Low As Long, ByVal High As Long) As Long
        Rand = Int((High - Low + 1) * Rnd()) + Low
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Const GEN = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890!@#$%^&*()"
        Dim intCounter As Integer
        Dim strKey As String
        Dim intIndex As Integer
        strKey = ""
        Randomize()

        Dim sltin As Integer
        sltin = wordbox1.Text

        For intCounter = 1 To sltin
            intIndex = Rand(1, Len(GEN))
            strKey = strKey & Mid$(GEN, intIndex, 1)
        Next
        result.Text = strKey

    End Sub

End Class
