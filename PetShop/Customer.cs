using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    internal class Customer
    {
        public string FirstName;
        public string LastName;

        public string GetFullName()
        {
            return FirstName  + " " + LastName; 
        }
    }
}
