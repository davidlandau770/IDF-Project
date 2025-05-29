using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIDF
{
    internal class Aman
    {
        static public Terrorist terrorist;
        public string[] LocationTerrorist = { "home", "car", "outside" };
        public string timestamp = DateTime.Now.ToString();

        List<Terrorist> terroristList = CreatRandomNumOfTerrorists.terroristList;
        public static List<string> ThratsList = new List<string>();
        Random rand = RandomProvider.GetRandom();

        public void Thrats()
        {
            for (int i = 0; i < rand.Next(15, 20);i++)
            {
                Terrorist terrorist = terroristList[rand.Next(CreatRandomNumOfTerrorists.terroristList.Count)];
                DateTime randomTime = DateTime.Now.AddSeconds(-rand.Next(0, 3 * 24 * 60 * 60));
                string location = LocationTerrorist[rand.Next(3)];
                terrorist.AddAlert(randomTime,location);
                terrorist.setLocation(location);
                ThratsList.Add($"messaeg recived at {randomTime} \n{terrorist.Name} was spoted in {location}");
            }
        }
        public string GetTheMostReports()
        {
            Thrats();
            int max = 0;
            string name = "";
            string location = "";
            string time = "";
            foreach (Terrorist terrorist in terroristList)
            {
                if (terrorist.GetNumOfAlert() > max)
                {
                    time = "";
                    name = terrorist.Name;
                    max = terrorist.GetNumOfAlert();
                    location = terrorist.Location;
                    foreach (Dictionary<DateTime, string> dict in terrorist.Alerts)
                    {
                        foreach (KeyValuePair<DateTime, string> pair in dict)
                        {
                            time += $"at {pair.Key}, located: {pair.Value}\n";
                        }
                    }
                }
            } 
            return $"most alearts: {name} ({max})\n{time}";
        }
    }
}
