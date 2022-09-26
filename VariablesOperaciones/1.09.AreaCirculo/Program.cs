//Declaración de variables
float radio, area;
//Entrada
Console.Write("Ingrese el radio dé un círculo: ");
radio = Convert.ToSingle(Console.ReadLine());
//Proceso
area = (Single)(Math.PI * Math.Pow(radio, 2));
//Salida
Console.WriteLine("area = Pi.r^2 => {0}.{1}^2 = {2}", Math.PI, radio, area);
