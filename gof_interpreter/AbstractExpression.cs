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

        public abstract int Interpret();

    }
}
