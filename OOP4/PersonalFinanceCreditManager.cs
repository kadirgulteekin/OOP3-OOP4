using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4
{
    class PersonalFinanceCreditManager : ICrediManager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hessaplandı.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
