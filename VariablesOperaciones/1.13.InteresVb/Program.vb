Imports System

Module Program
    Sub Main(args As String())
        Dim dias As UInteger
        Dim montoInicial, interesProducido, interesAnual, capitalAcumulado As Decimal

        Console.Write("Ingrese el Monto: ")
        montoInicial = Console.ReadLine()

        Console.Write("Ingrese el Interes anual: ")
        interesAnual = Console.ReadLine()

        Console.Write("Ingrese la Cantidad de Dias: ")
        dias = Console.ReadLine()

        interesProducido = montoInicial * interesAnual * dias / (360 * 100)
        capitalAcumulado = montoInicial + interesProducido
        Console.WriteLine($"Interes Producido: ${interesProducido:F}")
        Console.WriteLine($"Capital acumulado: ${capitalAcumulado:F}")
    End Sub
End Module
