using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            if (text == "Hallo" || text == "Hi")
            {
                Console.WriteLine("Wow, Hi, User!");
            }
            else if (text == "Привет")
            {
                Console.WriteLine("Привет Мир!");
            }
            else
            {
                Console.WriteLine("Hallo World!");
            }
        }
    }
}