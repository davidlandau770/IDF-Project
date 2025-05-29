using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Project;

namespace ProjectIDF
{
    internal class MenuToUser
    {
        public void MenuList()
        {
            InitialSettings initialSettings = new InitialSettings();
            initialSettings.InitialSetting();
            //initialSettings.Trys();

            // בהערה עד סיום העבודה
            IdfDefinition definition = new IdfDefinition();
            bool stop = true;
            while (stop)
            {
                Console.Clear();
                Console.WriteLine("Commander Console:\nChoose num: 1-6\n1. Intel Analysis\n2. Strike Availability\n3. Target Prioritization\n4. Strike Execution\n5. Show log attack\n6. Exit from system");
                int.TryParse(Console.ReadLine(), out int num);
                switch (num)
                {
                    case 1:
                        Console.Clear();
                        Aman aman = new Aman();
                        Console.WriteLine(aman.GetTheMostReports());
                        PrintNice();
                        break;
                    case 2:
                        Console.Clear();
                        AttackAvailability attack = new AttackAvailability();
                        attack.ShowAllarsenal();
                        PrintNice();
                        break;
                    case 3:
                        Console.Clear();
                        PrioritizingGoals prioritizing = new PrioritizingGoals();
                        Console.WriteLine(prioritizing.GetMostDengrous());
                        PrintNice();
                        break;
                    case 4:
                        Console.Clear();
                        Attacking attacking = new Attacking();
                        attacking.Target();
                        PrintNice();
                        break;
                    case 5:
                        Console.Clear();
                        PrintNice();
                        break;
                    case 6:
                        Console.Clear();
                        stop = false;
                        Console.WriteLine("Good bye!!!");
                        break;
                }
            }
        }

        void PrintNice()
        {
            Console.WriteLine("\n\nPress Enter to return to the menu.");
            Console.ReadLine();

        }
    }
}
