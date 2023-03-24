using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_And_Interface_Example
{
    public class Apple : Mobile, Imobile, IElectronic
    {
        public int DisplayCost()
        {
            throw new NotImplementedException();
        }

        public string GetModelColour()
        {
            throw new NotImplementedException();
        }

        public int GetPowerSupply()
        {
            throw new NotImplementedException();
        }

        public double GetScreensize()
        {
            throw new NotImplementedException();
        }

        public void UpdateIOSVersion()
        {

        }
    }
}
