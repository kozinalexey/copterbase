
Public Class PictureboxT
    Inherits PictureBox
    Private _ledstate As Integer
    Private _ledcolor As String


    Public Property LedState() As Integer
        Get
            Return _ledstate
        End Get
        Set(ByVal value As Integer)
            _ledstate = value
            If _ledcolor = "red" Then
                If _ledstate = 0 Then
                    Me.Image = My.Resources.LedRedDark
                Else
                    Me.Image = My.Resources.LedRed
                End If
            Else
                If _ledstate = 0 Then
                    Me.Image = My.Resources.LedGreenDark
                Else
                    Me.Image = My.Resources.LedGreen
                End If
            End If
        End Set
    End Property
    Public Property LedColor() As String
        Get
            Return _ledcolor
        End Get
        Set(ByVal value As String)
            _ledcolor = value
        End Set
    End Property
    Protected Overrides Sub OnPaintBackground(e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaintBackground(e)

        If Parent IsNot Nothing Then
            Dim index As Integer = Parent.Controls.GetChildIndex(Me)

            For i As Integer = Parent.Controls.Count - 1 To index + 1 Step -1
                Dim c As Control = Parent.Controls(i)
                If c.Bounds.IntersectsWith(Bounds) AndAlso c.Visible = True Then
                    Dim bmp As New Bitmap(c.Width, c.Height, e.Graphics)
                    c.DrawToBitmap(bmp, c.ClientRectangle)
                    e.Graphics.TranslateTransform(c.Left - Left(), c.Top - Top)
                    e.Graphics.DrawImageUnscaled(bmp, Point.Empty)
                    e.Graphics.TranslateTransform(Left() - c.Left, Top - c.Top)
                    bmp.Dispose()
                End If
            Next
        End If
    End Sub
End Class
