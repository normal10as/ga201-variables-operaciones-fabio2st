Imports System

Module Program
    Sub Main(args As String())
        'Declaraci�n de variables
        Dim segundos As UShort
        Dim distancia As ULong
        Const velocidadLuz = 300000
        'Entrada
        Console.Write("Ingrese n�mero de segundos: ")
        segundos = Console.ReadLine()
        'Proceso
        distancia = segundos * velocidadLuz
        'Salida
        Console.WriteLine("En {0} segundos, la luz recorre {1} Kilometros.", segundos, distancia)
    End Sub
End Module
