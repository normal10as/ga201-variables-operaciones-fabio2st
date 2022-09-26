Imports System

Module Program
    Sub Main(args As String())
        Dim numero As Single
        Console.Write("Ingrese un número real: ")
        numero = Console.ReadLine()
        Console.WriteLine("El valor aproximado por exceso de " & numero & " es: " & Math.Ceiling(numero))
        Console.WriteLine("El valor aproximado por defecto de " & numero & " es: " & Math.Floor(numero))
        Console.WriteLine("El valor redondeado de " & numero & " es: " & Math.Round(numero))
    End Sub
End Module
