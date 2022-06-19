Public Class Form3

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        '4, 10'
        conferir2(Button5, Button4)
        conferir2(Button5, Button10)
        verificar2()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '2, 6'
        conferir2(Button1, Button2)
        conferir2(Button1, Button6)
        verificar2()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '1, 3, 7'
        conferir2(Button2, Button1)
        conferir2(Button2, Button3)
        conferir2(Button2, Button7)
        verificar2()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '2, 4, 8'
        conferir2(Button3, Button2)
        conferir2(Button3, Button4)
        conferir2(Button3, Button8)
        verificar2()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        '3, 5, 9'
        conferir2(Button4, Button3)
        conferir2(Button4, Button5)
        conferir2(Button4, Button9)
        verificar2()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        '1, 7, 11'
        conferir2(Button6, Button1)
        conferir2(Button6, Button7)
        conferir2(Button6, Button11)
        verificar2()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        '2, 6, 8, 12'
        conferir2(Button7, Button2)
        conferir2(Button7, Button6)
        conferir2(Button7, Button8)
        conferir2(Button7, Button12)
        verificar2()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        '3, 7, 9, 13'
        conferir2(Button8, Button3)
        conferir2(Button8, Button7)
        conferir2(Button8, Button9)
        conferir2(Button8, Button13)
        verificar2()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        '4, 8, 10, 14'
        conferir2(Button9, Button4)
        conferir2(Button9, Button8)
        conferir2(Button9, Button10)
        conferir2(Button9, Button14)
        verificar2()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        '5, 9, 15'
        conferir2(Button10, Button5)
        conferir2(Button10, Button9)
        conferir2(Button10, Button15)
        verificar2()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        '6, 12, 16'
        conferir2(Button11, Button6)
        conferir2(Button11, Button12)
        conferir2(Button11, Button16)
        verificar2()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        '7, 11, 13, 17'
        conferir2(Button12, Button7)
        conferir2(Button12, Button11)
        conferir2(Button12, Button13)
        conferir2(Button12, Button17)
        verificar2()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        '8, 12, 14, 18'
        conferir2(Button13, Button8)
        conferir2(Button13, Button12)
        conferir2(Button13, Button14)
        conferir2(Button13, Button18)
        verificar2()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        '9, 13, 15, 19'
        conferir2(Button14, Button9)
        conferir2(Button14, Button13)
        conferir2(Button14, Button15)
        conferir2(Button14, Button19)
        verificar2()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        '10, 14, 20'
        conferir2(Button15, Button10)
        conferir2(Button15, Button20)
        conferir2(Button15, Button14)
        verificar2()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        '11, 17, 21'
        conferir2(Button16, Button11)
        conferir2(Button16, Button17)
        conferir2(Button16, Button21)
        verificar2()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        '12, 16, 18, 22'
        conferir2(Button17, Button12)
        conferir2(Button17, Button16)
        conferir2(Button17, Button18)
        conferir2(Button17, Button22)
        verificar2()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        '13, 17, 19, 23'
        conferir2(Button18, Button13)
        conferir2(Button18, Button17)
        conferir2(Button18, Button19)
        conferir2(Button18, Button23)
        verificar2()

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        '14, 18, 20, 24'
        conferir2(Button19, Button14)
        conferir2(Button19, Button18)
        conferir2(Button19, Button20)
        conferir2(Button19, Button24)
        verificar2()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        '15, 19, 25'
        conferir2(Button20, Button15)
        conferir2(Button20, Button19)
        conferir2(Button20, Button25)
        verificar2()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        '16, 22'
        conferir2(Button21, Button16)
        conferir2(Button21, Button22)
        verificar2()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        '17, 21, 23'
        conferir2(Button22, Button17)
        conferir2(Button22, Button21)
        conferir2(Button22, Button23)
        verificar2()
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        '18, 22, 24'
        conferir2(Button23, Button18)
        conferir2(Button23, Button22)
        conferir2(Button23, Button24)
        verificar2()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        '19, 23, 25'
        conferir2(Button24, Button19)
        conferir2(Button24, Button23)
        conferir2(Button24, Button25)
        verificar2()
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        '20, 24'
        conferir2(Button25, Button20)
        conferir2(Button25, Button24)
        verificar2()
    End Sub

    Private Sub MisturarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MisturarToolStripMenuItem.Click
        misturar1()
        verificar2()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        misturar1()
        verificar2()
        Timer1.Enabled = True
        clique = 0
        ClicksToolStripMenuItem.Text = "Clicks: " & clique
        perdida = 0
        PerdidasToolStripMenuItem.Text = "Perdidas: " & perdida
        Ganha = 0
        GanhasToolStripMenuItem.Text = "Ganhas: " & Ganha
        ToolStripMenuItem1.Text = 60
        ToolStripMenuItem5.Text = 10

    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        End
    End Sub


    Private Sub PerdidasToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        ToolStripMenuItem1.Text -= 1 'segundos'


        If ToolStripMenuItem1.Text = 0 Then
            ToolStripMenuItem5.Text -= 1
            ToolStripMenuItem1.Text = 60

        
        End If

        If ToolStripMenuItem5.Text = 0 Then
            Timer1.Stop()
            perdeumsg = MsgBox("Você perdeu!! Deseja continuar?", vbYesNo, vbExclamation)
            clique = 0
            misturar1()
            verificar2()
            ToolStripMenuItem1.Text = 60
            ToolStripMenuItem5.Text = 10
            perdida = perdida + 1
            PerdidasToolStripMenuItem.Text = "Perdidas: " & perdida

            
        End If

        

        If perdeumsg = vbYes Then
            Timer1.Stop()
            Timer1.Start()




        ElseIf perdeumsg = vbNo Then
            Me.Close()

        End If

        'If ToolStripMenuItem1.Text = 0 Then
        'ToolStripMenuItem5.Text -= 1 'minutos
        ' ToolStripMenuItem1.Text = 60
        ' End If

        'If ToolStripMenuItem5.Text = 60 Then
        'ToolStripMenuItem4.Text -= 1 'horas'
        'ToolStripMenuItem5.Text = 0
        'End If


    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub ClicksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClicksToolStripMenuItem.Click

    End Sub

    Private Sub GanhasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GanhasToolStripMenuItem.Click

    End Sub

    Private Sub VoltarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VoltarToolStripMenuItem.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class