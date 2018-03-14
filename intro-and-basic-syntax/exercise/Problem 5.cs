using System;
    class Program
    {
        static void Main()
        {
        var name = Console.ReadLine();
        var health = int.Parse(Console.ReadLine());
        var healthMax = int.Parse(Console.ReadLine());
        var energy = int.Parse(Console.ReadLine());
        var energyMax = int.Parse(Console.ReadLine());
        var healthEmpty = healthMax - health;
        var energyEmpty = energyMax - energy;

        Console.WriteLine("Name: {0}", name);

        Console.Write("Health: " + "|");
        Console.Write("{0}{1}", new string('|', health), new string('.', healthEmpty));
        Console.WriteLine("|");

        Console.Write("Energy: " + "|");
        Console.Write("{0}{1}", new string('|', energy), new string('.', energyEmpty));
        Console.WriteLine("|");
    }
    }

