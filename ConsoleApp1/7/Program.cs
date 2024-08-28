
Console.WriteLine("Please input your total amount");
int inputAmount = Convert.ToInt32(Console.ReadLine());

if (inputAmount > 1000)
{
    double newAmount = inputAmount * 0.9;
    Console.WriteLine("Your new total is " + newAmount + " after 10% discount");
}
else
{

    Console.WriteLine("The total is " + inputAmount);
}

