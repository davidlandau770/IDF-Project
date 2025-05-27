using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIDF
{
    internal class IntelligenceMessages
    {
        static  string[] namesList = CreatRandomNumOfTerrorists.terroristNames;
        static Random rand = RandomProvider.GetRandom();
        static List<string> terroristAlerts = new List<string>
        {
            $"🚨 Alert: Suspected terrorist activity reported near the border. Suspect: {namesList[rand.Next(namesList.Length)]}",
            $"⚠️ Warning: Explosives detected in vehicle linked to {namesList[rand.Next(namesList.Length)]}",
            $"🚔 Security Update: Surveillance flagged suspicious meeting involving {namesList[rand.Next(namesList.Length)]}",
            $"🚨 High Alert: {namesList[rand.Next(namesList.Length)]} attempted unauthorized access to military base.",
            $"📡 Intel Report: Communication intercepted from known cell involving {namesList[rand.Next(namesList.Length)]}",
            $"🔍 Investigation Ongoing: Weapons traced to smuggling operation by {namesList[rand.Next(namesList.Length)]}",
            $"🚨 Red Flag: Flight booking matched to terror watchlist ID of {namesList[rand.Next(namesList.Length)]}",
            $"🔒 Security Breach: Cyberattack traced to network affiliated with {namesList[rand.Next(namesList.Length)]}",
            $"🧨 Bomb Threat: Anonymous tip linked device to {namesList[rand.Next(namesList.Length)]}",
            $"🔫 Armed Suspect: {namesList[rand.Next(namesList.Length)]} seen entering urban area with automatic rifle.",
            $"🛑 Checkpoint Alert: Stolen passport used by {namesList[rand.Next(namesList.Length)]} at crossing.",
            $"🚁 Air Surveillance: Drone footage confirms hidden camp led by {namesList[rand.Next(namesList.Length)]}",
            $"🧬 DNA Match: Forensic evidence ties blast scene to {namesList[rand.Next(namesList.Length)]}",
            $"📷 Facial Recognition Hit: High-risk suspect identified as {namesList[rand.Next(namesList.Length)]}",
            $"📞 Intercepted Call: Plot discussed by {namesList[rand.Next(namesList.Length)]} for major attack.",
            $"🧳 Suspicious Package: Luggage registered under alias of {namesList[rand.Next(namesList.Length)]}",
            $"🚔 Raid Result: Arrest warrant issued for {namesList[rand.Next(namesList.Length)]} after cache found.",
            $"🌐 Online Activity Alert: Radical content posted by account of {namesList[rand.Next(namesList.Length)]}",
            $"📍 Location Update: Movement detected in restricted zone by {namesList[rand.Next(namesList.Length)]}",
            $"⚔️ Combat Engagement: Armed confrontation involving cell led by {namesList[rand.Next(namesList.Length)]}",
            $"🛃 Border Alert: Attempted illegal entry by {namesList[rand.Next(namesList.Length)]} with false ID.",
            $"🧨 Explosives Cache: Warehouse traced to operations by {namesList[rand.Next(namesList.Length)]}",
            $"🧑‍💻 Cyber Threat Alert: Malware linked to organization run by {namesList[rand.Next(namesList.Length)]}",
            $"📦 Suspicious Delivery: Shipment flagged under name connected to {namesList[rand.Next(namesList.Length)]}",
            $"📊 Risk Assessment: Priority 1 threat linked to profile of {namesList[rand.Next(namesList.Length)]}",
            $"🛰️ Satellite Scan: Heat signature detected in known hideout of {namesList[rand.Next(namesList.Length)]}",
            $"🧾 Fake Documents Found: Forged papers lead back to {namesList[rand.Next(namesList.Length)]}",
            $"💣 IED Discovery: Design pattern matches previous devices from {namesList[rand.Next(namesList.Length)]}",
            $"🔍 Interrogation Report: Detainee confesses link to {namesList[rand.Next(namesList.Length)]}",
            $"🛡️ Terror Threat Neutralized: Plot by {namesList[rand.Next(namesList.Length)]} foiled by special ops."
        };
        
        static private string[] Thrats()
        {
            string[] thrats = new string[rand.Next(10,20)];
            for (int i = 0; i < thrats.Length; i++)
            {
                string t = terroristAlerts[rand.Next(30)];
                if (!thrats.Contains(t))
                {
                    thrats[i] = t;
                }
                else
                {
                    i--;
                }
            }
            return thrats;
        }
        static public string[] alerts = IntelligenceMessages.Thrats();
        public static void PrintThrats()
        {
            string[] thrat = alerts;
            foreach (string alart in thrat)
            {
                Console.WriteLine( alart );
            }
        }
 
    }

}
