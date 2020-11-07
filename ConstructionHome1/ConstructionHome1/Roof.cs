using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructionHome1
{
    class Roof : IPart
    {
        public void Part(House house)
        {
            house.roof = new Roof();
        }
    }
}
