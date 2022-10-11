ushort dia, mes, año, hora, minutos, cantidadHora;
Console.WriteLine("Ingrese la fecha y hora inicial: ");
Console.Write("Ingrese dia: ");
dia = Convert.ToUInt16(Console.ReadLine());
Console.Write("Ingrese mes: ");
mes = Convert.ToUInt16(Console.ReadLine());
Console.Write("Ingrese anio: ");
año = Convert.ToUInt16(Console.ReadLine());
Console.Write("Ingrese hora: ");
hora = Convert.ToUInt16(Console.ReadLine());
Console.Write("Ingrese minutos: ");
minutos = Convert.ToUInt16(Console.ReadLine());

var fecha = new DateTime(año, mes, dia, hora, minutos, 0);

Console.Write("Ingrese el número de hora a sumar: ");
cantidadHora = Convert.ToUInt16(Console.ReadLine());

Console.WriteLine("Fecha final: " + fecha.AddHours(cantidadHora));
