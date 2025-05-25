using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIDF
{
    internal class F16 : AttackTools
    {
        public override string ToolName { get; } = "F16";
        public override string[] BombType { get; } = { "0.5 ton", "1 ton" };
        public override int AmmunitionCapacity { get; } = 8;
        public override string[] EffectiveAgainst { get; } = { "bulidings" };
        //public F16(string bombType, int ammunitionCapacity, string effectiveAgainst)
        //{
        //    BombType = bombType;
        //    AmmunitionCapacity = ammunitionCapacity;
        //    EffectiveAgainst = effectiveAgainst;
        //}
    }
}
