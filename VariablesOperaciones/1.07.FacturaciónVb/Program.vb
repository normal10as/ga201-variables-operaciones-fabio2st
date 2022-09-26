Imports System

Module Program
    Sub Main(args As String())
        'Declaración de variables
        Dim costo, precio, utilidad, impuesto, utilidadPorcentaje As Decimal
        Const impuestoPorcentaje As Decimal = 21
        'Entrada
        Console.Write("Costo: ")
        costo = Console.ReadLine()
        Console.Write("Porcentaje de utilidad: ")
        utilidadPorcentaje = Console.ReadLine()
        'Proceso
        utilidad = costo * utilidadPorcentaje / 100
        precio = costo + utilidad
        impuesto = precio * impuestoPorcentaje / 100
        precio += impuesto
        'Salida
        Console.WriteLine("Costo:    " & costo)  ' no estaba en el requerimiento
        Console.WriteLine("Utilidad: " & utilidad)
        Console.WriteLine("Impuesto: " & impuesto)
        Console.WriteLine("Precio:   " & precio)
    End Sub
End Module
