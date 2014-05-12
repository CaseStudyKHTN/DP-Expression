using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using xLib;
namespace Express2
{
    class Program
    {
        static void Main(string[] args)
        {
            // (3x^2 + 7) / (4x^3 + 5)
            Expression exp = new DivExpr(
                                new AddExpr(
                                    MonomialExpr.createObject(3, 2),
                                    ConstExpr.createObject(7)),
                                new AddExpr(
                                    MonomialExpr.createObject(4, 3),
                                    ConstExpr.createObject(5)));

            InfixNotation infix = new InfixNotation();
            PrefixNotation prefix = new PrefixNotation();
            PostfixNotation postfix = new PostfixNotation();

            Console.WriteLine(exp.ToString(infix));
            Console.WriteLine(exp.ToString(prefix));
            Console.WriteLine(exp.ToString(postfix));
        }
    }
}
