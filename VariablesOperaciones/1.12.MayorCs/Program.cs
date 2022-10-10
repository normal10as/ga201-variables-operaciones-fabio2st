int numero1, numero2, numero3;
Console.Write("Número 1: ");
numero1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Número 2: ");
numero2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Número 3: ");
numero3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("El número mayor es: " + Math.Max(numero1, Math.Max(numero2, numero3)));
