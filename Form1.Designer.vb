<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPiedra
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPiedra))
        Me.cmdPapel = New System.Windows.Forms.Button()
        Me.cmdPiedra = New System.Windows.Forms.Button()
        Me.cmdTijera = New System.Windows.Forms.Button()
        Me.pctJugador = New System.Windows.Forms.PictureBox()
        Me.pctPC = New System.Windows.Forms.PictureBox()
        Me.lblPuntosJug = New System.Windows.Forms.Label()
        Me.cmdOtraVez = New System.Windows.Forms.Button()
        Me.lblJugador = New System.Windows.Forms.Label()
        Me.lblPC = New System.Windows.Forms.Label()
        Me.lblPuntosPC = New System.Windows.Forms.Label()
        Me.lblPartidasJug = New System.Windows.Forms.Label()
        Me.lblPartidasPC = New System.Windows.Forms.Label()
        Me.lblWinsJug = New System.Windows.Forms.Label()
        Me.lblWinsPC = New System.Windows.Forms.Label()
        CType(Me.pctJugador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctPC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdPapel
        '
        Me.cmdPapel.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmdPapel.BackgroundImage = Global.Piedra_Papel_o_Tijera.My.Resources.Resources.Papel
        Me.cmdPapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdPapel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPapel.Enabled = False
        Me.cmdPapel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPapel.Location = New System.Drawing.Point(293, 338)
        Me.cmdPapel.Name = "cmdPapel"
        Me.cmdPapel.Size = New System.Drawing.Size(76, 50)
        Me.cmdPapel.TabIndex = 0
        Me.cmdPapel.UseVisualStyleBackColor = False
        '
        'cmdPiedra
        '
        Me.cmdPiedra.BackColor = System.Drawing.Color.YellowGreen
        Me.cmdPiedra.BackgroundImage = Global.Piedra_Papel_o_Tijera.My.Resources.Resources.piedra
        Me.cmdPiedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdPiedra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPiedra.Enabled = False
        Me.cmdPiedra.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPiedra.Location = New System.Drawing.Point(192, 338)
        Me.cmdPiedra.Name = "cmdPiedra"
        Me.cmdPiedra.Size = New System.Drawing.Size(74, 50)
        Me.cmdPiedra.TabIndex = 1
        Me.cmdPiedra.UseVisualStyleBackColor = False
        '
        'cmdTijera
        '
        Me.cmdTijera.BackColor = System.Drawing.Color.DarkOrange
        Me.cmdTijera.BackgroundImage = Global.Piedra_Papel_o_Tijera.My.Resources.Resources.Tijera
        Me.cmdTijera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdTijera.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdTijera.Enabled = False
        Me.cmdTijera.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdTijera.Location = New System.Drawing.Point(393, 338)
        Me.cmdTijera.Name = "cmdTijera"
        Me.cmdTijera.Size = New System.Drawing.Size(75, 50)
        Me.cmdTijera.TabIndex = 2
        Me.cmdTijera.UseVisualStyleBackColor = False
        '
        'pctJugador
        '
        Me.pctJugador.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pctJugador.BackgroundImage = Global.Piedra_Papel_o_Tijera.My.Resources.Resources.among_us_digibyte
        Me.pctJugador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctJugador.ErrorImage = Global.Piedra_Papel_o_Tijera.My.Resources.Resources.among_us_digibyte
        Me.pctJugador.InitialImage = Global.Piedra_Papel_o_Tijera.My.Resources.Resources.among_us_digibyte
        Me.pctJugador.Location = New System.Drawing.Point(12, 48)
        Me.pctJugador.Name = "pctJugador"
        Me.pctJugador.Size = New System.Drawing.Size(305, 237)
        Me.pctJugador.TabIndex = 3
        Me.pctJugador.TabStop = False
        '
        'pctPC
        '
        Me.pctPC.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pctPC.BackgroundImage = Global.Piedra_Papel_o_Tijera.My.Resources.Resources.among_us_2
        Me.pctPC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctPC.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.pctPC.ErrorImage = Global.Piedra_Papel_o_Tijera.My.Resources.Resources.among_us_2
        Me.pctPC.InitialImage = Global.Piedra_Papel_o_Tijera.My.Resources.Resources.among_us_2
        Me.pctPC.Location = New System.Drawing.Point(323, 48)
        Me.pctPC.Name = "pctPC"
        Me.pctPC.Size = New System.Drawing.Size(274, 237)
        Me.pctPC.TabIndex = 4
        Me.pctPC.TabStop = False
        '
        'lblPuntosJug
        '
        Me.lblPuntosJug.BackColor = System.Drawing.Color.LightSkyBlue
        Me.lblPuntosJug.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPuntosJug.Location = New System.Drawing.Point(269, 9)
        Me.lblPuntosJug.Name = "lblPuntosJug"
        Me.lblPuntosJug.Size = New System.Drawing.Size(38, 36)
        Me.lblPuntosJug.TabIndex = 5
        '
        'cmdOtraVez
        '
        Me.cmdOtraVez.BackgroundImage = Global.Piedra_Papel_o_Tijera.My.Resources.Resources.color
        Me.cmdOtraVez.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdOtraVez.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdOtraVez.Font = New System.Drawing.Font("Ravie", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOtraVez.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdOtraVez.Location = New System.Drawing.Point(228, 291)
        Me.cmdOtraVez.Name = "cmdOtraVez"
        Me.cmdOtraVez.Size = New System.Drawing.Size(198, 41)
        Me.cmdOtraVez.TabIndex = 7
        Me.cmdOtraVez.Text = "DALE!"
        Me.cmdOtraVez.UseVisualStyleBackColor = True
        '
        'lblJugador
        '
        Me.lblJugador.AutoSize = True
        Me.lblJugador.BackColor = System.Drawing.Color.Khaki
        Me.lblJugador.Font = New System.Drawing.Font("Ravie", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJugador.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblJugador.Location = New System.Drawing.Point(12, 9)
        Me.lblJugador.Name = "lblJugador"
        Me.lblJugador.Size = New System.Drawing.Size(88, 19)
        Me.lblJugador.TabIndex = 8
        Me.lblJugador.Text = "JUGADOR"
        '
        'lblPC
        '
        Me.lblPC.AutoSize = True
        Me.lblPC.BackColor = System.Drawing.Color.Khaki
        Me.lblPC.Font = New System.Drawing.Font("Ravie", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPC.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblPC.Location = New System.Drawing.Point(567, 12)
        Me.lblPC.Name = "lblPC"
        Me.lblPC.Size = New System.Drawing.Size(30, 19)
        Me.lblPC.TabIndex = 9
        Me.lblPC.Text = "PC"
        '
        'lblPuntosPC
        '
        Me.lblPuntosPC.BackColor = System.Drawing.Color.LightSkyBlue
        Me.lblPuntosPC.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPuntosPC.Location = New System.Drawing.Point(331, 9)
        Me.lblPuntosPC.Name = "lblPuntosPC"
        Me.lblPuntosPC.Size = New System.Drawing.Size(38, 36)
        Me.lblPuntosPC.TabIndex = 10
        '
        'lblPartidasJug
        '
        Me.lblPartidasJug.BackColor = System.Drawing.Color.OrangeRed
        Me.lblPartidasJug.Font = New System.Drawing.Font("Ravie", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartidasJug.Location = New System.Drawing.Point(13, 306)
        Me.lblPartidasJug.Name = "lblPartidasJug"
        Me.lblPartidasJug.Size = New System.Drawing.Size(76, 40)
        Me.lblPartidasJug.TabIndex = 11
        Me.lblPartidasJug.Text = "Partidas Ganadas"
        '
        'lblPartidasPC
        '
        Me.lblPartidasPC.BackColor = System.Drawing.Color.Gold
        Me.lblPartidasPC.Font = New System.Drawing.Font("Ravie", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartidasPC.Location = New System.Drawing.Point(521, 306)
        Me.lblPartidasPC.Name = "lblPartidasPC"
        Me.lblPartidasPC.Size = New System.Drawing.Size(76, 40)
        Me.lblPartidasPC.TabIndex = 12
        Me.lblPartidasPC.Text = "Partidas Ganadas"
        '
        'lblWinsJug
        '
        Me.lblWinsJug.AutoSize = True
        Me.lblWinsJug.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinsJug.ForeColor = System.Drawing.Color.Red
        Me.lblWinsJug.Location = New System.Drawing.Point(32, 366)
        Me.lblWinsJug.Name = "lblWinsJug"
        Me.lblWinsJug.Size = New System.Drawing.Size(22, 22)
        Me.lblWinsJug.TabIndex = 13
        Me.lblWinsJug.Text = "0"
        '
        'lblWinsPC
        '
        Me.lblWinsPC.AutoSize = True
        Me.lblWinsPC.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinsPC.ForeColor = System.Drawing.Color.Gold
        Me.lblWinsPC.Location = New System.Drawing.Point(554, 366)
        Me.lblWinsPC.Name = "lblWinsPC"
        Me.lblWinsPC.Size = New System.Drawing.Size(22, 22)
        Me.lblWinsPC.TabIndex = 14
        Me.lblWinsPC.Text = "0"
        '
        'frmPiedra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.Piedra_Papel_o_Tijera.My.Resources.Resources.color
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(607, 406)
        Me.Controls.Add(Me.lblWinsPC)
        Me.Controls.Add(Me.lblWinsJug)
        Me.Controls.Add(Me.lblPartidasPC)
        Me.Controls.Add(Me.lblPartidasJug)
        Me.Controls.Add(Me.lblPuntosPC)
        Me.Controls.Add(Me.lblPC)
        Me.Controls.Add(Me.lblJugador)
        Me.Controls.Add(Me.cmdOtraVez)
        Me.Controls.Add(Me.lblPuntosJug)
        Me.Controls.Add(Me.pctPC)
        Me.Controls.Add(Me.pctJugador)
        Me.Controls.Add(Me.cmdTijera)
        Me.Controls.Add(Me.cmdPiedra)
        Me.Controls.Add(Me.cmdPapel)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPiedra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Piedra Papel o Tijera"
        CType(Me.pctJugador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctPC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdPapel As Button
    Friend WithEvents cmdPiedra As Button
    Friend WithEvents cmdTijera As Button
    Friend WithEvents pctJugador As PictureBox
    Friend WithEvents pctPC As PictureBox
    Friend WithEvents lblPuntosJug As Label
    Friend WithEvents cmdOtraVez As Button
    Friend WithEvents lblJugador As Label
    Friend WithEvents lblPC As Label
    Friend WithEvents lblPuntosPC As Label
    Friend WithEvents lblPartidasJug As Label
    Friend WithEvents lblPartidasPC As Label
    Friend WithEvents lblWinsJug As Label
    Friend WithEvents lblWinsPC As Label
End Class
