using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace xLib
{
    public abstract class Notation
    {
        public abstract string ToString(string op, string operand1, string operand2);
    }
}
