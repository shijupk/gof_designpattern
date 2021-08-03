namespace gof_interpreter
{
    public abstract class MathExpression : IExpression
    {
        protected IExpression _firstExpression, _secondExpression;

        public MathExpression(IExpression firstExpression, IExpression secondExpression)
        {
            _firstExpression = firstExpression;
            _secondExpression = secondExpression;
        }

        public int Interpret()
        {
            return DoCalculation(_firstExpression.Interpret(), _secondExpression.Interpret());
        }

        protected abstract int DoCalculation(int number1, int number2);

    }
}
