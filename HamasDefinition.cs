using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIDF
{
    internal class HamasDefinition : IOrganization
    {
        public string DateOfEstablishment { get; set; }
        public string CurrentCommander { get; set; }
        public string[] CollectionOfStrike;

        public HamasDefinition(string dateOfEstablishment, string currentCommander)
        {
            DateOfEstablishment = dateOfEstablishment;
            CurrentCommander = currentCommander;
            CollectionOfStrike = new string[] { "terrorist 1", "terrorist 2", "terrorist 3" };
        }
    }
}
