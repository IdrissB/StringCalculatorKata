using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExercices
{
    public interface ICalculate
    {
        decimal Sum(string operation);
        decimal Substract(string operation);
        decimal Product(string operation);
        decimal Division(string operation);

    }
}
