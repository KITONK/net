using System;
using System.Collections.Generic;
using System.Text;

namespace Web_E_Tickets
{
    public static class CtorTest
    {
        public static void Test()
        {
            User defU = new User();
            Console.WriteLine(defU.Name);
            User initU = new User("passI", "nameI", "surnameI", 100 );
            Console.WriteLine(initU.Name);
            User copyU = new User(initU);
            Console.WriteLine(copyU.Name + "Copied");

            Flight dedF = new Flight();
            Console.WriteLine(dedF.Plane);

            Flight initf = new Flight(DateTime.Now, DateTime.Now.AddHours(3), "Kyiv", "London", "AN2323232", 30);
            Console.WriteLine(initf.Plane);

            Flight copyF = new Flight(initf);
            Console.WriteLine(copyF.Plane);

            Ticket defT = new Ticket();
            Console.WriteLine(defT.flight.CityArrival + defT.user.Name);
            Ticket initT = new Ticket(initU, initf);
            Console.WriteLine(initT.flight.CityArrival + initT.user.Name);
            Ticket copyT = new Ticket(initT);
            Console.WriteLine(copyT.flight.CityArrival + copyT.user.Name);

            Ticket acc2 = new Ticket(new User("password", "name", "password", 1000), new Flight(new DateTime(2021, 07, 25), new DateTime(2021, 07, 25), "London", "Kiev", "AE967ZQW", 105));
            Ticket acc1 = new Ticket();
            Ticket acc3 = new Ticket(acc2);

            User usr1 = new User();
            UserManager.CreateUser("password", "name", "surname", 1000);
            User usr2 = new User(usr1);

            usr1.AddTIcket(acc3);
            //usr1 = !usr1;

            try
            {
                UserManager.CreateUser("", "", "", 0);
            }
            catch (RegistrationException regEx)
            {
                Console.WriteLine(regEx.Message);
            }

            try
            {
                UserManager.AuthenticateUser(new User("", "", "", 0), "a");
            }
            catch (AuthenticationException authEx)
            {
                Console.WriteLine(authEx.Message);
            }

        }
        
        
    }
}
