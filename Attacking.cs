using ProjectIDF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Project
{
    internal class Attacking
    {
        string AttackTime = DateTime.Now.ToString();
        public void target()
        {
            bool choice = false;
            int a = 0;
            while (!choice)
            {
                Console.WriteLine("1: choose you target from data base\n" +
                    "2: attack most dengoures terrorist");
                choice = int.TryParse(Console.ReadLine(), out a);
                if (!choice) { Console.WriteLine("not a valid choice"); }
            }
            switch (a)
            {
                case 1:

                    List<Terrorist> t = CreatRandomNumOfTerrorists.terroristList;
                    //p.printTerrorist();
                    break;
                case 2:
                    MostReports rep = new MostReports();
                    rep.mostAlerts();
                    break;
            }
        }
    }
}
