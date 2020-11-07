using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructionHome1
{
    class TeamLeader : IWorker
    {
        public string Name { get; set; }
        string IWorker.Name => Name;

        public List<string> report = new List<string>();
        public TeamLeader(string Name)
        {
            this.Name = Name;
        }
        public void Report()
        {
            double message = report.Count / 11.0 * 100;//делим на 11 потому-что 11 обьектов, по 4 окна и стен, и остальное
            Console.WriteLine( message + " % done of completely work");
        }
    }
}
