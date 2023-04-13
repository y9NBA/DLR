using Microsoft.VisualBasic;
using System;

namespace ExpandesClass
{
    public class Organization
    {
        private readonly string name;
        private readonly object legalAddress;
        private readonly object actualAddress;
        private readonly Employee employee;

        public string Name { get { return name; } }
        public object LegalAddress { get { return legalAddress; } }
        public object ActualAddress { get { return actualAddress; } }
        public Employee Employee { get { return employee; } }

        public Organization(string name, object legalAddress, object actualAddress, Employee employee)
        {
            this.name = name;
            this.legalAddress = legalAddress;
            this.actualAddress = actualAddress;
            this.employee = employee;
        }
    }
}
