namespace MarsRover.App
    
{
    using MarsRover.App.Parsers;
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string plateauInput = "5 5";

            string rover1PositionInput = "1 2 N";
            string rover1InstructionsInput = "LMLMLMLMM";

            string rover2PositionInput = "3 3 E";
            string rover2InstructionsInput = "MMRMMRMRRM";


            var plateauParser = new PlateauParser();
            var positionParser = new PositionParser();
            var instructionParser = new InputParser();


            var plateau = plateauParser.PlateauParse(plateauInput);

            var rover1Position = positionParser.PositionParse(rover1PositionInput);
            var rover1Instructions = instructionParser.InputParse(rover1InstructionsInput);

            var rover2Position = positionParser.PositionParse(rover2PositionInput);
            var rover2Instructions = instructionParser.InputParse(rover2InstructionsInput);

            Console.WriteLine($"Plateau: {plateau.MaxX}, {plateau.MaxY}");

            Console.WriteLine($"Rover 1 Start: {rover1Position.X}, {rover1Position.Y}, {rover1Position.Facing}");
            Console.WriteLine($"Rover 1 Instructions Count: {rover1Instructions.Count}");

            Console.WriteLine($"Rover 2 Start: {rover2Position.X}, {rover2Position.Y}, {rover2Position.Facing}");
            Console.WriteLine($"Rover 2 Instructions Count: {rover2Instructions.Count}");
        }
    }
}
