namespace MarsRover.Tests
{
    using MarsRover.App.Parsers;
    using MarsRover.App.RoverMovement;

    public class Tests
    {
        public class HelloWorldTests
        {
            [Test]
            public void Successfully_runs_a_test()
            {
                Assert.That(true, Is.True);
            }
        }
        public class InputParserTests
        {
            [Test]
            public void InputParse_SingleInstruction_ReturnsSingleItemList()
            {
                var parser = new InputParser();

                var result = parser.InputParse("L");

                Assert.That(result[0], Is.EqualTo(Instruction.L));
            }
            [Test]
            public void InsputParse_EmptyString_ReturnsEmptyList()
            {
                var parser = new InputParser();

                var result = parser.InputParse("");

                Assert.That(result.Count, Is.EqualTo(0));
            }
            [Test]
            public void InputParse_MultipleInstructions_ReturnsMultipleEnums()
            {
                var parser = new InputParser();

                var result = parser.InputParse("LRM");

                Assert.AreEqual(3, result.Count);
                Assert.AreEqual(Instruction.L, result[0]);
                Assert.AreEqual(Instruction.R, result[1]);
                Assert.AreEqual(Instruction.M, result[2]);
            }
            [Test]
            public void InputParse_WorksWithLowercaseLMR_ReturnsLM()
            {
                var parser = new InputParser();

                var result = parser.InputParse("lm");

                Assert.AreEqual(2, result.Count);
                Assert.AreEqual(Instruction.L, result[0]);
                Assert.AreEqual(Instruction.M, result[1]);
            }
            [Test]
            public void InputParse_IgnoreInvalidCharacters_ReturnsOnlyLRM()
            {
                var parser = new InputParser();

                var result = parser.InputParse("LARSMP");

                Assert.AreEqual(3, result.Count);
            }
            [Test]
            public void InputParse_IgnoreWhitespace_ReturnsOnlyLRM()
            {
                var parser = new InputParser();

                var result = parser.InputParse(" L R M ");

                Assert.AreEqual(3, result.Count);
                Assert.AreEqual(Instruction.L, result[0]);
                Assert.AreEqual(Instruction.R, result[1]);
                Assert.AreEqual(Instruction.M, result[2]);
            }
            [Test]
            public void InputParse_IgnoresCharacters_ReturnsOnlyLRM()
            {
                var parser = new InputParser();

                var result = parser.InputParse(" L R M!");

                Assert.AreEqual(3, result.Count);
                Assert.AreEqual(Instruction.L, result[0]);
                Assert.AreEqual(Instruction.R, result[1]);
                Assert.AreEqual(Instruction.M, result[2]);
            }
        }
        public class PoitionParserTests
        {
            [Test]
            public void PositionParse_Withx1y1_Returns1x1yHardcodedFacingN()
            {
                var parser = new PositionParser();
                var result = parser.PositionParse("1 1 N");
                Assert.That(result.X, Is.EqualTo(1));
                Assert.That(result.Y, Is.EqualTo(1));
                Assert.That(result.Facing, Is.EqualTo(CompassDirection.N));
            }

            [Test]
            public void PositionParse_WuithAnyDirection_ReturnsCorrectFacingDirection()
            {
                var parser = new PositionParser();
                var result = parser.PositionParse("1 1 E");
                Assert.That(result.X, Is.EqualTo(1));
                Assert.That(result.Y, Is.EqualTo(1));
                Assert.That(result.Facing, Is.EqualTo(CompassDirection.E));
            }

            [Test]
            public void PositionParse_WithDifferentCoordinates_ReturnsCorrectValues()
            {
                var parser = new PositionParser();

                var result = parser.PositionParse("3 5 N");

                Assert.That(result.X, Is.EqualTo(3));
                Assert.That(result.Y, Is.EqualTo(5));
            }

            [Test]
            public void PositionParse_WithZeroCoordinates_ReturnsZeroValues()
            {
                var parser = new PositionParser();

                var result = parser.PositionParse("0 0 S");

                Assert.That(result.X, Is.EqualTo(0));
                Assert.That(result.Y, Is.EqualTo(0));
            }

            [Test]
            public void PositionParse_InvalidX_ThrowsException()
            {
                var parser = new PositionParser();

                Assert.Throws<Exception>(() => parser.PositionParse("X 1 N"));
            }

            [Test]
            public void PositionParse_InvalidY_ThrowsException()
            {
                var parser = new PositionParser();

                Assert.Throws<Exception>(() => parser.PositionParse("1 Y N"));
            }

            [Test]
            public void PositionParse_InvalidDirection_ThrowsException()
            {
                var parser = new PositionParser();

                Assert.Throws<Exception>(() => parser.PositionParse("1 1 Z"));
            }

            [Test]
            public void PositionParse_MissingDirection_ThrowsException()
            {
                var parser = new PositionParser();

                Assert.Throws<Exception>(() => parser.PositionParse("1 1"));
            }

            [Test]
            public void PositionParse_TooManyValues_ThrowsException()
            {
                var parser = new PositionParser();

                Assert.Throws<Exception>(() => parser.PositionParse("1 2 N EXTRA"));
            }
            [Test]
            public void PositionParse_LowercaseDirection_ReturnsCorrectDirection()
            {
                var parser = new PositionParser();

                var result = parser.PositionParse("1 2 n");

                Assert.That(result.Facing, Is.EqualTo(CompassDirection.N));
            }
        }
        public class PlateauParserTests
        {
            [Test]
            public void PlateauParse_ValidInput_ReturnsCorrectSize()
            {
                var parser = new PlateauParser();

                var result = parser.PlateauParse("5 5");

                Assert.That(result.MaxX, Is.EqualTo(5));
                Assert.That(result.MaxY, Is.EqualTo(5));
            }

            [Test]
            public void PlateauParse_DifferentValues_ReturnsCorrectSize()
            {
                var parser = new PlateauParser();

                var result = parser.PlateauParse("10 20");

                Assert.That(result.MaxX, Is.EqualTo(10));
                Assert.That(result.MaxY, Is.EqualTo(20));
            }

            [Test]
            public void PlateauParse_EmptyInput_ThrowsException()
            {
                var parser = new PlateauParser();

                Assert.Throws<ArgumentException>(() => parser.PlateauParse(""));
            }

            [Test]
            public void PlateauParse_NullInput_ThrowsException()
            {
                var parser = new PlateauParser();

                Assert.Throws<ArgumentException>(() => parser.PlateauParse(null));
            }

            [Test]
            public void PlateauParse_MissingValue_ThrowsException()
            {
                var parser = new PlateauParser();

                Assert.Throws<ArgumentException>(() => parser.PlateauParse("5"));
            }

            [Test]
            public void PlateauParse_TooManyValues_ThrowsException()
            {
                var parser = new PlateauParser();

                Assert.Throws<ArgumentException>(() => parser.PlateauParse("5 5 5"));
            }

            [Test]
            public void PlateauParse_InvalidX_ThrowsException()
            {
                var parser = new PlateauParser();

                Assert.Throws<ArgumentException>(() => parser.PlateauParse("X 5"));
            }

            [Test]
            public void PlateauParse_InvalidY_ThrowsException()
            {
                var parser = new PlateauParser();

                Assert.Throws<ArgumentException>(() => parser.PlateauParse("5 Y"));
            }
        }
    }
}