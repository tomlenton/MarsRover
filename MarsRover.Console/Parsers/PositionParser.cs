using MarsRover.App.Data;
using MarsRover.App.RoverMovement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.App.Parsers
{
    public class PositionParser
    {
        public Position PositionParse(string position)
        {
            if (string.IsNullOrWhiteSpace(position))
            {
                throw new ArgumentException("Invalid input, please provide a correct position");
            }
            var parts = position.Split(" ");
            if (parts.Length != 3)
            {
                throw new Exception("Invalid position format");
            }
            if (!int.TryParse(parts[0], out int x))
            {
                throw new Exception("Invalid x coordinate");
            }
            if (!int.TryParse(parts[1], out int y))
            {
                throw new Exception("Invalid y coordinate");
            }
            if (!Enum.TryParse(parts[2].ToUpper().ToString(), out CompassDirection facing))
            {
                throw new Exception("Invalid compass direction");
            }
            return new Position(x, y, facing);

        }
    }
}
