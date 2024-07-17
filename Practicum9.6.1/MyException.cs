using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum9._6._1
{
    internal class MyException: Exception
    {
        public MyException(string message): base(message)
        {

        }
    }
}
