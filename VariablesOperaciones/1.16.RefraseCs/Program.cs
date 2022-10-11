string frase, original, reemplazo, alternativaOriginal, alternativaReemplazo;
frase = "Aunque la cadena sea de oro, sirve para lo mismo.";

Console.WriteLine(frase);
Console.Write("Ingrese una palabra que exista en la frase: ");
original = Console.ReadLine();
Console.Write("Ingrese la palabra que la reemplaza: ");
reemplazo = Console.ReadLine();

alternativaOriginal = " " + original + " ";
alternativaReemplazo = " " + reemplazo + " ";
frase = frase.Replace(alternativaOriginal, alternativaReemplazo);

alternativaOriginal = " " + original + ".";
alternativaReemplazo = " " + reemplazo + ".";
frase = frase.Replace(alternativaOriginal, alternativaReemplazo);

alternativaOriginal = " " + original + ",";
alternativaReemplazo = " " + reemplazo + ",";
frase = frase.Replace(alternativaOriginal, alternativaReemplazo);

Console.WriteLine(frase);
