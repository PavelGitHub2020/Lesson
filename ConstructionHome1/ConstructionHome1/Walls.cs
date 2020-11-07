using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructionHome1
{
    class Walls : IPart
    {
        public void Part(House house)
        {
            house.walls.Add(new Walls());
        }
    }
}
