using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOLO
{
    class BlednyNumerException:SystemException
    {
        public BlednyNumerException(string Message)
        {
            Message = "Bledny numer";
        }
    }
}
 