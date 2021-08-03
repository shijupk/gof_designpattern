using System;
using System.Collections.Generic;

namespace gof_interpreter
{
    public class ExpressionParser
    {
        Stack<IExpression> _expressionStack = new Stack<IExpression>();

        public int Parse(string expression)
        {
            string[] tokens = expression.Split(" ");
            foreach (string token in tokens)
            {
                if (!ExpressionFactory.IsOperator(token))
                {
                    Console.WriteLine($"----------------------------Terminal Expression: '{token}' ----------------------------------");
                    IExpression number = ExpressionFactory.CreateExpression(token);

                    _expressionStack.Push(number);
                    Console.WriteLine($"Teminal Expression Pushed to stack: '{number.Interpret()}'");
                    Console.WriteLine($"--------------------------------------------------------------------------------------------");
                }
                else if (ExpressionFactory.IsOperator(token))
                {
                    Console.WriteLine($"----------------------------Non Terminal Expression: '{token}' -------------------------------");
                    IExpression firstExpression = _expressionStack.Pop();
                    IExpression secondExpression = _expressionStack.Pop();

                    Console.WriteLine($"Popped from stack: '{firstExpression.Interpret()}'");
                    Console.WriteLine($"Popped from stack: '{secondExpression.Interpret()}'");

                    IExpression operation = ExpressionFactory.CreateExpression(token, firstExpression, secondExpression);

                    Console.WriteLine($"Evaluating: '{firstExpression.Interpret()} {token} {secondExpression.Interpret()}'");

                    var numberExpression = operation.Interpret();

                    var resultExpression = ExpressionFactory.CreateExpression(numberExpression);
                    _expressionStack.Push(resultExpression);
                    Console.WriteLine($"Teminal Expression Pushed to stack: '{resultExpression.Interpret()}'");
                    Console.WriteLine($"------------------------------------------------------------------------------------------");
                }
            }

            var result = _expressionStack.Pop();
            return result.Interpret();

        }
    }
}
