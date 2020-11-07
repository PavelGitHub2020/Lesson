using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConstructionHome1
{
    class Team : IWorker
    {
        public TeamLeader teamLeader;

        public string Name = "BuildHouse";
        string IWorker.Name => Name;

        public List<Worker> workers = new List<Worker>();
        public Team()
        {
            teamLeader = new TeamLeader("Alex");

            workers = new List<Worker> { new Worker("Genrix"), new Worker("Jon"),
                new Worker("Mila"), new Worker("Frederih"), new Worker("Jec")};
        }
    }
}
