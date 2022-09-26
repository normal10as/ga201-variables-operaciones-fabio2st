decimal costo, precio, utilidad, impuesto, utilidadPorcentaje;
const decimal impuestoPorcentaje = 21;
//Entrada
Console.Write("Costo: ");
costo = Convert.ToDecimal(Console.ReadLine());
Console.Write("Porcentaje de utilidad: ");
utilidadPorcentaje = Convert.ToDecimal(Console.ReadLine());
//Proceso
utilidad = costo * utilidadPorcentaje / 100;
precio = costo + utilidad;
impuesto = precio * impuestoPorcentaje / 100;
precio += impuesto;
//Salida
Console.WriteLine("Costo:    " + costo);  // no estaba en el requerimiento
Console.WriteLine("Utilidad: " + utilidad);
Console.WriteLine("Impuesto: " + impuesto);
Console.WriteLine("Precio:   " + precio);
