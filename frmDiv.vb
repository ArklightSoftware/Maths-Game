Public Class frmDiv
    'Defining Global variables.
    Dim N1, N2, ans, correct, attempted As Integer
    Dim userAns As String

    Private Sub btnCheck_Click(sender As System.Object, e As System.EventArgs) Handles btnCheck.Click
        userAns = txtAns.Text

        'Fixes a somewhat critical bug, when a user clicked check with having nothing in the text box, the program crashed, this fixes that by making userAns = 2500.
        If IsNumeric(userAns) = False Then
            userAns = 2500
        End If

        'Checks to see if the users answer is the same as the correct answer, if it is then the user is congratulated, if it isnt then the correct answer is shown to the user.
        If ans = userAns Then
            My.Computer.Audio.Play(My.Resources.correct, AudioPlayMode.Background) 'Plays an approapriate sound when the user gets an answer correct.
            MsgBox("Correct!")
            correct += 1 'stores that the answer was correct.
        Else
            My.Computer.Audio.Play(My.Resources.fail, AudioPlayMode.Background) 'Plays an approapriate sound when the user gets an answer incorrect.
            MsgBox("No, the answer is: " & ans)
        End If

        attempted += 1 'Stores the number of attempts.

        'Shows the users score.
        lblInfo.Show()
        lblInfo.Text = "Attempted: " & attempted & " Correct: " & correct

        'Ensures that if the user has attempted 10 questions that they get a score and cannot do any more questions, since it takes them back to the menu form. 
        If attempted = 10 Then
            My.Computer.Audio.Play(My.Resources.victory, AudioPlayMode.Background) 'Plays a sound when the user has answered 10 questions. 
            MsgBox("Congratulations! you got " & correct & " Out of 10!")
            attempted = 0 'changes attempted back to 0 so if user opens multiplication form they can do the set of questions again with no issue.
            correct = 0 'changes correct back to 0 so if user opens multiplication form they can do the set of questions again with no issue.
            Me.Hide()
            frmMenu.Show()
            lblInfo.Hide() 'Hides the label after the form is closed. to ensure user doesnt see potential information stored from theit last session, since the form is never truly closed.
        End If
    End Sub

    Private Sub frmDiv_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        'Generates the second random number and the answer, and then makes the first random number by multiplying the answer and the second random number, which ensures that the number is divisible and a whole number.
        Randomize() 'makes the numbers truly random, since RND is only pseudo-random numbers.
        N2 = Int(Rnd() * 10) + 1
        ans = Int(Rnd() * 10) + 1
        N1 = N2 * ans

        'displays the 2 generated numbers to the user.
        lblN1.Text = N1
        lblN2.Text = N2

    End Sub

    Private Sub frmDiv_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class