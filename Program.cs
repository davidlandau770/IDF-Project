using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIDF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuToUser menu = new MenuToUser();
            menu.MenuList();
            if (args.Length == 0)
            {
                Console.WriteLine("You must pass the API key as a command-line argument.");
                return;
            }
            string apiKey = args[0]; // Read the first argument (your API key)
                                     // use the key as a part of the httpClient
        }
    }
}
