using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_And_Interface_Example
{
    public class MI : MobileA
    {
        public override string GetModelColour()
        {
            throw new NotImplementedException();
        }

        public override double GetScreensize()
        {
            throw new NotImplementedException();
        }
    }
}
