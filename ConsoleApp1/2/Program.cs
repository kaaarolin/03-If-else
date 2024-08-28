
using System;

Console.WriteLine("How old are you: " );
int inputName = Convert.ToInt32(Console.ReadLine());

if ( inputName < 13 )
{
    Console.WriteLine("You are a child");
}
else if (inputName >= 13 && inputName <= 19)
{
    Console.WriteLine("You are a teenager");
}
else 
{
    Console.WriteLine("You are an adult");
}


    

    

