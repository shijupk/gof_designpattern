namespace gof_interpreter
{
    public static class ExpressionFactory
    {
        public static bool IsOperator(string symbol)
        {
            return symbol == "+" || symbol == "-" || symbol == "*" || symbol == "/";
        }

        public static int Prec(char ch)
        {
            switch (ch)
            {
                case '+':
                case '-':
                    return 1;

                case '*':
                case '/':
                    return 2;

                case '^':
                    return 3;
            }
            return -1;
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
