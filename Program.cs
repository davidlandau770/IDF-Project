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
            //MenuToUser menu = new MenuToUser();
            //menu.MenuList();
            Aman a = new Aman();
            foreach (var b in a.Thrats()) {
                Console.WriteLine(b);
            }
        }
    }
}
