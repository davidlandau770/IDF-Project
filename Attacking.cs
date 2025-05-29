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
        PrioritizingGoals prioritizing = new PrioritizingGoals();
        List<Terrorist> terroristlist = CreatRandomNumOfTerrorists.terroristList; 
        public bool Success()
        {
            Random random = new Random();
            int rndomNum = random.Next(1,101);
            if(rndomNum > 95)
            {
                return false;
            }
            return true;
        }
        public void Attack(string name)
        {
            
            if (Success())
            {
                Console.WriteLine($"Congratulations, we successfully eliminated {name}.");
                foreach (Terrorist ter in terroristlist)
                {
                    if (ter.Name == name)
                    {
                        ter.Status = "dead";
                    }
                }
            }
            else
            {
                Console.WriteLine($"{name} survived the attack ):");
                Console.WriteLine("do you want to try agien?");
                string choice = Console.ReadLine();
                if (choice == "yes")
                {
                    Attack(name);
                }
            }
        }
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

            switch (number)
            {
                case 1:
                    Console.WriteLine("choose from the list");
                    prioritizing.QualityScoreByTerrorist();
                    bool choice2 = int.TryParse(Console.ReadLine(),out int num);
                    if (choice2 && num > 0 && num < PrioritizingGoals.listLevelOfDengarous.Count)
                    {
                        Attack(PrioritizingGoals.listLevelOfDengarous[num - 1]);
                    }
                    else
                    {
                        Console.WriteLine("number not valid");
                    }
                    break;
                case 2:
                    string target = prioritizing.GetMostDengrous();
                    Console.WriteLine(target);
                    string name = target.Split()[1] + " " + target.Split()[2];
                    Attack(name);
                    break;
            }
        }
    }
}
