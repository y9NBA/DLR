using Microsoft.VisualBasic;
using System;

namespace ExpandesClass
{
    public class Shift
    {
        private readonly string name;

        public string Name { get => name; }

        public Shift(string name)
        {
            this.name = name;
        }
    }
}
