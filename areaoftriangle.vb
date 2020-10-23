Imports System

Module Program
    Sub Main(args As String())

        'Simple area of a triangle example.

        'Variable Declaration
        Dim length As Single
        Dim breadth As Single
        Dim area As Single

        Console.WriteLine("Please enter length")
        length = Console.ReadLine

        Console.WriteLine("Please enter breadth")
        breadth = Console.ReadLine

        area = length * breadth
        Console.WriteLine(area)
    End Sub
End Module
