Imports System

Module Program
    Sub Main(args As String())
        'Declaración de variables
        Dim radio, area As Single
        'Entrada
        Console.Write("Ingrese el radio dé un círculo: ")
        radio = Console.ReadLine()
        'Proceso
        area = Math.PI * radio ^ 2
        'Salida
        Console.WriteLine("area = Pi.r^2 => {0}.{1}^2 = {2}", Math.PI, radio, area)
    End Sub
End Module
