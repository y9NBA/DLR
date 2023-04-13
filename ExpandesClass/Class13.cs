using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpandesClass
{
    public class Auditory
    {
        private readonly string name;
        public string Name { get { return name; } }

        private readonly Employee employee;
        public Employee Employee { get { return employee; } }

        private readonly int seat;
        public int Seat { get { return seat; } }
        private readonly int windows;
        public int Windows { get { return windows; } }

        private readonly List<Equipment> list;
        public List<Equipment> List { get { return list; } }

        public Auditory(string name, Employee employee, int seat, int windows, List<Equipment> list)
        {
            this.name = name;
            this.employee = employee;
            this.seat = seat;
            this.windows = windows;
            this.list = list;
        }
    }
}