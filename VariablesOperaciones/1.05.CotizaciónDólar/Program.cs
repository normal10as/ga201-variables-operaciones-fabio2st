//Declaración de variables
decimal montoDolar, costoDolar, montoPesos;
//Entrada
Console.Write("Ingrese monto en dólares: ");
montoDolar = Convert.ToDecimal(Console.ReadLine());
Console.Write("Costo dólar: ");
costoDolar = Convert.ToDecimal(Console.ReadLine());
//Proceso
montoPesos = montoDolar * costoDolar;
//Salida
Console.WriteLine("Pago en pesos: " + montoPesos);
