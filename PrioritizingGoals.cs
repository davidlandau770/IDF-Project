using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ProjectIDF
{
    internal class PrioritizingGoals
    {
        public static List<Terrorist> terList = CreatRandomNumOfTerrorists.terroristList;
        public static List<string> dangerList = new List<string>();
        public int WeaponPoints(string[] weapType)
        {
            int points = 0;
            foreach (var weaponItem in weapType)
            {
                switch (weaponItem)
                {
                    case "knife": points += 1; break;
                    case "gun": points += 2; break;
                    case "M16":
                    case "AK47": points += 3; break;
                }
            }
            return points;
        }

        public Dictionary<Terrorist, int> QualityScore()
        {
            Dictionary<Terrorist, int> qualityScore = new Dictionary<Terrorist, int>();
            foreach (var t in terList)
            {
                if (t.Status == "alive")
                {
                    qualityScore[t] = t.rank * WeaponPoints(t.Weapon);
                }
            }
            return qualityScore;
        }
        public List<string> QualityScoreByTerrorist()
        {
            dangerList.Clear();
            var sortedByValue = QualityScore().OrderByDescending(pair => pair.Value);
            int i = 1;
            foreach (KeyValuePair<Terrorist, int> terrorists in sortedByValue)
            {
                string message = $"{terrorists.Key.Name}, dengoures level: {terrorists.Value}";
                dangerList.Add(message);               
            }
            
                        
            return dangerList;
        }
        public string GetMostDangerous()
        {
            int max = 0;
            string terrorist = "";
            foreach (KeyValuePair<Terrorist, int> Q in QualityScore())
            {
                if (Q.Key.Status == "dead") continue;
                if (Q.Value > max)
                {
                    max = Q.Value;
                    terrorist = Q.Key.Name;
                }
            }
            return $"name: {terrorist}, dengoures level: {max}";
        }
    }
}
