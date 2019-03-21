using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteClasses
{
    public class BetAnalyzer
    {
        public void Analyze(RouletteWheel rouletteWheel)
        {
            if (rouletteWheel.randomNumber < 36)
            {
                Console.WriteLine("Winning bets are: ");
                IndividualNumbers(rouletteWheel);
                EvenOddNumbers(rouletteWheel);
                Colors(rouletteWheel);
                LowsHighs(rouletteWheel);
                Dozens(rouletteWheel);
                Columns(rouletteWheel);
                Streets(rouletteWheel);
                SixNumbers(rouletteWheel);
                Split(rouletteWheel);
                Corner(rouletteWheel);
            }
            else
            {
                Console.WriteLine("There are no winners.");
            }
        }
        private void IndividualNumbers(RouletteWheel rouletteWheel)
        {
            Console.WriteLine($"Those who bet on {rouletteWheel.bin}.");
        }
        private void EvenOddNumbers(RouletteWheel rouletteWheel)
        {
            if (rouletteWheel.randomNumber%2 == 0)
            {
                Console.WriteLine("Those who bet on evens.");
            }
            else
            {
                Console.WriteLine("Those who bet on odds.");
            }
        }
        private void Colors(RouletteWheel rouletteWheel)
        {
            if (rouletteWheel.color == "red")
            {
                Console.WriteLine("Those who bet on red.");
            }
            else
            {
                Console.WriteLine("Those who bet on black.");
            }
        }
        private void LowsHighs(RouletteWheel rouletteWheel)
        {
            if (rouletteWheel.randomNumber > 19)
            {
                Console.WriteLine("Those who bet low.");
            }
            else
            {
                Console.WriteLine("Those who bet high.");
            }
        }
        private void Dozens(RouletteWheel rouletteWheel)
        {
            if(rouletteWheel.randomNumber >= 12)
            {
                Console.WriteLine("Those who bet on the first dozen.");
            }
            else if (rouletteWheel.randomNumber <= 24 && rouletteWheel.randomNumber >= 13)
            {
                Console.WriteLine("Those who bet on the second dozen.");
            }
            else
            {
                Console.WriteLine("Those who bet on the third dozen.");
            }
        }
        private void Columns(RouletteWheel rouletteWheel)
        {
            if (rouletteWheel.randomNumber%3 == 0)
            {
                Console.WriteLine("Those who bet on the third column.");
            }
            else if (rouletteWheel.randomNumber%3 == 2)
            {
                Console.WriteLine("Those who bet on the second column.");
            }
            else
            {
                Console.WriteLine("Those who bet on the first column.");
            }
        }
        private void Streets(RouletteWheel rouletteWheel)
        {
            double hold = rouletteWheel.randomNumber / 3d;
            double rowNumber = Math.Ceiling(hold);
            Console.WriteLine($"Those who bet on row {rowNumber}.");
        }
        private void SixNumbers(RouletteWheel rouletteWheel)
        {
            double hold = rouletteWheel.randomNumber / 3d;
            double rowNumber = Math.Ceiling(hold);
            if (rowNumber > 1)
            {
                Console.WriteLine($"Those who bet on the 6 numbers in row {rowNumber - 1} and {rowNumber}.");
            }
            if (rowNumber < 12)
            {
                Console.WriteLine($"Those who bet on the 6 numbers in row {rowNumber} and {rowNumber + 1}.");
            }
        }
        private void Split(RouletteWheel rouletteWheel)
        {
            double hold = rouletteWheel.randomNumber / 3d;
            double rowNumber = Math.Ceiling(hold);
            if (rouletteWheel.randomNumber % 3 == 0)
            {
                Console.WriteLine($"Those who bet on the {rouletteWheel.randomNumber}/{rouletteWheel.randomNumber - 1} split.");
                if (rowNumber > 1)
                {
                    Console.WriteLine($"Those who bet on the {rouletteWheel.randomNumber}/{rouletteWheel.randomNumber - 3} split.");
                }
                if (rowNumber < 12)
                {
                    Console.WriteLine($"Those who bet on the {rouletteWheel.randomNumber}/{rouletteWheel.randomNumber + 3} split.");
                }
            }
            else if (rouletteWheel.randomNumber % 3 == 2)
            {
                Console.WriteLine($"Those who bet on the {rouletteWheel.randomNumber}/{rouletteWheel.randomNumber - 1} split.");
                if (rowNumber > 1)
                {
                    Console.WriteLine($"Those who bet on the {rouletteWheel.randomNumber}/{rouletteWheel.randomNumber - 3} split.");
                }
                if (rowNumber < 12)
                {
                    Console.WriteLine($"Those who bet on the {rouletteWheel.randomNumber}/{rouletteWheel.randomNumber + 3} split.");
                }
                Console.WriteLine($"Those who bet on the {rouletteWheel.randomNumber}/{rouletteWheel.randomNumber + 1} split.");
            }
            else
            {
                if (rowNumber > 1)
                {
                    Console.WriteLine($"Those who bet on the {rouletteWheel.randomNumber}/{rouletteWheel.randomNumber - 3} split.");
                }
                if (rowNumber < 12)
                {
                    Console.WriteLine($"Those who bet on the {rouletteWheel.randomNumber}/{rouletteWheel.randomNumber + 3} split.");
                }
                Console.WriteLine($"Those who bet on the {rouletteWheel.randomNumber}/{rouletteWheel.randomNumber + 1} split.");
            }

        }
        private void Corner(RouletteWheel rouletteWheel)
        {
            double hold = rouletteWheel.randomNumber / 3d;
            double rowNumber = Math.Ceiling(hold);
            if (rouletteWheel.randomNumber % 3 == 0)
            {
                if (rowNumber > 1)
                {
                    Console.WriteLine($"Those who bet on the corner of {rouletteWheel.randomNumber - 4}/{rouletteWheel.randomNumber - 3}/{rouletteWheel.randomNumber - 1}/{rouletteWheel.randomNumber}.");
                }
                if (rowNumber < 12)
                {
                    Console.WriteLine($"Those who bet on the corner of {rouletteWheel.randomNumber - 1}/{rouletteWheel.randomNumber}/{rouletteWheel.randomNumber + 2}/{rouletteWheel.randomNumber + 3}.");
                }
            }
            else if (rouletteWheel.randomNumber % 3 == 2)
            {
                if (rowNumber > 1)
                {
                    Console.WriteLine($"Those who bet on the corner of {rouletteWheel.randomNumber - 4}/{rouletteWheel.randomNumber - 3}/{rouletteWheel.randomNumber - 1}/{rouletteWheel.randomNumber}.");
                    Console.WriteLine($"Those who bet on the corner of {rouletteWheel.randomNumber - 3}/{rouletteWheel.randomNumber - 2}/{rouletteWheel.randomNumber}/{rouletteWheel.randomNumber + 1}.");
                }
                if (rowNumber < 12)
                {
                    Console.WriteLine($"Those who bet on the corner of {rouletteWheel.randomNumber - 1}/{rouletteWheel.randomNumber}/{rouletteWheel.randomNumber + 2}/{rouletteWheel.randomNumber + 3}.");
                    Console.WriteLine($"Those who bet on the corner of {rouletteWheel.randomNumber + 1}/{rouletteWheel.randomNumber}/{rouletteWheel.randomNumber + 3}/{rouletteWheel.randomNumber + 4}.");
                }
            }
            else
            {
                if (rowNumber > 1)
                {
                    Console.WriteLine($"Those who bet on the corner of {rouletteWheel.randomNumber - 3}/{rouletteWheel.randomNumber - 2}/{rouletteWheel.randomNumber}/{rouletteWheel.randomNumber + 1}.");
                }
                if (rowNumber < 12)
                {
                    Console.WriteLine($"Those who bet on the corner of {rouletteWheel.randomNumber + 1}/{rouletteWheel.randomNumber}/{rouletteWheel.randomNumber + 3}/{rouletteWheel.randomNumber + 4}.");
                }
            }

        }
    }
}
