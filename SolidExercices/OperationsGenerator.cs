using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExercices
{
    public class OperationsGenerator : IOperationsRepository
    {
        public string[] Operations { get; private set; }

        public string[] GetOperations()
        {
            Operations = new[] { "1+2,3", "2 x 3,6", "6-1-3,8", "6,6/3", "6/0", "not an operation", "a+1", "12", "" };
            return Operations;
        }
    }
}
