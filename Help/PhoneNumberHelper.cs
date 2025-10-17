using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstSessionwindowsform.Help
{
    static class PhoneNumberHelper
    {
        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            if (!string.IsNullOrEmpty(phoneNumber))
            {
                if (phoneNumber.Length == 11 && phoneNumber.StartsWith("09"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
