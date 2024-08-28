
Console.WriteLine("Please input your total amount");
int inputAmount = Convert.ToInt32(Console.ReadLine());
double newAmount = inputAmount * 0.9;

if (inputAmount > 1000)
{

    Console.WriteLine("Your new total is " + newAmount + " after 10% reduction");
}
else
{

    Console.WriteLine("The total is " + inputAmount);
}

