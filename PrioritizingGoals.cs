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
        public static List<string> listLevelOfDengarous = new List<string>();
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
                qualityScore[t] = t.rank * WeaponPoints(t.Weapon);
            }
            return qualityScore;
        }

        public void PrintQualityScore()
        {
            foreach(KeyValuePair<Terrorist,int> Q in QualityScore())
            {
                Console.WriteLine($"{Q.Key.ToString()} --------{Q.Value}");
            }
        }
        public void QualityScoreByTerrorist()
        {
            
            var sortedByValue = QualityScore().OrderByDescending(pair => pair.Value);
            int i = 1;
            foreach (KeyValuePair<Terrorist,int> terrorists in sortedByValue)
            {
                if (terrorists.Key.Status != "dad")
                {
                    string message = $"{i}. {terrorists.Key.Name}, dengoures level: {terrorists.Value}";
                    listLevelOfDengarous.Add(message);
                    Console.WriteLine(message);
                }
                i++;
            }
        }
        public string GetMostDengrous()
        {
            int max = 0;
            string terrorist = "";
            foreach (KeyValuePair<Terrorist, int> Q in QualityScore())
            {
                if (Q.Value > max)
                {
                    max = Q.Value;
                    terrorist = Q.Key.Name;
                }
            }
            return $"name: {terrorist}, dengoures level: {max}";
        }

        //public string GetDengrous()
        //{
        //    string terrorist = "";
        //    foreach (KeyValuePair<Terrorist, int> Q in QualityScore())
        //    {
        //        if (Q.Value > max)
        //        {
        //            max = Q.Value;
        //            terrorist = Q.Key.ToString();
        //        }
        //    }
        //    return $"{terrorist} \n dengoures level: {max}";
        //}
    }
}
