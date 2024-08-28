
Console.WriteLine("Please input a number");
int inputNumber = Convert.ToInt32(Console.ReadLine());

if (inputNumber < 0)
{
    Console.WriteLine(inputNumber + " is negative");
}
else if (inputNumber > 0)
{
    Console.WriteLine(inputNumber + " is positive");
}
else
{
    Console.WriteLine("The number is 0");
}
