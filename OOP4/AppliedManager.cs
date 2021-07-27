using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4
{
    class ApplyManager
    {
        public void Apply(ICrediManager crediManager,List<ILoggerService> loggerServices)
        {
           
            crediManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
           


        }

        public void CreditPreInformation(List<ICrediManager> credits)
        {
            foreach (var item in credits)
            {
                item.Calculate();

            }
        }
    }
}
