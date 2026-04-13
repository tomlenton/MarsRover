using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.App.Data
{
    internal class PlateauSize
    {
        public int MaxX { get; set; }
        public int MaxY { get; set; }

        public PlateauSize(int maxX, int maxY)
        {
            MaxX = maxX;
            MaxY = maxY;
        }
    }
}
