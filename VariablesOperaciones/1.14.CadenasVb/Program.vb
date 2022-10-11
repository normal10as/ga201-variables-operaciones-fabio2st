Imports System

Module Program
    Sub Main(args As String())
        Dim cadena As String
        Console.Write("Ingrese una frase de al menos tres palabras: ")
        cadena = Console.ReadLine()

        Console.WriteLine("La longitud de la cadena es: " & cadena.Length & " caracteres.")
        Console.WriteLine("La primera letra es: " & cadena(0))
        Console.WriteLine("La última letra es: " & cadena(cadena.Length - 1))

        Const letra As Char = "o"
        Console.WriteLine("La primera '{0}' aparece en la {1}º posición.", letra, cadena.IndexOf(letra) + 1)

        Dim segundaPalabraStart As Byte = cadena.IndexOf(" ") + 1
        Dim ultimaPalabraStart As Byte = cadena.LastIndexOf(" ") + 1

        Dim ultimaPalabra As String = cadena.Substring(ultimaPalabraStart)
        cadena = cadena.Remove(ultimaPalabraStart)
        cadena = cadena.Insert(segundaPalabraStart, ultimaPalabra + " ")
        Console.WriteLine("La última palabra ahora es la segunda: " & cadena)
    End Sub
End Module
