using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_And_Interface_Example
{
    public class UserDetails
    {
        public bool ValidateUserInput(string name, string number)
        {
            bool result;

            if ((name != "") && (number != ""))
            {
                result = true;
            }
            else
            {
                result = false;
            }           
            return result;
        }
    }
}
