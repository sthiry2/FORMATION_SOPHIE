using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryExceptions.ExceptionsMontre
{
    public class MinutesOutORangeException : Exception
    {
        public MinutesOutORangeException():base()
        { }



        public MinutesOutORangeException(string message):base(message)
        {
        }

        public MinutesOutORangeException(string message, Exception innerException):base(message,innerException)
        {
        }
        
        //protected Exception(SerializationInfo info, StreamingContext context);
    }
}
