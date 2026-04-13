using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.App.Enums;

namespace MarsRover.App.Parsers
{
    public class InputParser
    {
        public List<Instruction> InputParse(string instructions)
        {
            return new List<Instruction> { Instruction.L };
        }

    }
}
