uint dias;
decimal montoInicial, interesProducido, interesAnual, capitalAcumulado;

Console.Write("Ingrese el Monto: ");
montoInicial = Convert.ToDecimal(Console.ReadLine());
Console.Write("Ingrese el Interes anual: ");
interesAnual = Convert.ToDecimal(Console.ReadLine());
Console.Write("Ingrese la Cantidad de Dias: ");
dias = Convert.ToUInt32(Console.ReadLine());

interesProducido = montoInicial * interesAnual * dias / (360 * 100);
capitalAcumulado = montoInicial + interesProducido;
Console.WriteLine($"Interes Producido: ${interesProducido:F}");
Console.WriteLine($"Capital acumulado: ${capitalAcumulado:F}");
