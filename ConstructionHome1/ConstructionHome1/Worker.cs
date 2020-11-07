using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructionHome1
{
    class Worker : IWorker
    {
        public string Name { get; set; }

        string IWorker.Name => Name;

        public Worker(string Name)
        {
            this.Name = Name;
        }

        public void BuildHoude(House house, TeamLeader teamLeader)
        {
            if (house.basement == null)
            {
                Basement basement = new Basement();
                basement.Part(house);
                teamLeader.report.Add($"Worker {Name} builded is basement" );
            }
            else if (house.walls == null || house.walls.Count < 4)
            {
                if (house.walls == null)
                {
                    house.walls = new List<Walls>();
                }
                    
                Walls walls = new Walls();
                walls.Part(house);
                teamLeader.report.Add($"Worker {Name} builded is walls");
            }
            else if (house.roof == null)
            {
                Roof roof = new Roof();
                roof.Part(house);
                teamLeader.report.Add($"Worker {Name} builded is roof");
            }
            else if (house.window == null || house.window.Count < 4)
            {
                if (house.window == null)
                {
                    house.window = new List<Window>();
                }

                Window window = new Window();
                window.Part(house);
                teamLeader.report.Add($"Worker {Name} builded is window");
            }
            else if (house.door == null)
            {
                Door door = new Door();
                door.Part(house);
                teamLeader.report.Add($"Worker {Name} builded is door");
            }
           
        }
    }
}
