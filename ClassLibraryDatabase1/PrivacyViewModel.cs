using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDatabase1
{
    public class PrivacyViewModel
    {

        // constructor
        public PrivacyViewModel()
        {

        }

        public string _message = string.Empty;
        public string PrintString()
        {
            _message = "this ran from the second outside dll";
            return _message;
        }
    }
}
