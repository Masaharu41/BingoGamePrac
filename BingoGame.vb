Option Strict On
Option Explicit On
Option Compare Text
'Bingo Game
'Spring 2024

Imports System.Net.Http



'TODO
'[*] Start New Game
'[*] Draw One Ball
'[*] Track Drawn Ball
'[*] Display Ball #
'[*] Draw Two Ball
'[*] Repeat but no repeat balls can be displayed
Module BingoGame

    Sub Main()
        Dim userInput As String
        Dim tracker(14, 4) As Boolean ' each letter had 15 unique #
        Dim ballsDrawn As Integer = 0
        Dim message As String = "Hello There!"
        Game2.NewGame(tracker)
        Do
            Console.Clear()
            Game2.Display(tracker)
            Console.WriteLine(message)
            userInput = Console.ReadLine()
            If userInput = "n" Then
                Game2.NewGame(tracker)
            Else
                If ballsDrawn >= 75 Then
                    message = "All balls have been drawn"
                    Exit Do

                Else
                    Game2.DrawBall(tracker)
                    ballsDrawn += 1
                    message = "Press enter to draw, N for new game, or Q for quit"
                End If
            End If


        Loop Until userInput = "q"
        Console.WriteLine("Have a Nice Day!")
        Console.Read()
    End Sub

End Module
