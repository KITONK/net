using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Administrator : IAdministrator
    {
        public Administrator(string post)
        {
            Post = post;
            Console.WriteLine($"Ctor {GetType().Name} was called");
        }
        public string Post { get; set; }
       
    }
}
