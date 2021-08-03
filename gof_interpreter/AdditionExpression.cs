namespace gof_interpreter
{
    class AdditionExpression : AbstractExpression
    {

        public AdditionExpression(IExpression firstExpression, IExpression secondExpression) : base(firstExpression, secondExpression) { }


        public override int Interpret()
        {
            return _firstExpression.Interpret() + _secondExpression.Interpret();
        }
    }
}
