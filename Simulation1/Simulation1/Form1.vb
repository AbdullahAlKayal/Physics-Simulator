Public Class frmMain
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click 'declare the scope of the coding of Button1'
        Simulation1.Show() 'shows the window Simulation1'
        Hide() 'hides this window, i.e. frmMain'

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click 'declare the scope of the coding of Button2'
        Simulation2.Show() 'shows the window Simulation2'
        Hide() 'hides this window, i.e. frmMain'
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click 'declare the scope of the coding of Button3'
        Simulation3.Show() 'shows the window Simulation3'
        Hide() 'hides this window, i.e. frmMain'
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click 'declare the scope of the coding of Button4'
        Simulation4.Show() 'shows the window Simulation4'
        Hide() 'hides this window, i.e. frmMain'
    End Sub

End Class