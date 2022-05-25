using System;
using System.Collections.Generic;

[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config")]

namespace TesteLog4net
{
    internal class Program
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {

            // create 2 persons
            var person1 = new Person();
            person1.Name = "Diego";
            person1.LastName = "Gomes";
            //var person1 = new Person("Jonh", "Gold");
            //var person2 = new Person("James", "Miller");
            // create 2 cars
            var car1 = new Car("Tesla Model S", 2020, person1);
            //var car2 = new Car("Tesla Model X", 2020, person2);
            // logging
            logger.Debug("Some debug log");
            logger.Info(String.Format("{0} {1}", person1.Name, person1.LastName));
            //logger.Info(String.Format("Car2: {0}", car2));
            logger.Warn(String.Format("Warning accrued at {0}", DateTime.Now));
            logger.Error(String.Format("Error accrued at {0}", DateTime.Now));
            logger.Fatal(String.Format("Serious problem with car {0} accrued at {1}", car1, DateTime.Now));
        }
    }
}
