using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIDF
{
    internal class Terrorist
    {
        public string Name { get; set; }
        int Rank;
        public string Status = "alive";
        public string[] Weapon;
        public string Location = "";
        
        public List<Dictionary<DateTime,string>> Alerts { get; set; }
        public int rank
        {
            get {  return Rank; }
            set
            {
                if (value < 1)
                {
                    Rank = 1;
                }
                else if (value > 5)
                {
                    Rank = 5;
                }
                else
                {
                    Rank = value;
                }
            }
        }
    
        public Terrorist(string name, int rank, string[] weapon)
        {
            Name = name;
            this.rank = rank;
            this.Weapon = weapon;
            Alerts = new List<Dictionary<DateTime, string>>();
        }

        public override string ToString()
        {
            return $"Name: {Name}, Rank: {Rank}, Status: {Status}, Weapons: {string.Join(", ", Weapon)}";
        }

        public void AddAlert(DateTime time,string location)
        {
            Alerts.Add(new Dictionary<DateTime, string> { { time, location } });
            Alerts = Alerts
               .OrderBy(dict => dict.Keys.First())
               .ToList();
        }

        public int GetNumOfAlert()
        {
            return Alerts.Count;
        }
        public void setLocation(string location)
        {
            Location = location;
        }
    }
}
