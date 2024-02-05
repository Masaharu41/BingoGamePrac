Module Game2
    Sub NewGame()

    End Sub

    Sub DrawBall()

    End Sub

    Sub Display()

        Dim temp(14, 4) As Boolean

        temp(7, 3) = True
        temp(3, 4) = True
        For row = 0 To 14
            For column = 0 To 4
                If temp(row, column) Then
                    Console.Write($"X C")
                Else
                    Console.Write("/")
                End If
            Next
            Console.WriteLine()
        Next
    End Sub
End Module
