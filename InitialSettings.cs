using IDF_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIDF
{
    internal class InitialSettings
    {
        public void trys()
        {
            //IdfDefinition a = new IdfDefinition();
            IdfDefinition idf = new IdfDefinition();
            idf.CreatArsenal();
            //idf.printArsenal();
            AttackAvailability b = new AttackAvailability();
            b.showAllarsenal();
            //for (int i = 0; i < 3; i++)
            //{
            //    idf.unit.Add()
            //}
            //Terrorist terrorist1 = new Terrorist("achmad", 4, "alive",new string[ ] {"knife","M16"});
            //Terrorist terrorist2 = new Terrorist("aibraim", 1, "alive",new string[ ] {"AK47" ,"gun"});
            //Terrorist terrorist3 = new Terrorist("rachman", 3, "alive",new string[ ] {"knife","M16", "gun"});
            //Terrorist terrorist4 = new Terrorist("amin", 5, "dead",new string[ ] {"knife"});
            //Terrorist terrorist5 = new Terrorist("mosa", 4, "dead",new string[ ] { "gun"});
            //IdfDefinition idf = new IdfDefinition();

            CreatRandomNumOfTerrorists.TerroristList();
            //List<Terrorist> a = CreatRandomNumOfTerrorists.TerroristList();
            //CreatRandomNumOfTerrorists.print
            //foreach (var item in CreatRandomNumOfTerrorists.TerroristList())
            //{
            //    Console.WriteLine(item);
            //}
            //IntelligenceMessages.printThrats();
            //foreach (var a in TerroristWeaponArssenal.Personalweapon()) { 
            //    Console.WriteLine(a);
            //}
        }
    }
}
