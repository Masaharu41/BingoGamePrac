Module Game2
    Sub NewGame()

    End Sub

    Sub DrawBall()

    End Sub

    Sub UpdateTracker()

    End Sub

    Sub Display()

        Dim temp(14, 4) As Boolean

        Dim header() = {"B", "I", "N", "G", "O"}

        For Each letter In header
            Console.Write(letter.PadLeft(2).PadRight(4))
        Next
        Console.WriteLine()
        temp(7, 3) = True
        temp(3, 4) = True
        For row = 0 To 14
            For column = 0 To 4
                If temp(row, column) Then
                    Console.Write($"X C")
                Else
                    Console.Write("   /")
                End If
            Next
            Console.WriteLine()
        Next
    End Sub
End Module
