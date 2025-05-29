using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectIDF;

namespace IDF_Project
{
    internal class AttackAvailability
    {
        string catagory = "";
        public string showAllarsenal()
        {
            //Console.WriteLine("name         fuel (%)     boomb left\n");
            foreach(var all in IdfDefinition.Arsenal)
            {
                catagory += "~~~~~~   " + all.Key + "   ~~~~~~\n\nname         fuel (%)     boomb left\n\n";
               
                foreach (var tools in all.Value)
                {
                    
                    catagory += $"{tools.ToolName.Split()[0]} {tools.SerialNumber}       " +
                        $"{tools.FuelSupply} %         " +
                        $"{tools.AmmunitionCapacity}\n";
                }
                catagory += "\n";

            }
            Console.WriteLine(catagory);
            return catagory;
        }
    }
}
