using System;
using System.Collections.Generic;
using System.Text;

namespace Web_E_Tickets
{
    class CastingTest
    {
        public void Test()
        {
            User user = new SampleUser();
            SampleUser newUser = (SampleUser)user;
            Console.WriteLine("DownCasting complete");

            SampleUser user2 = new SampleUser();
            User newUser2 = user2;
            Console.WriteLine("UpCastiong complete");
        }
    }
}
