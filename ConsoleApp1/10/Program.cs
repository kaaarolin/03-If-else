
using System;

Console.WriteLine("Choose either 1 or 2:");
Console.WriteLine("1. Celsius to Fahrenheit");
Console.WriteLine("2. Fahrenheit to Celsius");
int Choice = Convert.ToInt32(Console.ReadLine());


if (Choice < 1 || Choice > 2)
{
    Console.WriteLine("Invalid choice");
}
else if (Choice == 1)
{
    Console.WriteLine("Please input a temperature");
    double inputTemp = Convert.ToInt32(Console.ReadLine());
    double newTempF = (inputTemp * 9.0 / 5.0) + 32;
    Console.WriteLine("The temperature is " + newTempF + " in Fahrenheit");
}
else
{
    Console.WriteLine("Please input a temperature");
    double inputTemp = Convert.ToInt32(Console.ReadLine());
    double newTempC = (inputTemp - 32) * 5.0 / 9.0;
    Console.WriteLine("The temperature is " + newTempC + " in celsius");
}



