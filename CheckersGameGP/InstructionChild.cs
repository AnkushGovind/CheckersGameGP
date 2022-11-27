using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersGameGP
{
    internal class InstructionChild:InstructionsClass,Iinstructions
    {
        public override string GetInstruction()
        {
            return "This is Second Instruction. If Player 1 gives a wrong answer the control will move to Player 2.";
        }

        public string GetNextInstruction()
        {
            return "This is Third Instruction. If Player 2 gives a right answer then Player 2 can move his/her piece.";
        }

        public string GetNextInstruction(String overload)
        {
            return "This is fourth Instruction. If Player 2 gives a wrong answer then the control goes back to player 1.";
        }

    }
}
