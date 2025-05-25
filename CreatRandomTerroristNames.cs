using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIDF
{
    internal class CreatRandomTerroristNames
    {
        static Random rand = RandomProvider.GetRandom();

        static List<string> arabicFirstNames = new List<string>
        {
            "Ahmed", "Mohammed", "Ali", "Omar", "Youssef", "Khaled", "Mahmoud", "Ibrahim", "Hassan", "Mustafa",
            "Samir", "Tariq", "Faisal", "Amir", "Rami", "Bilal", "Karim", "Ziad", "Hani", "Adnan",
            "Nabil", "Anwar", "Bassam", "Hatem", "Waleed", "Saad", "Farid", "Nasser", "Jamal", "Sami",
            "Imad", "Salim", "Munir", "Tamer", "Raed", "Fadi", "Rashid", "Samer", "Laith", "Kassem"
        };


        static List<string> arabicLastNames = new List<string>
        {
            "Almasri", "Haddad", "Natsheh", "Barhoum", "Qassem", "AbuAmar", "Khatib", "Hamdan", "Salman", "Alhindi",
            "Alqarni", "Zayyad", "Alnajjar", "Khalil", "Alhaj", "Omari", "Darwish", "Shalabi", "Azzam", "Abdulrahman",
            "Albaz", "Altarifi", "Jabari", "Shaheen", "Sawalha", "Alsaleh", "Bakri", "Rahal", "Asfour", "Amar",
            "Issa", "AbuZayd", "Alzayed", "Kanaan", "Farraj", "Hijazi", "Zein", "Nasrallah", "Marzouk", "Halabi"
        };
        public static string getNewName()
        {
            int i = rand.Next(arabicFirstNames.Count);
            int j = rand.Next(arabicLastNames.Count);
            return arabicFirstNames[i] + " " + arabicLastNames[j];
        }
    }
    }
