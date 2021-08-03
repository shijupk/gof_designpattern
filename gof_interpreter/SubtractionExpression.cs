namespace gof_interpreter
{
    public class SubtractionExpression : AbstractExpression
    {
        public SubtractionExpression(IExpression firstExpression, IExpression secondExpression) : base(firstExpression, secondExpression) { }


        public override int Interpret()
        {
            return _firstExpression.Interpret() - _secondExpression.Interpret();
        }
    }
}
