using System;

class Program
{
    static void Main(string[] args)
    {

//We put some numbs..
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int number3 = int.Parse(Console.ReadLine());
        int number4 = int.Parse(Console.ReadLine());

//We print some things..
        Console.WriteLine("{0:d4} {0:d4} {0:d4} {0:d4}",number1,number2,number3,number4);
    }
}