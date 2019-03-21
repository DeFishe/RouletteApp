using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteClasses
{
    public class RouletteWheel
    {
        Random random = new Random();
        public string color { get; set; }
        public string bin { get; set; }
        int[] redNumber = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
        int[] blackNumber = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
        public int randomNumber { get; set; }
        public void Roll()
        {
            randomNumber = random.Next(1, 38);
            bin = Convert.ToString(randomNumber);
            if (randomNumber < 36)
            {
                foreach (int redNumber in redNumber)
                {
                    if (redNumber == randomNumber)
                    {
                        color = "red";
                    }
                }
                foreach (int blackNumber in blackNumber)
                {
                    if (blackNumber == randomNumber)
                    {
                        color = "black";
                    }
                }
            }
            else if (randomNumber == 36)
            {
                bin = "0";
                color = "green";
            }
            else if (randomNumber == 37)
            {
                bin = "00";
                color = "green";
            }
        }
    }
}
