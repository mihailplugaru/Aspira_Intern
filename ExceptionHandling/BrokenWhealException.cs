using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
public class BrokenWheelException : Exception
    {
        public BrokenWheelException() : base() { }
        public BrokenWheelException(string message) : base(message) { }
        public BrokenWheelException(string message, Exception inner) : base(message, inner) { }
        //protected BrokenWheelException(System.Runtime.Serialization.SerializationInfo info,
        //    System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
