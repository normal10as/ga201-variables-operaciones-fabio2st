﻿string cadena, palabra1, palabra2, palabra3;
int espacio, maximaLongitud;

Console.Write("Por favor ingrese tres palabras: ");
cadena = Console.ReadLine();

espacio = cadena.IndexOf(" ");
palabra1 = cadena.Substring(0, espacio);
cadena = cadena.Substring(espacio + 1);

espacio = cadena.IndexOf(" ");
palabra2 = cadena.Substring(0, espacio);
palabra3 = cadena.Substring(espacio + 1);

maximaLongitud = Math.Max(palabra1.Length, palabra2.Length);
maximaLongitud = Math.Max(maximaLongitud, palabra3.Length);

Console.WriteLine("La palabra mas larga tiene " + maximaLongitud + " caracteres");
