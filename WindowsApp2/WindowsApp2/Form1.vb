Public Class Form1
    Dim score As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        chase(alien2)
        chase(alien7)
        chase(alien6)
        chase(alien5)




    End Sub
    Sub move(P As PictureBox, X As Integer, y As Integer)
        P.Location = New Point(P.Location.X + X, P.Location.Y + y)

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode

            Case Keys.W
                MoveTo(PictureBox1, 0, -5)
            Case Keys.R
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipX)
                Me.Refresh()
            Case Keys.A
                MoveTo(PictureBox1, -5, 0)
            Case Keys.S
                MoveTo(PictureBox1, 0, 5)
            Case Keys.D
                MoveTo(PictureBox1, 5, 0)
            Case Keys.Space
                bullet.Location = PictureBox1.Location
                bullet.Visible = True
                Timer2.Enabled = True
            Case Keys.Space
                bullet.Visible = Not bullet.Visible
        End Select
    End Sub
    Sub follow(p As PictureBox)
        Static headstart As Integer
        Static c As New Collection
        c.Add(PictureBox1.Location)
        headstart = headstart + 1
        If headstart > 10 Then
            p.Location = c.Item(1)
            c.Remove(1)
        End If
    End Sub

    Public Sub chase(p As PictureBox)
        Dim x, y As Integer
        If p.Location.X > PictureBox1.Location.X Then
            x = -5
        Else
            x = 5
        End If
        MoveTo(p, x, 0)
        'If p.Location.Y < PictureBox1.Location.Y Then
        '    y = 5
        'Else
        '    y = -5
        'End If
        'MoveTo(p, x, y)
    End Sub



    Function Collision(p As PictureBox, t As String, Optional ByRef other As Object = vbNull)
        Dim col As Boolean

        For Each c In Controls
            Dim obj As Control
            obj = c
            If obj.Visible AndAlso p.Bounds.IntersectsWith(obj.Bounds) And obj.Name.ToUpper.Contains(t.ToUpper) Then
                col = True
                other = obj
            End If
        Next
        Return col
    End Function


    'Return true or false if moving to the new location is clear of objects ending with t
    Function IsClear(p As PictureBox, distx As Integer, disty As Integer, t As String) As Boolean
        Dim b As Boolean

        p.Location += New Point(distx, disty)
        b = Not Collision(p, t)
        p.Location -= New Point(distx, disty)
        Return b
    End Function
    'Moves and object (won't move onto objects containing  "wall" and shows green if object ends with "win"
    Sub MoveTo(p As PictureBox, distx As Integer, disty As Integer)
        If IsClear(p, distx, disty, "wall") Then
            p.Location += New Point(distx, disty)
        End If

        If p.Name = "PictureBox1" And Collision(p, "alien") Then
            Me.BackColor = Color.Red
            Return
            'Me.BackColor = Color.Black.

        End If
        Dim other As Object = Nothing
        If p.Name = "bullet" And Collision(p, "alien", other) Then
            other.visible = False
            Return
            'Me.BackColor = Color.Black
        End If
    End Sub


    Private Sub win_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        MoveTo(bullet, 0, -150)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles bullet.Click

    End Sub

    Private Sub alien5_Click(sender As Object, e As EventArgs) Handles alien5.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class