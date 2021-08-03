using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gof_interpreter
{
    public interface IStrategy
    {
        string Convert(string expression);
    }
}
