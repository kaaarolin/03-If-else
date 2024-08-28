
using System.ComponentModel.Design;

Console.WriteLine("Please input a year: ");
int inputYear = Convert.ToInt32(Console.ReadLine());

if ((inputYear % 4 == 0 && inputYear % 100 != 0) || inputYear % 400 == 0)
{
    Console.WriteLine(inputYear + " is a leap year");
}
else
{
    Console.WriteLine(inputYear + " is not a leap year");
}