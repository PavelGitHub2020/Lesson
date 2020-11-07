using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructionHome1
{
    class House
    {
        public Basement basement;
        public Door door;
        public Roof roof;
        public List<Walls> walls;// 4 стены
        public List<Window> window;// 4 окна
    }
}
