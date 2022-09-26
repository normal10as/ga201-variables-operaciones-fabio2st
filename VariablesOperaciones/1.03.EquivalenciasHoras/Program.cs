//Declaración de variables
ushort horas;
uint minutos;
uint segundos;
ushort dias;
//Entrada
Console.Write("Ingrese cantidad horas: ");
horas = Convert.ToUInt16(Console.ReadLine());
//Proceso
minutos = (uint)horas * 60;
segundos = minutos * 60;
dias = (ushort)(horas / 24);
//Salida
Console.WriteLine("Equivale a {0} segundos", segundos);
Console.WriteLine("Equivale a {0} minutos", minutos);
Console.WriteLine("Equivale a {0} dias", dias);
