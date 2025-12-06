// Harjoitus 3 

string [] sanat = new string [3];

string sana;
for (int i = 0; i < 3; i++)
{
    Console.Write("kirjoita kolme sanaa: ");
    sana = Console.ReadLine();
    sanat[i] = sana;
}
for (int i = 2; i>= 0; i--)
{
    Console.WriteLine(sanat[i]);
}
// Harjoitus 4
{
string [] sanat4 = new string [3];

int count = 0;

while (count < sanat4.Length)

{
    Console.Write("kirjoita kolme sanaa: ");
    string sana4 = Console.ReadLine();
    sanat4[count] = sana4;
    count++;
}
int index = sanat4.Length -1;
while (index >= 0)
{
    Console.WriteLine(sanat4[index]); 
    index--;
}
}