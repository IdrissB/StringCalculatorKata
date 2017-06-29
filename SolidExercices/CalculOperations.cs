using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExercices
{
    public class CalculOperations
    {
        private readonly List<String> _operators = new List<String>();

        public CalculOperations()
        {
            _operators.Add("+");
            _operators.Add("-");
            _operators.Add("/");
            _operators.Add("x");
        }

        public List<string> Operators
        {
            get { return _operators; }
        }
    }
}
