using System;


class Program
{
    static void Main(string[] args)
    {
		//Read input
        var mile = double.Parse(Console.ReadLine());
		//Calculate kilometers
        var kilometers = mile * 1.60934;
		//Print result
        Console.WriteLine("{0:f2}", kilometers);
    }
}