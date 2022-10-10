Imports System

Module Program
    Sub Main(args As String())
        Dim numero1, numero2, numero3 As Integer

        Console.Write("Número 1: ")
        numero1 = Console.ReadLine()

        Console.Write("Número 2: ")
        numero2 = Console.ReadLine()

        Console.Write("Número 3: ")
        numero3 = Console.ReadLine()

        Console.WriteLine("El número mayor es: " & Math.Max(numero1, Math.Max(numero2, numero3)))
    End Sub
End Module
