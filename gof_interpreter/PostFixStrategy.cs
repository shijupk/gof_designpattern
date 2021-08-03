using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gof_interpreter
{
    public class PostFixStrategy: IStrategy
    {
        public string Convert(string expression)
        {
            return expression;
        }
    }
}
