using IDF_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIDF
{
    internal class IdfDefinition : IOrganization
    {
        public string DateOfEstablishment { get; } = "may 26 1948";
        public string CurrentCommander { get; } = "eyal zamir";
        private string[] CollectionOfStrike = new string[] { "aircraft", "drones", "artillery"};
        public static Dictionary<string, List<IAttackTools>> Arsenal = new Dictionary<string, List<IAttackTools>>();

        public void CreatArsenal()
        {
            foreach (string strike in CollectionOfStrike)
            {
                List<IAttackTools> attackUnit = new List<IAttackTools>();
                IAttackTools prototype = null;
                if (strike == "aircraft")
                {
                    prototype = new F16();
                }
                else if (strike == "drones")
                {
                    prototype = new Zik();
                }
                else if (strike == "artillery")
                {
                    prototype = new Artillery();
                }


                Random rand = RandomProvider.GetRandom();
                for (int i = 1; i < rand.Next(20,30); i++)
                {
                    IAttackTools cloned = prototype.Clone();
                    cloned.SerialNumber = $"{i:D3}";
                    attackUnit.Add(cloned);

                }
                Arsenal[strike] = attackUnit;
                

            }
        }
        //public void printArsenal()
        //{
        //    foreach(List<IAttackTools> arsnal in Arsenal.Values)
        //    {
        //        Console.WriteLine(arsnal.Count);
        //        foreach(IAttackTools tool in arsnal)
        //        {
        //            Console.WriteLine(tool.ToolName);
        //            Console.WriteLine(tool.SerialNumber);
        //        }
        //    }
        //}

        
    }

    
}
