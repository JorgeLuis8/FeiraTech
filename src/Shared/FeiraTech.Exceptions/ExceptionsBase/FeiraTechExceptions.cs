using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeiraTech.Exceptions.ExceptionsBase
{
    public class FeiraTechExceptions : SystemException
    {
        public FeiraTechExceptions(string message) : base(message)
        {
        }
    }
}
