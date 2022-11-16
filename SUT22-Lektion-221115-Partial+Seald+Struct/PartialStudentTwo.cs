using System;
using System.Collections.Generic;
using System.Text;

namespace SUT22_Lektion_221115_Partial_Seald_Struct
{
   public partial class PartialStudent
    {
        public string GetFullName()
        {
            return _firsName + " " + _lastName;
        }
    }
}
