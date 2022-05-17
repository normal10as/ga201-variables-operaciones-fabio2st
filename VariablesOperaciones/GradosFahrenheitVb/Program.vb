Imports System

Module Program
    Sub Main(args As String())
        ' Declaracion de variables
        Dim temperaturaCelcius As Single
        Dim temperaturaFahrenheit As Single
        ' Ingreso de datos
        Console.Write("Ingrese la temperatura en grados celcius: ")
        temperaturaCelcius = Console.ReadLine()
        ' proceso
        temperaturaFahrenheit = temperaturaCelcius * 1.8 + 32
        'salida
        Console.WriteLine($"Equivale a {temperaturaFahrenheit} grados fahrenheit")
    End Sub
End Module
