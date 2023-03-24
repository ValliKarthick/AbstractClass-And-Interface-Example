using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_And_Interface_Example
{
    public abstract class MobileA
    {
        public string MakeCall()
        {
            return "";
        }
        public string SendMessage()
        {
            return "";
        }
        //Abstract Methods
        public abstract double GetScreensize();
        public abstract string GetModelColour();
    }
}
