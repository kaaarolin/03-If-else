
Console.WriteLine("Please input your testscore (0-100) to see your grade: ");
int inputScore = Convert.ToInt32(Console.ReadLine());

if (inputScore < 0 || inputScore > 100)
{
    Console.WriteLine("Invalid number");
}
else if (inputScore >= 90)
{
    Console.WriteLine("A");
}
else if (inputScore >= 80)
{
    Console.Write("B");
}
else if (inputScore >= 70)
{
    Console.Write("C");
}
else if (inputScore >= 60)
{
    Console.Write("D");
}
else 
{
    Console.WriteLine("F");
}