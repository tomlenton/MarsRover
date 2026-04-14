using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.App.RoverMovement;

namespace MarsRover.App.Parsers
{
    public class InstructionParser
    {
        public List<Instruction> InputParse(string instructions)
        {
            if (string.IsNullOrEmpty(instructions))
            {
                return new List<Instruction>();
            }

            var result = new List<Instruction>();

            foreach (char c in instructions)
            {
                char cUpper = char.ToUpper(c);
                if (Enum.TryParse(cUpper.ToString(), out Instruction instruction))
                {
                    result.Add(instruction);
                }
            }
            return result;
        }
    }
}
