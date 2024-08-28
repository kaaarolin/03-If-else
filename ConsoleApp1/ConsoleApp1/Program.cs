
using System.ComponentModel.Design;

Console.WriteLine("Skriv ett tal: ");
int input = Convert.ToInt32(Console.ReadLine());

if (input % 2  == 0) 
{
    Console.WriteLine("Talet är jämnt ");
}
else
{
    Console.WriteLine("Talet är udda");
}
   
