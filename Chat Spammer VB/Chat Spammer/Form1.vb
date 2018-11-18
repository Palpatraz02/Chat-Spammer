Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 2
        If ProgressBar1.Value = 100 Then
            ProgressBar1.Value = 0
            Timer1.Stop()
            Form2.Show()
            Timer2.Start()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProgressBar1.Visible = True
        Button1.Visible = False

        My.Settings.num1 = 0
        My.Settings.num = 1
        If TextBox3.Text = "" Then
            MsgBox("Testo vuoto", MsgBoxStyle.Exclamation)
        Else
            Try
                My.Settings.num = NumericUpDown2.Value
            Catch
                MsgBox("Problema con il numero di messaggi", MsgBoxStyle.Critical)
            End Try

            Try
                Timer2.Interval = NumericUpDown1.Value
            Catch
                MsgBox("Problema con l'intervallo", MsgBoxStyle.Critical)
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
            Form2.Close()
            Button1.Visible = True
        Else
            SendKeys.Send(TextBox3.Text)
            SendKeys.Send("{ENTER}")
            My.Settings.num1 = My.Settings.num1 + 1
            ProgressBar1.Visible = False
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.num1 = 0
        My.Settings.num = 1
        My.Settings.start = True
        Timer2.Interval = 100
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        If NumericUpDown1.Value <= 0 Then
            MsgBox("Valore non valido", MsgBoxStyle.Exclamation)
            NumericUpDown1.Value = 100
        End If
    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        If NumericUpDown2.Value <= 0 Then
            MsgBox("Valore non valido", MsgBoxStyle.Exclamation)
            NumericUpDown2.Value = 100
        End If
    End Sub
End Class
