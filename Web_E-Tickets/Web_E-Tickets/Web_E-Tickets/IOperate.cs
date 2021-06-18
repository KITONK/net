using System;
using System.Collections.Generic;
using System.Text;

namespace Web_E_Tickets
{
    public interface IOpperate
    {
        public bool Excecute(User user, Flight flight);
    }
}
