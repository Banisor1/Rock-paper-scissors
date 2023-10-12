Public Class Form1
    Dim score As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim randomNum As New Random()
        Dim computerChoice As Integer = randomNum.Next(1, 4)

        Select Case computerChoice
            Case 1 ' Foaie
                MessageBox.Show("Egalitate!")
            Case 2 ' Foarfecă
                MessageBox.Show("Ai câștigat!")
                score += 1
            Case 3 ' Ciocan
                MessageBox.Show("Ai pierdut!")
                score -= 1
        End Select

        Label2.Text = "Scor: " & score
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim randomNum As New Random()
        Dim computerChoice As Integer = randomNum.Next(1, 4)

        Select Case computerChoice
            Case 1 ' Foaie
                MessageBox.Show("Ai pierdut!")
                score -= 1
            Case 2 ' Foarfecă
                MessageBox.Show("Egalitate!")
            Case 3 ' Ciocan
                MessageBox.Show("Ai câștigat!")
                score += 1
        End Select

        Label2.Text = "Scor: " & score
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim randomNum As New Random()
        Dim computerChoice As Integer = randomNum.Next(1, 4)

        Select Case computerChoice
            Case 1 ' Foaie
                MessageBox.Show("Ai câștigat!")
                score = score + 1
            Case 2 ' Foarfecă
                MessageBox.Show("Ai pierdut!")
                score -= 1
            Case 3 ' Ciocan
                MessageBox.Show("Egalitate!")
        End Select

        Label2.Text = "Scor: " & score
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        score = 0
        Label2.Text = "Scor: " & score
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class