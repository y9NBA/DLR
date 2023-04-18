using Microsoft.VisualBasic;
using System;

namespace ExpandesClass
{
    public class Discipline
    {
        private readonly string name;
        private readonly string abbreviation;

        public string Name { get { return name; } }
        public string Abbreviation { get { return abbreviation; } }

        public Discipline(string name, string abbreviation)
        {
            this.name = name;
            this.abbreviation = abbreviation;
        }

        internal dynamic ToExpando()
        {
            throw new NotImplementedException();
        }
    }
}
