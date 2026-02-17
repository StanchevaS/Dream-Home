using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamHome.Common.ExceptionTypes
{
    public class InvalidReservationException : Exception
    {
        public InvalidReservationException()
        {
        }

        public InvalidReservationException(string message)
            : base(message)
        {
        }

        public InvalidReservationException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
