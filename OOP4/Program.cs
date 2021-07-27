using System;
using System.Collections.Generic;

namespace OOP4
{
    class Program
    {
        static void Main(string[] args)
        {

            //interfaceler'de o interface'i implemente eden class'ın referans numarasını tutabilir.
            ICrediManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            ICrediManager vehicleCrediManager = new VehicleCrediManager();
            ICrediManager houseCrediManager = new HouseCrediManager();
            ICrediManager artisanCrediManager = new ArtisanCrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();



            ApplyManager applyManager = new ApplyManager();

            List<ILoggerService> loggerServices = new List<ILoggerService>() { new SmsLoggerService(), new FileLoggerService(), new DatabaseLoggerService() };
            applyManager.Apply(artisanCrediManager,loggerServices);


          
            List<ICrediManager> credits = new List<ICrediManager>() {personalFinanceCreditManager,vehicleCrediManager,houseCrediManager,artisanCrediManager };

            //applyManager.CreditPreInformation(credits);

            Console.ReadLine();

        }
    }
}
