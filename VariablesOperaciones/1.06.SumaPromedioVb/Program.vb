Imports System

Module Program
    Sub Main(args As String())
        Dim numero1, numero2, numero3, numero4 As Integer
        Dim sumatoria As Integer
        Console.Write("Ingrese el primer numero: ")
        numero1 = Console.ReadLine()

        Console.Write("Ingrese el segundo numero: ")
        numero2 = Console.ReadLine()

        Console.Write("Ingrese el tercer numero: ")
        numero3 = Console.ReadLine()

        Console.Write("Ingrese el cuarto numero: ")
        numero4 = Console.ReadLine()

        sumatoria = numero1 + numero2 + numero3 + numero4
        Console.WriteLine("La suma es: {0}", sumatoria)
        Console.WriteLine("La media es: {0}", sumatoria / 4)
    End Sub
End Module
