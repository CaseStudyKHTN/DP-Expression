﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace xLib
{
    public class MulExpr : BinaryExpr
    {
        public MulExpr(Expression e1, Expression e2)
            : base(e1, e2)
        {
        }

        public override double Evaluate(double x)
        {
            return base._expr1.Evaluate(x) *
                   base._expr2.Evaluate(x);
        }

        protected override Expression createDerive()
        {
            return new AddExpr(
                        new MulExpr(
                            base._expr1.Derive(),
                            base._expr2),
                        new MulExpr(
                            base._expr1,
                            base._expr2.Derive()));
        }

        public override string ToString()
        {
            return  "(" + _expr1.ToString() + ") * (" + _expr2.ToString() + ")";
        }

        public override string ToString(Notation notation)
        {
            return notation.ToString("*", base._expr1.ToString(notation), base._expr2.ToString(notation));
        }
    }
}
