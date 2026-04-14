using MarsRover.App.Data;
using MarsRover.App.RoverMovement;
using MarsRover.App.RoverMovementLogic;

namespace MarsRover.Tests;

public class RoverMoveTests
{
    // MOVE NORTH

    [Test]
    public void Move_FromNorth_IncreasesY()
    {
        var rover = new Rover(new Position(2, 2, CompassDirection.N));

        rover.Move();

        Assert.That(rover.position.X, Is.EqualTo(2));
        Assert.That(rover.position.Y, Is.EqualTo(3));
    }

    // MOVE EAST

    [Test]
    public void Move_FromEast_IncreasesX()
    {
        var rover = new Rover(new Position(2, 2, CompassDirection.E));

        rover.Move();

        Assert.That(rover.position.X, Is.EqualTo(3));
        Assert.That(rover.position.Y, Is.EqualTo(2));
    }

    // MOVE SOUTH

    [Test]
    public void Move_FromSouth_DecreasesY()
    {
        var rover = new Rover(new Position(2, 2, CompassDirection.S));

        rover.Move();

        Assert.That(rover.position.X, Is.EqualTo(2));
        Assert.That(rover.position.Y, Is.EqualTo(1));
    }

    // MOVE WEST

    [Test]
    public void Move_FromWest_DecreasesX()
    {
        var rover = new Rover(new Position(2, 2, CompassDirection.W));

        rover.Move();

        Assert.That(rover.position.X, Is.EqualTo(1));
        Assert.That(rover.position.Y, Is.EqualTo(2));
    }
}
