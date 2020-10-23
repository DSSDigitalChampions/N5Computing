Imports System

Module Program
    Sub Main(args As String())

        'Guess the Number Game.

        'Variable Declarations
        Dim answer As Integer
        Dim guess As Integer
        Dim guessed As Boolean
        Dim attempts As Integer

        attempts = 3

        'Initializes the randomizer
        Randomize()

        'Random Number Between 1 and 10
        answer = Int((10 * Rnd()) + 1)

        'Asks for guesses, with 3 attemps
        Do

            Console.WriteLine("Please pick a number between 1 and 10, you have " & attempts & " attempt(s) left.")

            'Gets user input
            guess = Console.ReadLine

            'Input Validation
            If guess <= 0 Or guess >= 11 Then
                Console.WriteLine("Invalid answer - Number must be between 1 and 10")
                attempts = attempts + 1 'Add one to tries so it doesn't remove the invalid attempt
            End If

            'Check answer
            If guess = answer Then
                guessed = True
            Else
                attempts = attempts - 1
            End If

        Loop Until guessed = True Or attempts = 0

        'Displays if you won or not
        If guessed = True Then
            Console.WriteLine("Congratulations! You gussed the right number!")
        Else
            Console.WriteLine("Sorry, you were unable to guess the right number.")
        End If
    End Sub
End Module
