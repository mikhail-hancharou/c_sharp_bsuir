using System;

namespace lab6
{
    interface IUpgradable
    {
        int experience { get; set; }
        void AddRaceStuff(int amount);
        void AddTrackStuff(int amount);
        void SoldTeam(string newCompanyName);
        void ChangeCaptain(string newCaptainName, int experience);
    }
}

