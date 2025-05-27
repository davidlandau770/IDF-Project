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
        static public List<Terrorist> terList = CreatRandomNumOfTerrorists.terroristList;
        public int WeaponPoints(string[] weapType)
        {
            int weaponPoins = 0;   
            foreach (var weaponItem in weapType) 
            {
                if (weaponItem == "knife")
                {
                    weaponPoins++;
                }
                else if (weaponItem == "gun")
                {
                    weaponPoins += 2;
                }
                else if (weaponItem == "M16" || weaponItem == "AK47")
                {
                    weaponPoins += 3;
                }
            }
            return weaponPoins;
        }
             
        public Dictionary<Terrorist, int> QualityScore()
        {
            Dictionary<Terrorist, int> qualityScore = new Dictionary<Terrorist, int>();
            foreach (var t in terList)
            {
                qualityScore[t] = t.rank* WeaponPoints(t.Weapon);
            }
            return qualityScore;
        }
        public void printQualityScore()
        {
            foreach(KeyValuePair<Terrorist,int> Q in QualityScore())
            {
                Console.WriteLine($"{Q.Key.ToString()} --------{Q.Value}");
            }
        }
        public string getMostDengrous()
        {
            int max = 0;
            string terrorist = "";
            foreach (KeyValuePair<Terrorist, int> Q in QualityScore())
            {
                if (Q.Value > max)
                {
                    max = Q.Value;
                    terrorist = Q.Key.ToString();
                }
            }
            return $"{terrorist} \n dengoures level: {max}";
        }

    }
}
