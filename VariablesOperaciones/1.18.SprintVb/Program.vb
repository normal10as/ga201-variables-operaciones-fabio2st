Imports System

Module Program
    Sub Main(args As String())
        Dim dia, mes, a�o, hora, minutos, cantidadHora As UShort
        Console.WriteLine("Ingrese la fecha y hora inicial: ")
        Console.Write("Ingrese dia: ")
        dia = Console.ReadLine()
        Console.Write("Ingrese mes: ")
        mes = Console.ReadLine()
        Console.Write("Ingrese anio: ")
        a�o = Console.ReadLine()
        Console.Write("Ingrese hora: ")
        hora = Console.ReadLine()
        Console.Write("Ingrese minutos: ")
        minutos = Console.ReadLine()

        Dim fecha = New DateTime(a�o, mes, dia, hora, minutos, 0)

        Console.Write("Ingrese el n�mero de hora a sumar: ")
        cantidadHora = Console.ReadLine()

        Console.WriteLine("Fecha final: " & fecha.AddHours(cantidadHora))
    End Sub
End Module
