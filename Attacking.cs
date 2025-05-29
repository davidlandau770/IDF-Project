using ProjectIDF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IDF_Project
{
    internal class Attacking
    {
        public string attackTime = DateTime.Now.ToString();
        public static Dictionary<string, string> attackLog = new Dictionary<string, string>();
        PrioritizingGoals prioritizing = new PrioritizingGoals();

        public bool Success()
        {
            Random random = new Random();
            int rndomNum = random.Next(1, 101);
            return rndomNum <= 95;
        }

        public void Attack(string name)
        {
            string tool = ChooseToolByTargetLocation(name);
            Console.WriteLine(tool);
            IAttackTools attackTool = AvailabelToolByRandom(tool);
            attackTool.UseAmmunition();
            attackTool.UseFuel();
            if (Success())
            {

                attackLog[DateTime.Now.ToString()] = $"IDF killed {name} with {attackTool.ToolName} {attackTool.SerialNumber}";
                Console.WriteLine($"Congratulations, we successfully eliminated {name} with {attackTool.ToolName} {attackTool.SerialNumber}.");
                foreach (Terrorist ter in PrioritizingGoals.terList)
                {
                    if (ter.Name == name)
                    {
                        ter.Status = "dead";
                        break;
                    }
                }  
            }
            else
            {
                attackLog[DateTime.Now.ToString()] = $"IDF tryd to kill {name} with {attackTool.ToolName} {attackTool.SerialNumber} \nbut unfortunately not succeed....";
                Console.WriteLine($"{name} survived the attack ):");
                Console.WriteLine("Do you want to try again? (yes/no)");
                string choice = Console.ReadLine();
                if (choice.ToLower() == "yes")
                {
                   Attack(name);
                }
            }
        }

        public void Target()
        {
            var currentList = prioritizing.QualityScoreByTerrorist();

            if (currentList.Count == 0)
            {
                Console.WriteLine("No terrorists in the database.");
                return;
            }

            Console.WriteLine("1: Choose your target from the database\n2: Attack the most dangerous terrorist");
            if (!int.TryParse(Console.ReadLine(), out int number) || (number != 1 && number != 2))
            {
                Console.WriteLine("Invalid choice.");
                return;
            }

            switch (number)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Choose a number from the list:");
                    for (int i = 0; i < currentList.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {currentList[i]}");
                    }

                    if (int.TryParse(Console.ReadLine(), out int num) && num > 0 && num <= currentList.Count)
                    {
                        string entry = currentList[num - 1];
                        string[] parts = entry.Split(new[] { '.', ',', ':' }, StringSplitOptions.RemoveEmptyEntries);
                        string name = parts[0].Trim();

                        PrioritizingGoals.dangerList.Remove(entry);
                        Attack(name);
                    }
                    else
                    {
                        Console.WriteLine("Invalid number.");
                    }
                    break;

                case 2:
                    Console.Clear();
                    string mostDengerous = PrioritizingGoals.dangerList[0];
                    PrioritizingGoals.dangerList.RemoveAt(0);
                    string[] parts2 = mostDengerous.Split(new[] { '.', ',', ':' }, StringSplitOptions.RemoveEmptyEntries);
                    string topName = parts2[0].Trim();
                    Attack(topName);
                    break;
            }
        }

        
        public IAttackTools AvailabelToolByRandom(string tool)
        {
            Random rand = new Random();
            int randit = rand.Next(IdfDefinition.Arsenal[tool].Count);
            IAttackTools UseTool = IdfDefinition.Arsenal[tool][randit];
            if (UseTool.FuelSupply <= 10)
            {
                Console.WriteLine($"go get some fuel to {UseTool.ToolName} {UseTool.SerialNumber}");
                IdfDefinition.Arsenal[tool].RemoveAt(randit);
            }
            else if (UseTool.AmmunitionCapacity <= 1)
            {
                Console.WriteLine($"go get more bombs to {UseTool.ToolName} {UseTool.SerialNumber}");
                IdfDefinition.Arsenal[tool].RemoveAt(randit);
            }    
            return UseTool;
        }
        public static string ChooseToolByTargetLocation(string name)
        {
            string output = "artillery";
            foreach(Terrorist ter in CreatRandomNumOfTerrorists.terroristList)
            {
                if (ter.Name == name)
                {
                    if (ter.Location == "home")
                    {
                        output =  "aircraft";
                    }
                    else if(ter.Location == "car")
                    {
                        output = "drones";
                    }
                    else if(ter.Location == "outside")
                    {
                        output = "artillery";
                    }
                }
            }return output;
        }
        public void GetAttackLog()
        {
            foreach (KeyValuePair<string,string> a in attackLog)
            {
                Console.WriteLine(a.Key);
                Console.WriteLine(a.Value);
            }
        }
    }
}

