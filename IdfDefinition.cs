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
        public Dictionary<string, List<IAttackTools>> Arsenal = new Dictionary<string, List<IAttackTools>>();
        public List<IAttackTools> unit = new List<IAttackTools> {new Zik(),new Artillery(),new F16()};

        public void CreatArsenal()
        {
            foreach (string strike in CollectionOfStrike)
            {
                Arsenal[strike] = new List<IAttackTools>();
                foreach(IAttackTools u in unit)
                { 
                    Random rand = RandomProvider.GetRandom();
                    for (int i = 0; i < rand.Next(30); i++)
                    {
                        Arsenal[strike].Add(u);
                    }
                }

            }
        }
        public void printArsenal()
        {
            foreach(List<IAttackTools> a in Arsenal.Values)
            {
                Console.WriteLine(a.Count);
            }
        }
    }
}
