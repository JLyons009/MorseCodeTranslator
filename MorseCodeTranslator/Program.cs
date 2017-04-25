using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("String to translate to Morse Code (enter nothing to quit): ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                Console.WriteLine("Morse Code: " + MorseCodeTranslator.ToMorse(input));
            }
        }
    }
}
