using System;
using log4net;

namespace TesteLog4net
{
    class Person
    {
        // create a static logger field
        //private static ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public string Name { get; set; }
        public string LastName { get; set; }

        public string FirstName { get; set; }
        public DateTime LastDate { get; set; }

        public int Id { get; set; }

        //public Person(string name, string lastName)
        //{
        //    Name = name;
        //    LastName = lastName;

        //    logger.Info(String.Format("Created a person {0} at {1}", this, DateTime.Now));
        //}

        public override string ToString()
        {
            return String.Format("[{0} {1}]", Name, LastName);
        }
    }
}

