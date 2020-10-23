Imports System

Module Program
    Sub Main(args As String())

       'Demonstration of Arrays
        Dim array(9) As Integer

        'Initiate Loop
        For counter = 0 To 9 'Remember in VB, arrays Start at 0

            'Set values of the array to the counter
            array(counter) = counter + 1

            'Display Results
            Console.WriteLine(array(counter))
        Next
    End Sub
End Module
