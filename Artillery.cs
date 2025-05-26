using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIDF
{
    internal class Artillery : IAttackTools
    {
        public string SerialNumber { get; set; }
        public string ToolName { get; } = "M109 Artillery";
        public string[] BombType { get; } = { "M109 Explosive shell" };
        public int AmmunitionCapacity { get; set; } = 40;
        public string[] EffectiveAgainst { get; } = { "open fildes" };
        public int FuelSupply { get; set; } = 100;
        public void UseAmmunition()
        {
            AmmunitionCapacity -= 1;
        }
        public void ReloadAmmonition()
        {
            AmmunitionCapacity = 8;
        }
        public void UseFuel()
        {
            FuelSupply -= 1;
        }
        public void ReloadFuel()
        {
            FuelSupply = 100;
        }
    }
}
