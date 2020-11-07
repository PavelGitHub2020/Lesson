using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructionHome1
{
    class Basement : IPart
    {
        public void Part(House house)
        {
            house.basement = new Basement();
        }
    }
}
