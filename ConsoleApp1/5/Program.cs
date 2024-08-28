
Console.WriteLine("Please input a number");
int numberOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please input a second number");
int numberTwo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please input a third number");
int numberThree = Convert.ToInt32(Console.ReadLine());

if (numberOne >= numberTwo && numberOne >= numberThree)
{
    Console.WriteLine(numberOne + "is the biggest number");
}
else if (numberTwo >= numberOne && numberTwo >= numberThree)
{
    Console.WriteLine(numberTwo + "is the biggest number");
}
else 
{
    Console.WriteLine(numberThree + " is the biggest number");
}