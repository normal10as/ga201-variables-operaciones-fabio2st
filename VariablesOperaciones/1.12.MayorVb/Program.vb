Imports System

Module Program
    Sub Main(args As String())
        Dim numero1, numero2, numero3 As Integer

        Console.Write("N�mero 1: ")
        numero1 = Console.ReadLine()

        Console.Write("N�mero 2: ")
        numero2 = Console.ReadLine()

        Console.Write("N�mero 3: ")
        numero3 = Console.ReadLine()

        Console.WriteLine("El n�mero mayor es: " & Math.Max(numero1, Math.Max(numero2, numero3)))
    End Sub
End Module
