int numero;
Console.Write("Ingrese un numero: ");
numero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Resto de {0} / 2: {1}", numero, numero % 2);
Console.WriteLine("Valor absoluto de {0}: {1}", numero, Math.Abs(numero));
Console.WriteLine("Decima potencia de {0}: {1}", numero, Math.Pow(numero, 10d));
Console.WriteLine("Raiz cuadrada de {0}: {1}", numero, Math.Sqrt(numero));
