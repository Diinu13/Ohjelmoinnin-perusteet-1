// Käytä "," desimaaleissa!!!!!!
Console.Write("Kirjoita numero: ");
double numero1 = double.Parse(Console.ReadLine());
Console.Write("Kirjoita toinen numero: ");
double numero2 = double.Parse(Console.ReadLine());
Console.Write("Käytä jotain näistä: - + * / operaattoreista");
string operaatio = Console.ReadLine();

if (operaatio == "/" && numero2 == 0)
{
    Console.WriteLine("Nollala ei voida jakaa!");
    return;
}
double tulos = 0;

if (operaatio == "+")
{
    tulos = numero1 + numero2;
}
else if (operaatio == "-")
{
    tulos = numero1 - numero2;
}
else if (operaatio == "/")
{
    tulos = numero1 / numero2;
}
else if (operaatio == "*")
{
    tulos = numero1 * numero2;
}
else
{
    Console.WriteLine("Tuntematon operaatio!");
    return;
}

Console.WriteLine($"{numero1} {operaatio} {numero2} = {tulos}");


