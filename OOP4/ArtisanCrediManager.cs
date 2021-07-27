using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4
{
    class ArtisanCrediManager : ICrediManager
    {
        public void Calculate()
        {
            Console.WriteLine("Esnaf Kredisi Hesaplandı.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
