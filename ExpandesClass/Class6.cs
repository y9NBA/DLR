using Microsoft.VisualBasic;
using System;

namespace ExpandesClass
{
    public class LessonType
    {
        private readonly string name;
        public LessonType(string name)
        {
            this.name = name;
        }

        internal dynamic ToExpando()
        {
            throw new NotImplementedException();
        }
    }
}
