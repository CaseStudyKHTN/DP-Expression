using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace xLib
{
    public class InfixNotation : Notation
    {
        public override string ToString(string op, string operand1, string operand2)
        {
            return "( " + operand1 + " " + op + " " + operand2 + " )"; 
        }
    }
}
