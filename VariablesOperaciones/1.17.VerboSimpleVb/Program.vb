Imports System

Module Program
    Sub Main(args As String())
        Console.Write("Ingrese un verbo regular de primera o segunda conjugación: ")
        Dim verbo As String
        verbo = Console.ReadLine()
        Dim raiz, terminacion, terminacionAux As String
        Dim longitud As Byte
        Console.WriteLine("Verbo: {0}", verbo)
        longitud = verbo.Length
        raiz = verbo.Substring(0, longitud - 2)
        terminacion = verbo.Substring(longitud - 2, 1)
        Console.WriteLine("Yo {0}o", raiz)
        Console.WriteLine("Tu {0}{1}s", raiz, terminacion.Replace("i", "e"))
        Console.WriteLine("El/ella {0}{1}", raiz, terminacion.Replace("i", "e"))
        Console.WriteLine("Nosotros {0}{1}mos", raiz, terminacion)
        terminacionAux = terminacion.Replace("a", "ái")
        terminacionAux = terminacionAux.Replace("e", "éi")
        terminacionAux = terminacionAux.Replace("i", "í")
        Console.WriteLine("Vosotros {0}{1}s", raiz, terminacionAux)
        Console.WriteLine("Ustedes {0}{1}n", raiz, terminacion.Replace("i", "e"))
        Console.WriteLine("Ellos/ellas {0}{1}n", raiz, terminacion.Replace("i", "e"))
        Console.WriteLine()
    End Sub
End Module
