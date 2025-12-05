using System.ComponentModel;
using System.Reflection;
using System.Xml.Schema;

{
// Harjoitus 1.1

string [] kokoelma = {"sana1" , "sana2" , "sana3" , "sana4" , "sana5" };
foreach (string sana in kokoelma)
{
    Console.WriteLine(sana);
}
}

{
    // Harjoitus 1.2

string[] kokoelma2 = {"tip" , "tap" , "tipetipe" , "tiptap" , "tip" } ;
for (int i = 0; i < kokoelma2.Length; i++)
{
    Console.WriteLine(kokoelma2[i]);
}
}
{
// Harjoitus 1.3

string[] kokoelma3 = {"a" , "b" , "c" , "d" , "e"};
int i = 0;
while (i < kokoelma3.Length)
{
    Console.WriteLine(kokoelma3[i++]);
}
}

{

// Harjoitus 2.1

float[] floats = {0.3f , 0.4f , 0.5f};
float summa = 0f;
for (int i = 0; i < floats.Length; i++)
{
    summa += floats[i];
}


}

{
// Harjoitus 2.2
double[] doubles = {0.4, 0.78, 0.98};
double sum = 0.0;

int i = 0;

while ( i < doubles.Length)
{
    sum += doubles[i];
    i++;
}
Console.WriteLine($"summa: {sum}");
}

// Harjoitus 2.3
{
double[] doubles2 = {0.6, 0.8, 0.90};
double summa2 = 0;
foreach (double arvo in doubles2)
{
    summa2 += arvo;
}

Console.WriteLine($"summa : {summa2}");
}