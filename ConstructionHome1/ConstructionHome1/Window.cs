using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructionHome1
{
    class Window : IPart
    {
        public void Part(House house)
        {
            house.window.Add(new Window());
        }
    }
}
