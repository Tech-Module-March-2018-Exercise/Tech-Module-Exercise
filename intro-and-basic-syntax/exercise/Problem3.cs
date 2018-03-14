using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Numerics;
 
namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            BigInteger hightesSnowballValue= 0;

            int MAXSnowballSnow = 0;
            int MAXsnowballTime = 0;
            int MAXsnowballQuality = 0;

            for (int i = 0; i < N; i++)
            {
                int SnowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger currentValue = BigInteger.Pow((SnowballSnow / snowballTime),snowballQuality );

             
                if (currentValue > hightesSnowballValue)
                {
                    hightesSnowballValue = currentValue;
                    MAXSnowballSnow = SnowballSnow;
                    MAXsnowballTime = snowballTime;
                    MAXsnowballQuality = snowballQuality;
                }

              

            }


            Console.WriteLine($"{MAXSnowballSnow} : {MAXsnowballTime} = {hightesSnowballValue} ({MAXsnowballQuality})");



        }
    }
}
