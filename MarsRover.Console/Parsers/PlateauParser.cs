using MarsRover.App.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.App.Parsers
{
    public class PlateauParser
    {
        public PlateauSize PlateauParse(string plateauSize)
        {
            if (String.IsNullOrEmpty(plateauSize))
            {
                throw new ArgumentException("Invalid input, please provide a correct plateau size");
            }
            var parts = plateauSize.Split(' ');

            if (parts.Length != 2)
            {
                throw new ArgumentException("Plateau size must contain exactly two values");
            }

            if (!int.TryParse(parts[0], out int maxX))
            {
                throw new ArgumentException("Invalid X value for plateau");
            }

            if (!int.TryParse(parts[1], out int maxY))
            {
                throw new ArgumentException("Invalid Y value for plateau");
            }

            return new PlateauSize(maxX, maxY);
        }
    }
}
