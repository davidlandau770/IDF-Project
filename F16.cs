using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIDF
{
    internal class F16 : IAttackTools
    {
        public string SerialNumber { get; set; }
        public string ToolName { get; } = "F16";
        public string[] BombType { get; } = { "0.5 ton", "1 ton" };
        public int AmmunitionCapacity { get; set; } = 8;
        public string[] EffectiveAgainst { get; } = { "bulidings" };
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

        public IAttackTools Clone()
        {
            return new F16();
        }
    }
}
