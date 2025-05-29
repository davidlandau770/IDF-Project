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
        
        public void Target()
        {
            bool choice = false;
            int number = 0;
            while (!choice)
            {
                Console.WriteLine("1: choose you target from data base\n" +
                    "2: attack most dengoures terrorist");
                choice = int.TryParse(Console.ReadLine(), out number);
                if (!choice) { Console.WriteLine("not a valid choice"); }
            }
            PrioritizingGoals prioritizing = new PrioritizingGoals();
            switch (number)
            {
                case 1:
                    prioritizing.QualityScoreByTerrorist();
                    break;
                case 2:
                    //PrioritizingGoals prioritizing = new PrioritizingGoals();
                    Console.WriteLine(prioritizing.GetMostDengrous());
                    break;
            }
        }
    }
}
