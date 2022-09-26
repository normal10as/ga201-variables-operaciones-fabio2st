// Declaración y asignación de variables
uint ancho, longitud;
decimal costoMetroCuadrado, costoTotal;
//Entradas
Console.Write("Ingrese el ancho del terreno: ");
ancho = Convert.ToUInt32(Console.ReadLine());
Console.Write("Ingrese la longitud del terreno: ");
longitud = Convert.ToUInt32(Console.ReadLine());
Console.Write("Ingrese el precio del metro cuadrado: ");
costoMetroCuadrado = Convert.ToInt32(Console.ReadLine());
//Procesos
costoTotal = ancho * longitud * costoMetroCuadrado;
//Salidas
Console.WriteLine("Valor cotización: $" + costoTotal);
