using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class FraudException : Exception
    {
        public FraudException()
            : base() { }
        //overloads constructor and takes in 1 argument
        public FraudException(string message)
            : base(message) { }
    }
}
