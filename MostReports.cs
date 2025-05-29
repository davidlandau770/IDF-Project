using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ProjectIDF
{
    internal class MostReports
    {
        string[] alerts = Aman.alerts;
        static string[] namesList = CreatRandomNumOfTerrorists.terroristNames;
        
        public Dictionary<string,int> AlertsByName()
        {
            Dictionary<string, int> alertNum = new Dictionary<string, int>();
            foreach (var alert in alerts)
            {
                foreach (string name in namesList)
                {
                    if (alert.Contains(name))
                    {
                        if (!alertNum.ContainsKey(name))
                        {
                            alertNum[name] = 1;
                        }
                        else
                        {
                            alertNum[name]++;
                        }
                    }

                }
            }
            return alertNum;

        }
        public string mostAlerts()
        {
            int num = 0;
            string terrorist = "";
            Dictionary<string,int> alertName = AlertsByName();
            foreach (KeyValuePair<string, int> name in alertName) 
            {
                if (name.Value > num)
                {
                    num = name.Value;
                    terrorist = $"{name.Key} with {num} alert messages";
                }
            }
            return terrorist;
        }
    }
}
