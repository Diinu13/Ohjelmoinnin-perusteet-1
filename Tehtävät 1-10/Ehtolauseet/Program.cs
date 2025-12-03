using System.Runtime.CompilerServices;

// Harjoitus 1

int ikä = 23;
string nimi = "Markus";
if (ikä == 23 && nimi == "Markus")
{
    Console.WriteLine("moi " + nimi + "!");
}
else
{
    Console.WriteLine("henkilö ei tunnistettu");
}

// Harjoitus 2

bool motor_is_running = false;
int temperature = 30;
if (temperature > 30);
{
    motor_is_running = true;
}
if (motor_is_running)
{
    Console.WriteLine("motor is running");
}
else
{
    Console.WriteLine("motor is not running");
}

// Harjoitus 3

int arvo1 = 30;
int arvo2 = 42;
if (arvo1 == 42 || arvo2 == 42)
{
    Console.WriteLine("42 löytyi");
}
else
{
    Console.WriteLine("42 ei löytynyt");
}

// Harjoitus 4

int luku = 250;
if (luku < 200)
{
    Console.WriteLine("arvo on aika pieni");
}
if (luku == 100)
{
    Console.WriteLine("arvo on sata");
}
if (luku > 100)
{
    Console.WriteLine("alkaa olla aika iso luku");
}
if (luku > 200)
{
    Console.WriteLine("nyt ollaan isoissa luvuissa"); 
}

// Harjoitus 5

int lukux = 81;
if (lukux % 2 == 0)
{
    Console.WriteLine("parillinen");
}
else
{
    Console.WriteLine("pariton");
}

// Harjoitus 6

Console.Write("Nimesi: ");


string käyttäjänimi = Console.ReadLine();

Console.WriteLine("Kiva juttu! Kirjoitit " + käyttäjänimi.Length + " merkkiä pitkän tekstin!");


// Harjoitus 7
Console.Write("sana1");
string sana1 = Console.ReadLine();
Console.Write("sana2");
string sana2 = Console.ReadLine();
if (sana1.Length > sana2.Length)
{
    Console.WriteLine(sana1);
}
else if (sana1.Length < sana2.Length)
{
    Console.WriteLine(sana2);
}
else // (sana1.Length == sana2.Length)
{
    Console.WriteLine(sana1.Length + sana2.Length);
}

// Harjoitus 8

Console.Write("Valitse joko a tai b: ");
string Käyttäjän_valinta = Console.ReadLine();
if (Käyttäjän_valinta == "a")
{
    Console.WriteLine("hieno valinta");
}
else if (Käyttäjän_valinta == "b")
{
    Console.WriteLine("loistava valinta");
}
else // (Käyttäjän_valinta != a || b)
{
    Console.WriteLine("Virheellinen syöte");
}

// Harjoitus 9

Console.Write("Mikä instituutio: ");
string instituutio = Console.ReadLine();
Console.Write("Mikä on kiinnostavaa: ");
string Kiinnostuksen_kohde = Console.ReadLine();
if ((instituutio == "koulu" && Kiinnostuksen_kohde == "ohjelmointi") || (instituutio == "ohjelmointi" && Kiinnostuksen_kohde == "koulu"))
{
    Console.WriteLine("Hienot sanat!");
}
else
{
    Console.WriteLine("Ei huonot sanat.");
}

// Harjoitus 10 

Console.Write("kokonaisluku_1: ");
int x1 = Int32.Parse(Console.ReadLine());
Console.Write("kokonais_luku_2: ");
int x2 = Int32.Parse(Console.ReadLine());

Console.WriteLine("summa: " + (x1 + x2));