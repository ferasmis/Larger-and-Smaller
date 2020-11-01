Public Class Form1
    Private Sub btnCompare_Click(sender As Object, e As EventArgs) Handles btnCompare.Click
        'declare variables
        Dim dblNumberA As Double = CDbl(txtA.Text)
        Dim dblNumebrB As Double

        'clearing label
        lblMessage.Text = ""


        'validating number A
        If IsNumeric(dblNumberA) Then
            If dblNumberA > dblNumebrB Then
                'display message a is greater
                lblMessage.Text = "Value A is greatest"

            ElseIf dblNumberA < -100 And dblNumberA > 100 Then
                lblMessage.Text = "Number A needs to be in the range of -100.00 to 100.00"
            End If
            If txtA.Text = String.Empty Then
                lblMessage.Text = "Please enter a numeric value"
            End If

        End If
        'validating number B

        If Double.TryParse(txtB.Text, dblNumebrB) Then
            If dblNumebrB > dblNumberA Then
                'display message B is greater
                lblMessage.Text = "Value b is greatest"
            End If
            If dblNumebrB < -100 And dblNumebrB > 100 Then
                lblMessage.Text = "Number B needs to be in the range of -100.00 to 100.00"
            End If

            If txtB.Text = String.Empty Then
                lblMessage.Text = "Please enter a numeric value"
            End If



        End If

        'validating both A and B
        If dblNumberA = dblNumebrB Then
                lblMessage.Text = "Both values are equal"

            End If




            'converting to a string
            dblNumberA.ToString("n")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clearing labels and textboxes
        lblMessage.Text = ""
        txtA.Text = String.Empty
        txtB.Clear()

        'set focus to 1st text control
        txtA.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'close the application
        Me.Close()
    End Sub
End Class