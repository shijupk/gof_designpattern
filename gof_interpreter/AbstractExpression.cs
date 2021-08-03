namespace gof_interpreter
{
    public abstract class AbstractExpression : IExpression
    {
        protected IExpression _firstExpression, _secondExpression;

        public AbstractExpression(IExpression firstExpression, IExpression secondExpression)
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
