int numero1, numero2, numero3, numero4;
int sumatoria;

Console.Write("Ingrese el primer numero: ");
numero1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese el segundo numero: ");
numero2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese el tercer numero: ");
numero3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese el cuarto numero: ");
numero4 = Convert.ToInt32(Console.ReadLine());

sumatoria = numero1 + numero2 + numero3 + numero4;
Console.WriteLine("La sumatoria es: {0}", sumatoria);
Console.WriteLine("La media es: {0}", sumatoria / 4f);
