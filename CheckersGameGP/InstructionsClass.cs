using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersGameGP
{
    internal class InstructionsClass
    {
        public virtual string GetInstruction()
        {
            return "There will be 2 Players playing the game. Each player is asked to ansewer a question. Initially the control is with Player 1. If Player 1 answers the question correctly, the player can move his/her piece.";
        }
    }
}
