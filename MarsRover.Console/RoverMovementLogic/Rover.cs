using MarsRover.App.Data;
using MarsRover.App.Parsers;
using MarsRover.App.RoverMovement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.App.RoverMovementLogic
{
    public class Rover
    {
        public Position position { get; private set; }
        public Rover (Position startPosition)
        {
            position = startPosition;
        }
        public void RotateLeft()
        {
            if (position.Facing == CompassDirection.N)
            {
                position.Facing = CompassDirection.W;
            }
            else if (position.Facing == CompassDirection.W)
            {
                position.Facing = CompassDirection.S;
            }
            else if (position.Facing == CompassDirection.S)
            {
                position.Facing = CompassDirection.E;
            }
            else if (position.Facing == CompassDirection.E)
            {
                position.Facing = CompassDirection.N;
            }
        }
        public void RotateRight()
        {
            if (position.Facing == CompassDirection.N)
            {
                position.Facing = CompassDirection.E;
            }
            else if (position.Facing == CompassDirection.E)
            {
                position.Facing = CompassDirection.S;
            }
            else if (position.Facing == CompassDirection.S)
            {
                position.Facing = CompassDirection.W;
            }
            else if (position.Facing == CompassDirection.W)
            {
                position.Facing = CompassDirection.N;
            }
        }
        public void Move()
        {
            if (position.Facing == CompassDirection.N)
            {
                position.Y++;
            }
            else if (position.Facing == CompassDirection.E)
            {
                position.X++;
            }
            else if (position.Facing == CompassDirection.S)
            {
                position.Y--;
            }
            else if (position.Facing == CompassDirection.W)
            {
                position.X--;
            }
        }
    }
}
