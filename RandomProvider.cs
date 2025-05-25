using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIDF
{
    public static class RandomProvider
    {
        private static readonly Random _instance = new Random();

        public static Random GetRandom()
        {
            return _instance;
        }
    }
}
