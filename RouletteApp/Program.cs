using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RouletteClasses;

namespace RouletteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            RouletteWheel rouletteWheel = new RouletteWheel();
            BetAnalyzer betAnalyzer = new BetAnalyzer();
            for (int i = 0; i < 10; i++)
            {
                rouletteWheel.Roll();
                Console.WriteLine($"You rolled a {rouletteWheel.bin} which is {rouletteWheel.color}.");
                betAnalyzer.Analyze(rouletteWheel);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
