Imports System

Module Program
    Sub Main(args As String())
        'Declaraci�n de variables
        Dim montoDolar, costoDolar, montoPesos As Decimal
        'Entrada
        Console.Write("Ingrese monto en d�lares: ")
        montoDolar = Console.ReadLine()
        Console.Write("Costo d�lar: ")
        costoDolar = Console.ReadLine()
        'Proceso
        montoPesos = montoDolar * costoDolar
        'Salida
        Console.WriteLine("Pago en pesos: " & montoPesos)
    End Sub
End Module
