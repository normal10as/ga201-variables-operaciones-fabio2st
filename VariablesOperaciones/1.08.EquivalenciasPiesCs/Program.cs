//Declaración de variables
const byte piePulgadas = 12;
const byte yardaPies = 3;
const decimal pulgadaCms = 2.54M;
const byte metroCms = 100;
uint pies;
decimal pulgadas, yardas, cms, metros;
//Entrada
Console.Write("Ingrese medida en pies: ");
pies = Convert.ToUInt32(Console.ReadLine());
//Proceso
pulgadas = pies * piePulgadas;
yardas = pies / yardaPies;
cms = pulgadas * pulgadaCms;
metros = cms / metroCms;
//Salida
Console.WriteLine("Equivale a {0} pulgadas", pulgadas);
Console.WriteLine("Equivale a {0} yardas", yardas);
Console.WriteLine("Equivale a {0} centimetros", cms);
Console.WriteLine("Equivale a {0} metros", metros);
