Imports System
Imports System.IO

Module Program
    Sub Main(args As String())
        'Declaración de variables
        Const piePulgadas As Byte = 12
        Const yardaPies As Byte = 3
        Const pulgadaCms As Decimal = 2.54
        Const metroCms As Byte = 100
        Dim pies As UInteger
        Dim pulgadas, yardas, cms, metros As Decimal
        'Entrada
        Console.Write("Ingrese medida en pies: ")
        pies = Console.ReadLine()
        'Proceso
        pulgadas = pies * piePulgadas
        yardas = pies / yardaPies
        cms = pulgadas * pulgadaCms
        metros = cms / metroCms
        'Salida
        Console.WriteLine("Equivale a {0} pulgadas", pulgadas)
        Console.WriteLine("Equivale a {0} yardas", yardas)
        Console.WriteLine("Equivale a {0} centimetros", cms)
        Console.WriteLine("Equivale a {0} metros", metros)
    End Sub
End Module
