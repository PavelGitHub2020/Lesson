using System;
using System.Collections.Generic;
using System.Text;

namespace DataType
{
    struct Coefficient
    {
        public int A { get; set; }

        public int B { get; set; }

        public override string ToString()
        {
            return $"Value A = {A}, Value B = {B}";
        }
    }
}
