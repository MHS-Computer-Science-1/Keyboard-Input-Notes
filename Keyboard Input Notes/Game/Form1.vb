Public Class Form1
    Dim frame As Bitmap
    Dim framePen, formPen As Graphics

    Dim shipX, shipY As Integer


    Private Sub GameTimer_Tick(sender As Object, e As EventArgs) Handles GameTimer.Tick
        'DRAW STUFF HERE
        '---------------
        'Draw your background first!
        framePen.DrawImage(My.Resources.space_background, 0, 0)


        'Move Ship



        'Draw the ship
        framePen.DrawImage(My.Resources.ship, shipX, shipY)


        'Do not alter below this line
        formPen.DrawImage(frame, 0, 0)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Do not alter this code
        frame = New Bitmap(getWidth(), getHeight())
        formPen = Me.CreateGraphics
        framePen = Graphics.FromImage(frame)

        formPen.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
        formPen.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        formPen.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality
        formPen.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality

        framePen.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
        framePen.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        framePen.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality
        framePen.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality

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
