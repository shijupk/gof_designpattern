namespace gof_interpreter
{
    public class MultiplicationExpression : AbstractExpression
    {
        public MultiplicationExpression(IExpression firstExpression, IExpression secondExpression) : base(firstExpression, secondExpression) { }


        public override int Interpret()
        {
            return _firstExpression.Interpret() * _secondExpression.Interpret();
        }

    }
}
