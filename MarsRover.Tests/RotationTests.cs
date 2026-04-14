using MarsRover.App.Data;
using MarsRover.App.RoverMovement;
using MarsRover.App.RoverMovementLogic;
namespace MarsRover.Tests;

public class RotationTests
{
    // ROTATE RIGHT TESTS

    [Test]
    public void RotateRight_FromNorth_FacesEast()
    {
        var rover = new Rover(new Position(0, 0, CompassDirection.N));

        rover.RotateRight();

        Assert.That(rover.position.Facing, Is.EqualTo(CompassDirection.E));
    }

    [Test]
    public void RotateRight_FromEast_FacesSouth()
    {
        var rover = new Rover(new Position(0, 0, CompassDirection.E));

        rover.RotateRight();

        Assert.That(rover.position.Facing, Is.EqualTo(CompassDirection.S));
    }

    [Test]
    public void RotateRight_FromSouth_FacesWest()
    {
        var rover = new Rover(new Position(0, 0, CompassDirection.S));

        rover.RotateRight();

        Assert.That(rover.position.Facing, Is.EqualTo(CompassDirection.W));
    }

    [Test]
    public void RotateRight_FromWest_FacesNorth()
    {
        var rover = new Rover(new Position(0, 0, CompassDirection.W));

        rover.RotateRight();

        Assert.That(rover.position.Facing, Is.EqualTo(CompassDirection.N));
    }

    // ROTATE LEFT TESTS

    [Test]
    public void RotateLeft_FromNorth_FacesWest()
    {
        var rover = new Rover(new Position(0, 0, CompassDirection.N));

        rover.RotateLeft();

        Assert.That(rover.position.Facing, Is.EqualTo(CompassDirection.W));
    }

    [Test]
    public void RotateLeft_FromWest_FacesSouth()
    {
        var rover = new Rover(new Position(0, 0, CompassDirection.W));

        rover.RotateLeft();

        Assert.That(rover.position.Facing, Is.EqualTo(CompassDirection.S));
    }

    [Test]
    public void RotateLeft_FromSouth_FacesEast()
    {
        var rover = new Rover(new Position(0, 0, CompassDirection.S));

        rover.RotateLeft();

        Assert.That(rover.position.Facing, Is.EqualTo(CompassDirection.E));
    }

    [Test]
    public void RotateLeft_FromEast_FacesNorth()
    {
        var rover = new Rover(new Position(0, 0, CompassDirection.E));

        rover.RotateLeft();

        Assert.That(rover.position.Facing, Is.EqualTo(CompassDirection.N));
    }
}
