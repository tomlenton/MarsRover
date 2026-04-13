namespace MarsRover.App
    using System;

public class Position
{
    public int X { get; set; }
    public int Y { get; set; }
    public CompassDirection Facing { get; set; }

    public Position(int x, int y, CompassDirection facing)
    {
        X = x;
        Y = y;
        Facing = facing;
    }
}
