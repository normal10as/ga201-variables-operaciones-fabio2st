Imports System

Module Program
    Sub Main(args As String())
        Dim cadena, palabra1, palabra2, palabra3 As String
        Dim espacio, maximaLongitud As Integer

        Console.Write("Por favor ingrese tres palabras: ")
        cadena = Console.ReadLine()

        espacio = cadena.IndexOf(" ")
        palabra1 = cadena.Substring(0, espacio)
        cadena = cadena.Substring(espacio + 1)
        espacio = cadena.IndexOf(" ")
        palabra2 = cadena.Substring(0, espacio)
        palabra3 = cadena.Substring(espacio + 1)

        maximaLongitud = Math.Max(palabra1.Length, palabra2.Length)
        maximaLongitud = Math.Max(maximaLongitud, palabra3.Length)

        Console.WriteLine("La palabra mas larga tiene " & maximaLongitud & " caracteres")
    End Sub
End Module
