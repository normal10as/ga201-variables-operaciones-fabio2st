Imports System

Module Program
    Sub Main(args As String())
        'Declaración de variables
        Dim montoDolar, costoDolar, montoPesos As Decimal
        'Entrada
        Console.Write("Ingrese monto en dólares: ")
        montoDolar = Console.ReadLine()
        Console.Write("Costo dólar: ")
        costoDolar = Console.ReadLine()
        'Proceso
        montoPesos = montoDolar * costoDolar
        'Salida
        Console.WriteLine("Pago en pesos: " & montoPesos)
    End Sub
End Module
