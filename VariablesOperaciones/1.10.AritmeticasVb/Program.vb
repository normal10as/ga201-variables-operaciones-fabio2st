Imports System

Module Program
    Sub Main(args As String())
        Dim numero As Integer
        Console.Write("Ingrese un numero: ")
        numero = Console.ReadLine()
        Console.WriteLine("Resto de {0} / 2: {1}", numero, numero Mod 2)
        Console.WriteLine("Valor absoluto de {0}: {1}", numero, Math.Abs(numero))
        Console.WriteLine("Decima potencia de {0}: {1}", numero, numero ^ 10)
        Console.WriteLine("Raiz cuadrada de {0}: {1}", numero, Math.Sqrt(numero))
    End Sub
End Module
