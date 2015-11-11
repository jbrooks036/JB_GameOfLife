using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGameOfLife
{
    public class Cell
    {
        // property only used for Bounded World
        public bool IsAlive { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
