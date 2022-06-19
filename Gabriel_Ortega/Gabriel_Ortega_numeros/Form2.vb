Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conferir(Button1, Button2)
        conferir(Button1, Button5)
        verificar1()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        conferir(Button2, Button1)
        conferir(Button2, Button3)
        conferir(Button2, Button6)
        verificar1()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        conferir(Button3, Button2)
        conferir(Button3, Button4)
        conferir(Button3, Button7)
        verificar1()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        conferir(Button4, Button3)
        conferir(Button4, Button8)
        verificar1()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        conferir(Button5, Button1)
        conferir(Button5, Button6)
        conferir(Button5, Button9)
        verificar1()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        conferir(Button6, Button2)
        conferir(Button6, Button5)
        conferir(Button6, Button7)
        conferir(Button6, Button10)
        verificar1()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        conferir(Button7, Button3)
        conferir(Button7, Button6)
        conferir(Button7, Button8)
        conferir(Button7, Button11)
        verificar1()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        conferir(Button8, Button4)
        conferir(Button8, Button7)
        conferir(Button8, Button12)
        verificar1()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        conferir(Button9, Button5)
        conferir(Button9, Button10)
        conferir(Button9, Button13)
        verificar1()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        conferir(Button10, Button6)
        conferir(Button10, Button9)
        conferir(Button10, Button11)
        conferir(Button10, Button14)
        verificar1()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        conferir(Button11, Button7)
        conferir(Button11, Button10)
        conferir(Button11, Button12)
        conferir(Button11, Button15)
        verificar1()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        conferir(Button12, Button8)
        conferir(Button12, Button11)
        conferir(Button12, Button16)
        verificar1()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        conferir(Button13, Button14)
        conferir(Button13, Button9)
        verificar1()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        conferir(Button14, Button10)
        conferir(Button14, Button13)
        conferir(Button14, Button15)
        verificar1()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        conferir(Button15, Button11)
        conferir(Button15, Button14)
        conferir(Button15, Button16)
        verificar1()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        conferir(Button16, Button12)
        conferir(Button16, Button15)
        verificar1()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        

        segundo.Text -= 1 'segundos'


        If segundo.Text = 0 Then
            minuto.Text -= 1
            segundo.Text = 60



        End If



        If minuto.Text = 0 Then
            Timer1.Stop()
            msgperdeu2 = MsgBox("Você perdeu!! Deseja continuar?", vbYesNo, vbExclamation)
            cliquess = 0
            misturar()
            verificar1()
            segundo.Text = 60
            minuto.Text = 5
            perdidas2 = perdidas2 + 1
            PerdidasToolStripMenuItem.Text = "Perdidas: " & perdidas2

            
        End If

        If msgperdeu2 = vbYes Then
            Timer1.Stop()
            Timer1.Start()
            




        ElseIf msgperdeu2 = vbNo Then
            Me.Close()
        End If

    End Sub

    Private Sub MisturarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MisturarToolStripMenuItem.Click
        misturar()
        verificar1()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        misturar()
        verificar1()
        Timer1.Enabled = True
        cliquess = 0
        ClicksToolStripMenuItem.Text = "Clicks: " & cliquess
        perdidas2 = 0
        PerdidasToolStripMenuItem.Text = "Perdidas: " & perdidas2
        Ganhas2 = 0
        GanhasToolStripMenuItem.Text = "Ganhas: " & Ganhas2
        segundo.Text = 60
        minuto.Text = 5


    End Sub



    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        End
    End Sub

    Private Sub VoltarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VoltarToolStripMenuItem.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class