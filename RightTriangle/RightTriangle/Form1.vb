Option Strict On
Public Class Form1


    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click

      

        Dim a As Double = CDbl(txtSideOne.Text)
        Dim b As Double = CDbl(txtSideTwo.Text)
        Dim c As Double

        c = Hypotenuse(a, b)


        txtHyp.Text = CStr(c)


    End Sub

    Function Hypotenuse(ByVal a As Double, ByVal b As Double) As Double
        Dim c As Double

        c = Math.Sqrt(a ^ 2 + b ^ 2)

        Return c
        'All of this can be converted into Return Math.Sqrt(a ^ 2 + b ^ 2)


    End Function
End Class
