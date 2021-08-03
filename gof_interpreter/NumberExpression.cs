﻿namespace gof_interpreter
{
    public class NumberExpression : IExpression
    {
        private int _number;
        public NumberExpression(int number)
        {
            _number = number;
        }

        public int Interpret()
        {
            return _number;
        }
    }
}
