using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public static class OBjectValidator
    {
        public static void CheckIfOBjectIsNull(object obj,string errorMsg = GlobalConstants.EMPTY_STRING)
        {
            if(obj == null)
            {
                throw new NullReferenceException(GlobalErrorMessages.NULLFIGUREMESAGE);
            }
        }
    }
}
