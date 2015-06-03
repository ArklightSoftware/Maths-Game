Public Class frmMenu

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'Takes user to the addition form.
        Me.Hide()
        frmAdd.Show()
    End Sub

    Private Sub btnSub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSub.Click
        'Takes user to the subtraction form.
        Me.Hide()
        frmSub.Show()
    End Sub

    Private Sub btnMulti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMulti.Click
        'Takes user to the multiplication form.
        Me.Hide()
        frmMulti.Show()
    End Sub

    Private Sub btnDiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiv.Click
        'Takes user to the division form.
        Me.Hide()
        frmdiv.show()
    End Sub

    Private Sub btnQuit_Click(sender As System.Object, e As System.EventArgs) Handles btnQuit.Click
        'Ends the program.
        End
    End Sub

    Private Sub btnHelp_Click(sender As System.Object, e As System.EventArgs) Handles btnHelp.Click
        'Takes user to the user help form.
        Me.Hide()
        frmHelp.Show()
    End Sub

    Private Sub btnOptions_Click(sender As System.Object, e As System.EventArgs) Handles btnOptions.Click
        'Takes user to the options menu form.
        Me.Hide()
        frmOptions.Show()
    End Sub
End Class
