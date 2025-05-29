using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIDF
{
    internal class Aman
    {
        static public Terrorist terrorist;
        public string[] LocationTerrorist = { "home", "car", "outside" };
        public string timestamp;
    
        static string[] Thrats()
        {
            Random rand = RandomProvider.GetRandom();
            string[] thrats = new string[rand.Next(10, 20)];
            for (int i = 0; i < thrats.Length; i++)
            {
                string t = IntelligenceMessages.terroristAlerts[rand.Next(30)];
                if (!thrats.Contains(t))
                {
                    thrats[i] = t + $" timestamp: {DateTime.Now}";
                }
                else
                {
                    i--;
                }
            }
            return thrats;
        }
        static public string[] alerts = Thrats();
        public void PrintThrats()
        {
            string[] thrat = alerts;
            foreach (string alart in thrat)
            {
                Console.WriteLine(alart);
            }
        }

    }
}
