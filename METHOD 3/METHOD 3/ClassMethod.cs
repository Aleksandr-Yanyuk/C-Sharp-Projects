using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHOD_3
{
    class ClassMethod
    {

        public static int Calc(int firstInput, int secondInput = 0)
        {
            int calcAnswer = 20 + firstInput + secondInput;
            return calcAnswer;
        }
    }
}