using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpandesClass
{
    public class Equipment
    {
        private readonly string name;
        private readonly int price;
        private readonly DateTime registrationDate;

        public string Name { get { return name; } }
        public int Price { get { return price; } }
        DateTime RegistrationDate { get { return registrationDate; } }

        public Equipment(string name, int price, DateTime? registrationDate = null)
        {
            this.name = name;
            this.price = price;
            this.registrationDate = registrationDate ?? DateTime.Now;
        }
    }
}