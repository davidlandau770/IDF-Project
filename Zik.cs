using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIDF
{
    internal class Zik : AttackTools
    {
        public override string ToolName { get; } = "Zik";
        public override string[] BombType { get; } = { "veraity bombs" };
        public override int AmmunitionCapacity { get; } = 3;
        public override string[] EffectiveAgainst { get; } = { "pepole","car" };
        //public Zik(string bombType , int ammunitionCapacity , string effectiveAgainst )
        //{
        //    BombType = bombType;
        //    AmmunitionCapacity = ammunitionCapacity;
        //    EffectiveAgainst = effectiveAgainst;
        //}
    }
}
