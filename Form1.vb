Public Class frmPiedra
    Private Z As New Random
    Dim J1 As Integer = 0
    Dim PC As Integer = 0
    Dim WJ As Integer = 0
    Dim WPC As Integer = 0

    Private Sub cmdPiedra_Click(sender As Object, e As EventArgs) Handles cmdPiedra.Click
        Dim X As Integer = 0
        X = Z.Next(1, 4)
        pctJugador.Image = My.Resources.piedra

        Select Case X
            Case 1
                pctPC.Image = My.Resources.piedra


            Case 2
                pctPC.Image = My.Resources.Papel

                PC = (PC + 1)

            Case 3
                pctPC.Image = My.Resources.Tijera

                J1 = (J1 + 1)

        End Select
        lblPuntosJug.Text = J1
        lblPuntosPC.Text = PC
        cmdPiedra.Enabled = False
        cmdPapel.Enabled = False
        cmdTijera.Enabled = False


    End Sub

    Private Sub cmdPapel_Click(sender As Object, e As EventArgs) Handles cmdPapel.Click
        Dim X As Integer = 0
        X = Z.Next(1, 4)
        pctJugador.Image = My.Resources.Papel

        Select Case X
            Case 1
                pctPC.Image = My.Resources.piedra

                J1 = (J1 + 1)

            Case 2
                pctPC.Image = My.Resources.Papel


            Case 3
                pctPC.Image = My.Resources.Tijera

                PC = (PC + 1)

        End Select
        lblPuntosJug.Text = J1
        lblPuntosPC.Text = PC
        cmdPiedra.Enabled = False
        cmdPapel.Enabled = False
        cmdTijera.Enabled = False

    End Sub

    Private Sub cmdTijera_Click(sender As Object, e As EventArgs) Handles cmdTijera.Click
        Dim X As Integer = 0
        X = Z.Next(1, 4)
        pctJugador.Image = My.Resources.Tijera

        Select Case X
            Case 1
                pctPC.Image = My.Resources.piedra

                PC = (PC + 1)

            Case 2
                pctPC.Image = My.Resources.Papel

                J1 = (J1 + 1)

            Case 3
                pctPC.Image = My.Resources.Tijera


        End Select
        lblPuntosJug.Text = J1
        lblPuntosPC.Text = PC
        cmdPiedra.Enabled = False
        cmdPapel.Enabled = False
        cmdTijera.Enabled = False
    End Sub

    Private Sub cmdOtraVez_Click(sender As Object, e As EventArgs) Handles cmdOtraVez.Click
        pctJugador.Image = My.Resources.among_us_digibyte
        pctPC.Image = My.Resources.among_us_2
        cmdPiedra.Enabled = True
        cmdPapel.Enabled = True
        cmdTijera.Enabled = True
        cmdOtraVez.Text = "Dale"
        lblJugador.Text = "Jugador"
        lblPC.Text = "PC"
        If J1 = 3 Then
            cmdOtraVez.Text = "GANASTE"
            J1 = 0
            PC = 0
            lblPuntosJug.Text = 0
            lblPuntosPC.Text = 0
            cmdPiedra.Enabled = False
            cmdPapel.Enabled = False
            cmdTijera.Enabled = False
            Me.BackgroundImage = My.Resources.among_us_digibyte
            WJ = (WJ + 1)
            lblWinsJug.Text = WJ
        End If
        If PC = 3 Then
            cmdOtraVez.Text = "Perdiste"
            J1 = 0
            PC = 0
            lblPuntosJug.Text = 0
            lblPuntosPC.Text = 0
            lblPC.Text = "JAJ"
            lblJugador.Text = "*o*"
            cmdPiedra.Enabled = False
            cmdPapel.Enabled = False
            cmdTijera.Enabled = False
            Me.BackgroundImage = My.Resources.among_us_2
            WPC = (WPC + 1)
            lblWinsPC.Text = WPC
        Else
            cmdOtraVez.Text = "A Jugar"
            Me.BackgroundImage = My.Resources.color
        End If

    End Sub

End Class
