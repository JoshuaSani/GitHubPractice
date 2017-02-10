using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lolcats
{
    class Program
    {
        static void Main(string[] args)
        {
            MeowMeow();
        }

        static void MeowMeow()
        {
            // Stanford please make this function say "meow meow".
            Console.Write("Meow? ");
            string input = Console.ReadLine().ToLower();
            bool trigger = false;
            while (trigger != true)
            {
                if (input == "meow")
                {
                    Console.WriteLine("Meow!");
                    Console.Write("Meow? ");
                    input = Console.ReadLine().ToLower();
                }
                else if (input == "stop")
                {
                    Console.WriteLine(":(");
                    trigger = true;
                }
                else
                {
                    Console.Write("Meow!!!!!!???? ");
                    input = Console.ReadLine().ToLower();
                }
            }
        }
    }
}
