float numero;
Console.Write("Ingrese un número real: ");
numero = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("El valor aproximado por exceso de " + numero + " es: " + Math.Ceiling(numero));
Console.WriteLine("El valor aproximado por defecto de " + numero + " es: " + Math.Floor(numero));
Console.WriteLine("El valor redondeado de " + numero + " es: " + Math.Round(numero));
