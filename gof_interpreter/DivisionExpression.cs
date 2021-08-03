namespace gof_interpreter
{
    public class DivisionExpression : MathExpression
    {
        public DivisionExpression(IExpression firstExpression, IExpression secondExpression)
            : base(firstExpression, secondExpression) { }


        protected override int DoCalculation(int number1, int number2)
        {
            return number1 / number2;
        }
    }
}
