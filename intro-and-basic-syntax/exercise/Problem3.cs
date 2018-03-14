using System;

 //How about this 
namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            var mile = double.Parse(Console.ReadLine());
            var kilometers = mile * 1.60934;
            Console.WriteLine("{0:f2}", kilometers);



        }
    }
}
