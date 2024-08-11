using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAException
{
    public class InvalidAddressException : Exception
    {
        public InvalidAddressException(string message) :base(message) { }
    }
}
