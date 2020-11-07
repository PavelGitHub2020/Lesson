using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructionHome1
{
    class Door : IPart
    {
        public void Part(House house)
        {
            house.door = new Door();
        }
    }
}
