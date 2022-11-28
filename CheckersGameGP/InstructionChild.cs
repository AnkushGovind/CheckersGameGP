using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersGameGP
{
    internal class InstructionChild:InstructionsClass,Iinstructions
    {
        //This is a override method from parent class to display the second instruction
        public override string GetInstruction()
        {
            return "This is Second Instruction. If Player 1 gives a wrong answer the control will move to Player 2.";
        }

        //The below two methods are overloaded methods. One use no parameters while other uses one parameter to overload the method GetNextInstruction;
        public string GetNextInstruction()
        {
            return "This is Third Instruction. If Player 2 gives a right answer then Player 2 can move his/her piece. If Player 2 gives a wrong answer then Player 2 cannot move the piece. Then the control goes back to Player 1";
        }

        public string GetNextInstruction(String overload)
        {
            return "This is fourth Instruction. If Player 2 gives a wrong answer then the control goes back to player 1.";
        }

    }
}
