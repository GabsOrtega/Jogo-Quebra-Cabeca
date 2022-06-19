Public Class Form4
    
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        '11, 16, 18, 23
        conferir3(Button17, Button11)
        conferir3(Button17, Button16)
        conferir3(Button17, Button18)
        conferir3(Button17, Button23)
        verificar3()
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        '22, 27, 29, 34
        conferir3(Button28, Button22)
        conferir3(Button28, Button27)
        conferir3(Button28, Button29)
        conferir3(Button28, Button34)
        verificar3()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        misturar2()
        verificar3()
        Timer1.Enabled = True
        clique3 = 0
        ClicksToolStripMenuItem.Text = "Clicks: " & clique3
        perdidas3 = 0
        PerdidasToolStripMenuItem.Text = "Perdidas: " & perdidas3
        ganhas3 = 0
        GanhasToolStripMenuItem.Text = "Ganhas: " & ganhas3
        ToolStripMenuItem5.Text = 60
        ToolStripMenuItem3.Text = 15


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '2, 7
        conferir3(Button1, Button2)
        conferir3(Button1, Button7)
        verificar3()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '1, 3, 8
        conferir3(Button2, Button1)
        conferir3(Button2, Button3)
        conferir3(Button2, Button8)
        verificar3()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '2, 4 , 9
        conferir3(Button3, Button2)
        conferir3(Button3, Button4)
        conferir3(Button3, Button9)
        verificar3()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        '3, 5, 10
        conferir3(Button4, Button3)
        conferir3(Button4, Button5)
        conferir3(Button4, Button10)
        verificar3()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        '4, 6, 11
        conferir3(Button5, Button4)
        conferir3(Button5, Button6)
        conferir3(Button5, Button11)
        verificar3()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        '5, 12
        conferir3(Button6, Button5)
        conferir3(Button6, Button12)
        verificar3()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        '1, 8, 13
        conferir3(Button7, Button1)
        conferir3(Button7, Button8)
        conferir3(Button7, Button13)
        verificar3()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        '2, 7, 9, 14
        conferir3(Button8, Button2)
        conferir3(Button8, Button7)
        conferir3(Button8, Button9)
        conferir3(Button8, Button14)
        verificar3()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        '3, 8, 10, 15
        conferir3(Button9, Button3)
        conferir3(Button9, Button8)
        conferir3(Button9, Button10)
        conferir3(Button9, Button15)
        verificar3()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        '4, 9, 11, 16
        conferir3(Button10, Button4)
        conferir3(Button10, Button9)
        conferir3(Button10, Button11)
        conferir3(Button10, Button16)
        verificar3()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        '5, 10, 12, 17
        conferir3(Button11, Button5)
        conferir3(Button11, Button10)
        conferir3(Button11, Button12)
        conferir3(Button11, Button17)
        verificar3()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        '6, 11, 18
        conferir3(Button12, Button6)
        conferir3(Button12, Button11)
        conferir3(Button12, Button18)
        verificar3()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        '7, 14, 19
        conferir3(Button13, Button7)
        conferir3(Button13, Button14)
        conferir3(Button13, Button19)
        verificar3()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        '8, 13, 15, 20
        conferir3(Button14, Button8)
        conferir3(Button14, Button13)
        conferir3(Button14, Button15)
        conferir3(Button14, Button20)
        verificar3()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        '9, 14, 16, 21
        conferir3(Button15, Button9)
        conferir3(Button15, Button14)
        conferir3(Button15, Button16)
        conferir3(Button15, Button21)
        verificar3()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        '10, 15, 17, 22
        conferir3(Button16, Button10)
        conferir3(Button16, Button15)
        conferir3(Button16, Button17)
        conferir3(Button16, Button22)
        verificar3()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        '12, 17, 24
        conferir3(Button18, Button12)
        conferir3(Button18, Button17)
        conferir3(Button18, Button24)
        verificar3()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        '13, 20, 25
        conferir3(Button19, Button13)
        conferir3(Button19, Button20)
        conferir3(Button19, Button25)
        verificar3()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        '14, 19, 21, 26
        conferir3(Button20, Button14)
        conferir3(Button20, Button19)
        conferir3(Button20, Button21)
        conferir3(Button20, Button26)
        verificar3()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        '15, 20, 22, 27
        conferir3(Button21, Button15)
        conferir3(Button21, Button20)
        conferir3(Button21, Button22)
        conferir3(Button21, Button27)
        verificar3()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        '16, 21, 23, 28
        conferir3(Button22, Button16)
        conferir3(Button22, Button21)
        conferir3(Button22, Button23)
        conferir3(Button22, Button28)
        verificar3()

    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        '17, 22, 24, 29
        conferir3(Button23, Button17)
        conferir3(Button23, Button22)
        conferir3(Button23, Button24)
        conferir3(Button23, Button29)
        verificar3()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        '18, 23, 30
        conferir3(Button24, Button18)
        conferir3(Button24, Button23)
        conferir3(Button24, Button30)
        verificar3()
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        '19, 26, 31
        conferir3(Button25, Button19)
        conferir3(Button25, Button26)
        conferir3(Button25, Button31)
        verificar3()
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        '20, 25, 27, 32
        conferir3(Button26, Button20)
        conferir3(Button26, Button25)
        conferir3(Button26, Button27)
        conferir3(Button26, Button32)
        verificar3()
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        '21, 26, 28, 33
        conferir3(Button27, Button21)
        conferir3(Button27, Button26)
        conferir3(Button27, Button28)
        conferir3(Button27, Button33)
        verificar3()
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        '23, 28, 30, 35
        conferir3(Button29, Button23)
        conferir3(Button29, Button28)
        conferir3(Button29, Button30)
        conferir3(Button29, Button35)
        verificar3()
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        '24, 29, 36
        conferir3(Button30, Button24)
        conferir3(Button30, Button29)
        conferir3(Button30, Button36)
        verificar3()
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        '25, 32
        conferir3(Button31, Button25)
        conferir3(Button31, Button32)
        verificar3()

    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        '26, 31, 33
        conferir3(Button32, Button26)
        conferir3(Button32, Button31)
        conferir3(Button32, Button33)
        verificar3()
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        '27, 32, 34
        conferir3(Button33, Button27)
        conferir3(Button33, Button32)
        conferir3(Button33, Button34)
        verificar3()
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        '29, 34, 36
        conferir3(Button35, Button29)
        conferir3(Button35, Button34)
        conferir3(Button35, Button36)
        verificar3()
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        '28, 34, 36
        conferir3(Button34, Button28)
        conferir3(Button34, Button33)
        conferir3(Button34, Button35)
        verificar3()
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        '30, 35
        conferir3(Button36, Button30)
        conferir3(Button36, Button35)
        verificar3()
    End Sub

    Private Sub MisturarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MisturarToolStripMenuItem.Click
        misturar2()
        verificar3()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripMenuItem5.Text -= 1 'segundos'


        If ToolStripMenuItem5.Text = 0 Then
            ToolStripMenuItem3.Text -= 1
            ToolStripMenuItem5.Text = 60

        End If

        If ToolStripMenuItem3.Text = 0 Then
            Timer1.Stop()
            perdeumsg3 = MsgBox("Você perdeu!! Deseja continuar?", vbYesNo, vbExclamation)
            ToolStripMenuItem3.Text = 15
            ToolStripMenuItem5.Text = 60
            misturar2()
            verificar3()
            perdidas3 = perdidas3 + 1
            PerdidasToolStripMenuItem.Text = "Perdidas: " & perdidas3

        End If

        If perdeumsg3 = vbYes Then
            Timer1.Stop()
            Timer1.Start()

        ElseIf perdeumsg3 = vbNo Then
            Me.Close()
        End If


    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        End
    End Sub

    Private Sub VoltarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VoltarToolStripMenuItem.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class