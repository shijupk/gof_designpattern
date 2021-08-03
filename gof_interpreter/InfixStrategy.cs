using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gof_interpreter
{
    public class InfixStrategy: IStrategy
    {
        public string Convert(string expression)
        {
            string postFix = "";

            Stack<char> literalStack = new Stack<char>();

            foreach (char literal in expression)
            {
                if (literal == ' ')
                {
                    continue;
                }

                if (char.IsLetterOrDigit(literal))
                {
                    postFix += literal + " ";
                }
                else if (literal == '(')
                {
                    literalStack.Push(literal);
                }
                else if (literal == ')')
                {
                    while (literalStack.Count > 0 && literalStack.Peek() != '(')
                    {
                        postFix += literalStack.Pop() + " ";
                    }

                    if (literalStack.Count > 0 && literalStack.Peek() != '(')
                    {
                        return "Invalid Expression";
                    }
                    else
                    {
                        literalStack.Pop();
                    }
                }
                else
                {
                    while (literalStack.Count > 0 && ExpressionFactory.Prec(literal) <= ExpressionFactory.Prec(literalStack.Peek()))
                    {
                        postFix += literalStack.Pop() + " ";
                    }

                    literalStack.Push(literal);
                }
            }

            while (literalStack.Count > 0)
            {
                postFix += literalStack.Pop() + " ";

            }

            return postFix;
        }
    }
}
