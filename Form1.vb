Public Class frmMain
    Dim playerTurn As String = "1"
    Private imagelist() As Image = {My.Resources.player1, My.Resources.player2}
    Public personname As String


    Private Sub a1_Click(sender As Object, e As EventArgs) Handles a1.Click, b1.Click, c1.Click, d1.Click, e1.Click, f1.Click
        For i As Integer = 5 To 0 Step -1
            Dim img As PictureBox = TableLayoutPanel1.GetControlFromPosition(0, i)
            If img.Image Is Nothing Then
                moveTurn(img)
                Exit For
            End If
            'sender.Tag = playerT
        Next

        ' If f1.Image Is Nothing Then
        '     moveTurn(f1)
        ' ElseIf e1.Image IsNot My.Resources.player1 AndAlso e1.Image IsNot My.Resources.player2 Then
        '     moveTurn(e1)
        ' ElseIf d1.Image IsNot My.Resources.player1 AndAlso d1.Image IsNot My.Resources.player2 Then
        '     moveTurn(d1)
        ' ElseIf c1.Image IsNot My.Resources.player1 AndAlso c1.Image IsNot My.Resources.player2 Then
        '     moveTurn(c1)
        ' ElseIf b1.Image IsNot My.Resources.player1 AndAlso b1.Image IsNot My.Resources.player2 Then
        '     moveTurn(b1)
        ' ElseIf a1.Image IsNot My.Resources.player1 AndAlso a1.Image IsNot My.Resources.player2 Then
        '     moveTurn(a1)
        ' End If
    End Sub

    Private Sub moveTurn(space As PictureBox)
        'Console.WriteLine("moveTurn: " & space.Name)
        If playerTurn = "1" Then
            space.Image = imagelist(0)
        ElseIf playerTurn = "2" Then
            space.Image = imagelist(1)
        End If
        If playerTurn = "1" Then
            playerTurn = "2"
        ElseIf playerTurn = "2" Then
            playerTurn = "1"
        End If
        checkForWin(space)
    End Sub

    Function CheckColumnsForWin()
        Dim cols As Integer = TableLayoutPanel1.ColumnCount
        Dim rows As Integer = TableLayoutPanel1.RowCount
        Dim newwin As Boolean = False
        For j As Integer = 0 To cols - 1
            For i As Integer = rows - 1 To 3 Step -1
                Dim sp1 As PictureBox = TableLayoutPanel1.GetControlFromPosition(j, i)
                Dim sp2 As PictureBox = TableLayoutPanel1.GetControlFromPosition(j, i - 1)
                Dim sp3 As PictureBox = TableLayoutPanel1.GetControlFromPosition(j, i - 2)
                Dim sp4 As PictureBox = TableLayoutPanel1.GetControlFromPosition(j, i - 3)
                If sp1.Image Is imagelist(0) AndAlso sp2.Image Is imagelist(0) AndAlso sp3.Image Is imagelist(0) AndAlso sp4.Image Is imagelist(0) Then
                    newwin = True
                    Exit For
                ElseIf sp1.Image Is imagelist(1) AndAlso sp2.Image Is imagelist(1) AndAlso sp3.Image Is imagelist(1) AndAlso sp4.Image Is imagelist(1) Then
                    newwin = True
                    Exit For
                End If

            Next
            If newwin Then
                Exit For
            End If
        Next
        Return newwin
    End Function

    Function CheckRowsForWin() As Boolean
        Dim cols As Integer = TableLayoutPanel1.ColumnCount
        Dim rows As Integer = TableLayoutPanel1.RowCount
        Dim newwin As Boolean = False
        For j As Integer = 0 To rows - 1
            For i As Integer = cols - 1 To 3 Step -1
                Dim sp1 As PictureBox = TableLayoutPanel1.GetControlFromPosition(i, j)
                Dim sp2 As PictureBox = TableLayoutPanel1.GetControlFromPosition(i - 1, j)
                Dim sp3 As PictureBox = TableLayoutPanel1.GetControlFromPosition(i - 2, j)
                Dim sp4 As PictureBox = TableLayoutPanel1.GetControlFromPosition(i - 3, j)
                If sp1.Image Is imagelist(0) AndAlso sp2.Image Is imagelist(0) AndAlso sp3.Image Is imagelist(0) AndAlso sp4.Image Is imagelist(0) Then
                    newwin = True
                    Exit For
                ElseIf sp1.Image Is imagelist(1) AndAlso sp2.Image Is imagelist(1) AndAlso sp3.Image Is imagelist(1) AndAlso sp4.Image Is imagelist(1) Then
                    newwin = True
                    Exit For
                End If

            Next
            If newwin Then
                Exit For
            End If
        Next
        Return newwin
    End Function

    Function CheckDiagonalsForWin() As Boolean
        Dim win As Boolean = False
        If a1.Image Is imagelist(0) AndAlso b2.Image Is imagelist(0) AndAlso c3.Image Is imagelist(0) AndAlso d4.Image Is imagelist(0) Then
            win = True
        ElseIf b2.Image Is imagelist(0) AndAlso c3.Image Is imagelist(0) AndAlso d4.Image Is imagelist(0) AndAlso e5.Image Is imagelist(0) Then
            win = True
        ElseIf c3.Image Is imagelist(0) AndAlso d4.Image Is imagelist(0) AndAlso e5.Image Is imagelist(0) AndAlso f6.Image Is imagelist(0) Then
            win = True
        End If
        If a1.Image Is imagelist(1) AndAlso b2.Image Is imagelist(1) AndAlso c3.Image Is imagelist(1) AndAlso d4.Image Is imagelist(1) Then
            win = True
        ElseIf b2.Image Is imagelist(1) AndAlso c3.Image Is imagelist(1) AndAlso d4.Image Is imagelist(1) AndAlso e5.Image Is imagelist(1) Then
            win = True
        ElseIf c3.Image Is imagelist(1) AndAlso d4.Image Is imagelist(1) AndAlso e5.Image Is imagelist(1) AndAlso f6.Image Is imagelist(1) Then
            win = True
        End If

        If a2.Image Is imagelist(0) AndAlso b3.Image Is imagelist(0) AndAlso c4.Image Is imagelist(0) AndAlso d5.Image Is imagelist(0) Then
            win = True
        ElseIf b3.Image Is imagelist(0) AndAlso c3.Image Is imagelist(0) AndAlso d4.Image Is imagelist(0) AndAlso e5.Image Is imagelist(0) Then
            win = True
        End If
        If a2.Image Is imagelist(1) AndAlso b3.Image Is imagelist(1) AndAlso c4.Image Is imagelist(1) AndAlso d5.Image Is imagelist(1) Then
            win = True
        ElseIf b3.Image Is imagelist(1) AndAlso c3.Image Is imagelist(1) AndAlso d4.Image Is imagelist(1) AndAlso e5.Image Is imagelist(1) Then
            win = True
        End If

        If a3.Image Is imagelist(0) AndAlso b4.Image Is imagelist(0) AndAlso c5.Image Is imagelist(0) AndAlso d6.Image Is imagelist(0) Then
            win = True
        End If
        If a3.Image Is imagelist(1) AndAlso b4.Image Is imagelist(1) AndAlso c5.Image Is imagelist(1) AndAlso d6.Image Is imagelist(1) Then
            win = True
        End If

        If b1.Image Is imagelist(0) AndAlso c2.Image Is imagelist(0) AndAlso d3.Image Is imagelist(0) AndAlso e4.Image Is imagelist(0) Then
            win = True
        ElseIf c2.Image Is imagelist(0) AndAlso d3.Image Is imagelist(0) AndAlso e4.Image Is imagelist(0) AndAlso f5.Image Is imagelist(0) Then
            win = True
        End If
        If b1.Image Is imagelist(1) AndAlso c2.Image Is imagelist(1) AndAlso d3.Image Is imagelist(1) AndAlso e4.Image Is imagelist(1) Then
            win = True
        ElseIf c2.Image Is imagelist(1) AndAlso d3.Image Is imagelist(1) AndAlso e4.Image Is imagelist(1) AndAlso f5.Image Is imagelist(1) Then
            win = True
        End If

        If c1.Image Is imagelist(0) AndAlso d2.Image Is imagelist(0) AndAlso e3.Image Is imagelist(0) AndAlso f4.Image Is imagelist(0) Then
            win = True
        End If
        If c1.Image Is imagelist(1) AndAlso d2.Image Is imagelist(1) AndAlso e3.Image Is imagelist(1) AndAlso f4.Image Is imagelist(1) Then
            win = True
        End If

        If a6.Image Is imagelist(0) AndAlso b5.Image Is imagelist(0) AndAlso c4.Image Is imagelist(0) AndAlso d3.Image Is imagelist(0) Then
            win = True
        ElseIf b5.Image Is imagelist(0) AndAlso c4.Image Is imagelist(0) AndAlso d3.Image Is imagelist(0) AndAlso e2.Image Is imagelist(0) Then
            win = True
        ElseIf c4.Image Is imagelist(0) AndAlso d3.Image Is imagelist(0) AndAlso e2.Image Is imagelist(0) AndAlso f1.Image Is imagelist(0) Then
            win = True
        End If
        If a6.Image Is imagelist(1) AndAlso b5.Image Is imagelist(1) AndAlso c4.Image Is imagelist(1) AndAlso d3.Image Is imagelist(1) Then
            win = True
        ElseIf b5.Image Is imagelist(1) AndAlso c4.Image Is imagelist(1) AndAlso d3.Image Is imagelist(1) AndAlso e2.Image Is imagelist(1) Then
            win = True
        ElseIf c4.Image Is imagelist(1) AndAlso d3.Image Is imagelist(1) AndAlso e2.Image Is imagelist(1) AndAlso f1.Image Is imagelist(1) Then
            win = True
        End If

        If c6.Image Is imagelist(0) AndAlso d5.Image Is imagelist(0) AndAlso e4.Image Is imagelist(0) AndAlso f3.Image Is imagelist(0) Then
            win = True
        End If
        If c6.Image Is imagelist(1) AndAlso d5.Image Is imagelist(1) AndAlso e4.Image Is imagelist(1) AndAlso f3.Image Is imagelist(1) Then
            win = True
        End If

        If b6.Image Is imagelist(0) AndAlso c5.Image Is imagelist(0) AndAlso d4.Image Is imagelist(0) AndAlso e3.Image Is imagelist(0) Then
            win = True
        ElseIf c5.Image Is imagelist(0) AndAlso d4.Image Is imagelist(0) AndAlso e3.Image Is imagelist(0) AndAlso f2.Image Is imagelist(0) Then
            win = True
        End If
        If b6.Image Is imagelist(1) AndAlso c5.Image Is imagelist(1) AndAlso d4.Image Is imagelist(1) AndAlso e3.Image Is imagelist(1) Then
            win = True
        ElseIf c5.Image Is imagelist(1) AndAlso d4.Image Is imagelist(1) AndAlso e3.Image Is imagelist(1) AndAlso f2.Image Is imagelist(1) Then
            win = True
        End If

        If a4.Image Is imagelist(0) AndAlso b3.Image Is imagelist(0) AndAlso c2.Image Is imagelist(0) AndAlso d1.Image Is imagelist(0) Then
            win = True
        End If
        If a4.Image Is imagelist(1) AndAlso b3.Image Is imagelist(1) AndAlso c2.Image Is imagelist(1) AndAlso d1.Image Is imagelist(1) Then
            win = True
        End If

        If a5.Image Is imagelist(0) AndAlso b4.Image Is imagelist(0) AndAlso c3.Image Is imagelist(0) AndAlso d2.Image Is imagelist(0) Then
            win = True
        ElseIf b4.Image Is imagelist(0) AndAlso c3.Image Is imagelist(0) AndAlso d2.Image Is imagelist(0) AndAlso e1.Image Is imagelist(0) Then
            win = True
        End If
        Return win
    End Function


    Private Sub checkForWin(space As PictureBox)
        Dim form2 As Form = New Form2
        Dim form3 As Form = New Form3

        Dim newwin = CheckColumnsForWin() OrElse CheckRowsForWin() OrElse CheckDiagonalsForWin()

        If newwin Then
            Console.WriteLine("Balls You win!")
            If space.Image Is imagelist(0) Then
                'Console.WriteLine("test")
                Form2.Show()
                Threading.Thread.Sleep(10000)
                Me.Hide()
            End If
            If space.Image Is imagelist(1) Then
                'Console.WriteLine("test2")
                Form3.Show()
                Threading.Thread.Sleep(10000)
                Me.Hide()
            End If
        End If

        'check left to right
        'nested for loops. if i , j == i + 1, j == i+2, j
        Dim win As Boolean = False

        'If a1.Image Is imagelist(0) AndAlso b1.Image Is imagelist(0) AndAlso c1.Image Is imagelist(0) AndAlso d1.Image Is imagelist(0) Then
        '    win = True
        'ElseIf b1.Image Is imagelist(0) AndAlso c1.Image Is imagelist(0) AndAlso d1.Image Is imagelist(0) AndAlso e1.Image Is imagelist(0) Then
        '    win = True
        'ElseIf c1.Image Is imagelist(0) AndAlso d1.Image Is imagelist(0) AndAlso e1.Image Is imagelist(0) AndAlso f1.Image Is imagelist(0) Then
        '    win = True
        'End If
        '
        'If a1.Image Is imagelist(1) AndAlso b1.Image Is imagelist(1) AndAlso c1.Image Is imagelist(1) AndAlso d1.Image Is imagelist(1) Then
        '    win = True
        'ElseIf b1.Image Is imagelist(1) AndAlso c1.Image Is imagelist(1) AndAlso d1.Image Is imagelist(1) AndAlso e1.Image Is imagelist(1) Then
        '    win = True
        'ElseIf c1.Image Is imagelist(1) AndAlso d1.Image Is imagelist(1) AndAlso e1.Image Is imagelist(1) AndAlso f1.Image Is imagelist(1) Then
        '    win = True
        'End If
        '
        'If a2.Image Is imagelist(0) AndAlso b2.Image Is imagelist(0) AndAlso c2.Image Is imagelist(0) AndAlso d2.Image Is imagelist(0) Then
        '    win = True
        'ElseIf b2.Image Is imagelist(0) AndAlso c2.Image Is imagelist(0) AndAlso d2.Image Is imagelist(0) AndAlso e2.Image Is imagelist(0) Then
        '    win = True
        'ElseIf c2.Image Is imagelist(0) AndAlso d2.Image Is imagelist(0) AndAlso e2.Image Is imagelist(0) AndAlso f2.Image Is imagelist(0) Then
        '    win = True
        'End If
        'If a2.Image Is imagelist(1) AndAlso b2.Image Is imagelist(1) AndAlso c2.Image Is imagelist(1) AndAlso d2.Image Is imagelist(1) Then
        '    win = True
        'ElseIf b2.Image Is imagelist(1) AndAlso c2.Image Is imagelist(1) AndAlso d2.Image Is imagelist(1) AndAlso e2.Image Is imagelist(1) Then
        '    win = True
        'ElseIf c2.Image Is imagelist(1) AndAlso d2.Image Is imagelist(1) AndAlso e2.Image Is imagelist(1) AndAlso f2.Image Is imagelist(1) Then
        '    win = True
        'End If
        '
        'If a3.Image Is imagelist(0) AndAlso b3.Image Is imagelist(0) AndAlso c3.Image Is imagelist(0) AndAlso d3.Image Is imagelist(0) Then
        '    win = True
        'ElseIf b3.Image Is imagelist(0) AndAlso c3.Image Is imagelist(0) AndAlso d3.Image Is imagelist(0) AndAlso e3.Image Is imagelist(0) Then
        '    win = True
        'ElseIf c3.Image Is imagelist(0) AndAlso d3.Image Is imagelist(0) AndAlso e3.Image Is imagelist(0) AndAlso f3.Image Is imagelist(0) Then
        '    win = True
        'End If
        'If a3.Image Is imagelist(1) AndAlso b3.Image Is imagelist(1) AndAlso c3.Image Is imagelist(1) AndAlso d3.Image Is imagelist(1) Then
        '    win = True
        'ElseIf b3.Image Is imagelist(1) AndAlso c3.Image Is imagelist(1) AndAlso d3.Image Is imagelist(1) AndAlso e3.Image Is imagelist(1) Then
        '    win = True
        'ElseIf c3.Image Is imagelist(1) AndAlso d3.Image Is imagelist(1) AndAlso e3.Image Is imagelist(1) AndAlso f3.Image Is imagelist(1) Then
        '    win = True
        'End If
        '
        'If a4.Image Is imagelist(0) AndAlso b4.Image Is imagelist(0) AndAlso c4.Image Is imagelist(0) AndAlso d4.Image Is imagelist(0) Then
        '    win = True
        'ElseIf b4.Image Is imagelist(0) AndAlso c4.Image Is imagelist(0) AndAlso d4.Image Is imagelist(0) AndAlso e4.Image Is imagelist(0) Then
        '    win = True
        'ElseIf c4.Image Is imagelist(0) AndAlso d4.Image Is imagelist(0) AndAlso e4.Image Is imagelist(0) AndAlso f4.Image Is imagelist(0) Then
        '    win = True
        'End If
        'If a4.Image Is imagelist(1) AndAlso b4.Image Is imagelist(1) AndAlso c4.Image Is imagelist(1) AndAlso d4.Image Is imagelist(1) Then
        '    win = True
        'ElseIf b4.Image Is imagelist(1) AndAlso c4.Image Is imagelist(1) AndAlso d4.Image Is imagelist(1) AndAlso e4.Image Is imagelist(1) Then
        '    win = True
        'ElseIf c4.Image Is imagelist(1) AndAlso d4.Image Is imagelist(1) AndAlso e4.Image Is imagelist(1) AndAlso f4.Image Is imagelist(1) Then
        '    win = True
        'End If
        '
        'If a5.Image Is imagelist(0) AndAlso b5.Image Is imagelist(0) AndAlso c5.Image Is imagelist(0) AndAlso d5.Image Is imagelist(0) Then
        '    win = True
        'ElseIf b5.Image Is imagelist(0) AndAlso c5.Image Is imagelist(0) AndAlso d5.Image Is imagelist(0) AndAlso e5.Image Is imagelist(0) Then
        '    win = True
        'ElseIf c5.Image Is imagelist(0) AndAlso d5.Image Is imagelist(0) AndAlso e5.Image Is imagelist(0) AndAlso f5.Image Is imagelist(0) Then
        '    win = True
        'End If
        'If a5.Image Is imagelist(1) AndAlso b5.Image Is imagelist(1) AndAlso c5.Image Is imagelist(1) AndAlso d5.Image Is imagelist(1) Then
        '    win = True
        'ElseIf b5.Image Is imagelist(1) AndAlso c5.Image Is imagelist(1) AndAlso d5.Image Is imagelist(1) AndAlso e5.Image Is imagelist(1) Then
        '    win = True
        'ElseIf c5.Image Is imagelist(1) AndAlso d5.Image Is imagelist(1) AndAlso e5.Image Is imagelist(1) AndAlso f5.Image Is imagelist(1) Then
        '    win = True
        'End If
        '
        'If a6.Image Is imagelist(0) AndAlso b6.Image Is imagelist(0) AndAlso c6.Image Is imagelist(0) AndAlso d6.Image Is imagelist(0) Then
        '    win = True
        'ElseIf b6.Image Is imagelist(0) AndAlso c6.Image Is imagelist(0) AndAlso d6.Image Is imagelist(0) AndAlso e6.Image Is imagelist(0) Then
        '    win = True
        'ElseIf c6.Image Is imagelist(0) AndAlso d6.Image Is imagelist(0) AndAlso e6.Image Is imagelist(0) AndAlso f6.Image Is imagelist(0) Then
        '    win = True
        'End If
        'If a6.Image Is imagelist(1) AndAlso b6.Image Is imagelist(1) AndAlso c6.Image Is imagelist(1) AndAlso d6.Image Is imagelist(1) Then
        '    win = True
        'ElseIf b6.Image Is imagelist(1) AndAlso c6.Image Is imagelist(1) AndAlso d6.Image Is imagelist(1) AndAlso e6.Image Is imagelist(1) Then
        '    win = True
        'ElseIf c6.Image Is imagelist(1) AndAlso d6.Image Is imagelist(1) AndAlso e6.Image Is imagelist(1) AndAlso f6.Image Is imagelist(1) Then
        '    win = True
        'End If
        '
        '
        ''Vertical win possibilities
        '
        'If a1.Image Is imagelist(0) AndAlso a2.Image Is imagelist(0) AndAlso a3.Image Is imagelist(0) AndAlso a4.Image Is imagelist(0) Then
        '    win = True
        'ElseIf a2.Image Is imagelist(0) AndAlso a3.Image Is imagelist(0) AndAlso a4.Image Is imagelist(0) AndAlso a5.Image Is imagelist(0) Then
        '    win = True
        'ElseIf a3.Image Is imagelist(0) AndAlso a4.Image Is imagelist(0) AndAlso a5.Image Is imagelist(0) AndAlso a6.Image Is imagelist(0) Then
        '    win = True
        'End If
        'If a1.Image Is imagelist(1) AndAlso a2.Image Is imagelist(1) AndAlso a3.Image Is imagelist(1) AndAlso a4.Image Is imagelist(1) Then
        '    win = True
        'ElseIf a2.Image Is imagelist(1) AndAlso a3.Image Is imagelist(1) AndAlso a4.Image Is imagelist(1) AndAlso a5.Image Is imagelist(1) Then
        '    win = True
        'ElseIf a3.Image Is imagelist(1) AndAlso a4.Image Is imagelist(1) AndAlso a5.Image Is imagelist(1) AndAlso a6.Image Is imagelist(1) Then
        '    win = True
        'End If
        '
        'If b1.Image Is imagelist(0) AndAlso b2.Image Is imagelist(0) AndAlso b3.Image Is imagelist(0) AndAlso b4.Image Is imagelist(0) Then
        '    win = True
        'ElseIf b2.Image Is imagelist(0) AndAlso b3.Image Is imagelist(0) AndAlso b4.Image Is imagelist(0) AndAlso b5.Image Is imagelist(0) Then
        '    win = True
        'ElseIf b3.Image Is imagelist(0) AndAlso b4.Image Is imagelist(0) AndAlso b5.Image Is imagelist(0) AndAlso b6.Image Is imagelist(0) Then
        '    win = True
        'End If
        'If b1.Image Is imagelist(1) AndAlso b2.Image Is imagelist(1) AndAlso b3.Image Is imagelist(1) AndAlso b4.Image Is imagelist(1) Then
        '    win = True
        'ElseIf b2.Image Is imagelist(1) AndAlso b3.Image Is imagelist(1) AndAlso b4.Image Is imagelist(1) AndAlso b5.Image Is imagelist(1) Then
        '    win = True
        'ElseIf b3.Image Is imagelist(1) AndAlso b4.Image Is imagelist(1) AndAlso b5.Image Is imagelist(1) AndAlso b6.Image Is imagelist(1) Then
        '    win = True
        'End If
        '
        'If c1.Image Is imagelist(0) AndAlso c2.Image Is imagelist(0) AndAlso c3.Image Is imagelist(0) AndAlso c4.Image Is imagelist(0) Then
        '    win = True
        'ElseIf c2.Image Is imagelist(0) AndAlso c3.Image Is imagelist(0) AndAlso c4.Image Is imagelist(0) AndAlso c5.Image Is imagelist(0) Then
        '    win = True
        'ElseIf c3.Image Is imagelist(0) AndAlso c4.Image Is imagelist(0) AndAlso c5.Image Is imagelist(0) AndAlso c6.Image Is imagelist(0) Then
        '    win = True
        'End If
        'If c1.Image Is imagelist(1) AndAlso c2.Image Is imagelist(1) AndAlso c3.Image Is imagelist(1) AndAlso c4.Image Is imagelist(1) Then
        '    win = True
        'ElseIf c2.Image Is imagelist(1) AndAlso c3.Image Is imagelist(1) AndAlso c4.Image Is imagelist(1) AndAlso c5.Image Is imagelist(1) Then
        '    win = True
        'ElseIf c3.Image Is imagelist(1) AndAlso c4.Image Is imagelist(1) AndAlso c5.Image Is imagelist(1) AndAlso c6.Image Is imagelist(1) Then
        '    win = True
        'End If
        '
        'If d1.Image Is imagelist(0) AndAlso d2.Image Is imagelist(0) AndAlso d3.Image Is imagelist(0) AndAlso d4.Image Is imagelist(0) Then
        '    win = True
        'ElseIf d2.Image Is imagelist(0) AndAlso d3.Image Is imagelist(0) AndAlso d4.Image Is imagelist(0) AndAlso d5.Image Is imagelist(0) Then
        '    win = True
        'ElseIf d3.Image Is imagelist(0) AndAlso d4.Image Is imagelist(0) AndAlso d5.Image Is imagelist(0) AndAlso d6.Image Is imagelist(0) Then
        '    win = True
        'End If
        'If d1.Image Is imagelist(1) AndAlso d2.Image Is imagelist(1) AndAlso d3.Image Is imagelist(1) AndAlso d4.Image Is imagelist(1) Then
        '    win = True
        'ElseIf d2.Image Is imagelist(1) AndAlso d3.Image Is imagelist(1) AndAlso d4.Image Is imagelist(1) AndAlso d5.Image Is imagelist(1) Then
        '    win = True
        'ElseIf d3.Image Is imagelist(1) AndAlso d4.Image Is imagelist(1) AndAlso d5.Image Is imagelist(1) AndAlso d6.Image Is imagelist(1) Then
        '    win = True
        'End If
        '
        'If e1.Image Is imagelist(0) AndAlso e2.Image Is imagelist(0) AndAlso e3.Image Is imagelist(0) AndAlso e4.Image Is imagelist(0) Then
        '    win = True
        'ElseIf e2.Image Is imagelist(0) AndAlso e3.Image Is imagelist(0) AndAlso e4.Image Is imagelist(0) AndAlso e5.Image Is imagelist(0) Then
        '    win = True
        'ElseIf e3.Image Is imagelist(0) AndAlso e4.Image Is imagelist(0) AndAlso e5.Image Is imagelist(0) AndAlso e6.Image Is imagelist(0) Then
        '    win = True
        'End If
        'If e1.Image Is imagelist(1) AndAlso e2.Image Is imagelist(1) AndAlso e3.Image Is imagelist(1) AndAlso e4.Image Is imagelist(1) Then
        '    win = True
        'ElseIf e2.Image Is imagelist(1) AndAlso e3.Image Is imagelist(1) AndAlso e4.Image Is imagelist(1) AndAlso e5.Image Is imagelist(1) Then
        '    win = True
        'ElseIf e3.Image Is imagelist(1) AndAlso e4.Image Is imagelist(1) AndAlso e5.Image Is imagelist(1) AndAlso e6.Image Is imagelist(1) Then
        '    win = True
        'End If
        '
        'If f1.Image Is imagelist(0) AndAlso f2.Image Is imagelist(0) AndAlso f3.Image Is imagelist(0) AndAlso f4.Image Is imagelist(0) Then
        '    win = True
        'ElseIf f2.Image Is imagelist(0) AndAlso f3.Image Is imagelist(0) AndAlso f4.Image Is imagelist(0) AndAlso f5.Image Is imagelist(0) Then
        '    win = True
        'ElseIf f3.Image Is imagelist(0) AndAlso f4.Image Is imagelist(0) AndAlso f5.Image Is imagelist(0) AndAlso f6.Image Is imagelist(0) Then
        '    win = True
        'End If
        'If f1.Image Is imagelist(1) AndAlso f2.Image Is imagelist(1) AndAlso f3.Image Is imagelist(1) AndAlso f4.Image Is imagelist(1) Then
        '    win = True
        'ElseIf f2.Image Is imagelist(1) AndAlso f3.Image Is imagelist(1) AndAlso f4.Image Is imagelist(1) AndAlso f5.Image Is imagelist(1) Then
        '    win = True
        'ElseIf f3.Image Is imagelist(1) AndAlso f4.Image Is imagelist(1) AndAlso f5.Image Is imagelist(1) AndAlso f6.Image Is imagelist(1) Then
        '    win = True
        'End If

        'diagonal win possibilities

        'If a1.Image Is imagelist(0) AndAlso b2.Image Is imagelist(0) AndAlso c3.Image Is imagelist(0) AndAlso d4.Image Is imagelist(0) Then
        '    win = True
        'ElseIf b2.Image Is imagelist(0) AndAlso c3.Image Is imagelist(0) AndAlso d4.Image Is imagelist(0) AndAlso e5.Image Is imagelist(0) Then
        '    win = True
        'ElseIf c3.Image Is imagelist(0) AndAlso d4.Image Is imagelist(0) AndAlso e5.Image Is imagelist(0) AndAlso f6.Image Is imagelist(0) Then
        '    win = True
        'End If
        'If a1.Image Is imagelist(1) AndAlso b2.Image Is imagelist(1) AndAlso c3.Image Is imagelist(1) AndAlso d4.Image Is imagelist(1) Then
        '    win = True
        'ElseIf b2.Image Is imagelist(1) AndAlso c3.Image Is imagelist(1) AndAlso d4.Image Is imagelist(1) AndAlso e5.Image Is imagelist(1) Then
        '    win = True
        'ElseIf c3.Image Is imagelist(1) AndAlso d4.Image Is imagelist(1) AndAlso e5.Image Is imagelist(1) AndAlso f6.Image Is imagelist(1) Then
        '    win = True
        'End If
        '
        'If a2.Image Is imagelist(0) AndAlso b3.Image Is imagelist(0) AndAlso c4.Image Is imagelist(0) AndAlso d5.Image Is imagelist(0) Then
        '    win = True
        'ElseIf b3.Image Is imagelist(0) AndAlso c3.Image Is imagelist(0) AndAlso d4.Image Is imagelist(0) AndAlso e5.Image Is imagelist(0) Then
        '    win = True
        'End If
        'If a2.Image Is imagelist(1) AndAlso b3.Image Is imagelist(1) AndAlso c4.Image Is imagelist(1) AndAlso d5.Image Is imagelist(1) Then
        '    win = True
        'ElseIf b3.Image Is imagelist(1) AndAlso c3.Image Is imagelist(1) AndAlso d4.Image Is imagelist(1) AndAlso e5.Image Is imagelist(1) Then
        '    win = True
        'End If
        '
        'If a3.Image Is imagelist(0) AndAlso b4.Image Is imagelist(0) AndAlso c5.Image Is imagelist(0) AndAlso d6.Image Is imagelist(0) Then
        '    win = True
        'End If
        'If a3.Image Is imagelist(1) AndAlso b4.Image Is imagelist(1) AndAlso c5.Image Is imagelist(1) AndAlso d6.Image Is imagelist(1) Then
        '    win = True
        'End If
        '
        'If b1.Image Is imagelist(0) AndAlso c2.Image Is imagelist(0) AndAlso d3.Image Is imagelist(0) AndAlso e4.Image Is imagelist(0) Then
        '    win = True
        'ElseIf c2.Image Is imagelist(0) AndAlso d3.Image Is imagelist(0) AndAlso e4.Image Is imagelist(0) AndAlso f5.Image Is imagelist(0) Then
        '    win = True
        'End If
        'If b1.Image Is imagelist(1) AndAlso c2.Image Is imagelist(1) AndAlso d3.Image Is imagelist(1) AndAlso e4.Image Is imagelist(1) Then
        '    win = True
        'ElseIf c2.Image Is imagelist(1) AndAlso d3.Image Is imagelist(1) AndAlso e4.Image Is imagelist(1) AndAlso f5.Image Is imagelist(1) Then
        '    win = True
        'End If
        '
        'If c1.Image Is imagelist(0) AndAlso d2.Image Is imagelist(0) AndAlso e3.Image Is imagelist(0) AndAlso f4.Image Is imagelist(0) Then
        '    win = True
        'End If
        'If c1.Image Is imagelist(1) AndAlso d2.Image Is imagelist(1) AndAlso e3.Image Is imagelist(1) AndAlso f4.Image Is imagelist(1) Then
        '    win = True
        'End If
        '
        'If a6.Image Is imagelist(0) AndAlso b5.Image Is imagelist(0) AndAlso c4.Image Is imagelist(0) AndAlso d3.Image Is imagelist(0) Then
        '    win = True
        'ElseIf b5.Image Is imagelist(0) AndAlso c4.Image Is imagelist(0) AndAlso d3.Image Is imagelist(0) AndAlso e2.Image Is imagelist(0) Then
        '    win = True
        'ElseIf c4.Image Is imagelist(0) AndAlso d3.Image Is imagelist(0) AndAlso e2.Image Is imagelist(0) AndAlso f1.Image Is imagelist(0) Then
        '    win = True
        'End If
        'If a6.Image Is imagelist(1) AndAlso b5.Image Is imagelist(1) AndAlso c4.Image Is imagelist(1) AndAlso d3.Image Is imagelist(1) Then
        '    win = True
        'ElseIf b5.Image Is imagelist(1) AndAlso c4.Image Is imagelist(1) AndAlso d3.Image Is imagelist(1) AndAlso e2.Image Is imagelist(1) Then
        '    win = True
        'ElseIf c4.Image Is imagelist(1) AndAlso d3.Image Is imagelist(1) AndAlso e2.Image Is imagelist(1) AndAlso f1.Image Is imagelist(1) Then
        '    win = True
        'End If
        '
        'If c6.Image Is imagelist(0) AndAlso d5.Image Is imagelist(0) AndAlso e4.Image Is imagelist(0) AndAlso f3.Image Is imagelist(0) Then
        '    win = True
        'End If
        'If c6.Image Is imagelist(1) AndAlso d5.Image Is imagelist(1) AndAlso e4.Image Is imagelist(1) AndAlso f3.Image Is imagelist(1) Then
        '    win = True
        'End If
        '
        'If b6.Image Is imagelist(0) AndAlso c5.Image Is imagelist(0) AndAlso d4.Image Is imagelist(0) AndAlso e3.Image Is imagelist(0) Then
        '    win = True
        'ElseIf c5.Image Is imagelist(0) AndAlso d4.Image Is imagelist(0) AndAlso e3.Image Is imagelist(0) AndAlso f2.Image Is imagelist(0) Then
        '    win = True
        'End If
        'If b6.Image Is imagelist(1) AndAlso c5.Image Is imagelist(1) AndAlso d4.Image Is imagelist(1) AndAlso e3.Image Is imagelist(1) Then
        '    win = True
        'ElseIf c5.Image Is imagelist(1) AndAlso d4.Image Is imagelist(1) AndAlso e3.Image Is imagelist(1) AndAlso f2.Image Is imagelist(1) Then
        '    win = True
        'End If
        '
        'If a4.Image Is imagelist(0) AndAlso b3.Image Is imagelist(0) AndAlso c2.Image Is imagelist(0) AndAlso d1.Image Is imagelist(0) Then
        '    win = True
        'End If
        'If a4.Image Is imagelist(1) AndAlso b3.Image Is imagelist(1) AndAlso c2.Image Is imagelist(1) AndAlso d1.Image Is imagelist(1) Then
        '    win = True
        'End If
        '
        'If a5.Image Is imagelist(0) AndAlso b4.Image Is imagelist(0) AndAlso c3.Image Is imagelist(0) AndAlso d2.Image Is imagelist(0) Then
        '    win = True
        'ElseIf b4.Image Is imagelist(0) AndAlso c3.Image Is imagelist(0) AndAlso d2.Image Is imagelist(0) AndAlso e1.Image Is imagelist(0) Then
        '    win = True
        'End If

        'Dim winner As PictureBox
        'If win = True Then
        '    winner = space
        '    If space.Contains(My.Resou) Then
        '    End If

    End Sub

    Private Sub a2_Click(sender As Object, e As EventArgs) Handles a2.Click, b2.Click, c2.Click, d2.Click, e2.Click, f2.Click
        For i As Integer = 5 To 0 Step -1
            Dim img As PictureBox = TableLayoutPanel1.GetControlFromPosition(1, i)
            If img.Image Is Nothing Then
                moveTurn(img)
                Exit For
            End If
        Next
    End Sub

    Private Sub a3_Click(sender As Object, e As EventArgs) Handles a3.Click, b3.Click, c3.Click, d3.Click, e3.Click, f3.Click
        For i As Integer = 5 To 0 Step -1
            Dim img As PictureBox = TableLayoutPanel1.GetControlFromPosition(2, i)
            If img.Image Is Nothing Then
                moveTurn(img)
                Exit For
            End If
        Next
    End Sub

    Private Sub a4_Click(sender As Object, e As EventArgs) Handles a4.Click, b4.Click, c4.Click, d4.Click, e4.Click, f4.Click
        For i As Integer = 5 To 0 Step -1
            Dim img As PictureBox = TableLayoutPanel1.GetControlFromPosition(3, i)
            If img.Image Is Nothing Then
                moveTurn(img)
                Exit For
            End If
        Next
    End Sub

    Private Sub a5_Click(sender As Object, e As EventArgs) Handles a5.Click, b5.Click, c5.Click, d5.Click, e5.Click, f5.Click
        For i As Integer = 5 To 0 Step -1
            Dim img As PictureBox = TableLayoutPanel1.GetControlFromPosition(4, i)
            If img.Image Is Nothing Then
                moveTurn(img)
                Exit For
            End If
        Next
    End Sub

    Private Sub a6_Click(sender As Object, e As EventArgs) Handles a6.Click, b6.Click, c6.Click, d6.Click, e6.Click, f6.Click
        For i As Integer = 5 To 0 Step -1
            Dim img As PictureBox = TableLayoutPanel1.GetControlFromPosition(5, i)
            If img.Image Is Nothing Then
                moveTurn(img)
                Exit For
            End If
        Next
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class


