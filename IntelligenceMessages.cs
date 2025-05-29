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
        static string[] namesList = CreatRandomNumOfTerrorists.terroristNames;
        static Random rand = RandomProvider.GetRandom();
        
        static public List<string> terroristAlerts = new List<string>
        {
            $"Alert:\t\t\tSuspected terrorist activity reported near the border. Suspect: {namesList[0]}",
            $"Warning:\t\t\tExplosives detected in vehicle linked to {namesList[rand.Next(namesList.Length)]}",
            $"Security Update:\t\tSurveillance flagged suspicious meeting involving {namesList[1]}",
            $"High Alert:\t\t\t{namesList[rand.Next(namesList.Length)]} attempted unauthorized access to military base.",
            $"Intel Report:\t\tCommunication intercepted from known cell involving {namesList[2]}",
            $"Investigation Ongoing:\tWeapons traced to smuggling operation by {namesList[rand.Next(namesList.Length)]}",
            $"Red Flag:\t\t\tFlight booking matched to terror watchlist ID of {namesList[rand.Next(namesList.Length)]}",
            $"Security Breach:\t\tCyberattack traced to network affiliated with {namesList[3]}",
            $"Bomb Threat:\t\t\tAnonymous tip linked device to {namesList[rand.Next(namesList.Length)]}",
            $"Armed Suspect:\t\t{namesList[rand.Next(namesList.Length)]} seen entering urban area with automatic rifle.",
            $"Checkpoint Alert:\t\tStolen passport used by {namesList[rand.Next(namesList.Length)]} at crossing.",
            $"Air Surveillance:\t\tDrone footage confirms hidden camp led by {namesList[rand.Next(namesList.Length)]}",
            $"DNA Match:\t\t\tForensic evidence ties blast scene to {namesList[rand.Next(namesList.Length)]}",
            $"Facial Recognition Hit:\tHigh-risk suspect identified as {namesList[rand.Next(namesList.Length)]}",
            $"Intercepted Call:\t\tPlot discussed by {namesList[rand.Next(namesList.Length)]} for major attack.",
            $"Suspicious Package:\t\tLuggage registered under alias of {namesList[rand.Next(namesList.Length)]}",
            $"Raid Result:\t\t\tArrest warrant issued for {namesList[rand.Next(namesList.Length)]} after cache found.",
            $"Online Activity Alert:\tRadical content posted by account of {namesList[rand.Next(namesList.Length)]}",
            $"Location Update:\t\tMovement detected in restricted zone by {namesList[rand.Next(namesList.Length)]}",
            $"Combat Engagement:\t\tArmed confrontation involving cell led by {namesList[rand.Next(namesList.Length)]}",
            $"Border Alert:\t\tAttempted illegal entry by {namesList[rand.Next(namesList.Length)]} with false ID.",
            $"Explosives Cache:\t\tWarehouse traced to operations by {namesList[rand.Next(namesList.Length)]}",
            $"Cyber Threat Alert:\tMalware linked to organization run by {namesList[rand.Next(namesList.Length)]}",
            $"Suspicious Delivery:\tShipment flagged under name connected to {namesList[rand.Next(namesList.Length)]}",
            $"Risk Assessment:\t\tPriority 1 threat linked to profile of {namesList[rand.Next(namesList.Length)]}",
            $"Satellite Scan:\t\tHeat signature detected in known hideout of {namesList[rand.Next(namesList.Length)]}",
            $"Fake Documents Found:\tForged papers lead back to {namesList[rand.Next(namesList.Length)]}",
            $"IED Discovery:\t\tDesign pattern matches previous devices from {namesList[rand.Next(namesList.Length)]}",
            $"Interrogation Report:\tDetainee confesses link to {namesList[rand.Next(namesList.Length)]}",
            $"Terror Threat Neutralized:\tPlot by {namesList[rand.Next(namesList.Length)]} foiled by special ops."
        };
    }
}
