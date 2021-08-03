namespace gof_interpreter
{
    public class DivisionExpression : AbstractExpression
    {
        public DivisionExpression(IExpression firstExpression, IExpression secondExpression) : base(firstExpression, secondExpression) { }


        public override int Interpret()
        {
            return _firstExpression.Interpret() / _secondExpression.Interpret();
        }
    }
}
