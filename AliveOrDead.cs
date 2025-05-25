using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIDF
{
    internal class AliveOrDead
    {
        static string[] status = new string[] {"alive","dead"};
        static Random rand = RandomProvider.GetRandom();
        public static string Status()
        {
            return status[rand.Next(status.Length)];
        }
    }
}
