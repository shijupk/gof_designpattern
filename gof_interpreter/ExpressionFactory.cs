namespace gof_interpreter
{
    public static class ExpressionFactory
    {
        public static bool IsOperator(string symbol)
        {
            return symbol == "+" || symbol == "-" || symbol == "*" || symbol == "/";
        }

        public static IExpression CreateExpression(string symbol, IExpression firstExpression = null, IExpression secondExpression = null)
        {
            if (symbol == "+")
            {
                return new AdditionExpression(firstExpression, secondExpression);
            }
            else if (symbol == "-")
            {
                return new SubtractionExpression(firstExpression, secondExpression);
            }
            else if (symbol == "*")
            {
                return new MultiplicationExpression(firstExpression, secondExpression);
            }
            else if (symbol == "/")
            {
                return new DivisionExpression(firstExpression, secondExpression);
            }
            else
            {
                return new NumberExpression(int.Parse(symbol));
            }
        }

        public static IExpression CreateExpression(int number)
        {
            return new NumberExpression(number);
        }
    }
}
