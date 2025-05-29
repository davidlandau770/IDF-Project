using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIDF
{
    internal class CreatRandomNumOfTerrorists
    {
        static Random rand = RandomProvider.GetRandom();
        static int amount = rand.Next(15,20);
        public static string[] terroristNames = new string[amount];
        public static List<Terrorist> terroristList = new List<Terrorist>();
        public List<Terrorist> TerroristList()
        {
            for (int i = 0; i < amount; i++)
            {
                string name = CreatRandomTerroristNames.getNewName();
                if (!terroristNames.Contains(name))
                {
                    terroristNames[i] = name;
                    Terrorist terrorist = new Terrorist(name, RandomProvider.GetRandom().Next(1, 6), TerroristWeaponArssenal.Personalweapon());
                    terroristList.Add(terrorist);
                }
                else
                {
                    i--;
                }
            }
            return terroristList;
        }
        public void Aaa()
        {
            Console.WriteLine(terroristNames[0]);
        }
    }
}
