using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIDF
{
    internal interface IAttackTools
    {
        string SerialNumber { get; set; }
        string ToolName { get; }
        string[] BombType { get; }
        int AmmunitionCapacity { get; set; }
        string[] EffectiveAgainst { get; }
        int FuelSupply { get; set; }
        void UseAmmunition();
        void ReloadAmmonition();
        void UseFuel();
        void ReloadFuel();

    }
}
