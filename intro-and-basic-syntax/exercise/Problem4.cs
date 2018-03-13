using System;

class Program
{
    static void Main(string[] args)
    {
		//Read input
        var name = Console.ReadLine();
        var volume = int.Parse(Console.ReadLine());
        var energy = int.Parse(Console.ReadLine());
        var sugar = int.Parse(Console.ReadLine());
		
		//Calculate energy content
        var energyContent = ((double)volume * energy) / 100;
		
		//Calculate sugar content
        var sugarContent = ((double)volume * sugar) / 100;
		
		//Print result
        Console.WriteLine($"{volume}ml {name}:");
        Console.WriteLine($"{energyContent}kcal, {sugarContent}g sugars");
    }
}