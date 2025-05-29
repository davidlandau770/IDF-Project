using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIDF
{
    internal class MenuToUser
    {
        public void MenuList()
        {
            InitialSettings initialSettings = new InitialSettings();
            //initialSettings.InitialSetting();
            initialSettings.Trys();

            // בהערה עד סיום העבודה
            //IdfDefinition definition = new IdfDefinition();
            //while (true)
            //{
            //    Console.WriteLine("Commander Console:\nChoose num: 1-10\n1. Intel Analysis\n2. Strike Availability\n3. Target Prioritization\n4. Strike Execution\n");
            //    int.TryParse(Console.ReadLine(), out int num);
            //    switch (num)
            //    {
            //        case 1:
            //            //IntelAnalysis();
            //            break;
            //        case 2:
            //            //StrikeAvailability();
            //            break;
            //        case 3:
            //            //TargetPrioritization();
            //            break;
            //        case 4:
            //            //StrikeExecution();
            //            break;
            //    }
            //}
        }
    }
}
