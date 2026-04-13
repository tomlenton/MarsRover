namespace MarsRover.Tests
{
using MarsRover.App.Enums;
    using MarsRover.App.Parsers;
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
        public class ParserTests
        {
            [Test]
            public void InstructionParse_SingleInstruction_ReturnsSingleItemList()
            {
                var parser = new InputParser();

                var result = parser.InputParse("L");

                Assert.That(result[0], Is.EqualTo(Instruction.L));
            }
            [Test]
            public void InstructionParse_EmptyString_ReturnsEmptyList()
            {
                var parser = new InputParser();

                var result = parser.InputParse("");

                Assert.That(result.Count, Is.EqualTo(0));
            }
        }
    }
}