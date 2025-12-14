using System.Runtime.Versioning;

int salainen;
// luetaan ensimmäinen rivi
string ekarivi = Console.ReadLine();
// // Ensimmäinen rivi joko on tai ei ole #secret
bool Secret_totta = ekarivi.StartsWith("#SECRET=");
if (Secret_totta)
{
    // Parsitaan secret numero 
    string[] osat = ekarivi.Split('='); 
    string numero_tekstinä = osat[1];
    salainen = int.Parse(numero_tekstinä);
}
else
{
    // Jatketaan normaalisti ilman secrettiä
    // // Numeron arvonta
    Random rand = new Random();
    salainen = rand.Next(0,101);
    // Ensimmäisen rivin parsiminen
    int ekaarvaus = int.Parse(ekarivi);
    if (Tarkista_arvaus(ekaarvaus, salainen))
    {
        return;
    }
}

while (true)
{
        
    Console.Write("Kirjoita lukuarvo 0-100: ");
    int lukuarvo = int.Parse(Console.ReadLine());
    if (Tarkista_arvaus(lukuarvo, salainen))
    {
        break;
    }
}

 bool Tarkista_arvaus(int lukuarvo, int salainen)
{
    if (lukuarvo == salainen)
    {
        Console.WriteLine("Oikein!");
        return true;
    }
    else if (lukuarvo < salainen)
    {
        Console.WriteLine("Korkeampi!");
    }
    else
    {
        Console.WriteLine("Alempi!");
    }
    return false;
}