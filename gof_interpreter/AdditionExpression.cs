namespace gof_interpreter
{
    class AdditionExpression : MathExpression
    {

        public AdditionExpression(IExpression firstExpression, IExpression secondExpression)
            : base(firstExpression, secondExpression) { }


        protected override int DoCalculation(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}
