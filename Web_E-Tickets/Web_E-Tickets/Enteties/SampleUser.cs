using System;
using System.Collections.Generic;
using System.Text;

namespace Web_E_Tickets
{
    public class SampleUser: User
    {
        public SampleUser() { }

        public SampleUser(AbstractUser usr) : base(usr){ }

        public SampleUser(string password, string name, string surname, float balance) : base(password, name, surname, balance){ }



    }
}
