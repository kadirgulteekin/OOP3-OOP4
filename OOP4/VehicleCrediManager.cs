using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4
{
    class VehicleCrediManager : ICrediManager
    {
        public void Calculate()
        {
            Console.WriteLine("Araç kredisi ödeme planı hessaplandı.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
