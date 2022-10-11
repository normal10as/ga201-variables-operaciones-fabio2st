using System;
static class Program
{
    public static void Main(string[] args)
    {
        string cadena;
        Console.Write("Ingrese una frase de al menos tres palabras: ");
        cadena = Console.ReadLine();

        Console.WriteLine("La longitud de la cadena es: " + cadena.Length + " caracteres.");
        Console.WriteLine("La primera letra es: " + cadena[0]);
        Console.WriteLine("La última letra es: " + cadena[cadena.Length - 1]);

        const char letra = 'o';
        Console.WriteLine("La primera '{0}' aparece en la {1}º posición.", letra, cadena.IndexOf(letra) + 1);

        byte segundaPalabraStart = (byte)(cadena.IndexOf(" ") + 1);
        byte ultimaPalabraStart = (byte)(cadena.LastIndexOf(" ") + 1);

        string ultimaPalabra = cadena.Substring(ultimaPalabraStart);
        cadena = cadena.Remove(ultimaPalabraStart);
        cadena = cadena.Insert(segundaPalabraStart, ultimaPalabra + " ");
        Console.WriteLine("La última palabra ahora es la segunda: " + cadena);
    }
}