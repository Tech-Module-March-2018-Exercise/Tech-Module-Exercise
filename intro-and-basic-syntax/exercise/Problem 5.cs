//Checked Scotttimetotry.
using System;
    class Program
    {
        static void Main()
        {

        // We enter the name (string) from console.
        var name = Console.ReadLine();

        /* In the next four lines receive health, max health,
         * energy, max energy.*/
        var health = int.Parse(Console.ReadLine());
        var healthMax = int.Parse(Console.ReadLine());
        var energy = int.Parse(Console.ReadLine());
        var energyMax = int.Parse(Console.ReadLine());

        // We calculate healtEmpty and energyEmpty.
        var healthEmpty = healthMax - health;
        var energyEmpty = energyMax - energy;


        // Print name.
        Console.WriteLine("Name: {0}", name);

        // Print Health.
        Console.Write("Health: " + "|");
        Console.Write("{0}{1}", new string('|', health), new string('.', healthEmpty));
        Console.WriteLine("|");

        // Print Energy.
        Console.Write("Energy: " + "|");
        Console.Write("{0}{1}", new string('|', energy), new string('.', energyEmpty));
        Console.WriteLine("|");
    }
    }

