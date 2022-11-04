﻿Public Class Form1
    Dim frame As Bitmap
    Dim g, gFinal As Graphics

    Dim shipX, shipY As Integer

    Private Sub GameTimer_Tick(sender As Object, e As EventArgs) Handles GameTimer.Tick
        'DRAW STUFF HERE
        '---------------
        'Draw your background first!
        g.DrawImage(My.Resources.space_background, 0, 0)


        'Move Ship


        'Draw the ship
        g.DrawImage(My.Resources.ship, shipX, shipY)


        'Do not alter below this line
        gFinal.DrawImage(frame, 0, 0)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Do not alter this code
        frame = New Bitmap(getWidth(), getHeight())
        gFinal = Me.CreateGraphics
        g = Graphics.FromImage(frame)

        gFinal.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
        gFinal.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        gFinal.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality
        gFinal.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality

        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality
        g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality

        GameTimer.Start()
    End Sub


    Function getWidth() As Integer
        'Returns the usable width of the form
        Return Me.ClientSize.Width
    End Function
    Function getHeight() As Integer
        'Returns the usable height of the form
        Return Me.ClientSize.Height
    End Function
End Class
