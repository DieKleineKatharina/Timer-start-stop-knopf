Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        button1.Text = "Timer starten"
        Text = "Starten Sie den Timer"
    End Sub
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click

        Timer1.Enabled = Not Timer1.Enabled

        If Timer1.Enabled = False Then
            'button1.Text = "Timer starten"
            button1.Text = "Timer starten"
            Text = "Starten Sie den Timer"

        Else

            button1.Text = "Timer stoppen"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Text = Date.Now.ToString()
    End Sub


End Class
