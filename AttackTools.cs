using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIDF
{
    internal abstract class AttackTools
    {
        public abstract string ToolName { get; }
        public abstract string[] BombType { get; }
        public abstract int AmmunitionCapacity { get;}
        public int FuelSupply { get; set; }
        public abstract string[] EffectiveAgainst { get; }

    }
}
