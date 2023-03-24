using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_And_Interface_Example
{
    public class Samsung : Mobile, Imobile
    {
        public int DisplayCost()
        {
            throw new NotImplementedException();
        }

        public string GetKeypadType()
        {
            return "Qwerty, wired";
        }

        public string GetModelColour()
        {
            return "green";
        }

        public double GetScreensize()
        {
            return 4.1 ;
        }
    }
}
