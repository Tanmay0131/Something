Module Module1
    Public Sub Main()
        Start()
    End Sub
    Public Sub Start()
        Console.WriteLine("What's player 1's name?")
        Dim player1 As String = Console.ReadLine()
        Console.WriteLine("What's player 2's name?")
        Dim player2 As String = Console.ReadLine()
        Dim f1 As Form = New frmMain
        f1.Show()

    End Sub
End Module
