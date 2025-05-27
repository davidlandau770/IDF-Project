using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIDF
{
    internal class IdfDefinition : IOrganization
    {
        public string DateOfEstablishment { get; } = "may 26 1948";
        public string CurrentCommander { get; } = "eyal zamir";
        public string[] CollectionOfStrike = new string[] { "aircraft", "drones", "artillery" };   
        
    }
}
