Imports System

Module Program
    Sub Main(args As String())
        ' Declaraci�n y asignaci�n de variables
        Dim ancho, longitud As Integer
        Dim costoMetroCuadrado, costoTotal As Decimal
        'Entradas
        Console.Write("Ingrese el ancho del terreno: ")
        ancho = Console.ReadLine()
        Console.Write("Ingrese la longitud del terreno: ")
        longitud = Console.ReadLine()
        Console.Write("Ingrese el precio del metro cuadrado: ")
        costoMetroCuadrado = Console.ReadLine()
        'Procesos
        costoTotal = ancho * longitud * costoMetroCuadrado
        'Salidas
        Console.WriteLine("Valor cotizaci�n: $" & costoTotal)
    End Sub
End Module
