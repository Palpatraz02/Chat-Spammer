Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 2
        If ProgressBar1.Value = 100 Then
            ProgressBar1.Value = 0
            Timer1.Stop()
            Timer2.Start()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.num1 = 0
        My.Settings.num = 1
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Compilare tutti i campi", MsgBoxStyle.Exclamation)
        Else
            Try
                My.Settings.num = TextBox1.Text
            Catch
                MsgBox("Carattere inserito non valido", MsgBoxStyle.Exclamation)
                My.Settings.start = False
            End Try
            Try
                Timer2.Interval = TextBox2.Text
            Catch
                MsgBox("Carattere inserito non valido", MsgBoxStyle.Exclamation)
                My.Settings.start = False
            End Try
            If My.Settings.start = True Then
                MsgBox("Hai 5 secondi per selezionare la chat dove scrivere", MsgBoxStyle.Exclamation)
                My.Settings.start = True
                Timer1.Start()
            Else
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If My.Settings.num1 = My.Settings.num Then
            Timer2.Stop()
        Else
            SendKeys.Send(TextBox3.Text)
            SendKeys.Send("{ENTER}")
            My.Settings.num1 = My.Settings.num1 + 1
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.num1 = 0
        My.Settings.num = 1
        My.Settings.start = True
        Timer2.Interval = 100
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Versione: 0.2", MsgBoxStyle.Information)
    End Sub
End Class
