'Bingo Game
'Spring 2024

Option Strict On
Option Explicit On
Option Compare Text

'TODO
'[] Start New Game
'[] Draw One Ball
'[] Track Drawn Ball
'[] Display Ball #
'[] Draw Two Ball
'[] Repeat but no repeat balls can be displayed
Module BingoGame

    Sub Main()
        Dim userInput As String
        Dim tracker(14, 4) As Boolean ' each letter had 15 unique #

        Do
            Game2.NewGame()
            Console.Clear()
            Game2.Display()
            Console.WriteLine("Prompt")
            userInput = Console.ReadLine()
        Loop Until userInput = "q"
        Console.Read()
    End Sub

End Module
