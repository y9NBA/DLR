using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpandesClass
{
    public class Group
    {
        private readonly string name;
        private readonly string shortName;
        private readonly int number;
        private readonly int yearAdmission;
        private readonly Specialization special;
        private readonly Employee employee;

        public string Name { get { return name; } }
        public string ShortName { get { return shortName; } }
        public int Number { get { return number; } }
        public int YearAdmission { get { return yearAdmission; } }
        public Specialization Specialization { get { return special; } }
        public Employee Employee { get { return employee; } }

        public Group(string name, string shortName, int number, int yearAdmission, Specialization special, Employee employee)
        {
            this.name = name;
            this.shortName = shortName;
            this.number = number;
            this.yearAdmission = yearAdmission;
            this.special = special;
            this.employee = employee;
        }

        internal dynamic ToExpando()
        {
            throw new NotImplementedException();
        }
    }
}
