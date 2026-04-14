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
        }
    }
}