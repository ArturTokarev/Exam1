using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static ulong input;
        static void Main(string[] args)
        {
            input = 0;
            bool isGoodNum = false;

            while (isGoodNum == false)
            {
                isGoodNum = ulong.TryParse(args[0], out input);
                if (isGoodNum == false)
                {
                    Console.WriteLine("Wrong input. Enter an unsigned long");
                    isGoodNum = false;
                    break;
                }
                else
                {
                    isGoodNum = true;
                    return;
                }

            }
        }

        // Hex representation
        static public void PrintHex(ulong input)
        {
            string Hex = string.Format("0x{0}", input.ToString("X"));
            Console.WriteLine(input.ToString() + " -> " + Hex);
        }

        static public ulong ulongToBinToHex(ulong input)
        {
            ulong bin;
            if (input != 0)
            {
                bin = (input % 2) + 10 * ulongToBinToHex(input / 2);
                return 0;
            }
            else
                return 0;
        }

    }
}
