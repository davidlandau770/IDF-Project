using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIDF
{
    internal class Zik : AttackTools
    {
        public string ToolName { get; } = "Zik";
        public string[] BombType { get; } = { "veraity bombs" };
        public int AmmunitionCapacity { get; set; } = 3;
        public string[] EffectiveAgainst { get; } = { "pepole","car" };
        public int FuelSupply { get; set; } = 100;
        public void UseAmmunition()
        {
            AmmunitionCapacity -= 1;
        }
        public void ReloadAmmonition()
        {
            AmmunitionCapacity = 3;
        }
        public void UseFuel()
        {
            FuelSupply -= 1;
        }
        public void ReloadFuel()
        {
            FuelSupply = 100;
        }
        //public Zik(string bombType , int ammunitionCapacity , string effectiveAgainst )
        //{
        //    BombType = bombType;
        //    AmmunitionCapacity = ammunitionCapacity;
        //    EffectiveAgainst = effectiveAgainst;
        //}
    }
}
