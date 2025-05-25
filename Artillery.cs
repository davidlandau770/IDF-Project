using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIDF
{
    internal class Artillery : AttackTools
    {
        public override string ToolName { get; } = "M109 Artillery";
        public override string[] BombType { get; } = { "M109 Explosive shell" };
        public override int AmmunitionCapacity { get; } = 40;
        public override string[] EffectiveAgainst { get; } = { "open fildes" };
        
    }
}
