Imports System

Module Program
    Sub Main(args As String())
        Dim dia, mes, año, hora, minutos, cantidadHora As UShort
        Console.WriteLine("Ingrese la fecha y hora inicial: ")
        Console.Write("Ingrese dia: ")
        dia = Console.ReadLine()
        Console.Write("Ingrese mes: ")
        mes = Console.ReadLine()
        Console.Write("Ingrese anio: ")
        año = Console.ReadLine()
        Console.Write("Ingrese hora: ")
        hora = Console.ReadLine()
        Console.Write("Ingrese minutos: ")
        minutos = Console.ReadLine()

        Dim fecha = New DateTime(año, mes, dia, hora, minutos, 0)

        Console.Write("Ingrese el número de hora a sumar: ")
        cantidadHora = Console.ReadLine()

        Console.WriteLine("Fecha final: " & fecha.AddHours(cantidadHora))
    End Sub
End Module
