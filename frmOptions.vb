Public Class frmOptions
    Private Sub frmOptions_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        'Uses the combobox to see what the user has selected from the drop down menu, and then changes the background colour of all forms to the selected colour.
        If cmboBack.Text = "Defualt" Then 'Changes background of all forms to the VB defualt 'Control' colour.
            frmAdd.BackColor = SystemColors.Control
            frmDiv.BackColor = SystemColors.Control
            frmHelp.BackColor = SystemColors.Control
            frmMenu.BackColor = SystemColors.Control
            frmMulti.BackColor = SystemColors.Control
            Me.BackColor = SystemColors.Control
            frmSub.BackColor = SystemColors.Control

        ElseIf cmboBack.Text = "Blue" Then 'Changes the colour of all forms to the colour blue.
            frmAdd.BackColor = Color.Blue
            frmDiv.BackColor = Color.Blue
            frmHelp.BackColor = Color.Blue
            frmMenu.BackColor = Color.Blue
            frmMulti.BackColor = Color.Blue
            Me.BackColor = Color.Blue
            frmSub.BackColor = Color.Blue

        ElseIf cmboBack.Text = "Green" Then 'Changes the colour of all forms to the colour green.
            frmAdd.BackColor = Color.Green
            frmDiv.BackColor = Color.Green
            frmHelp.BackColor = Color.Green
            frmMenu.BackColor = Color.Green
            frmMulti.BackColor = Color.Green
            Me.BackColor = Color.Green
            frmSub.BackColor = Color.Green

        ElseIf cmboBack.Text = "Red" Then 'Changes the colour of all forms to the colour red.
            frmAdd.BackColor = Color.Red
            frmDiv.BackColor = Color.Red
            frmHelp.BackColor = Color.Red
            frmMenu.BackColor = Color.Red
            frmMulti.BackColor = Color.Red
            Me.BackColor = Color.Red
            frmSub.BackColor = Color.Red

        ElseIf cmboBack.Text = "Purple" Then 'Changes the colour of all forms to the colour purple.
            frmAdd.BackColor = Color.Purple
            frmDiv.BackColor = Color.Purple
            frmHelp.BackColor = Color.Purple
            frmMenu.BackColor = Color.Purple
            frmMulti.BackColor = Color.Purple
            Me.BackColor = Color.Purple
            frmSub.BackColor = Color.Purple

        ElseIf cmboBack.Text = "Black" Then 'Changes the colour of all forms to the colour black.
            frmAdd.BackColor = Color.Black
            frmDiv.BackColor = Color.Black
            frmHelp.BackColor = Color.Black
            frmMenu.BackColor = Color.Black
            frmMulti.BackColor = Color.Black
            Me.BackColor = Color.Black
            frmSub.BackColor = Color.Black

        ElseIf cmboBack.Text = "Orange" Then 'Changes the colour of all forms to the colour orange.
            frmAdd.BackColor = Color.Orange
            frmDiv.BackColor = Color.Orange
            frmHelp.BackColor = Color.Orange
            frmMenu.BackColor = Color.Orange
            frmMulti.BackColor = Color.Orange
            Me.BackColor = Color.Orange
            frmSub.BackColor = Color.Orange

        ElseIf cmboBack.Text = "Yellow" Then 'Changes the colour of all forms to the colour yellow.
            frmAdd.BackColor = Color.Yellow
            frmDiv.BackColor = Color.Yellow
            frmHelp.BackColor = Color.Yellow
            frmMenu.BackColor = Color.Yellow
            frmMulti.BackColor = Color.Yellow
            Me.BackColor = Color.Yellow
            frmSub.BackColor = Color.Yellow

        ElseIf cmboBack.Text = "Pink" Then 'Changes the colour of all forms to the colour pink.
            frmAdd.BackColor = Color.Pink
            frmDiv.BackColor = Color.Pink
            frmHelp.BackColor = Color.Pink
            frmMenu.BackColor = Color.Pink
            frmMulti.BackColor = Color.Pink
            Me.BackColor = Color.Pink
            frmSub.BackColor = Color.Pink

        ElseIf cmboBack.Text = "White" Then 'Changes the colour of all forms to the colour white.
            frmAdd.BackColor = Color.White
            frmDiv.BackColor = Color.White
            frmHelp.BackColor = Color.White
            frmMenu.BackColor = Color.White
            frmMulti.BackColor = Color.White
            Me.BackColor = Color.White
            frmSub.BackColor = Color.White

        End If
    End Sub

    Private Sub btnText_Click(sender As System.Object, e As System.EventArgs) Handles btnText.Click
        'Uses the combobox to see what the user has selected from the drop down menu, and then changes the text colour of all forms to the selected colour.
        If cmboText.Text = "Blue" Then 'Changes the text of all forms to the colour blue.
            Me.ForeColor = Color.Blue
            frmAdd.ForeColor = Color.Blue
            frmDiv.ForeColor = Color.Blue
            frmMenu.ForeColor = Color.Blue
            frmMulti.ForeColor = Color.Blue
            frmSub.ForeColor = Color.Blue

        ElseIf cmboText.Text = "Green" Then 'Changes the text of all forms to the colour green.
            Me.ForeColor = Color.Green
            frmAdd.ForeColor = Color.Green
            frmDiv.ForeColor = Color.Green
            frmMenu.ForeColor = Color.Green
            frmMulti.ForeColor = Color.Green
            frmSub.ForeColor = Color.Green

        ElseIf cmboText.Text = "Red" Then 'Changes the text of all forms to the colour red.
            Me.ForeColor = Color.Red
            frmAdd.ForeColor = Color.Red
            frmDiv.ForeColor = Color.Red
            frmMenu.ForeColor = Color.Red
            frmMulti.ForeColor = Color.Red
            frmSub.ForeColor = Color.Red

        ElseIf cmboText.Text = "Purple" Then 'Changes the text of all forms to the colour purple.
            Me.ForeColor = Color.Purple
            frmAdd.ForeColor = Color.Purple
            frmDiv.ForeColor = Color.Purple
            frmMenu.ForeColor = Color.Purple
            frmMulti.ForeColor = Color.Purple
            frmSub.ForeColor = Color.Purple

        ElseIf cmboText.Text = "Black" Then 'Changes the text of all forms to the colour black.
            Me.ForeColor = Color.Black
            frmAdd.ForeColor = Color.Black
            frmDiv.ForeColor = Color.Black
            frmMenu.ForeColor = Color.Black
            frmMulti.ForeColor = Color.Black
            frmSub.ForeColor = Color.Black

        ElseIf cmboText.Text = "Orange" Then 'Changes the text of all forms to the colour orange.
            Me.ForeColor = Color.Orange
            frmAdd.ForeColor = Color.Orange
            frmDiv.ForeColor = Color.Orange
            frmMenu.ForeColor = Color.Orange
            frmMulti.ForeColor = Color.Orange
            frmSub.ForeColor = Color.Orange

        ElseIf cmboText.Text = "Yellow" Then 'Changes the text of all forms to the colour yellow.
            Me.ForeColor = Color.Yellow
            frmAdd.ForeColor = Color.Yellow
            frmDiv.ForeColor = Color.Yellow
            frmMenu.ForeColor = Color.Yellow
            frmMulti.ForeColor = Color.Yellow
            frmSub.ForeColor = Color.Yellow

        ElseIf cmboText.Text = "Pink" Then 'Changes the text of all forms to the colour pink.
            Me.ForeColor = Color.Pink
            frmAdd.ForeColor = Color.Pink
            frmDiv.ForeColor = Color.Pink
            frmMenu.ForeColor = Color.Pink
            frmMulti.ForeColor = Color.Pink
            frmSub.ForeColor = Color.Pink

        ElseIf cmboText.Text = "White" Then 'Changes the text of all forms to the colour white.
            Me.ForeColor = Color.White
            frmAdd.ForeColor = Color.White
            frmDiv.ForeColor = Color.White
            frmMenu.ForeColor = Color.White
            frmMulti.ForeColor = Color.White
            frmSub.ForeColor = Color.White
        End If
    End Sub

    Private Sub btnGoBack_Click(sender As System.Object, e As System.EventArgs) Handles btnGoBack.Click
        Me.Hide() 'hides current form
        frmMenu.Show() 'shows the main menu form
    End Sub

    Private Sub btnBtn_Click(sender As System.Object, e As System.EventArgs) Handles btnBtn.Click
        If cmboBtn.Text = "Defualt" Then 'Changes the background colour of all the buttons on the program to the vb defualt control colour.
            frmMenu.btnAdd.BackColor = SystemColors.Control
            frmMenu.btnDiv.BackColor = SystemColors.Control
            frmMenu.btnHelp.BackColor = SystemColors.Control
            frmMenu.btnMulti.BackColor = SystemColors.Control
            frmMenu.btnOptions.BackColor = SystemColors.Control
            frmMenu.btnQuit.BackColor = SystemColors.Control
            frmMenu.btnSub.BackColor = SystemColors.Control

            frmAdd.btnCheck.BackColor = SystemColors.Control
            frmDiv.btnCheck.BackColor = SystemColors.Control
            frmMulti.btnCheck.BackColor = SystemColors.Control
            frmSub.btnCheck.BackColor = SystemColors.Control
            Me.btnGoBack.BackColor = SystemColors.Control
            frmHelp.btnBack.BackColor = SystemColors.Control
            Me.btnBack.BackColor = SystemColors.Control
            Me.btnBtn.BackColor = SystemColors.Control
            Me.btnText.BackColor = SystemColors.Control

        ElseIf cmboBtn.Text = "Blue" Then 'Changes the background colour of all the buttons on the program to blue.
            frmMenu.btnAdd.BackColor = Color.Blue
            frmMenu.btnDiv.BackColor = Color.Blue
            frmMenu.btnHelp.BackColor = Color.Blue
            frmMenu.btnMulti.BackColor = Color.Blue
            frmMenu.btnOptions.BackColor = Color.Blue
            frmMenu.btnQuit.BackColor = Color.Blue
            frmMenu.btnSub.BackColor = Color.Blue

            frmAdd.btnCheck.BackColor = Color.Blue
            frmDiv.btnCheck.BackColor = Color.Blue
            frmMulti.btnCheck.BackColor = Color.Blue
            frmSub.btnCheck.BackColor = Color.Blue
            Me.btnGoBack.BackColor = Color.Blue
            frmHelp.btnBack.BackColor = Color.Blue

            Me.btnBack.BackColor = Color.Blue
            Me.btnBtn.BackColor = Color.Blue
            Me.btnText.BackColor = Color.Blue

        ElseIf cmboBtn.Text = "Green" Then 'Changes the background colour of all the buttons on the program to green.
            frmMenu.btnAdd.BackColor = Color.Green
            frmMenu.btnDiv.BackColor = Color.Green
            frmMenu.btnHelp.BackColor = Color.Green
            frmMenu.btnMulti.BackColor = Color.Green
            frmMenu.btnOptions.BackColor = Color.Green
            frmMenu.btnQuit.BackColor = Color.Green
            frmMenu.btnSub.BackColor = Color.Green

            frmAdd.btnCheck.BackColor = Color.Green
            frmDiv.btnCheck.BackColor = Color.Green
            frmMulti.btnCheck.BackColor = Color.Green
            frmSub.btnCheck.BackColor = Color.Green
            Me.btnGoBack.BackColor = Color.Green
            frmHelp.btnBack.BackColor = Color.Green

            Me.btnBack.BackColor = Color.Green
            Me.btnBtn.BackColor = Color.Green
            Me.btnText.BackColor = Color.Green

        ElseIf cmboBtn.Text = "Red" Then 'Changes the background colour of all the buttons on the program to red.
            frmMenu.btnAdd.BackColor = Color.Red
            frmMenu.btnDiv.BackColor = Color.Red
            frmMenu.btnHelp.BackColor = Color.Red
            frmMenu.btnMulti.BackColor = Color.Red
            frmMenu.btnOptions.BackColor = Color.Red
            frmMenu.btnQuit.BackColor = Color.Red
            frmMenu.btnSub.BackColor = Color.Red

            frmAdd.btnCheck.BackColor = Color.Red
            frmDiv.btnCheck.BackColor = Color.Red
            frmMulti.btnCheck.BackColor = Color.Red
            frmSub.btnCheck.BackColor = Color.Red
            Me.btnGoBack.BackColor = Color.Red
            frmHelp.btnBack.BackColor = Color.Red

            Me.btnBack.BackColor = Color.Red
            Me.btnBtn.BackColor = Color.Red
            Me.btnText.BackColor = Color.Red

        ElseIf cmboBtn.Text = "Purple" Then 'Changes the background colour of all the buttons on the program to purple.
            frmMenu.btnAdd.BackColor = Color.Purple
            frmMenu.btnDiv.BackColor = Color.Purple
            frmMenu.btnHelp.BackColor = Color.Purple
            frmMenu.btnMulti.BackColor = Color.Purple
            frmMenu.btnOptions.BackColor = Color.Purple
            frmMenu.btnQuit.BackColor = Color.Purple
            frmMenu.btnSub.BackColor = Color.Purple

            frmAdd.btnCheck.BackColor = Color.Purple
            frmDiv.btnCheck.BackColor = Color.Purple
            frmMulti.btnCheck.BackColor = Color.Purple
            frmSub.btnCheck.BackColor = Color.Purple
            Me.btnGoBack.BackColor = Color.Purple
            frmHelp.btnBack.BackColor = Color.Purple

            Me.btnBack.BackColor = Color.Purple
            Me.btnBtn.BackColor = Color.Purple
            Me.btnText.BackColor = Color.Purple

        ElseIf cmboBtn.Text = "Black" Then 'Changes the background colour of all the buttons on the program to black.
            frmMenu.btnAdd.BackColor = Color.Black
            frmMenu.btnDiv.BackColor = Color.Black
            frmMenu.btnHelp.BackColor = Color.Black
            frmMenu.btnMulti.BackColor = Color.Black
            frmMenu.btnOptions.BackColor = Color.Black
            frmMenu.btnQuit.BackColor = Color.Black
            frmMenu.btnSub.BackColor = Color.Black

            frmAdd.btnCheck.BackColor = Color.Black
            frmDiv.btnCheck.BackColor = Color.Black
            frmMulti.btnCheck.BackColor = Color.Black
            frmSub.btnCheck.BackColor = Color.Black
            Me.btnGoBack.BackColor = Color.Black
            frmHelp.btnBack.BackColor = Color.Black

            Me.btnBack.BackColor = Color.Black
            Me.btnBtn.BackColor = Color.Black
            Me.btnText.BackColor = Color.Black

        ElseIf cmboBtn.Text = "Orange" Then 'Changes the background colour of all the buttons on the program to orange.
            frmMenu.btnAdd.BackColor = Color.Orange
            frmMenu.btnDiv.BackColor = Color.Orange
            frmMenu.btnHelp.BackColor = Color.Orange
            frmMenu.btnMulti.BackColor = Color.Orange
            frmMenu.btnOptions.BackColor = Color.Orange
            frmMenu.btnQuit.BackColor = Color.Orange
            frmMenu.btnSub.BackColor = Color.Orange

            frmAdd.btnCheck.BackColor = Color.Orange
            frmDiv.btnCheck.BackColor = Color.Orange
            frmMulti.btnCheck.BackColor = Color.Orange
            frmSub.btnCheck.BackColor = Color.Orange
            Me.btnGoBack.BackColor = Color.Orange
            frmHelp.btnBack.BackColor = Color.Orange

            Me.btnBack.BackColor = Color.Orange
            Me.btnBtn.BackColor = Color.Orange
            Me.btnText.BackColor = Color.Orange

        ElseIf cmboBtn.Text = "Yellow" Then 'Changes the background colour of all the buttons on the program to yellow.
            frmMenu.btnAdd.BackColor = Color.Yellow
            frmMenu.btnDiv.BackColor = Color.Yellow
            frmMenu.btnHelp.BackColor = Color.Yellow
            frmMenu.btnMulti.BackColor = Color.Yellow
            frmMenu.btnOptions.BackColor = Color.Yellow
            frmMenu.btnQuit.BackColor = Color.Yellow
            frmMenu.btnSub.BackColor = Color.Yellow

            frmAdd.btnCheck.BackColor = Color.Yellow
            frmDiv.btnCheck.BackColor = Color.Yellow
            frmMulti.btnCheck.BackColor = Color.Yellow
            frmSub.btnCheck.BackColor = Color.Yellow
            Me.btnGoBack.BackColor = Color.Yellow
            frmHelp.btnBack.BackColor = Color.Yellow

            Me.btnBack.BackColor = Color.Yellow
            Me.btnBtn.BackColor = Color.Yellow
            Me.btnText.BackColor = Color.Yellow

        ElseIf cmboBtn.Text = "Pink" Then 'Changes the background colour of all the buttons on the program to pink.
            frmMenu.btnAdd.BackColor = Color.Pink
            frmMenu.btnDiv.BackColor = Color.Pink
            frmMenu.btnHelp.BackColor = Color.Pink
            frmMenu.btnMulti.BackColor = Color.Pink
            frmMenu.btnOptions.BackColor = Color.Pink
            frmMenu.btnQuit.BackColor = Color.Pink
            frmMenu.btnSub.BackColor = Color.Pink

            frmAdd.btnCheck.BackColor = Color.Pink
            frmDiv.btnCheck.BackColor = Color.Pink
            frmMulti.btnCheck.BackColor = Color.Pink
            frmSub.btnCheck.BackColor = Color.Pink
            Me.btnGoBack.BackColor = Color.Pink
            frmHelp.btnBack.BackColor = Color.Pink

            Me.btnBack.BackColor = Color.Pink
            Me.btnBtn.BackColor = Color.Pink
            Me.btnText.BackColor = Color.Pink

        ElseIf cmboBtn.Text = "White" Then 'Changes the background colour of all the buttons on the program to white.
            frmMenu.btnAdd.BackColor = Color.White
            frmMenu.btnDiv.BackColor = Color.White
            frmMenu.btnHelp.BackColor = Color.White
            frmMenu.btnMulti.BackColor = Color.White
            frmMenu.btnOptions.BackColor = Color.White
            frmMenu.btnQuit.BackColor = Color.White
            frmMenu.btnSub.BackColor = Color.White

            frmAdd.btnCheck.BackColor = Color.White
            frmDiv.btnCheck.BackColor = Color.White
            frmMulti.btnCheck.BackColor = Color.White
            frmSub.btnCheck.BackColor = Color.White
            Me.btnGoBack.BackColor = Color.White
            frmHelp.btnBack.BackColor = Color.White

            Me.btnBack.BackColor = Color.White
            Me.btnBtn.BackColor = Color.White
            Me.btnText.BackColor = Color.White
        End If
    End Sub
End Class